using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using PratikMuhasebe.Server.DTOs;
using System.Security.Cryptography.Xml;

namespace PratikMuhasebe.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class A03Controller : ControllerBase
{
	private readonly HttpClient _httpClient;
	private readonly MikroDbV16Test2Context _context;
	private readonly IMemoryCache _memoryCache;

	public A03Controller(IHttpClientFactory httpClientFactory, MikroDbV16Test2Context context, IMemoryCache memoryCache)
	{
		_httpClient = httpClientFactory.CreateClient();
		_context = context;
		_memoryCache = memoryCache;
	}

	[HttpPost]
	public async Task<ActionResult> GetA03(A09Dto a09Dto)
	{
		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A03_Havale_EFT.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=12&baslangic_tarihi={a09Dto.StartDate:yyyy-MM-dd}&bitis_tarihi={a09Dto.EndDate:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A03Response>(jsonResponse);
			if (jsonData.GelenHareketler is not null | jsonData.GidenHareketler is not null | jsonData.Kesintiler is not null)
			{
				int evrakSiraNo;
				int sonCariislemKodu;
				var sonCariIslem = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Take(1)
					.FirstOrDefaultAsync();
				var kaydınEvrakTipi = "";
				if (jsonData.GelenHareketler.Count > 0)
				{
					kaydınEvrakTipi = jsonData.GelenHareketler[0].EvrakNo;
				}
				else
				{
					kaydınEvrakTipi = "";
				}
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
				int toplamGelenHareketler = 0;
				if (jsonData.GelenHareketler.Count > 0)
				{
					var filtrelenmisGelenHareketler = new List<GelenHareketler>();
					foreach (var gelenHareketler in jsonData.GelenHareketler)
					{
						if (!mikrodaVarolanBelgeNumaraları.Contains(gelenHareketler.BelgeNo))
						{
							filtrelenmisGelenHareketler.Add(gelenHareketler);
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamGelenHareketler += 1;
							CariHesapHareketleri gelenHareketlerCari = new()
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
								ChaEvrakTip = 34,
								ChaEvraknoSeri = gelenHareketler.EvrakNo,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = DateTime.Parse(gelenHareketler.BelgeTarihi.ToString("yyyy-MM-dd")),
								ChaTip = 1,
								ChaCinsi = 0,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = gelenHareketler.BelgeNo,
								ChaBelgeTarih = DateTime.Parse(gelenHareketler.BelgeTarihi.ToString("yyyy-MM-dd")),
								ChaAciklama = gelenHareketler.Aciklama.Length > 40 ? gelenHareketler.Aciklama.Substring(0, 40) : gelenHareketler.Aciklama,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = gelenHareketler.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 2,
								ChaKasaHizkod = gelenHareketler.BankaKodu,
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 1,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(gelenHareketler.Meblag) / 100,
								ChaAratoplam = double.Parse(gelenHareketler.Meblag) / 100,
								ChaVade = int.Parse(gelenHareketler.BelgeTarihi.ToString("yyyyMMdd")),
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
                                BanMainProgramNo = gelenHareketler.BanMainProgramNo,  // Yeni alanlar eklendi
                                BanVersionNo = gelenHareketler.BanVersionNo,
                                BanMenuNo = gelenHareketler.BanMenuNo,
                                BanMikroSpecial1 = gelenHareketler.BanMikroSpecial1,
                                BanMikroSpecial2 = gelenHareketler.BanMikroSpecial2,
                                BanMikroSpecial3 = gelenHareketler.BanMikroSpecial3,
                                BanExternalProgramType = gelenHareketler.BanExternalProgramType,
                                BanExternalProgramId = gelenHareketler.BanExternalProgramId,
                                BanHash = gelenHareketler.BanHash
                            };
							await _context.CariHesapHareketleris.AddAsync(gelenHareketlerCari);
						}
					}
                    if (filtrelenmisGelenHareketler.Count > 0)
                    {
                        Console.WriteLine(JsonConvert.SerializeObject(filtrelenmisGelenHareketler));
                        _memoryCache.Set("FiltrelenmisGelenHareketlerCacheKey", filtrelenmisGelenHareketler, TimeSpan.FromMinutes(10));
                    }

                }
                if (jsonData.GidenHareketler.Count > 0)
				{
					kaydınEvrakTipi = jsonData.GidenHareketler[0].EvrakNo;
					sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
				}
				if (sonCariIslemEvrakSiraNo is null)
					evrakSiraNo = 0;
				else
					evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
				mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
				int toplamGidenHareketler = 0;
				if (jsonData.GidenHareketler?.Count > 0)
				{
					var filtrelenmisGidenHareketler = new List<GidenHareketler>();
					foreach (var gidenHareketler in jsonData.GidenHareketler)
					{
						if (!mikrodaVarolanBelgeNumaraları.Contains(gidenHareketler.BelgeNo))
						{
							filtrelenmisGidenHareketler.Add(gidenHareketler);
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamGidenHareketler += 1;

							CariHesapHareketleri gidenHareketlerCari = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaIptal = false,
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
								ChaEvrakTip = 35,
								ChaEvraknoSeri = gidenHareketler.EvrakNo,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = DateTime.Parse(gidenHareketler.BelgeTarihi.ToString("yyyy-MM-dd")),
								ChaTip = 0,
								ChaCinsi = 0,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = gidenHareketler.BelgeNo,
								ChaBelgeTarih = DateTime.Parse(gidenHareketler.BelgeTarihi.ToString("yyyy-MM-dd")),
								ChaAciklama = gidenHareketler.Aciklama.Length > 40 ? gidenHareketler.Aciklama.Substring(0, 40) : gidenHareketler.Aciklama,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = gidenHareketler.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GLH",
								ChaKasaHizmet = 2,
								ChaKasaHizkod = gidenHareketler.BankaKodu,
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 1,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(gidenHareketler.Meblag) / 100,
								ChaAratoplam = double.Parse(gidenHareketler.Meblag) / 100,
								ChaVade = int.Parse(gidenHareketler.BelgeTarihi.ToString("yyyyMMdd")),
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
								ChaVergifonToplam = 0
							};
							await _context.CariHesapHareketleris.AddAsync(gidenHareketlerCari);
						}
					}
                    if (filtrelenmisGidenHareketler.Count > 0)
                    {
                        // Log ile listeyi kontrol edin
                        Console.WriteLine(JsonConvert.SerializeObject(filtrelenmisGidenHareketler));
                        _memoryCache.Set("FiltrelenmisGidenHareketlerCacheKey", filtrelenmisGidenHareketler, TimeSpan.FromMinutes(10));
                    }

                }
                if (jsonData.Kesintiler.Count > 0)
				{
					kaydınEvrakTipi = jsonData.Kesintiler[0].EvrakNo;
					sonCariIslemEvrakSiraNo = await _context.CariHesapHareketleris.OrderByDescending(x => x.ChaSpecRecNo).Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi).FirstOrDefaultAsync();
				}
				if (sonCariIslemEvrakSiraNo is null)
					evrakSiraNo = 0;
				else
					evrakSiraNo = (int)sonCariIslemEvrakSiraNo.ChaEvraknoSira!;
				mikrodaVarolanBelgeNumaraları = await _context.CariHesapHareketleris
					.OrderByDescending(x => x.ChaSpecRecNo)
					.Where(x => x.ChaEvraknoSeri == kaydınEvrakTipi)
					.Take(100000)
					.Select(x => x.ChaBelgeNo)
					.ToListAsync();
				int toplamKesintiler = 0;

				if (jsonData.Kesintiler?.Count > 0)
				{
					var filtrelenmisKesintiler = new List<Kesintiler>();
					foreach (var kesintiler in jsonData.Kesintiler)
					{
						if (!mikrodaVarolanBelgeNumaraları.Contains(kesintiler.BelgeNo))
						{
							filtrelenmisKesintiler.Add(kesintiler);
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKesintiler += 1;

							CariHesapHareketleri kesintilerCari = new()
							{
								ChaSpecRecNo = sonCariislemKodu,
								ChaFileid = 51,
								ChaHidden = false,
								ChaKilitli = true,
								ChaIptal = false,
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
								ChaEvrakTip = 34,
								ChaEvraknoSeri = kesintiler.EvrakNo,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = DateTime.Parse(kesintiler.BelgeTarihi.ToString("yyyy-MM-dd")),
								ChaTip = 1,
								ChaCinsi = 0,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = kesintiler.BelgeNo,
								ChaBelgeTarih = DateTime.Parse(kesintiler.BelgeTarihi.ToString("yyyy-MM-dd")),
								ChaAciklama = kesintiler.Aciklama.Length > 40 ? kesintiler.Aciklama.Substring(0, 40) : kesintiler.Aciklama,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = "TEM." + kesintiler.MuhasebeKodu,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "GDH",
								ChaKasaHizmet = 2,
								ChaKasaHizkod = kesintiler.MuhasebeKodu,
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 1,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = double.Parse(kesintiler.MeblagBSMVDahil) / 100,
								ChaAratoplam = double.Parse(kesintiler.MeblagBSMVDahil) / 100,
								ChaVade = int.Parse(kesintiler.BelgeTarihi.ToString("yyyyMMdd")),
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
								ChaVergifonToplam = 0
							};
							await _context.CariHesapHareketleris.AddAsync(kesintilerCari);
						}
					}
                    if (filtrelenmisKesintiler.Count > 0)
                    {
                        Console.WriteLine(JsonConvert.SerializeObject(filtrelenmisKesintiler));
                        _memoryCache.Set("FiltrelenmisKesintilerCacheKey", filtrelenmisKesintiler, TimeSpan.FromMinutes(10));
                    }
                }
				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.GidenHareketler.Count + jsonData.GelenHareketler.Count + jsonData.Kesintiler.Count} adettir. Aktarılan Giden Hareketler {toplamGidenHareketler} adettir. Aktarılan Gelen Hareketler {toplamGelenHareketler} adettir. Aktarılan Kesintiler {toplamKesintiler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}

    [HttpGet]
    public async Task<ActionResult> GetGidenHareketler()
    {
        if (_memoryCache.TryGetValue("FiltrelenmisGidenHareketlerCacheKey", out List<GidenHareketler> gidenHareketler))
        {
            if (gidenHareketler == null || !gidenHareketler.Any()) // Boş liste kontrolü
            {
                return NotFound("Giden Hareketler bulunamadı. Cache'de veri yok.");
            }
            return Ok(gidenHareketler);
        }
        return NotFound("Giden Hareketler bulunamadı.");
    }



    [HttpGet]
    public async Task<ActionResult> GetGelenHavaleler()
    {
        if (_memoryCache.TryGetValue("FiltrelenmisGelenHareketlerCacheKey", out List<GelenHareketler> gelenHareketler))
        {
            if (gelenHareketler == null || !gelenHareketler.Any()) // Boş liste kontrolü
            {
                return NotFound("Gelen Havaleler bulunamadı. Cache'de veri yok.");
            }
            return Ok(gelenHareketler);
        }
        return NotFound("Gelen Havaleler bulunamadı.");
    }


    [HttpGet]
    public async Task<ActionResult> GetKesintiler()
    {
        if (_memoryCache.TryGetValue("FiltrelenmisKesintilerCacheKey", out List<Kesintiler> kesintiler))
        {
            if (kesintiler == null || !kesintiler.Any()) // Boş liste kontrolü
            {
                return NotFound("Kesintiler bulunamadı. Cache'de veri yok.");
            }
            return Ok(kesintiler);
        }
        return NotFound("Kesintiler bulunamadı.");
    }


}
