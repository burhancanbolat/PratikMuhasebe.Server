using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using PratikMuhasebe.Server.DTOs;
using System;

namespace PratikMuhasebe.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class A05Controller : ControllerBase
{
	private readonly HttpClient _httpClient;
	private readonly MikroDbV16Test2Context _context;
	private readonly IMemoryCache _memoryCache;

	public A05Controller(IHttpClientFactory httpClientFactory, MikroDbV16Test2Context context, IMemoryCache memoryCache)
	{
		_httpClient = httpClientFactory.CreateClient();
		_context = context;
		_memoryCache = memoryCache;
	}

	[HttpPost]
	public async Task<ActionResult> GetKOT001(A09Dto a09Dto)
	{
		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip={2}&baslangic_tarihi={a09Dto.StartDate:yyyy-MM-dd}&bitis_tarihi={a09Dto.EndDate:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.Tahakkuk is not null)
			{
				DateTime tarihim = a09Dto.StartDate;
				string SorgulananTarihKisa = tarihim.ToString("yyMMdd");
				string SorgulananTarihKisaYilUzun = tarihim.ToString("yyyyMMdd");
				int evrakSiraNo;
				int sonCariislemKodu;
				var sonCariIslem = await _context.CariHesapHareketleris
				.OrderByDescending(x => x.ChaSpecRecNo)
				.Take(1)
					.FirstOrDefaultAsync();
				var kaydınEvrakTipi = "KOT001";
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
				int toplamKayıtlar = 0;
				int toplamVeri = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var filtrelenmisKayıtlar = new List<OdenenKurumlar>();
					foreach (var tahakkuk in jsonData.Tahakkuk)
					{
						int evrakKaydınınSatirNumarasi = -1;
						
						foreach (var odemeYolu in tahakkuk.OdenenKurumlar)
						{
							toplamVeri += 1;
							var belge_no = tahakkuk.MuhasebeKodu + "1" + SorgulananTarihKisa;
							var belge_no1 = tahakkuk.MuhasebeKodu + "1" + SorgulananTarihKisa;
							var belge_no2 = tahakkuk.MuhasebeKodu + "2" + SorgulananTarihKisa;
							var belge_no3 = tahakkuk.MuhasebeKodu + "3" + SorgulananTarihKisa;
							var belge_no4 = tahakkuk.MuhasebeKodu + "4" + SorgulananTarihKisa;
							var belge_no5 = tahakkuk.MuhasebeKodu + "5" + SorgulananTarihKisa;
							var belge_no6 = tahakkuk.MuhasebeKodu + "6" + SorgulananTarihKisa;
							var belge_no7 = tahakkuk.MuhasebeKodu + "7" + SorgulananTarihKisa;
							var belge_no8 = tahakkuk.MuhasebeKodu + "8" + SorgulananTarihKisa;
							var belge_no9 = tahakkuk.MuhasebeKodu + "9" + SorgulananTarihKisa;
							var belge_no10 = tahakkuk.MuhasebeKodu + "10" + SorgulananTarihKisa;
							var belge_no11 = tahakkuk.MuhasebeKodu + "11" + SorgulananTarihKisa;
							var belge_no12 = tahakkuk.MuhasebeKodu + "12" + SorgulananTarihKisa;

							var BelgeNoString1 = (tahakkuk.MuhasebeKodu + (1 + ((evrakKaydınınSatirNumarasi + 1) * 2)) + SorgulananTarihKisa).Replace("TEM.", "").Replace(".", "") + 2;
							var BelgeNoString2 = (tahakkuk.MuhasebeKodu + (2 + ((evrakKaydınınSatirNumarasi + 1) * 2)) + SorgulananTarihKisa).Replace("TEM.", "").Replace(".", "") + 2;

							if (mikrodaVarolanBelgeNumaraları != null && !mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) && !mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2))
							{
								filtrelenmisKayıtlar.Add(odemeYolu);
								sonCariislemKodu += 1;
								evrakSiraNo += 1;
								toplamKayıtlar += 2;
								CariHesapHareketleri borc = new CariHesapHareketleri();
								CariHesapHareketleri alacak = new CariHesapHareketleri();

								borc.ChaSpecRecNo = sonCariislemKodu;
								sonCariislemKodu += 1;
								alacak.ChaSpecRecNo = sonCariislemKodu;
								borc.ChaSatirNo = 1 + (evrakKaydınınSatirNumarasi * 2);
								alacak.ChaSatirNo = 2 + (evrakKaydınınSatirNumarasi * 2);
								borc.ChaBelgeNo = (tahakkuk.MuhasebeKodu + (1 + (evrakKaydınınSatirNumarasi * 2)).ToString() + SorgulananTarihKisa).Replace("TEM.", "").Replace(".", "") + 2.ToString();
								alacak.ChaBelgeNo = (tahakkuk.MuhasebeKodu + (2 + (evrakKaydınınSatirNumarasi * 2)).ToString() + SorgulananTarihKisa).Replace("TEM.", "").Replace(".", "") + 2.ToString();
								borc.ChaIptal = false;
								alacak.ChaIptal = false;
                                borc.BanMainProgramNo = tahakkuk.BanMainProgramNo;
                                alacak.BanMainProgramNo = tahakkuk.BanMainProgramNo;
                                borc.BanVersionNo = tahakkuk.BanVersionNo;
                                alacak.BanVersionNo = tahakkuk.BanVersionNo;
                                borc.BanMenuNo = tahakkuk.BanMenuNo;
                                alacak.BanMenuNo = tahakkuk.BanMenuNo;
                                borc.BanMikroSpecial1 = tahakkuk.BanMikroSpecial1;
                                alacak.BanMikroSpecial1 = tahakkuk.BanMikroSpecial1;
                                borc.BanMikroSpecial2 = tahakkuk.BanMikroSpecial2;
                                alacak.BanMikroSpecial2 = tahakkuk.BanMikroSpecial2;
                                borc.BanMikroSpecial3 = tahakkuk.BanMikroSpecial3;
                                alacak.BanMikroSpecial3 = tahakkuk.BanMikroSpecial3;
                                borc.BanExternalProgramType = tahakkuk.BanExternalProgramType;
                                alacak.BanExternalProgramType = tahakkuk.BanExternalProgramType;
                                borc.BanExternalProgramId = tahakkuk.BanExternalProgramId;
                                alacak.BanExternalProgramId = tahakkuk.BanExternalProgramId;
                                borc.BanHash = tahakkuk.BanHash;
                                alacak.BanHash = tahakkuk.BanHash;
                                borc.ChaFileid = 51;
								alacak.ChaFileid = 51;
								borc.ChaHidden = false;
								alacak.ChaHidden = false;
								borc.ChaKilitli = false;
								alacak.ChaKilitli = false;
								borc.ChaDegisti = false;
								alacak.ChaDegisti = false;
								borc.ChaCheckSum = 0;
								alacak.ChaCheckSum = 0;
								borc.ChaCreateUser = 5;
								alacak.ChaCreateUser = 5;
								borc.ChaCreateDate = DateTime.Now;
								alacak.ChaCreateDate = DateTime.Now;
								borc.ChaLastupUser = 5;
								alacak.ChaLastupUser= 5;
								borc.ChaLastupDate = DateTime.Now;
								alacak.ChaLastupDate= DateTime.Now;
								borc.ChaSpecial1 = "";
								borc.ChaSpecial2 = "";
								borc.ChaSpecial3 = "";
								alacak.ChaSpecial1 = "";
								alacak.ChaSpecial2 = "";
								alacak.ChaSpecial3 = "";
								borc.ChaFirmano = 0;
								alacak.ChaFirmano = 0;
								borc.ChaSubeno = 0;
								alacak.ChaSubeno= 0;
								borc.ChaEvrakTip = 57;
								alacak.ChaEvrakTip = 57;
								borc.ChaEvraknoSeri = "KOT001";
								alacak.ChaEvraknoSeri = "KOT001";
								borc.ChaEvraknoSira = evrakSiraNo;
								alacak.ChaEvraknoSira= evrakSiraNo;
								borc.ChaTarihi = a09Dto.StartDate;
								alacak.ChaTarihi= a09Dto.StartDate;
								borc.ChaTip = 0;
								alacak.ChaTip = 1;
								borc.ChaCinsi = 5;
								alacak.ChaCinsi= 5;
								borc.ChaNormalIade = 0;
								alacak.ChaNormalIade = 0;
								borc.ChaTpoz = 0;
								alacak.ChaTpoz= 0;
								borc.ChaTicaretTuru = 0;
								alacak.ChaTicaretTuru= 0;
								borc.ChaBelgeTarih = a09Dto.StartDate;
								alacak.ChaBelgeTarih = a09Dto.StartDate;
								borc.ChaAciklama = a09Dto.StartDate + "ÖdFatBed" + (evrakKaydınınSatirNumarasi * 2);
								alacak.ChaAciklama = a09Dto.StartDate + "ÖdFatBed" + ((evrakKaydınınSatirNumarasi * 2) + 1);
								borc.ChaSaticiKodu = "";
								alacak.ChaSaticiKodu = "";
								borc.ChaEximkodu = "";
								alacak.ChaEximkodu = "";
								borc.ChaProjekodu = "";
								alacak.ChaProjekodu = "";
								borc.ChaYatTesKodu = "";
								alacak.ChaYatTesKodu = "";
								borc.ChaCariCins = 0;
								alacak.ChaCariCins = 0;
								borc.ChaKod = tahakkuk.MuhasebeKodu;
								alacak.ChaKod = tahakkuk.MuhasebeKodu;
								borc.ChaCiroCariKodu = "";
								alacak.ChaCiroCariKodu = "";
								borc.ChaDCins = 0;
								alacak.ChaDCins=0;
								borc.ChaDKur = 1;
								alacak.ChaDKur = 1;
								borc.ChaAltdKur = 1;
								alacak.ChaAltdKur= 1;
								borc.ChaGrupno = 0;
								alacak.ChaGrupno= 0;
								borc.ChaSrmrkkodu = "GLH";
								alacak.ChaSrmrkkodu = "KRM";
								borc.ChaKasaHizmet = 0;
								alacak.ChaKasaHizmet= 0;
								borc.ChaKasaHizkod = "";
								alacak.ChaKasaHizkod = "";
								borc.ChaKarsidcinsi = 0;
								alacak.ChaKarsidcinsi= 0;
								borc.ChaKarsidKur = 1;
								alacak.ChaKarsidKur= 1;
								borc.ChaKarsidgrupno = 0;
								alacak.ChaKarsidgrupno= 0;
								borc.ChaSrmrkkodu = "";
								alacak.ChaSrmrkkodu = "";
								borc.ChaMiktari = 0;
								alacak.ChaMiktari= 0;
								borc.ChaMeblag = odemeYolu.FaturaFiyat / 100;
								alacak.ChaMeblag = odemeYolu.FaturaFiyat /100;
								borc.ChaAratoplam = odemeYolu.FaturaFiyat / 100;
								alacak.ChaAratoplam = odemeYolu.FaturaFiyat/100;
								borc.ChaVade = 0;
								alacak.ChaVade = 0;
								borc.ChaVadeFarkiYuz = 0;
								alacak.ChaVadeFarkiYuz = 0;
								borc.ChaFtIskonto1 = 0;
								borc.ChaFtIskonto2 = 0;
								borc.ChaFtIskonto3 = 0;
								borc.ChaFtIskonto4 = 0;
								borc.ChaFtIskonto5 = 0;
								borc.ChaFtIskonto6 = 0;
								borc.ChaFtMasraf1 = 0;
								borc.ChaFtMasraf2 = 0;
								borc.ChaFtMasraf3 = 0;
								borc.ChaFtMasraf4 = 0;
								borc.ChaIskMas1 = 0;
								borc.ChaIskMas2 = 0;
								borc.ChaIskMas3 = 0;
								borc.ChaIskMas4 = 0;
								borc.ChaIskMas5 = 0;
								borc.ChaIskMas6 = 0;
								borc.ChaIskMas7 = 0;
								borc.ChaIskMas8 = 0;
								borc.ChaIskMas9 = 0;
								borc.ChaIskMas10 = 0;
								borc.ChaSatIskmas1 = false;
								borc.ChaSatIskmas2 = false;
								borc.ChaSatIskmas3 = false;
								borc.ChaSatIskmas4 = false;
								borc.ChaSatIskmas5 = false;
								borc.ChaSatIskmas6 = false;
								borc.ChaSatIskmas7 = false;
								borc.ChaSatIskmas8 = false;
								borc.ChaSatIskmas9 = false;
								borc.ChaSatIskmas10 = false;
								borc.ChaYuvarlama = 0;
								borc.ChaStFonPntr = 0;
								borc.ChaStopaj = 0;
								borc.ChaSavsandesfonu = 0;
								borc.ChaAvansmakDamgapul = 0;
								borc.ChaVergipntr = 0;
								borc.ChaVergi1 = 0;
								borc.ChaVergi2 = 0;
								borc.ChaVergi3 = 0;
								borc.ChaVergi4 = 0;
								borc.ChaVergi5 = 0;
								borc.ChaVergi6 = 0;
								borc.ChaVergi7 = 0;
								borc.ChaVergi8 = 0;
								borc.ChaVergi9 = 0;
								borc.ChaVergi10 = 0;
								borc.ChaOivergisizFl = false;
								borc.ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00");
								borc.ChaFisSirano = 0;
								borc.ChaTrefno = "";
								borc.ChaSntckPoz = 0;
								borc.ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00");
								borc.ChaIstisnakodu = 0;
								borc.ChaPosHareketi = 0;
								borc.ChaMeblagAltDovizIcinGecersizFl = 0;
								borc.ChaMeblagAnaDovizIcinGecersizFl = 0;
								borc.ChaMeblagOrjDovizIcinGecersizFl = 0;
								borc.ChaDbcno = 0;
								borc.ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00");
								borc.ChaVardiyaNo = 0;
								borc.ChaVardiyaEvrakTi = 0;
								borc.ChaEbelgeTuru = 0;
								borc.ChaTevkifatToplam = 0;
								borc.ChaIlaveEdilecekKdv1 = 0;
								borc.ChaIlaveEdilecekKdv2 = 0;
								borc.ChaIlaveEdilecekKdv3 = 0;
								borc.ChaIlaveEdilecekKdv4 = 0;
								borc.ChaIlaveEdilecekKdv5 = 0;
								borc.ChaIlaveEdilecekKdv6 = 0;
								borc.ChaIlaveEdilecekKdv7 = 0;
								borc.ChaIlaveEdilecekKdv8 = 0;
								borc.ChaIlaveEdilecekKdv9 = 0;
								borc.ChaIlaveEdilecekKdv10 = 0;
								borc.ChaEIslemTuru = 0;
								borc.ChaFaturaBelgeTuru = 0;
								borc.ChaDigerBelgeAdi = "";

								alacak.ChaFtIskonto1 = 0;
								alacak.ChaFtIskonto2 = 0;
								alacak.ChaFtIskonto3 = 0;
								alacak.ChaFtIskonto4 = 0;
								alacak.ChaFtIskonto5 = 0;
								alacak.ChaFtIskonto6 = 0;
								alacak.ChaFtMasraf1 = 0;
								alacak.ChaFtMasraf2 = 0;
								alacak.ChaFtMasraf3 = 0;
								alacak.ChaFtMasraf4 = 0;
								alacak.ChaIskMas1 = 0;
								alacak.ChaIskMas2 = 0;
								alacak.ChaIskMas3 = 0;
								alacak.ChaIskMas4 = 0;
								alacak.ChaIskMas5 = 0;
								alacak.ChaIskMas6 = 0;
								alacak.ChaIskMas7 = 0;
								alacak.ChaIskMas8 = 0;
								alacak.ChaIskMas9 = 0;
								alacak.ChaIskMas10 = 0;
								alacak.ChaSatIskmas1 = false;
								alacak.ChaSatIskmas2 = false;
								alacak.ChaSatIskmas3 = false;
								alacak.ChaSatIskmas4 = false;
								alacak.ChaSatIskmas5 = false;
								alacak.ChaSatIskmas6 = false;
								alacak.ChaSatIskmas7 = false;
								alacak.ChaSatIskmas8 = false;
								alacak.ChaSatIskmas9 = false;
								alacak.ChaSatIskmas10 = false;
								alacak.ChaYuvarlama = 0;
								alacak.ChaStFonPntr = 0;
								alacak.ChaStopaj = 0;
								alacak.ChaSavsandesfonu = 0;
								alacak.ChaAvansmakDamgapul = 0;
								alacak.ChaVergipntr = 0;
								alacak.ChaVergi1 = 0;
								alacak.ChaVergi2 = 0;
								alacak.ChaVergi3 = 0;
								alacak.ChaVergi4 = 0;
								alacak.ChaVergi5 = 0;
								alacak.ChaVergi6 = 0;
								alacak.ChaVergi7 = 0;
								alacak.ChaVergi8 = 0;
								alacak.ChaVergi9 = 0;
								alacak.ChaVergi10 = 0;
								alacak.ChaOivergisizFl = false;
								alacak.ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00");
								alacak.ChaFisSirano = 0;
								alacak.ChaTrefno = "";
								alacak.ChaSntckPoz = 0;
								alacak.ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00");
								alacak.ChaIstisnakodu = 0;
								alacak.ChaPosHareketi = 0;
								alacak.ChaMeblagAltDovizIcinGecersizFl = 0;
								alacak.ChaMeblagAnaDovizIcinGecersizFl = 0;
								alacak.ChaMeblagOrjDovizIcinGecersizFl = 0;
								alacak.ChaDbcno = 0;
								alacak.ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00");
								alacak.ChaVardiyaNo = 0;
								alacak.ChaVardiyaEvrakTi = 0;
								alacak.ChaEbelgeTuru = 0;
								alacak.ChaTevkifatToplam = 0;
								alacak.ChaIlaveEdilecekKdv1 = 0;
								alacak.ChaIlaveEdilecekKdv2 = 0;
								alacak.ChaIlaveEdilecekKdv3 = 0;
								alacak.ChaIlaveEdilecekKdv4 = 0;
								alacak.ChaIlaveEdilecekKdv5 = 0;
								alacak.ChaIlaveEdilecekKdv6 = 0;
								alacak.ChaIlaveEdilecekKdv7 = 0;
								alacak.ChaIlaveEdilecekKdv8 = 0;
								alacak.ChaIlaveEdilecekKdv9 = 0;
								alacak.ChaIlaveEdilecekKdv10 = 0;
								alacak.ChaEIslemTuru = 0;
								alacak.ChaFaturaBelgeTuru = 0;
								alacak.ChaDigerBelgeAdi = "";

								await _context.CariHesapHareketleris.AddRangeAsync(borc,alacak);
							}
						}

						
					}
					if (filtrelenmisKayıtlar.Count > 0)
					{
						_memoryCache.Set("FiltrelenmisKayıtlarCacheKey", filtrelenmisKayıtlar, TimeSpan.FromMinutes(1));
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {toplamVeri} adettir. Aktarılan toplam veri {toplamKayıtlar} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
	[HttpPost]
	public async Task<ActionResult> GetKOT002(A09Dto a09Dto)
	{
		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip={3}&baslangic_tarihi={a09Dto.StartDate:yyyy-MM-dd}&bitis_tarihi={a09Dto.EndDate:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.KurumTahakkuk is not null)
			{
				DateTime tarihim = a09Dto.StartDate;
				string SorgulananTarihKisa = tarihim.ToString("yyMMdd");
				string SorgulananTarihKisaYilUzun = tarihim.ToString("yyyyMMdd");
				int evrakSiraNo;
				int sonCariislemKodu;
				var sonCariIslem = await _context.CariHesapHareketleris
				.OrderByDescending(x => x.ChaSpecRecNo)
				.Take(1)
					.FirstOrDefaultAsync();
				var kaydınEvrakTipi = "KOT002";
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
				int toplamKayıtlar = 0;
				int toplamVeri = 0;
				if (jsonData.KurumTahakkuk.Count > 0)
				{
					var filtrelenmisKurumTahakkuk = new List<KurumTahakkuk>();
					foreach (var tahakkuk in jsonData.KurumTahakkuk)
					{
						int evrakKaydınınSatirNumarasi = -1;

						
							toplamVeri += 1;

							var BelgeNoString1 = (tahakkuk.MuhasebeKodu + (1 + ((evrakKaydınınSatirNumarasi + 1) * 2)) + SorgulananTarihKisa).Replace("KRM.", "").Replace(".", "") + 4;
							var BelgeNoString2 = (tahakkuk.MuhasebeKodu + (2 + ((evrakKaydınınSatirNumarasi + 1) * 2)) + SorgulananTarihKisa).Replace("KRM.", "").Replace(".", "") + 4;

							if (mikrodaVarolanBelgeNumaraları != null && !mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) && !mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString2))
							{
								filtrelenmisKurumTahakkuk.Add(tahakkuk);
								sonCariislemKodu += 1;
								evrakSiraNo += 1;
								toplamKayıtlar += 2;
								CariHesapHareketleri borc = new CariHesapHareketleri();
								CariHesapHareketleri alacak = new CariHesapHareketleri();

								borc.ChaSpecRecNo = sonCariislemKodu;
								sonCariislemKodu += 1;
								alacak.ChaSpecRecNo = sonCariislemKodu;
								borc.ChaSatirNo = 1 + (evrakKaydınınSatirNumarasi * 2);
								alacak.ChaSatirNo = 2 + (evrakKaydınınSatirNumarasi * 2);
								borc.ChaBelgeNo = (tahakkuk.MuhasebeKodu + (1 + (evrakKaydınınSatirNumarasi * 2)).ToString() + SorgulananTarihKisa).Replace("KRM.", "").Replace(".", "") + 4.ToString();
								alacak.ChaBelgeNo = (tahakkuk.MuhasebeKodu + (2 + (evrakKaydınınSatirNumarasi * 2)).ToString() + SorgulananTarihKisa).Replace("KRM.", "").Replace(".", "") + 4.ToString();
								borc.ChaIptal = false;
								alacak.ChaIptal = false;
								borc.ChaFileid = 51;
								alacak.ChaFileid = 51;
								borc.ChaHidden = false;
								alacak.ChaHidden = false;
								borc.ChaKilitli = false;
								alacak.ChaKilitli = false;
								borc.ChaDegisti = false;
								alacak.ChaDegisti = false;
								borc.ChaCheckSum = 0;
								alacak.ChaCheckSum = 0;
								borc.ChaCreateUser = 5;
								alacak.ChaCreateUser = 5;
								borc.ChaCreateDate = DateTime.Now;
								alacak.ChaCreateDate = DateTime.Now;
								borc.ChaLastupUser = 5;
								alacak.ChaLastupUser = 5;
								borc.ChaLastupDate = DateTime.Now;
								alacak.ChaLastupDate = DateTime.Now;
								borc.ChaSpecial1 = "";
								borc.ChaSpecial2 = "";
								borc.ChaSpecial3 = "";
								alacak.ChaSpecial1 = "";
								alacak.ChaSpecial2 = "";
								alacak.ChaSpecial3 = "";
								borc.ChaFirmano = 0;
								alacak.ChaFirmano = 0;
								borc.ChaSubeno = 0;
								alacak.ChaSubeno = 0;
								borc.ChaEvrakTip = 57;
								alacak.ChaEvrakTip = 57;
								borc.ChaEvraknoSeri = "KOT002";
								alacak.ChaEvraknoSeri = "KOT002";
								borc.ChaEvraknoSira = evrakSiraNo;
								alacak.ChaEvraknoSira = evrakSiraNo;
								borc.ChaTarihi = a09Dto.StartDate;
								alacak.ChaTarihi = a09Dto.StartDate;
								borc.ChaTip = 0;
								alacak.ChaTip = 1;
								borc.ChaCinsi = 5;
								alacak.ChaCinsi = 5;
								borc.ChaNormalIade = 0;
								alacak.ChaNormalIade = 0;
								borc.ChaTpoz = 0;
								alacak.ChaTpoz = 0;
								borc.ChaTicaretTuru = 0;
								alacak.ChaTicaretTuru = 0;
								borc.ChaBelgeTarih = a09Dto.StartDate;
								alacak.ChaBelgeTarih = a09Dto.StartDate;
								borc.ChaAciklama = a09Dto.StartDate + "ÖdFatBed" + (evrakKaydınınSatirNumarasi * 2);
								alacak.ChaAciklama = a09Dto.StartDate + "ÖdFatBed" + ((evrakKaydınınSatirNumarasi * 2) + 1);
								borc.ChaSaticiKodu = "";
								alacak.ChaSaticiKodu = "";
								borc.ChaEximkodu = "";
								alacak.ChaEximkodu = "";
								borc.ChaProjekodu = "";
								alacak.ChaProjekodu = "";
								borc.ChaYatTesKodu = "";
								alacak.ChaYatTesKodu = "";
								borc.ChaCariCins = 0;
								alacak.ChaCariCins = 0;
								borc.ChaKod = tahakkuk.MuhasebeKodu;
								alacak.ChaKod = tahakkuk.PortalKodu;
								borc.ChaCiroCariKodu = "";
								alacak.ChaCiroCariKodu = "";
								borc.ChaDCins = 0;
								alacak.ChaDCins = 0;
								borc.ChaDKur = 1;
								alacak.ChaDKur = 1;
								borc.ChaAltdKur = 1;
								alacak.ChaAltdKur = 1;
								borc.ChaGrupno = 0;
								alacak.ChaGrupno = 0;
								borc.ChaSrmrkkodu = "KRM";
								alacak.ChaSrmrkkodu = "159";
								borc.ChaKasaHizmet = 0;
								alacak.ChaKasaHizmet = 0;
								borc.ChaKasaHizkod = "";
								alacak.ChaKasaHizkod = "";
								borc.ChaKarsidcinsi = 0;
								alacak.ChaKarsidcinsi = 0;
								borc.ChaKarsidKur = 1;
								alacak.ChaKarsidKur = 1;
								borc.ChaKarsidgrupno = 0;
								alacak.ChaKarsidgrupno = 0;
								borc.ChaSrmrkkodu = "";
								alacak.ChaSrmrkkodu = "";
								borc.ChaMiktari = 0;
								alacak.ChaMiktari = 0;
								borc.ChaMeblag = tahakkuk.FaturaFiyat / 100;
								alacak.ChaMeblag = tahakkuk.FaturaFiyat / 100;
								borc.ChaAratoplam = tahakkuk.FaturaFiyat / 100;
								alacak.ChaAratoplam = tahakkuk.FaturaFiyat / 100;
								borc.ChaVade = 0;
								alacak.ChaVade = 0;
								borc.ChaVadeFarkiYuz = 0;
								alacak.ChaVadeFarkiYuz = 0;
								borc.ChaFtIskonto1 = 0;
								borc.ChaFtIskonto2 = 0;
								borc.ChaFtIskonto3 = 0;
								borc.ChaFtIskonto4 = 0;
								borc.ChaFtIskonto5 = 0;
								borc.ChaFtIskonto6 = 0;
								borc.ChaFtMasraf1 = 0;
								borc.ChaFtMasraf2 = 0;
								borc.ChaFtMasraf3 = 0;
								borc.ChaFtMasraf4 = 0;
								borc.ChaIskMas1 = 0;
								borc.ChaIskMas2 = 0;
								borc.ChaIskMas3 = 0;
								borc.ChaIskMas4 = 0;
								borc.ChaIskMas5 = 0;
								borc.ChaIskMas6 = 0;
								borc.ChaIskMas7 = 0;
								borc.ChaIskMas8 = 0;
								borc.ChaIskMas9 = 0;
								borc.ChaIskMas10 = 0;
								borc.ChaSatIskmas1 = false;
								borc.ChaSatIskmas2 = false;
								borc.ChaSatIskmas3 = false;
								borc.ChaSatIskmas4 = false;
								borc.ChaSatIskmas5 = false;
								borc.ChaSatIskmas6 = false;
								borc.ChaSatIskmas7 = false;
								borc.ChaSatIskmas8 = false;
								borc.ChaSatIskmas9 = false;
								borc.ChaSatIskmas10 = false;
								borc.ChaYuvarlama = 0;
								borc.ChaStFonPntr = 0;
								borc.ChaStopaj = 0;
								borc.ChaSavsandesfonu = 0;
								borc.ChaAvansmakDamgapul = 0;
								borc.ChaVergipntr = 0;
								borc.ChaVergi1 = 0;
								borc.ChaVergi2 = 0;
								borc.ChaVergi3 = 0;
								borc.ChaVergi4 = 0;
								borc.ChaVergi5 = 0;
								borc.ChaVergi6 = 0;
								borc.ChaVergi7 = 0;
								borc.ChaVergi8 = 0;
								borc.ChaVergi9 = 0;
								borc.ChaVergi10 = 0;
								borc.ChaOivergisizFl = false;
								borc.ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00");
								borc.ChaFisSirano = 0;
								borc.ChaTrefno = "";
								borc.ChaSntckPoz = 0;
								borc.ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00");
								borc.ChaIstisnakodu = 0;
								borc.ChaPosHareketi = 0;
								borc.ChaMeblagAltDovizIcinGecersizFl = 0;
								borc.ChaMeblagAnaDovizIcinGecersizFl = 0;
								borc.ChaMeblagOrjDovizIcinGecersizFl = 0;
								borc.ChaDbcno = 0;
								borc.ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00");
								borc.ChaVardiyaNo = 0;
								borc.ChaVardiyaEvrakTi = 0;
								borc.ChaEbelgeTuru = 0;
								borc.ChaTevkifatToplam = 0;
								borc.ChaIlaveEdilecekKdv1 = 0;
								borc.ChaIlaveEdilecekKdv2 = 0;
								borc.ChaIlaveEdilecekKdv3 = 0;
								borc.ChaIlaveEdilecekKdv4 = 0;
								borc.ChaIlaveEdilecekKdv5 = 0;
								borc.ChaIlaveEdilecekKdv6 = 0;
								borc.ChaIlaveEdilecekKdv7 = 0;
								borc.ChaIlaveEdilecekKdv8 = 0;
								borc.ChaIlaveEdilecekKdv9 = 0;
								borc.ChaIlaveEdilecekKdv10 = 0;
								borc.ChaEIslemTuru = 0;
								borc.ChaFaturaBelgeTuru = 0;
								borc.ChaDigerBelgeAdi = "";
								


								alacak.ChaFtIskonto1 = 0;
								alacak.ChaFtIskonto2 = 0;
								alacak.ChaFtIskonto3 = 0;
								alacak.ChaFtIskonto4 = 0;
								alacak.ChaFtIskonto5 = 0;
								alacak.ChaFtIskonto6 = 0;
								alacak.ChaFtMasraf1 = 0;
								alacak.ChaFtMasraf2 = 0;
								alacak.ChaFtMasraf3 = 0;
								alacak.ChaFtMasraf4 = 0;
								alacak.ChaIskMas1 = 0;
								alacak.ChaIskMas2 = 0;
								alacak.ChaIskMas3 = 0;
								alacak.ChaIskMas4 = 0;
								alacak.ChaIskMas5 = 0;
								alacak.ChaIskMas6 = 0;
								alacak.ChaIskMas7 = 0;
								alacak.ChaIskMas8 = 0;
								alacak.ChaIskMas9 = 0;
								alacak.ChaIskMas10 = 0;
								alacak.ChaSatIskmas1 = false;
								alacak.ChaSatIskmas2 = false;
								alacak.ChaSatIskmas3 = false;
								alacak.ChaSatIskmas4 = false;
								alacak.ChaSatIskmas5 = false;
								alacak.ChaSatIskmas6 = false;
								alacak.ChaSatIskmas7 = false;
								alacak.ChaSatIskmas8 = false;
								alacak.ChaSatIskmas9 = false;
								alacak.ChaSatIskmas10 = false;
								alacak.ChaYuvarlama = 0;
								alacak.ChaStFonPntr = 0;
								alacak.ChaStopaj = 0;
								alacak.ChaSavsandesfonu = 0;
								alacak.ChaAvansmakDamgapul = 0;
								alacak.ChaVergipntr = 0;
								alacak.ChaVergi1 = 0;
								alacak.ChaVergi2 = 0;
								alacak.ChaVergi3 = 0;
								alacak.ChaVergi4 = 0;
								alacak.ChaVergi5 = 0;
								alacak.ChaVergi6 = 0;
								alacak.ChaVergi7 = 0;
								alacak.ChaVergi8 = 0;
								alacak.ChaVergi9 = 0;
								alacak.ChaVergi10 = 0;
								alacak.ChaOivergisizFl = false;
								alacak.ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00");
								alacak.ChaFisSirano = 0;
								alacak.ChaTrefno = "";
								alacak.ChaSntckPoz = 0;
								alacak.ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00");
								alacak.ChaIstisnakodu = 0;
								alacak.ChaPosHareketi = 0;
								alacak.ChaMeblagAltDovizIcinGecersizFl = 0;
								alacak.ChaMeblagAnaDovizIcinGecersizFl = 0;
								alacak.ChaMeblagOrjDovizIcinGecersizFl = 0;
								alacak.ChaDbcno = 0;
								alacak.ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00");
								alacak.ChaVardiyaNo = 0;
								alacak.ChaVardiyaEvrakTi = 0;
								alacak.ChaEbelgeTuru = 0;
								alacak.ChaTevkifatToplam = 0;
								alacak.ChaIlaveEdilecekKdv1 = 0;
								alacak.ChaIlaveEdilecekKdv2 = 0;
								alacak.ChaIlaveEdilecekKdv3 = 0;
								alacak.ChaIlaveEdilecekKdv4 = 0;
								alacak.ChaIlaveEdilecekKdv5 = 0;
								alacak.ChaIlaveEdilecekKdv6 = 0;
								alacak.ChaIlaveEdilecekKdv7 = 0;
								alacak.ChaIlaveEdilecekKdv8 = 0;
								alacak.ChaIlaveEdilecekKdv9 = 0;
								alacak.ChaIlaveEdilecekKdv10 = 0;
								alacak.ChaEIslemTuru = 0;
								alacak.ChaFaturaBelgeTuru = 0;
								alacak.ChaDigerBelgeAdi = "";
                            borc.BanMainProgramNo = 0;
                            alacak.BanMainProgramNo = 0;

                            borc.BanVersionNo = 0;
                            alacak.BanVersionNo = 0;

                            borc.BanMenuNo = 0;
                            alacak.BanMenuNo = 0;

                            borc.BanMikroSpecial1 = "";
                            alacak.BanMikroSpecial1 = "";

                            borc.BanMikroSpecial2 = "";
                            alacak.BanMikroSpecial2 = "";

                            borc.BanMikroSpecial3 = "";
                            alacak.BanMikroSpecial3 = "";

                            borc.BanExternalProgramType = "";
                            alacak.BanExternalProgramType = "";

                            borc.BanExternalProgramId = 0;
                            alacak.BanExternalProgramId =0;

                            borc.BanHash = "";
                            alacak.BanHash = "";

                            await _context.CariHesapHareketleris.AddRangeAsync(borc, alacak);
							}
						


					}
					if (filtrelenmisKurumTahakkuk.Count > 0)
					{
						_memoryCache.Set("FiltrelenmisKurumTahakkukCacheKey", filtrelenmisKurumTahakkuk, TimeSpan.FromMinutes(1));
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {toplamVeri} adettir. Aktarılan toplam veri {toplamKayıtlar} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
	[HttpPost]
	public async Task<ActionResult> GetKOT003(A09Dto a09Dto)
	{
		string apiUrl = $"http://betik.bizimvezne.com/resmi_muhasebe/A05_Odemeler.php?kod=SPCRRnEeutJUceZkIYgEbCN4NGYC5g83&tip={1}&baslangic_tarihi={a09Dto.StartDate:yyyy-MM-dd}&bitis_tarihi={a09Dto.EndDate:yyyy-MM-dd}";
		var response = await _httpClient.GetAsync(apiUrl);
		if (response.IsSuccessStatusCode)
		{
			var jsonResponse = await response.Content.ReadAsStringAsync();
			var jsonData = JsonConvert.DeserializeObject<A05Response>(jsonResponse);
			if (jsonData.KurumTahakkuk is not null)
			{
				DateTime tarihim = a09Dto.StartDate;
				string SorgulananTarihKisa = tarihim.ToString("yyMMdd");
				string SorgulananTarihKisaYilUzun = tarihim.ToString("yyyyMMdd");
				int evrakSiraNo;
				int sonCariislemKodu;
				var sonCariIslem = await _context.CariHesapHareketleris
				.OrderByDescending(x => x.ChaSpecRecNo)
				.Take(1)
					.FirstOrDefaultAsync();
				var kaydınEvrakTipi = "KOT003";
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
				int toplamKayıtlar = 0;
				int toplamVeri = 0;
				if (jsonData.Tahakkuk.Count > 0)
				{
					var filtrelenmisKurumTahakkuk = new List<Tahakkuk>();
					foreach (var tahakkuk in jsonData.Tahakkuk)
					{
						int evrakKaydınınSatirNumarasi = -1;

						double toplamTutar = 0;
						int toplamAdet = 0;
						foreach (var odenenKurumlar in tahakkuk.OdenenKurumlar)
						{
							toplamTutar += odenenKurumlar.FaturaFiyat;
							toplamAdet += odenenKurumlar.Adet;
						}

						toplamVeri += 1;

						string BelgeNoString1 = SorgulananTarihKisa + tahakkuk.MuhasebeKodu.Substring(tahakkuk.MuhasebeKodu.Length - 4) + "K3" + (evrakKaydınınSatirNumarasi + 1).ToString();

						if (mikrodaVarolanBelgeNumaraları != null && !mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1) && !mikrodaVarolanBelgeNumaraları.Contains(BelgeNoString1))
						{
							filtrelenmisKurumTahakkuk.Add(tahakkuk);
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKayıtlar += 1;
							CariHesapHareketleri borc = new CariHesapHareketleri();

							borc.ChaSpecRecNo = sonCariislemKodu;
							borc.ChaSatirNo = evrakKaydınınSatirNumarasi;
							borc.ChaBelgeNo = BelgeNoString1;
							borc.ChaIptal = false;
							borc.ChaFileid = 51;
							borc.ChaHidden = false;
							borc.ChaKilitli = false;
							borc.ChaDegisti = false;
							borc.ChaCheckSum = 0;
							borc.ChaCreateUser = 5;
							borc.ChaCreateDate = DateTime.Now;
							borc.ChaLastupUser = 5;
							borc.ChaLastupDate = DateTime.Now;
							borc.ChaSpecial1 = "";
							borc.ChaSpecial2 = "";
							borc.ChaSpecial3 = "";
							borc.ChaFirmano = 0;
							borc.ChaSubeno = 0;
							borc.ChaEvrakTip = 57;
							borc.ChaEvraknoSeri = "KOT003";
							borc.ChaEvraknoSira = evrakSiraNo;
							borc.ChaTarihi = a09Dto.StartDate;
							borc.ChaTip = 0;
							borc.ChaCinsi = 5;
							borc.ChaNormalIade = 0;
							borc.ChaTpoz = 0;
							borc.ChaTicaretTuru = 0;
							borc.ChaBelgeTarih = a09Dto.StartDate;
							borc.ChaAciklama = a09Dto.StartDate + "ÖdFatBed" + (evrakKaydınınSatirNumarasi + 1);
							borc.ChaSaticiKodu = "";
							borc.ChaEximkodu = "";
							borc.ChaProjekodu = "";
							borc.ChaYatTesKodu = "";
							borc.ChaCariCins = 0;
							borc.ChaKod = tahakkuk.MuhasebeKodu;
							borc.ChaCiroCariKodu = "";
							borc.ChaDCins = 0;
							borc.ChaDKur = 1;
							borc.ChaAltdKur = 1;
							borc.ChaGrupno = 0;
							borc.ChaSrmrkkodu = "GLH";
							borc.ChaKasaHizmet = 2;
							borc.ChaKasaHizkod = "";
							borc.ChaKarsidcinsi = 0;
							borc.ChaKarsidKur = 1;
							borc.ChaKarsidgrupno = 1;
							borc.ChaSrmrkkodu = "";
							borc.ChaMiktari = 0;
							borc.ChaMeblag = toplamTutar / 100;
							borc.ChaAratoplam = 0;
							borc.ChaVade = int.Parse(SorgulananTarihKisaYilUzun);
							borc.ChaVadeFarkiYuz = 0;
							borc.ChaFtIskonto1 = 0;
							borc.ChaFtIskonto2 = 0;
							borc.ChaFtIskonto3 = 0;
							borc.ChaFtIskonto4 = 0;
							borc.ChaFtIskonto5 = 0;
							borc.ChaFtIskonto6 = 0;
							borc.ChaFtMasraf1 = 0;
							borc.ChaFtMasraf2 = 0;
							borc.ChaFtMasraf3 = 0;
							borc.ChaFtMasraf4 = 0;
							borc.ChaIskMas1 = 0;
							borc.ChaIskMas2 = 0;
							borc.ChaIskMas3 = 0;
							borc.ChaIskMas4 = 0;
							borc.ChaIskMas5 = 0;
							borc.ChaIskMas6 = 0;
							borc.ChaIskMas7 = 0;
							borc.ChaIskMas8 = 0;
							borc.ChaIskMas9 = 0;
							borc.ChaIskMas10 = 0;
							borc.ChaSatIskmas1 = false;
							borc.ChaSatIskmas2 = false;
							borc.ChaSatIskmas3 = false;
							borc.ChaSatIskmas4 = false;
							borc.ChaSatIskmas5 = false;
							borc.ChaSatIskmas6 = false;
							borc.ChaSatIskmas7 = false;
							borc.ChaSatIskmas8 = false;
							borc.ChaSatIskmas9 = false;
							borc.ChaSatIskmas10 = false;
							borc.ChaYuvarlama = 0;
							borc.ChaStFonPntr = 0;
							borc.ChaStopaj = 0;
							borc.ChaSavsandesfonu = 0;
							borc.ChaAvansmakDamgapul = 0;
							borc.ChaVergipntr = 0;
							borc.ChaVergi1 = 0;
							borc.ChaVergi2 = 0;
							borc.ChaVergi3 = 0;
							borc.ChaVergi4 = 0;
							borc.ChaVergi5 = 0;
							borc.ChaVergi6 = 0;
							borc.ChaVergi7 = 0;
							borc.ChaVergi8 = 0;
							borc.ChaVergi9 = 0;
							borc.ChaVergi10 = 0;
							borc.ChaOivergisizFl = false;
							borc.ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00");
							borc.ChaFisSirano = 0;
							borc.ChaTrefno = "";
							borc.ChaSntckPoz = 0;
							borc.ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00");
							borc.ChaIstisnakodu = 0;
							borc.ChaPosHareketi = 0;
							borc.ChaMeblagAltDovizIcinGecersizFl = 0;
							borc.ChaMeblagAnaDovizIcinGecersizFl = 0;
							borc.ChaMeblagOrjDovizIcinGecersizFl = 0;
							borc.ChaDbcno = 0;
							borc.ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00");
							borc.ChaVardiyaNo = 0;
							borc.ChaVardiyaEvrakTi = 0;
							borc.ChaEbelgeTuru = 0;
							borc.ChaTevkifatToplam = 0;
							borc.ChaIlaveEdilecekKdv1 = 0;
							borc.ChaIlaveEdilecekKdv2 = 0;
							borc.ChaIlaveEdilecekKdv3 = 0;
							borc.ChaIlaveEdilecekKdv4 = 0;
							borc.ChaIlaveEdilecekKdv5 = 0;
							borc.ChaIlaveEdilecekKdv6 = 0;
							borc.ChaIlaveEdilecekKdv7 = 0;
							borc.ChaIlaveEdilecekKdv8 = 0;
							borc.ChaIlaveEdilecekKdv9 = 0;
							borc.ChaIlaveEdilecekKdv10 = 0;
							borc.ChaEIslemTuru = 0;
							borc.ChaFaturaBelgeTuru = 0;
							borc.ChaDigerBelgeAdi = "";
                            borc.BanMainProgramNo = 0;
                            borc.BanVersionNo = 0;
                            borc.BanMenuNo = 0;
                            borc.BanMikroSpecial1 = "";
                            borc.BanMikroSpecial2 = "";
                            borc.BanMikroSpecial3 = "";
                            borc.BanExternalProgramType = "";
                            borc.BanExternalProgramId = 0;
                            borc.BanHash = "";

                            await _context.CariHesapHareketleris.AddAsync(borc);
						}
						foreach (var odenenKurum in tahakkuk.OdenenKurumlar)
						{
							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKayıtlar += 1;
							CariHesapHareketleri alacak = new CariHesapHareketleri();

							alacak.ChaSpecRecNo = sonCariislemKodu;
							alacak.ChaSatirNo = evrakKaydınınSatirNumarasi;
							alacak.ChaBelgeNo = BelgeNoString1;
							alacak.ChaIptal = false;
							alacak.ChaFileid = 51;
							alacak.ChaHidden = false;
							alacak.ChaKilitli = true;
							alacak.ChaDegisti = false;
							alacak.ChaCheckSum = 0;
							alacak.ChaCreateUser = 5;
							alacak.ChaCreateDate = DateTime.Now;
							alacak.ChaLastupUser = 5;
							alacak.ChaLastupDate = DateTime.Now;
							alacak.ChaSpecial1 = "";
							alacak.ChaSpecial2 = "";
							alacak.ChaSpecial3 = "";
							alacak.ChaFirmano = 0;
							alacak.ChaSubeno = 0;
							alacak.ChaEvrakTip = 57;
							alacak.ChaEvraknoSeri = "KOT003";
							alacak.ChaEvraknoSira = evrakSiraNo;
							alacak.ChaTarihi = a09Dto.StartDate;
							alacak.ChaTip = 0;
							alacak.ChaCinsi = 5;
							alacak.ChaNormalIade = 0;
							alacak.ChaTpoz = 0;
							alacak.ChaTicaretTuru = 0;
							alacak.ChaBelgeTarih = a09Dto.StartDate;
							alacak.ChaAciklama = a09Dto.StartDate + "ÖdFatBed" + (evrakKaydınınSatirNumarasi + 1);
							alacak.ChaSaticiKodu = "";
							alacak.ChaEximkodu = "";
							alacak.ChaProjekodu = "";
							alacak.ChaYatTesKodu = "";
							alacak.ChaCariCins = 0;
							alacak.ChaKod = odenenKurum.KurumKodu;
							alacak.ChaCiroCariKodu = "";
							alacak.ChaDCins = 0;
							alacak.ChaDKur = 1;
							alacak.ChaAltdKur = 1;
							alacak.ChaGrupno = 0;
							alacak.ChaSrmrkkodu = "KRM";
							alacak.ChaKasaHizmet = 2;
							alacak.ChaKasaHizkod = "";
							alacak.ChaKarsidcinsi = 0;
							alacak.ChaKarsidKur = 1;
							alacak.ChaKarsidgrupno = 1;
							alacak.ChaSrmrkkodu = "";
							alacak.ChaMiktari = 0;
							alacak.ChaMeblag = odenenKurum.FaturaFiyat / 100;
							alacak.ChaAratoplam = 0;
							alacak.ChaVade = int.Parse(SorgulananTarihKisaYilUzun);
							alacak.ChaVadeFarkiYuz = 0;
							alacak.ChaFtIskonto1 = 0;
							alacak.ChaFtIskonto2 = 0;
							alacak.ChaFtIskonto3 = 0;
							alacak.ChaFtIskonto4 = 0;
							alacak.ChaFtIskonto5 = 0;
							alacak.ChaFtIskonto6 = 0;
							alacak.ChaFtMasraf1 = 0;
							alacak.ChaFtMasraf2 = 0;
							alacak.ChaFtMasraf3 = 0;
							alacak.ChaFtMasraf4 = 0;
							alacak.ChaIskMas1 = 0;
							alacak.ChaIskMas2 = 0;
							alacak.ChaIskMas3 = 0;
							alacak.ChaIskMas4 = 0;
							alacak.ChaIskMas5 = 0;
							alacak.ChaIskMas6 = 0;
							alacak.ChaIskMas7 = 0;
							alacak.ChaIskMas8 = 0;
							alacak.ChaIskMas9 = 0;
							alacak.ChaIskMas10 = 0;
							alacak.ChaSatIskmas1 = false;
							alacak.ChaSatIskmas2 = false;
							alacak.ChaSatIskmas3 = false;
							alacak.ChaSatIskmas4 = false;
							alacak.ChaSatIskmas5 = false;
							alacak.ChaSatIskmas6 = false;
							alacak.ChaSatIskmas7 = false;
							alacak.ChaSatIskmas8 = false;
							alacak.ChaSatIskmas9 = false;
							alacak.ChaSatIskmas10 = false;
							alacak.ChaYuvarlama = 0;
							alacak.ChaStFonPntr = 0;
							alacak.ChaStopaj = 0;
							alacak.ChaSavsandesfonu = 0;
							alacak.ChaAvansmakDamgapul = 0;
							alacak.ChaVergipntr = 0;
							alacak.ChaVergi1 = 0;
							alacak.ChaVergi2 = 0;
							alacak.ChaVergi3 = 0;
							alacak.ChaVergi4 = 0;
							alacak.ChaVergi5 = 0;
							alacak.ChaVergi6 = 0;
							alacak.ChaVergi7 = 0;
							alacak.ChaVergi8 = 0;
							alacak.ChaVergi9 = 0;
							alacak.ChaVergi10 = 0;
							alacak.ChaOivergisizFl = false;
							alacak.ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00");
							alacak.ChaFisSirano = 0;
							alacak.ChaTrefno = "";
							alacak.ChaSntckPoz = 0;
							alacak.ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00");
							alacak.ChaIstisnakodu = 0;
							alacak.ChaPosHareketi = 0;
							alacak.ChaMeblagAltDovizIcinGecersizFl = 0;
							alacak.ChaMeblagAnaDovizIcinGecersizFl = 0;
							alacak.ChaMeblagOrjDovizIcinGecersizFl = 0;
							alacak.ChaDbcno = 0;
							alacak.ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00");
							alacak.ChaVardiyaNo = 0;
							alacak.ChaVardiyaEvrakTi = 0;
							alacak.ChaEbelgeTuru = 0;
							alacak.ChaTevkifatToplam = 0;
							alacak.ChaIlaveEdilecekKdv1 = 0;
							alacak.ChaIlaveEdilecekKdv2 = 0;
							alacak.ChaIlaveEdilecekKdv3 = 0;
							alacak.ChaIlaveEdilecekKdv4 = 0;
							alacak.ChaIlaveEdilecekKdv5 = 0;
							alacak.ChaIlaveEdilecekKdv6 = 0;
							alacak.ChaIlaveEdilecekKdv7 = 0;
							alacak.ChaIlaveEdilecekKdv8 = 0;
							alacak.ChaIlaveEdilecekKdv9 = 0;
							alacak.ChaIlaveEdilecekKdv10 = 0;
							alacak.ChaEIslemTuru = 0;
							alacak.ChaFaturaBelgeTuru = 0;
							alacak.ChaDigerBelgeAdi = "";

							await _context.CariHesapHareketleris.AddAsync(alacak);
						}
						foreach (var kurumTahakkuk in jsonData.KurumTahakkuk)
						{
							 BelgeNoString1 = SorgulananTarihKisa + kurumTahakkuk.KurumKodu.Substring(kurumTahakkuk.KurumKodu.Length - 4) + "KGT" + kurumTahakkuk.BankaKodu.Substring(3).Replace(".", "");

							sonCariislemKodu += 1;
							evrakSiraNo += 1;
							toplamKayıtlar += 1;
							CariHesapHareketleri alacak = new CariHesapHareketleri();

							alacak.ChaSpecRecNo = sonCariislemKodu;
							alacak.ChaSatirNo = evrakKaydınınSatirNumarasi;
							alacak.ChaBelgeNo = BelgeNoString1;
							alacak.ChaIptal = false;
							alacak.ChaFileid = 51;
							alacak.ChaHidden = false;
							alacak.ChaKilitli = true;
							alacak.ChaDegisti = false;
							alacak.ChaCheckSum = 0;
							alacak.ChaCreateUser = 5;
							alacak.ChaCreateDate = DateTime.Now;
							alacak.ChaLastupUser = 5;
							alacak.ChaLastupDate = DateTime.Now;
							alacak.ChaSpecial1 = "";
							alacak.ChaSpecial2 = "";
							alacak.ChaSpecial3 = "";
							alacak.ChaFirmano = 0;
							alacak.ChaSubeno = 0;
							alacak.ChaEvrakTip = 57;
							alacak.ChaEvraknoSeri = "KGT001";
							alacak.ChaEvraknoSira = evrakSiraNo;
							alacak.ChaTarihi = a09Dto.StartDate;
							alacak.ChaTip = 0;
							alacak.ChaCinsi = 5;
							alacak.ChaNormalIade = 0;
							alacak.ChaTpoz = 0;
							alacak.ChaTicaretTuru = 0;
							alacak.ChaBelgeTarih = a09Dto.StartDate;
							alacak.ChaAciklama = a09Dto.StartDate + "KrmdanBankaya" ;
							alacak.ChaSaticiKodu = "";
							alacak.ChaEximkodu = "";
							alacak.ChaProjekodu = "";
							alacak.ChaYatTesKodu = "";
							alacak.ChaCariCins = 0;
							alacak.ChaKod = kurumTahakkuk.KurumKodu;
							alacak.ChaCiroCariKodu = "";
							alacak.ChaDCins = 0;
							alacak.ChaDKur = 1;
							alacak.ChaAltdKur = 1;
							alacak.ChaGrupno = 0;
							alacak.ChaSrmrkkodu = "KRM";
							alacak.ChaKasaHizmet = 2;
							alacak.ChaKasaHizkod = kurumTahakkuk.BankaKodu;
							alacak.ChaKarsidcinsi = 0;
							alacak.ChaKarsidKur = 1;
							alacak.ChaKarsidgrupno = 1;
							alacak.ChaSrmrkkodu = "";
							alacak.ChaMiktari = 0;
							alacak.ChaMeblag = kurumTahakkuk.FaturaFiyat / 100;
							alacak.ChaAratoplam = kurumTahakkuk.FaturaFiyat / 100;
							alacak.ChaVade = int.Parse(SorgulananTarihKisaYilUzun);
							alacak.ChaVadeFarkiYuz = 0;
							alacak.ChaFtIskonto1 = 0;
							alacak.ChaFtIskonto2 = 0;
							alacak.ChaFtIskonto3 = 0;
							alacak.ChaFtIskonto4 = 0;
							alacak.ChaFtIskonto5 = 0;
							alacak.ChaFtIskonto6 = 0;
							alacak.ChaFtMasraf1 = 0;
							alacak.ChaFtMasraf2 = 0;
							alacak.ChaFtMasraf3 = 0;
							alacak.ChaFtMasraf4 = 0;
							alacak.ChaIskMas1 = 0;
							alacak.ChaIskMas2 = 0;
							alacak.ChaIskMas3 = 0;
							alacak.ChaIskMas4 = 0;
							alacak.ChaIskMas5 = 0;
							alacak.ChaIskMas6 = 0;
							alacak.ChaIskMas7 = 0;
							alacak.ChaIskMas8 = 0;
							alacak.ChaIskMas9 = 0;
							alacak.ChaIskMas10 = 0;
							alacak.ChaSatIskmas1 = false;
							alacak.ChaSatIskmas2 = false;
							alacak.ChaSatIskmas3 = false;
							alacak.ChaSatIskmas4 = false;
							alacak.ChaSatIskmas5 = false;
							alacak.ChaSatIskmas6 = false;
							alacak.ChaSatIskmas7 = false;
							alacak.ChaSatIskmas8 = false;
							alacak.ChaSatIskmas9 = false;
							alacak.ChaSatIskmas10 = false;
							alacak.ChaYuvarlama = 0;
							alacak.ChaStFonPntr = 0;
							alacak.ChaStopaj = 0;
							alacak.ChaSavsandesfonu = 0;
							alacak.ChaAvansmakDamgapul = 0;
							alacak.ChaVergipntr = 0;
							alacak.ChaVergi1 = 0;
							alacak.ChaVergi2 = 0;
							alacak.ChaVergi3 = 0;
							alacak.ChaVergi4 = 0;
							alacak.ChaVergi5 = 0;
							alacak.ChaVergi6 = 0;
							alacak.ChaVergi7 = 0;
							alacak.ChaVergi8 = 0;
							alacak.ChaVergi9 = 0;
							alacak.ChaVergi10 = 0;
							alacak.ChaOivergisizFl = false;
							alacak.ChaFisTarih = DateTime.Parse("1899-12-30 00:00:00");
							alacak.ChaFisSirano = 0;
							alacak.ChaTrefno = "";
							alacak.ChaSntckPoz = 0;
							alacak.ChaReftarihi = DateTime.Parse("1899-12-30 00:00:00");
							alacak.ChaIstisnakodu = 0;
							alacak.ChaPosHareketi = 0;
							alacak.ChaMeblagAltDovizIcinGecersizFl = 0;
							alacak.ChaMeblagAnaDovizIcinGecersizFl = 0;
							alacak.ChaMeblagOrjDovizIcinGecersizFl = 0;
							alacak.ChaDbcno = 0;
							alacak.ChaVardiyaTarihi = DateTime.Parse("1899-12-30 00:00:00");
							alacak.ChaVardiyaNo = 0;
							alacak.ChaVardiyaEvrakTi = 0;
							alacak.ChaEbelgeTuru = 0;
							alacak.ChaTevkifatToplam = 0;
							alacak.ChaIlaveEdilecekKdv1 = 0;
							alacak.ChaIlaveEdilecekKdv2 = 0;
							alacak.ChaIlaveEdilecekKdv3 = 0;
							alacak.ChaIlaveEdilecekKdv4 = 0;
							alacak.ChaIlaveEdilecekKdv5 = 0;
							alacak.ChaIlaveEdilecekKdv6 = 0;
							alacak.ChaIlaveEdilecekKdv7 = 0;
							alacak.ChaIlaveEdilecekKdv8 = 0;
							alacak.ChaIlaveEdilecekKdv9 = 0;
							alacak.ChaIlaveEdilecekKdv10 = 0;
							alacak.ChaEIslemTuru = 0;
							alacak.ChaFaturaBelgeTuru = 0;
							alacak.ChaDigerBelgeAdi = "";


                            alacak.BanMainProgramNo = 0;
                            alacak.BanVersionNo = 0;
                            alacak.BanMenuNo = 0;
                            alacak.BanMikroSpecial1 = "";
                            alacak.BanMikroSpecial2 = "";
                            alacak.BanMikroSpecial3 = "";
                            alacak.BanExternalProgramType = "";
                            alacak.BanExternalProgramId = 0;
                            alacak.BanHash = "";
                            await _context.CariHesapHareketleris.AddAsync(alacak);
						}



					}
					if (filtrelenmisKurumTahakkuk.Count > 0)
					{
						_memoryCache.Set("FiltrelenmisKurumTahakkukCacheKey", filtrelenmisKurumTahakkuk, TimeSpan.FromMinutes(1));
					}
				}

				await _context.SaveChangesAsync();
				return Ok(new A09ResponseDto { Message = $"Çekilen toplam veri {toplamVeri} adettir. Aktarılan toplam veri {toplamKayıtlar} adettir." });

			}
			var errorResponse = JsonConvert.DeserializeObject<A03ErrorResponse>(jsonResponse);
			return BadRequest(errorResponse);

		}
		return BadRequest();
	}
}
