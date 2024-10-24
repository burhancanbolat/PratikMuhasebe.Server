using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using PratikMuhasebe.Server.DTOs;

namespace PratikMuhasebe.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class A10Controller : ControllerBase
{
	private readonly HttpClient _httpClient;
	private readonly MikroDbV16Test2Context _context;
	private readonly IMemoryCache _memoryCache;

	public A10Controller(IHttpClientFactory httpClientFactory, MikroDbV16Test2Context context, IMemoryCache memoryCache)
	{
		_httpClient = httpClientFactory.CreateClient();
		_context = context;
		_memoryCache = memoryCache;
	}

	[HttpPost]
	public async Task<ActionResult> GetA10(A09Dto a09Dto)
	{
		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A10_Zararlar.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=1&baslangic_tarihi={a09Dto.StartDate:yyyy-MM-dd}&bitis_tarihi={a09Dto.EndDate:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A10Response>(jsonResponse);
			if (jsonData.Zararlar is not null)
			{
				int evrakSiraNo;
				int sonCariislemKodu;
				var sonCariIslem = await _context.CariHesapHareketleris
				.OrderByDescending(x => x.ChaSpecRecNo)
				.Take(1)
					.FirstOrDefaultAsync();
				var kaydınEvrakTipi = "FZR001";
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
				int toplamZararlar = 0;
				if (jsonData.Zararlar.Count > 0)
				{
					var filtrelenmisZararlar = new List<Zararlar>();
					foreach (var zarar in jsonData.Zararlar)
					{
						string srmrkkodu = "";
						byte caricins = 0;
						if (zarar.KarsilayanHesap == "689.02.002")
						{
							caricins = 5;
						}
						else
						{
							caricins = 0;
						}
						if (zarar.KarsilayanHesap == "689.02.002")
						{
							srmrkkodu = "";
						}
						else
						{
							srmrkkodu = "159";
						}
						if (!mikrodaVarolanBelgeNumaraları.Contains(zarar.BelgeNo))
						{
							filtrelenmisZararlar.Add(zarar);
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamZararlar += 2;
							CariHesapHareketleri nakitHareketler = new()
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
								ChaEvrakTip = 33,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = DateTime.Parse(zarar.Tarih.ToString("yyyy-MM-dd")),
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = zarar.BelgeNo,
								ChaBelgeTarih = DateTime.Parse(zarar.Tarih.ToString("yyyy-MM-dd")),
								ChaAciklama = zarar.Aciklama.Length > 40 ? zarar.Aciklama.Substring(0, 40) : zarar.Aciklama,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = caricins,
								ChaKod = zarar.KarsilayanHesap,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = srmrkkodu,
								ChaKasaHizmet = 0,
								ChaKasaHizkod = "",
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = (zarar.MeblagBSMVDahil / 100) * -1,
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
								ChaFisSirano = 1,
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
                                BanMainProgramNo = zarar.BanMainProgramNo, 
                                BanVersionNo = zarar.BanVersionNo,         
                                BanMenuNo = zarar.BanMenuNo,              
                                BanMikroSpecial1 = zarar.BanMikroSpecial1, 
                                BanMikroSpecial2 = zarar.BanMikroSpecial2, 
                                BanMikroSpecial3 = zarar.BanMikroSpecial3, 
                                BanExternalProgramType = zarar.BanExternalProgramType, 
                                BanExternalProgramId = zarar.BanExternalProgramId,     
                                BanHash = zarar.BanHash
                            };
							sonCariislemKodu += 1;
							CariHesapHareketleri nakitHareketler2 = new()
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
								ChaEvrakTip = 33,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 1,
								ChaTarihi = DateTime.Parse(zarar.Tarih.ToString("yyyy-MM-dd")),
								ChaTip = 1,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = zarar.BelgeNo,
								ChaBelgeTarih = DateTime.Parse(zarar.Tarih.ToString("yyyy-MM-dd")),
								ChaAciklama = zarar.Aciklama.Length > 40 ? zarar.Aciklama.Substring(0, 40) : zarar.Aciklama,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = zarar.MuhasebeKodu,
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
								ChaMeblag = (zarar.MeblagBSMVDahil / 100) * -1,
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
								ChaFisSirano = 1,
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
                                BanMainProgramNo = zarar.BanMainProgramNo, 
                                BanVersionNo = zarar.BanVersionNo,         
                                BanMenuNo = zarar.BanMenuNo,               
                                BanMikroSpecial1 = zarar.BanMikroSpecial1, 
                                BanMikroSpecial2 = zarar.BanMikroSpecial2, 
                                BanMikroSpecial3 = zarar.BanMikroSpecial3, 
                                BanExternalProgramType = zarar.BanExternalProgramType, 
                                BanExternalProgramId = zarar.BanExternalProgramId,     
                                BanHash = zarar.BanHash
                            };
							await _context.CariHesapHareketleris.AddRangeAsync(nakitHareketler,nakitHareketler2);
						}
					}
					if (filtrelenmisZararlar.Count > 0)
					{
						_memoryCache.Set("FiltrelenmisZararlarCacheKey", filtrelenmisZararlar, TimeSpan.FromMinutes(1));
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Zararlar.Count} adettir. Aktarılan Zarar hareketleri {toplamZararlar} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse.Hata = "Seçilen tarihler arasında kayıt bulunamadı");

		}
		return BadRequest();
	}


	[HttpGet]
	public async Task<ActionResult> GetZararlar()
	{
		if (_memoryCache.TryGetValue("FiltrelenmisZararlarCacheKey", out List<Zararlar> zararlar))
		{
			return Ok(zararlar);
		}
		return NotFound("Gönderilen Nakitler bulunamadı.");
	}
}
