﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using PratikMuhasebe.Server.DTOs;
using System.Net.Http;

namespace PratikMuhasebe.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class A14Controller : ControllerBase
{
	private readonly HttpClient _httpClient;
	private readonly MikroDbV16Test2Context _context;
	private readonly IMemoryCache _memoryCache;

	public A14Controller(IHttpClientFactory httpClientFactory, MikroDbV16Test2Context context, IMemoryCache memoryCache)
	{
		_httpClient = httpClientFactory.CreateClient();
		_context = context;
		_memoryCache = memoryCache;
	}

	[HttpPost]
	public async Task<ActionResult> GetA14(A09Dto a09Dto)
	{
		string apiUrl = $"https://betik.bizimvezne.com/resmi_muhasebe/A14_Giderler?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip=2&baslangic_tarihi={a09Dto.StartDate:yyyy-MM-dd}&bitis_tarihi={a09Dto.EndDate:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A11Response>(jsonResponse);
			if (jsonData.Giderler is not null)
			{
				int evrakSiraNo;
				int sonCariislemKodu;
				var sonCariIslem = await _context.CariHesapHareketleris
				.OrderByDescending(x => x.ChaSpecRecNo)
				.Take(1)
					.FirstOrDefaultAsync();
				var kaydınEvrakTipi = "GDP";
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
				int toplamGiderler = 0;
				if (jsonData.Giderler.Count > 0)
				{
					var filtrelenmisGiderler = new List<Giderler>();
					foreach (var gider in jsonData.Giderler)
					{

						if (!mikrodaVarolanBelgeNumaraları.Contains(gider.BelgeNo))
						{
							string dismitemmi = string.Empty;
							if (gider.MuhasebeKodu.Substring(0, 2) == "01")
							{
								dismitemmi = "TEM." + gider.MuhasebeKodu.Substring(0, 2) + ".001." +
											 gider.MuhasebeKodu.Substring(gider.MuhasebeKodu.LastIndexOf('.') + 1);
							}
							else if (gider.MuhasebeKodu.Substring(0, 2) == "02")
							{
								dismitemmi = "DIS." + gider.MuhasebeKodu.Substring(0, 2) + ".001." +
											 gider.MuhasebeKodu.Substring(gider.MuhasebeKodu.LastIndexOf('.') + 1);
							}
							string chaaciklama = gider.Aciklama + "-" + gider.FaturaNo;
							filtrelenmisGiderler.Add(gider);
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamGiderler += 1;
							CariHesapHareketleri giderler = new()
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
								ChaEvrakTip = 35,
								ChaEvraknoSeri = kaydınEvrakTipi,
								ChaEvraknoSira = evrakSiraNo,
								ChaSatirNo = 0,
								ChaTarihi = DateTime.Parse(gider.OdenmeTarihi.ToString("yyyy-MM-dd")),
								ChaTip = 0,
								ChaCinsi = 5,
								ChaNormalIade = 0,
								ChaTpoz = 0,
								ChaTicaretTuru = 0,
								ChaBelgeNo = gider.BelgeNo,
								ChaBelgeTarih = DateTime.Parse(gider.OdenmeTarihi.ToString("yyyy-MM-dd")),
								ChaAciklama = chaaciklama.Length > 40 ? chaaciklama.Substring(0, 40) : chaaciklama,
								ChaSaticiKodu = "",
								ChaEximkodu = "",
								ChaProjekodu = "",
								ChaYatTesKodu = "",
								ChaCariCins = 0,
								ChaKod = dismitemmi,
								ChaCiroCariKodu = "",
								ChaDCins = 0,
								ChaDKur = 1,
								ChaAltdKur = 1,
								ChaGrupno = 0,
								ChaSrmrkkodu = "DIS",
								ChaKasaHizmet = 2,
								ChaKasaHizkod = gider.OdemeYontemi,
								ChaKarsidcinsi = 0,
								ChaKarsidKur = 1,
								ChaKarsidgrupno = 0,
								ChaKarsisrmrkkodu = "",
								ChaMiktari = 0,
								ChaMeblag = gider.Tutar / 100,
								ChaAratoplam = gider.Tutar / 100,
								ChaVade = int.Parse(gider.OdenmeTarihi.ToString("yyyyMMdd")),
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
                                BanMainProgramNo = gider.BanMainProgramNo,
                                BanVersionNo = gider.BanVersionNo,
                                BanMenuNo = gider.BanMenuNo,
                                BanMikroSpecial1 = gider.BanMikroSpecial1,
                                BanMikroSpecial2 = gider.BanMikroSpecial2,
                                BanMikroSpecial3 = gider.BanMikroSpecial3,
                                BanExternalProgramType = gider.BanExternalProgramType,
                                BanExternalProgramId = gider.BanExternalProgramId,
                                BanHash = gider.BanHash
                            };
							await _context.CariHesapHareketleris.AddAsync(giderler);
						}
					}
					if (filtrelenmisGiderler.Count > 0)
					{
						_memoryCache.Set("FiltrelenmisGiderlerCacheKey", filtrelenmisGiderler, TimeSpan.FromHours(1));
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {jsonData.Giderler.Count} adettir. Aktarılan Gider hareketleri {toplamGiderler} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}

	[HttpGet]
	public async Task<ActionResult> GetGiderler()
	{
		if (_memoryCache.TryGetValue("FiltrelenmisGiderlerCacheKey", out List<Giderler> giderler))
		{
			return Ok(giderler);
		}
		return NotFound("Giderler bulunamadı.");
	}
}