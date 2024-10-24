using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using PratikMuhasebe.Server.DTOs;

namespace PratikMuhasebe.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class A17Controller : ControllerBase
{
	private readonly HttpClient _httpClient;
	private readonly MikroDbV16Test2Context _context;
	private readonly IMemoryCache _memoryCache;

	public A17Controller(IHttpClientFactory httpClientFactory, MikroDbV16Test2Context context, IMemoryCache memoryCache)
	{
		_httpClient = httpClientFactory.CreateClient();
		_context = context;
		_memoryCache = memoryCache;
	}

	[HttpPost]
	public async Task<ActionResult> GetTPM1(A08Dto a08Dto)
	{
		DateTime baslangıcTarihi = DateTime.Parse(a08Dto.StartDate + "-01");
		DateTime bitisTarihi = baslangıcTarihi.AddMonths(1).AddDays(-1);

		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=1&baslangic_tarihi={baslangıcTarihi:yyyy-MM-dd}&bitis_tarihi={bitisTarihi:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.Tahakkuk is not null)
			{

				int toplamKesintiler = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var kaydınEvrakTipi = "TPM1";
					int evrakSiraNo;
					int sonCariislemKodu;
					var sonCariIslem = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Take(1)
						.FirstOrDefaultAsync();

					var mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
					if (mikrodaVarolanBelgeNumaraları.Count <= 0)
						mikrodaVarolanBelgeNumaraları = "AfseqweAW,awADfawafs".Split(',').ToList();
					var sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
					if (sonCariIslemEvrakSiraNo is null)
						evrakSiraNo = 0;
					else
						evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
					if (sonCariIslem is not null)
						sonCariislemKodu = (int)sonCariIslem.ChaSpecRecNo!;
					else
						sonCariislemKodu = 0;

					foreach (var cariHareket in jsonData.Tahakkuk)
					{
						int evrakKaydininSatirNumarasi = -1;

						string BelgeNoString1 = (cariHareket.MuhasebeKodu + (1 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						string BelgeNoString2 = (cariHareket.MuhasebeKodu + (2 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						double TemsilcininKendiKazancı = cariHareket.Prim;
						double PininKazancı = cariHareket.BrutKar;
						double PininKazancınınBSMVsi = (PininKazancı * 1.05) - PininKazancı;
						double TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali = (TemsilcininKendiKazancı - PininKazancınınBSMVsi) / 100;


						if (mikrodaVarolanBelgeNumaraları != null &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2) &&
							cariHareket.Prim > 0 &&
							TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali > 0 &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22653" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22386" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20001" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20002" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22337" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22272" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22672" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22664")
						{
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKesintiler += 1;
							CariHesapHareketleri kesintiler = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = bitisTarihi,
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayCekme1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = cariHareket.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							sonCariislemKodu += 1;
							CariHesapHareketleri kesintiler2 = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 1,
								ChaTarihi = bitisTarihi,
								ChaTip = 1,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıCekme1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = "TEM.01.001.90009",
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							await _context.CariHesapHareketleris.AddRangeAsync(kesintiler, kesintiler2);
						}
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Tahakkuk.Count} adettir. Aktarılan Kesintiler {toplamKesintiler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
	[HttpPost]
	public async Task<ActionResult> GetTPM2(A08Dto a08Dto)
	{
		DateTime baslangıcTarihi = DateTime.Parse(a08Dto.StartDate + "-01");
		DateTime bitisTarihi = baslangıcTarihi.AddMonths(1).AddDays(-1);

		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=2&baslangic_tarihi={baslangıcTarihi:yyyy-MM-dd}&bitis_tarihi={bitisTarihi:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.Tahakkuk is not null)
			{

				int toplamKesintiler = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var kaydınEvrakTipi = "TPM2";
					int evrakSiraNo;
					int sonCariislemKodu;
					var sonCariIslem = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Take(1)
						.FirstOrDefaultAsync();

					var mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
					if (mikrodaVarolanBelgeNumaraları.Count <= 0)
						mikrodaVarolanBelgeNumaraları = "AfseqweAW,awADfawafs".Split(',').ToList();
					var sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
					if (sonCariIslemEvrakSiraNo is null)
						evrakSiraNo = 0;
					else
						evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
					if (sonCariIslem is not null)
						sonCariislemKodu = (int)sonCariIslem.ChaSpecRecNo!;
					else
						sonCariislemKodu = 0;

					foreach (var cariHareket in jsonData.Tahakkuk)
					{
						int evrakKaydininSatirNumarasi = -1;

						string BelgeNoString1 = (cariHareket.MuhasebeKodu + (1 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						string BelgeNoString2 = (cariHareket.MuhasebeKodu + (2 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						double TemsilcininKendiKazancı = cariHareket.Prim;
						double PininKazancı = cariHareket.BrutKar;
						double PininKazancınınBSMVsi = (PininKazancı * 1.05) - PininKazancı;
						double TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali = (TemsilcininKendiKazancı - PininKazancınınBSMVsi) / 100;


						if (mikrodaVarolanBelgeNumaraları != null &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2) &&
							cariHareket.Prim > 0 &&
							TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali > 0 &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22653" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22386" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20001" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20002" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22337" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22272" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22672" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22664")
						{
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKesintiler += 1;
							CariHesapHareketleri kesintiler = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = bitisTarihi,
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayCekme1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = cariHareket.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							sonCariislemKodu += 1;
							CariHesapHareketleri kesintiler2 = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 1,
								ChaTarihi = bitisTarihi,
								ChaTip = 1,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıCekme1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = "TEM.01.001.90009",
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							await _context.CariHesapHareketleris.AddRangeAsync(kesintiler, kesintiler2);
						}
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Tahakkuk.Count} adettir. Aktarılan Kesintiler {toplamKesintiler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
	[HttpPost]
	public async Task<ActionResult> GetTPM3(A08Dto a08Dto)
	{
		DateTime baslangıcTarihi = DateTime.Parse(a08Dto.StartDate + "-01");
		DateTime bitisTarihi = baslangıcTarihi.AddMonths(1).AddDays(-1);

		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=3&baslangic_tarihi={baslangıcTarihi:yyyy-MM-dd}&bitis_tarihi={bitisTarihi:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.Tahakkuk is not null)
			{

				int toplamKesintiler = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var kaydınEvrakTipi = "TPM3";
					int evrakSiraNo;
					int sonCariislemKodu;
					var sonCariIslem = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Take(1)
						.FirstOrDefaultAsync();

					var mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
					if (mikrodaVarolanBelgeNumaraları.Count <= 0)
						mikrodaVarolanBelgeNumaraları = "AfseqweAW,awADfawafs".Split(',').ToList();
					var sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
					if (sonCariIslemEvrakSiraNo is null)
						evrakSiraNo = 0;
					else
						evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
					if (sonCariIslem is not null)
						sonCariislemKodu = (int)sonCariIslem.ChaSpecRecNo!;
					else
						sonCariislemKodu = 0;

					foreach (var cariHareket in jsonData.Tahakkuk)
					{
						int evrakKaydininSatirNumarasi = -1;

						string BelgeNoString1 = (cariHareket.MuhasebeKodu + (1 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						string BelgeNoString2 = (cariHareket.MuhasebeKodu + (2 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						double TemsilcininKendiKazancı = cariHareket.Prim;
						double PininKazancı = cariHareket.BrutKar;
						double PininKazancınınBSMVsi = (PininKazancı * 1.05) - PininKazancı;
						double TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali = (TemsilcininKendiKazancı - PininKazancınınBSMVsi) / 100;


						if (mikrodaVarolanBelgeNumaraları != null &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2) &&
							cariHareket.Prim > 0 &&
							TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali > 0 &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22653" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22386" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20001" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20002" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22337" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22272" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22672" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22664")
						{
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKesintiler += 1;
							CariHesapHareketleri kesintiler = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = bitisTarihi,
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayCekme1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = cariHareket.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""

                            };
							sonCariislemKodu += 1;
							CariHesapHareketleri kesintiler2 = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 1,
								ChaTarihi = bitisTarihi,
								ChaTip = 1,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıCekme1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = "TEM.01.001.90009",
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							await _context.CariHesapHareketleris.AddRangeAsync(kesintiler, kesintiler2);
						}
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Tahakkuk.Count} adettir. Aktarılan Kesintiler {toplamKesintiler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
	[HttpPost]
	public async Task<ActionResult> GetTPA1(A08Dto a08Dto)
	{
		DateTime baslangıcTarihi = DateTime.Parse(a08Dto.StartDate + "-01");
		DateTime bitisTarihi = baslangıcTarihi.AddMonths(1).AddDays(-1);

		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=3&baslangic_tarihi={baslangıcTarihi:yyyy-MM-dd}&bitis_tarihi={bitisTarihi:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.Tahakkuk is not null)
			{

				int toplamKesintiler = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var kaydınEvrakTipi = "TPA1";
					int evrakSiraNo;
					int sonCariislemKodu;
					var sonCariIslem = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Take(1)
						.FirstOrDefaultAsync();

					var mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
					if (mikrodaVarolanBelgeNumaraları.Count <= 0)
						mikrodaVarolanBelgeNumaraları = "AfseqweAW,awADfawafs".Split(',').ToList();
					var sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
					if (sonCariIslemEvrakSiraNo is null)
						evrakSiraNo = 0;
					else
						evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
					if (sonCariIslem is not null)
						sonCariislemKodu = (int)sonCariIslem.ChaSpecRecNo!;
					else
						sonCariislemKodu = 0;

					foreach (var cariHareket in jsonData.Tahakkuk)
					{
						int evrakKaydininSatirNumarasi = -1;

						string BelgeNoString1 = (cariHareket.MuhasebeKodu + (1 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						string BelgeNoString2 = (cariHareket.MuhasebeKodu + (2 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						double TemsilcininKendiKazancı = cariHareket.Prim;
						double PininKazancı = cariHareket.BrutKar;
						double PininKazancınınBSMVsi = (PininKazancı * 1.05) - PininKazancı;
						double TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali = (TemsilcininKendiKazancı - PininKazancınınBSMVsi) / 100;


						if (mikrodaVarolanBelgeNumaraları != null &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2) &&
							cariHareket.Prim > 0 &&
							TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali > 0 &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22653" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22386" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20001" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20002" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22337" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22272" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22672" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22664")
						{
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKesintiler += 1;
							CariHesapHareketleri kesintiler = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = bitisTarihi,
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıIade1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = "TEM.01.001.90009",
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							sonCariislemKodu += 1;
							CariHesapHareketleri kesintiler2 = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 1,
								ChaTarihi = bitisTarihi,
								ChaTip = 1,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıIade1" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = cariHareket.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							await _context.CariHesapHareketleris.AddRangeAsync(kesintiler, kesintiler2);
						}
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Tahakkuk.Count} adettir. Aktarılan Kesintiler {toplamKesintiler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
	[HttpPost]
	public async Task<ActionResult> GetTPA2(A08Dto a08Dto)
	{
		DateTime baslangıcTarihi = DateTime.Parse(a08Dto.StartDate + "-01");
		DateTime bitisTarihi = baslangıcTarihi.AddMonths(1).AddDays(-1);

		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=3&baslangic_tarihi={baslangıcTarihi:yyyy-MM-dd}&bitis_tarihi={bitisTarihi:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.Tahakkuk is not null)
			{

				int toplamKesintiler = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var kaydınEvrakTipi = "TPA2";
					int evrakSiraNo;
					int sonCariislemKodu;
					var sonCariIslem = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Take(1)
						.FirstOrDefaultAsync();

					var mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
					if (mikrodaVarolanBelgeNumaraları.Count <= 0)
						mikrodaVarolanBelgeNumaraları = "AfseqweAW,awADfawafs".Split(',').ToList();
					var sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
					if (sonCariIslemEvrakSiraNo is null)
						evrakSiraNo = 0;
					else
						evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
					if (sonCariIslem is not null)
						sonCariislemKodu = (int)sonCariIslem.ChaSpecRecNo!;
					else
						sonCariislemKodu = 0;

					foreach (var cariHareket in jsonData.Tahakkuk)
					{
						int evrakKaydininSatirNumarasi = -1;

						string BelgeNoString1 = (cariHareket.MuhasebeKodu + (1 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						string BelgeNoString2 = (cariHareket.MuhasebeKodu + (2 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						double TemsilcininKendiKazancı = cariHareket.Prim;
						double PininKazancı = cariHareket.BrutKar;
						double PininKazancınınBSMVsi = (PininKazancı * 1.05) - PininKazancı;
						double TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali = (TemsilcininKendiKazancı - PininKazancınınBSMVsi) / 100;


						if (mikrodaVarolanBelgeNumaraları != null &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2) &&
							cariHareket.Prim > 0 &&
							TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali > 0 &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22653" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22386" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20001" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20002" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22337" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22272" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22672" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22664")
						{
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKesintiler += 1;
							CariHesapHareketleri kesintiler = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = bitisTarihi,
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıIade2" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = "TEM.01.001.90009",
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							sonCariislemKodu += 1;
							CariHesapHareketleri kesintiler2 = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 1,
								ChaTarihi = bitisTarihi,
								ChaTip = 1,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıIade2" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = cariHareket.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							await _context.CariHesapHareketleris.AddRangeAsync(kesintiler, kesintiler2);
						}
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Tahakkuk.Count} adettir. Aktarılan Kesintiler {toplamKesintiler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
	[HttpPost]
	public async Task<ActionResult> GetTPA3(A08Dto a08Dto)
	{
		DateTime baslangıcTarihi = DateTime.Parse(a08Dto.StartDate + "-01");
		DateTime bitisTarihi = baslangıcTarihi.AddMonths(1).AddDays(-1);

		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=3&baslangic_tarihi={baslangıcTarihi:yyyy-MM-dd}&bitis_tarihi={bitisTarihi:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.Tahakkuk is not null)
			{

				int toplamKesintiler = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var kaydınEvrakTipi = "TPA3";
					int evrakSiraNo;
					int sonCariislemKodu;
					var sonCariIslem = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Take(1)
						.FirstOrDefaultAsync();

					var mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
					if (mikrodaVarolanBelgeNumaraları.Count <= 0)
						mikrodaVarolanBelgeNumaraları = "AfseqweAW,awADfawafs".Split(',').ToList();
					var sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
					if (sonCariIslemEvrakSiraNo is null)
						evrakSiraNo = 0;
					else
						evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
					if (sonCariIslem is not null)
						sonCariislemKodu = (int)sonCariIslem.ChaSpecRecNo!;
					else
						sonCariislemKodu = 0;

					foreach (var cariHareket in jsonData.Tahakkuk)
					{
						int evrakKaydininSatirNumarasi = -1;

						string BelgeNoString1 = (cariHareket.MuhasebeKodu + (1 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						string BelgeNoString2 = (cariHareket.MuhasebeKodu + (2 + ((evrakKaydininSatirNumarasi + 1) * 2)).ToString() + a08Dto.StartDate)
							.Replace("TEM.01.001.", "")
							.Replace(".", "")
							.Replace("-", "")
							+ kaydınEvrakTipi;

						double TemsilcininKendiKazancı = cariHareket.Prim;
						double PininKazancı = cariHareket.BrutKar;
						double PininKazancınınBSMVsi = (PininKazancı * 1.05) - PininKazancı;
						double TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali = (TemsilcininKendiKazancı - PininKazancınınBSMVsi) / 100;


						if (mikrodaVarolanBelgeNumaraları != null &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) &&
							!mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2) &&
							cariHareket.Prim > 0 &&
							TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali > 0 &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22653" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22386" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20001" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.20002" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22337" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22272" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22672" &&
							cariHareket.MuhasebeKodu != "TEM.01.001.22664")
						{
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKesintiler += 1;
							CariHesapHareketleri kesintiler = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = bitisTarihi,
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıCekme3" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = "TEM.01.001.90009",
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							sonCariislemKodu += 1;
							CariHesapHareketleri kesintiler2 = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaIptal = false,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaDegisti = false,
								ChaCheckSum = 0,
								ChaCreateUser = 5,
								ChaCreateDate = DateTime.Now,
								ChaLastupUser = 5,
								ChaLastupDate = DateTime.Now,
								ChaSpecial1 = "",
								ChaSpecial2 = "",
								ChaSpecial3 = "",
								ChaFirmano = 0,
								ChaSubeno = 0,
								ChaEvrakTip = 57,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 1,
								ChaTarihi = bitisTarihi,
								ChaTip = 1,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = BelgeNoString1,
								ChaBelgeTarih = bitisTarihi,
								ChaAciklama = "TemsilciPayıCekme3" + a08Dto.StartDate,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = cariHareket.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(TemsilcininKendiKazancıPikazancınaaitBSMVninDüşülmüşhali.ToString("F2")),
								ChaAratoplam = 0,
								ChaVade = 0,
								ChaVadeFarkiYuz = 0,
								ChaFtIskonto1 = 0,
								ChaFtIskonto2 = 0,
								ChaFtIskonto3 = 0,
								ChaFtIskonto4 = 0,
								ChaFtIskonto5 = 0,
								ChaFtIskonto6 = 0,
								ChaFtMasraf1 = 0,
								ChaFtMasraf2 = 0,
								ChaFtMasraf3 = 0,
								ChaFtMasraf4 = 0,
								ChaIskMas1 = 0,
								ChaIskMas2 = 0,
								ChaIskMas3 = 0,
								ChaIskMas4 = 0,
								ChaIskMas5 = 0,
								ChaIskMas6 = 0,
								ChaIskMas7 = 0,
								ChaIskMas8 = 0,
								ChaIskMas9 = 0,
								ChaIskMas10 = 0,
								ChaSatIskmas1 = false,
								ChaSatIskmas2 = false,
								ChaSatIskmas3 = false,
								ChaSatIskmas4 = false,
								ChaSatIskmas5 = false,
								ChaSatIskmas6 = false,
								ChaSatIskmas7 = false,
								ChaSatIskmas8 = false,
								ChaSatIskmas9 = false,
								ChaSatIskmas10 = false,
								ChaYuvarlama = 0,
								ChaStFonPntr = 0,
								ChaStopaj = 0,
								ChaSavsandesfonu = 0,
								ChaAvansmakDamgapul = 0,
								ChaVergipntr = 0,
								ChaVergi1 = 0,
								ChaVergi2 = 0,
								ChaVergi3 = 0,
								ChaVergi4 = 0,
								ChaVergi5 = 0,
								ChaVergi6 = 0,
								ChaVergi7 = 0,
								ChaVergi8 = 0,
								ChaVergi9 = 0,
								ChaVergi10 = 0,
								ChaVergisizFl = false,
								ChaOtvtutari = 0,
								ChaOtvvergisizFl = false,
								ChaOivPntr = 0,
								ChaOivtutari = 0,
								ChaOivVergi = 0,
								ChaOivergisizFl = false,
								ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00"),
								ChaFisSirano = 0,
								ChaTrefno = "",
								ChaSntckPoz = 0,
								ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaIstisnakodu = 0,
								ChaPosHareketi = 0,
								ChaMeblagAnaDovizIcinGecersizFl = 0,
								ChaMeblagAltDovizIcinGecersizFl = 0,
								ChaMeblagOrjDovizIcinGecersizFl = 0,
								ChaDbcno = 0,
								ChaKiraharUid = Guid.NewGuid(),
								ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00"),
								ChaVardiyaNo = 0,
								ChaVardiyaEvrakTi = 0,
								ChaEbelgeTuru = 0,
								ChaTevkifatToplam = 0,
								ChaIlaveEdilecekKdv1 = 0,
								ChaIlaveEdilecekKdv2 = 0,
								ChaIlaveEdilecekKdv3 = 0,
								ChaIlaveEdilecekKdv4 = 0,
								ChaIlaveEdilecekKdv5 = 0,
								ChaIlaveEdilecekKdv6 = 0,
								ChaIlaveEdilecekKdv7 = 0,
								ChaIlaveEdilecekKdv8 = 0,
								ChaIlaveEdilecekKdv9 = 0,
								ChaIlaveEdilecekKdv10 = 0,
								ChaEIslemTuru = 0,
								ChaFaturaBelgeTuru = 0,
								ChaDigerBelgeAdi = "",
								ChaUuid = "",
								ChaAdresNo = 0,
								ChaBsbaEBelgeMi = 0,
								ChaDisyazilimid = "",
								ChaDisyazilimTip = 0,
								ChaEbelgeIslemturu = 0,
								ChaEbelgenoSeri = "",
								ChaEbelgenoSira = 0,
								ChaEticaretKanalKodu = "",
								ChaGuid = Guid.NewGuid(),
								ChaHareketGrupKodu1 = "",
								ChaHareketGrupKodu2 = "",
								ChaHareketGrupKodu3 = "",
								ChaHizliSatisKasaNo = 0,
								ChaHubglbid = "",
								ChaHubid = "",
								ChaIlkBelgeDovizKuru = 0,
								ChaIlkBelgeTarihi = DateTime.Now,
								ChaSipUid = Guid.NewGuid(),
								ChaVergifonToplam = 0,
                                BanMainProgramNo = 0,
                                BanVersionNo = 0,
                                BanMenuNo = 0,
                                BanMikroSpecial1 = "",
                                BanMikroSpecial2 = "",
                                BanMikroSpecial3 = "",
                                BanExternalProgramType = "",
                                BanExternalProgramId = 0,
                                BanHash = ""
                            };
							await _context.CariHesapHareketleris.AddRangeAsync(kesintiler, kesintiler2);
						}
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Tahakkuk.Count} adettir. Aktarılan Kesintiler {toplamKesintiler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
}
