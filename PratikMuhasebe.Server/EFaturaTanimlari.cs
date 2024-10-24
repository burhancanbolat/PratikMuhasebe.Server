using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EFaturaTanimlari
{
    public Guid EfpGuid { get; set; }

    public short EfpDbcno { get; set; }

    public int? EfpSpecRecno { get; set; }

    public bool? EfpIptal { get; set; }

    public short? EfpFileid { get; set; }

    public bool? EfpHidden { get; set; }

    public bool? EfpKilitli { get; set; }

    public bool? EfpDegisti { get; set; }

    public int? EfpChecksum { get; set; }

    public short? EfpCreateUser { get; set; }

    public DateTime EfpCreateDate { get; set; }

    public short? EfpLastupUser { get; set; }

    public DateTime? EfpLastupDate { get; set; }

    public string? EfpSpecial1 { get; set; }

    public string? EfpSpecial2 { get; set; }

    public string? EfpSpecial3 { get; set; }

    public int? EfpFirmano { get; set; }

    public int? EfpSubeno { get; set; }

    public string? EfpKullanici { get; set; }

    public string? EfpSifre { get; set; }

    public byte? EfpEntegratorId { get; set; }

    public byte? EfpUcnoktaUrlSet { get; set; }

    public string? EfpFpAlias { get; set; }

    public string? EfpFpSifre { get; set; }

    public string? EfpPortalIzin { get; set; }

    public string? EfpPortalFaturaDosya { get; set; }

    public string? EfpPortalBirimKodu { get; set; }

    public int? EfpBaslangicDegeri { get; set; }

    public bool? EfpAciklamaAktarilsinFl { get; set; }

    public bool? EfpKabulIrsKarsilaFl { get; set; }

    public byte? EfpKabulSipKarsilaFl { get; set; }

    public bool? EfpCarievrakKilitleFl { get; set; }

    public bool? EfpBelgetarihiniEvraktarihiKaydetFl { get; set; }

    public bool? EfpIrsaliyeBelgenoGonderFl { get; set; }

    public bool? EfpSiparisBelgenoGonderFl { get; set; }

    public bool? EfpSatisFatStokbirlestirFl { get; set; }

    public bool? EfpAnaDovizleGonderFl { get; set; }

    public bool? EfpDetayliGosterFl { get; set; }

    public bool? EfpSatisFatHizmetbirlestirFl { get; set; }

    public bool? EfpSrmllkPrjeAyirdtmdnHizmBrlstr { get; set; }

    public bool? EfpSevkAdresiKullanFl { get; set; }

    public bool? EfpYetkiliEpostaKullanFl { get; set; }

    public bool? EfpAlisFatEfaturaKullanicisiFl { get; set; }

    public bool? EfpSrmllkPrjeAyirdtmdnStokBrlstr { get; set; }

    public string? EfpVarsayilanIstisnaAciklama { get; set; }

    public int? EfpCustomIrsaliyeFieldCount { get; set; }

    public double? EfpKdvfarkitutari { get; set; }

    public string? EfpEkMasraflarinKodu { get; set; }

    public bool? EfpFatBaglamaBelgeNoGuncelleFl { get; set; }

    public bool? EfpYenidenEntegreFisAciklamaBelgenoFl { get; set; }

    public byte? EfpNotHareketAciklamayaAktarilMasinFl { get; set; }

    public bool? EfpEvrakSiraGirilsinFl { get; set; }

    public bool? EfpVknsorguGlbVeritabanindanFl { get; set; }

    public bool? EfpDetayTakipsizStokBirlestirFl { get; set; }

    public bool? EfpGonderimdeLogOlusturFl { get; set; }

    public byte? EfpIrsaliyeSiparisEklentileri { get; set; }

    public string? EfpVarsayilanAraciKodu { get; set; }

    public string? EfpSgkCariKodu { get; set; }

    public bool? EfpSubeyeGoreFiltrele { get; set; }

    public byte? EfpNavlunMasrafTip { get; set; }

    public byte? EfpSigortaMasrafTip { get; set; }

    public byte? EfpKomisyonMasrafTip { get; set; }

    public byte? EfpDigerMasrafTip { get; set; }

    public string? EfpDigerAciklama { get; set; }

    public byte? EfpKullaniciYetkiKontroluNereden { get; set; }

    public bool? EfpIrsEvrakSiraGirilsinFl { get; set; }

    public byte? EfpDepoSevklerEIrsaliyemi { get; set; }

    public string? EfpBankaKodu { get; set; }

    public string? EfpBankaKodu2 { get; set; }

    public string? EfpBankaKodu3 { get; set; }

    public string? EfpBankaKodu4 { get; set; }

    public string? EfpBankaKodu5 { get; set; }

    public string? EfpFirmaEirsAlias { get; set; }

    public DateTime? EfpSonGonderimTarihi { get; set; }

    public DateTime? EfpArsivSonGonderimTarihi { get; set; }

    public bool? EfpStandartFaturalar { get; set; }

    public bool? EfpDisKasadanGelenFaturalar { get; set; }

    public bool? EfpHizliSatistanGelenFaturalar { get; set; }

    public bool? EfpShopsidedanGelenFaturalar { get; set; }

    public bool? EfpSonraMuhasebeSeriDahilEdilmesinFl { get; set; }

    public bool? EfpEarsivSmsGonderimiAktifFl { get; set; }

    public bool? EfpIrsyerinegecerYazilsinFl { get; set; }

    public bool? EfpIrsdahasonrakesilecekyazilsinFl { get; set; }

    public bool? EfpIrsSubeyeGoreFiltreleFl { get; set; }

    public byte? EfpPetKrediliSatislarEIrsaliyemi { get; set; }

    public byte? EfpIrsaliyeDetaylariZorunluFl { get; set; }

    public bool? EfpUrunKoduBarkodOlsunFl { get; set; }

    public byte? EfpKabulHalMasrafNereyeEklensin { get; set; }

    public byte? EfpIrsStokBirlestirFl { get; set; }

    public byte? EfpIrsSrmPrjAyrmdnStokBirlestirFl { get; set; }

    public byte? EfpIrsDetayTakibiYpmdnStokBirlestirFl { get; set; }

    public byte? EfpCikislarEIrsaliyemi { get; set; }

    public byte? EfpFasonCikislarEIrsaliyemi { get; set; }

    public byte? EfpKiralamaSevkCikislarEIrsaliyemi { get; set; }

    public byte? EfpMillilestirmeEIrsaliyemi { get; set; }

    public byte? EfpFireCikislarEIrsaliyemi { get; set; }

    public byte? EfpSarfCikislarEIrsaliyemi { get; set; }

    public byte? EfpSayimCikislarEIrsaliyemi { get; set; }

    public byte? EfpUretimeCikislarEIrsaliyemi { get; set; }

    public byte? EfpAntrepolarEIrsaliyemi { get; set; }

    public string? EfpEirsDepoSevklerSeriNoKriteri { get; set; }

    public string? EfpEirsCikislarSeriNoKriteri { get; set; }

    public string? EfpEirsFasonCikislarSeriNoKriteri { get; set; }

    public string? EfpEirsKiralamaSevkCikisSeriNoKriteri { get; set; }

    public string? EfpEirsMillilestirmeSeriNoKriteri { get; set; }

    public string? EfpEirsFireCikislarSeriNoKriteri { get; set; }

    public string? EfpEirsSarfCikislarSeriNoKriteri { get; set; }

    public string? EfpEirsSayimCikislarSeriNoKriteri { get; set; }

    public string? EfpEirsUretimeCikislarSeriNoKriteri { get; set; }

    public string? EfpEirsAntrepolarSeriNoKriteri { get; set; }

    public byte? EfpKismiKabuldeIadeIrsOlussun { get; set; }

    public string? EfpVknTckn { get; set; }

    public bool? EfpStandartDisiFaturalarDonussunFl { get; set; }

    public bool? EfpEirsGonderimdeEvrakkilitleFl { get; set; }

    public byte? EfpEbelgeGonderveBaglaTip { get; set; }

    public byte? EfpAtikHareketleriEIrsaliyemi { get; set; }

    public string? EfpEirsAtikHareketleriSeriNoKriteri { get; set; }

    public int? EfpIkifarklitarihpaketgondpaketSayisi { get; set; }

    public byte? EfpGonderilmemisIrsFaturaYapildiginda { get; set; }

    public bool? EfpEirsGonderimdeTutarFiyatGizleFl { get; set; }

    public byte? EfpGelenFaturadaOtoStokKartiAcilsin { get; set; }

    public bool? EfpKurFarkiAnaDovizleGonderFl { get; set; }

    public byte? EfpEfaturaDizaynYonlendirmeCevapTip { get; set; }

    public byte? EfpEarsivDizaynYonlendirmeCevapTip { get; set; }

    public byte? EfpEmustahDizaynYonlendirmeCevapTip { get; set; }

    public byte? EfpEsmmDizaynYonlendirmeCevapTip { get; set; }

    public byte? EfpEirsDizaynYonlendirmeCevapTip { get; set; }

    public bool? EfpEirsDetaylariBirEylulZorunluFl { get; set; }

    public byte? EfpEirsFireSarfSayimUretimdeSevkAdresi { get; set; }

    public byte? EfpEvraklardaEbelgeyeKonuAlanlarEksikse { get; set; }

    public byte? EfpKartlardaEbelgeyeKonuAlanlarEksikse { get; set; }
}
