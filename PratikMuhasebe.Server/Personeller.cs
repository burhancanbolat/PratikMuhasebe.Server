using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Personeller
{
    public Guid PerGuid { get; set; }

    public short PerDbcno { get; set; }

    public int? PerSpecRecno { get; set; }

    public bool? PerIptal { get; set; }

    public short? PerFileid { get; set; }

    public bool? PerHidden { get; set; }

    public bool? PerKilitli { get; set; }

    public bool? PerDegisti { get; set; }

    public int? PerChecksum { get; set; }

    public short? PerCreateUser { get; set; }

    public DateTime PerCreateDate { get; set; }

    public short? PerLastupUser { get; set; }

    public DateTime? PerLastupDate { get; set; }

    public string? PerSpecial1 { get; set; }

    public string? PerSpecial2 { get; set; }

    public string? PerSpecial3 { get; set; }

    public string? PerKod { get; set; }

    public string? PerAdi { get; set; }

    public string? PerSoyadi { get; set; }

    public string? PerOrjdildeadisoyadi { get; set; }

    public string? PerSicilNo { get; set; }

    public int? PerFirmaNo { get; set; }

    public int? PerSubeNo { get; set; }

    public string? PerCaripersKodu { get; set; }

    public byte? PerTip { get; set; }

    public string? PerDeptKod { get; set; }

    public byte? PerIsGrup { get; set; }

    public DateTime? PerGirisTar { get; set; }

    public DateTime? PerCikisTar { get; set; }

    public string? PerCikisNeden { get; set; }

    public string? PerMuhKod { get; set; }

    public byte? PerKimTahsil { get; set; }

    public string? PerKimMeslek { get; set; }

    public string? PerKimGorev { get; set; }

    public byte? PerKimSakatDerece { get; set; }

    public byte? PerKimGocmen { get; set; }

    public byte? PerKimGorevKod { get; set; }

    public byte? PerKimSgkKod { get; set; }

    public byte? PerKimCocuk { get; set; }

    public byte? PerKimOkuloncesi { get; set; }

    public byte? PerKimIlkokul { get; set; }

    public byte? PerKimOrtaokul { get; set; }

    public byte? PerKimLise { get; set; }

    public byte? PerKimYuksek { get; set; }

    public string? PerNufUyruk { get; set; }

    public byte? PerNufCinsiyet { get; set; }

    public byte? PerNufMedeniHal { get; set; }

    public string? PerNufDin { get; set; }

    public DateTime? PerNufDogumTarih { get; set; }

    public string? PerNufDogumYer { get; set; }

    public byte? PerNufKangrup { get; set; }

    public string? PerNufSeriNo { get; set; }

    public string? PerNufIl { get; set; }

    public string? PerNufIlce { get; set; }

    public string? PerNufMahalle { get; set; }

    public string? PerNufKoy { get; set; }

    public string? PerNufCiltno { get; set; }

    public string? PerNufSayfano { get; set; }

    public string? PerNufKutukno { get; set; }

    public string? PerNufVerNeden { get; set; }

    public string? PerNufVerYer { get; set; }

    public DateTime? PerNufVerTarih { get; set; }

    public string? PerNufCuzKayitno { get; set; }

    public byte? PerUcrTip { get; set; }

    public double? PerUcret { get; set; }

    public byte? PerBrutNet { get; set; }

    public byte? PerUcrSendDurum { get; set; }

    public byte? PerUcrSend { get; set; }

    public int? PerUcrPsskSube { get; set; }

    public string? PerUcrHesapno { get; set; }

    public byte? PerUcrSigYuzdeGr { get; set; }

    public byte? PerUcrBodeYapilma { get; set; }

    public string? PerUcrVdaire { get; set; }

    public string? PerUcrVkarneno { get; set; }

    public DateTime? PerUcrVkarneTarih { get; set; }

    public byte? PerUcrKonutfon { get; set; }

    public short? PerUcrOnceod { get; set; }

    public double? PerOzelavansorani { get; set; }

    public string? PerSgkDegerKodu { get; set; }

    public byte? PerYardYol { get; set; }

    public byte? PerYardYemek { get; set; }

    public byte? PerYardYakacak { get; set; }

    public byte? PerYardBayram { get; set; }

    public byte? PerYardCocuk { get; set; }

    public byte? PerYardAile { get; set; }

    public byte? PerYardOzelindirim { get; set; }

    public string? PerAdrCadde { get; set; }

    public string? PerAdrMahalle { get; set; }

    public string? PerAdrSokak { get; set; }

    public string? PerAdrSemt { get; set; }

    public string? PerAdrApartmanNo { get; set; }

    public string? PerAdrDaireNo { get; set; }

    public string? PerAdrPostaKod { get; set; }

    public string? PerAdrIlce { get; set; }

    public string? PerAdrIl { get; set; }

    public string? PerAdrUlke { get; set; }

    public string? PerAdrAdresKodu { get; set; }

    public string? PerTelUlkeKod { get; set; }

    public string? PerTelBolgeKod { get; set; }

    public string? PerTelNo1 { get; set; }

    public string? PerTelNo2 { get; set; }

    public string? PerTelFaxno { get; set; }

    public string? PerTelCepno { get; set; }

    public byte? PerDovizCinsi { get; set; }

    public string? PerMuhGrpkod { get; set; }

    public string? PerMuhOzelc1 { get; set; }

    public string? PerMuhOzelc2 { get; set; }

    public string? PerMuhOzelc3 { get; set; }

    public string? PerMuhOzelc4 { get; set; }

    public string? PerMuhOzelc5 { get; set; }

    public string? PerMuhOzelc6 { get; set; }

    public string? PerMuhOzelc7 { get; set; }

    public string? PerMuhOzelc8 { get; set; }

    public string? PerMuhOzelc9 { get; set; }

    public string? PerMuhOzelc10 { get; set; }

    public string? PerMuhOzelc11 { get; set; }

    public string? PerMuhOzelc12 { get; set; }

    public string? PerMuhOzelc13 { get; set; }

    public string? PerMuhOzelc14 { get; set; }

    public string? PerMuhOzelc15 { get; set; }

    public string? PerMuhOzelc16 { get; set; }

    public string? PerMuhOzelc17 { get; set; }

    public string? PerMuhOzelc18 { get; set; }

    public string? PerMuhOzelc19 { get; set; }

    public string? PerMuhOzelc20 { get; set; }

    public string? PerMuhOzelc21 { get; set; }

    public string? PerMuhOzelc22 { get; set; }

    public string? PerMuhOzelc23 { get; set; }

    public string? PerMuhOzelc24 { get; set; }

    public double? PerOldUcret { get; set; }

    public DateTime? PerOldTarih { get; set; }

    public byte? PerMaasIkramiye { get; set; }

    public string? PerOzelNot { get; set; }

    public bool? PerVkfKesOdFl { get; set; }

    public DateTime? PerKidemTarih { get; set; }

    public byte? PerIszlksig { get; set; }

    public byte? PerCalismatipi { get; set; }

    public bool? PerDil1 { get; set; }

    public bool? PerDil2 { get; set; }

    public bool? PerDil3 { get; set; }

    public bool? PerDil4 { get; set; }

    public bool? PerDil5 { get; set; }

    public bool? PerDil6 { get; set; }

    public bool? PerDil7 { get; set; }

    public bool? PerDil8 { get; set; }

    public bool? PerDil9 { get; set; }

    public bool? PerDil10 { get; set; }

    public bool? PerDil11 { get; set; }

    public bool? PerDil12 { get; set; }

    public byte? PerMevsim { get; set; }

    public byte? PerKapsam { get; set; }

    public bool? PerAsgariUcretli { get; set; }

    public byte? PerPerCariCins1 { get; set; }

    public byte? PerPerCariCins2 { get; set; }

    public byte? PerPerCariCins3 { get; set; }

    public byte? PerPerCariCins4 { get; set; }

    public byte? PerPerCariCins5 { get; set; }

    public byte? PerPerCariCins6 { get; set; }

    public byte? PerPerCariCins7 { get; set; }

    public byte? PerPerCariCins8 { get; set; }

    public byte? PerPerCariCins9 { get; set; }

    public byte? PerPerCariCins10 { get; set; }

    public byte? PerPerCariCins11 { get; set; }

    public byte? PerPerCariCins12 { get; set; }

    public byte? PerPerCariCins13 { get; set; }

    public byte? PerPerCariCins14 { get; set; }

    public byte? PerPerCariCins15 { get; set; }

    public byte? PerPerCariCins16 { get; set; }

    public byte? PerPerCariCins17 { get; set; }

    public byte? PerPerCariCins18 { get; set; }

    public byte? PerPerCariCins19 { get; set; }

    public byte? PerPerCariCins20 { get; set; }

    public byte? PerPerCariCins21 { get; set; }

    public byte? PerPerCariCins22 { get; set; }

    public byte? PerPerCariCins23 { get; set; }

    public byte? PerPerCariCins24 { get; set; }

    public byte? PerPerCariCinsGrupno1 { get; set; }

    public byte? PerPerCariCinsGrupno2 { get; set; }

    public byte? PerPerCariCinsGrupno3 { get; set; }

    public byte? PerPerCariCinsGrupno4 { get; set; }

    public byte? PerPerCariCinsGrupno5 { get; set; }

    public byte? PerPerCariCinsGrupno6 { get; set; }

    public byte? PerPerCariCinsGrupno7 { get; set; }

    public byte? PerPerCariCinsGrupno8 { get; set; }

    public byte? PerPerCariCinsGrupno9 { get; set; }

    public byte? PerPerCariCinsGrupno10 { get; set; }

    public byte? PerPerCariCinsGrupno11 { get; set; }

    public byte? PerPerCariCinsGrupno12 { get; set; }

    public byte? PerPerCariCinsGrupno13 { get; set; }

    public byte? PerPerCariCinsGrupno14 { get; set; }

    public byte? PerPerCariCinsGrupno15 { get; set; }

    public byte? PerPerCariCinsGrupno16 { get; set; }

    public byte? PerPerCariCinsGrupno17 { get; set; }

    public byte? PerPerCariCinsGrupno18 { get; set; }

    public byte? PerPerCariCinsGrupno19 { get; set; }

    public byte? PerPerCariCinsGrupno20 { get; set; }

    public byte? PerPerCariCinsGrupno21 { get; set; }

    public byte? PerPerCariCinsGrupno22 { get; set; }

    public byte? PerPerCariCinsGrupno23 { get; set; }

    public byte? PerPerCariCinsGrupno24 { get; set; }

    public string? PerTcKimlikNo { get; set; }

    public string? PerPersMailAddress { get; set; }

    public double? PerAylikCalismaSaati { get; set; }

    public string? PerMuhGrupKodu { get; set; }

    public string? PerBolgeKodu { get; set; }

    public string? PerOkulAd { get; set; }

    public string? PerIdariAmirKodu { get; set; }

    public string? PerTeknikAmirKodu { get; set; }

    public byte? PerCikisSebebiSecimli { get; set; }

    public string? PerIlksoyad { get; set; }

    public byte? PerTabiioldugukanun { get; set; }

    public bool? PerSemadaGostermeFl { get; set; }

    public string? PerEhlBelNo { get; set; }

    public DateTime? PerEhlBelTar { get; set; }

    public string? PerEhlSinif { get; set; }

    public DateTime? PerEhlVerTar { get; set; }

    public string? PerEhlVerIl { get; set; }

    public string? PerEhlVerIlce { get; set; }

    public string? PerEhlKartNo { get; set; }

    public string? PerPasaprotNo { get; set; }

    public DateTime? PerPasAlindigiTar { get; set; }

    public DateTime? PerPasGecTar { get; set; }

    public string? PerNufAskerCuzdan { get; set; }

    public DateTime? PerNufAskerBastarih { get; set; }

    public DateTime? PerNufAskerBittarih { get; set; }

    public byte? PerNufAskerDurum { get; set; }

    public string? PerIsyKimlikNo { get; set; }

    public string? PerCalismaizniNo { get; set; }

    public DateTime? PerCalismaizniAlindigiTar { get; set; }

    public DateTime? PerCalismaizniGecTar { get; set; }

    public double? PerBoyu { get; set; }

    public double? PerKilo { get; set; }

    public string? PerGomlekBed { get; set; }

    public string? PerPantBed { get; set; }

    public string? PerEtekBed { get; set; }

    public string? PerAyakNo { get; set; }

    public string? PerSapkaBed { get; set; }

    public string? PerOnlukBed { get; set; }

    public string? PerDigerBed1 { get; set; }

    public string? PerDigerBed2 { get; set; }

    public string? PerDigerBed3 { get; set; }

    public int? PerUserNo { get; set; }

    public string? PerUyeDernek { get; set; }

    public string? PerUyeDernekSicilNo { get; set; }

    public bool? PerSinyorityUygulamasiFl { get; set; }

    public bool? PerIzinparasiUygulamasiFl { get; set; }

    public string? PerYemekKartiId { get; set; }

    public byte? PerSrmmrkbaglantiTip { get; set; }

    public string? PerSrmmrkdaganahKodu { get; set; }

    public byte? PerMaasBanka { get; set; }

    public string? PerCalismaKodu { get; set; }

    public string? PerMeslekKodu { get; set; }

    public string? PerServisGuzergahi { get; set; }

    public string? PerVizeNo { get; set; }

    public DateTime? PerVizeAlindigiTarih { get; set; }

    public DateTime? PerVizeTarihi { get; set; }

    public byte? PerSskbelgeTuru { get; set; }

    public byte? PerAgineTabii { get; set; }

    public bool? PerOzur5763KontDahiliFl { get; set; }

    public string? PerYabanciUlke { get; set; }

    public byte? PerSigortalilikTuru { get; set; }

    public string? PerEskiSicilNo { get; set; }

    public byte? PerTabiioldugukanun2 { get; set; }

    public byte? PerMaaskiminhesabina { get; set; }

    public string? PerMaassistemikodu { get; set; }

    public string? PerIsGrupKodu { get; set; }

    public string? PerUnvanKodu { get; set; }

    public string? PerRaporlamaYapacagiPerKod { get; set; }

    public string? PerOkulKodu { get; set; }

    public string? PerOkulBolumKodu { get; set; }

    public string? PerBolumKodu { get; set; }

    public string? PerAltDeptKod { get; set; }

    public DateTime? PerKanunGecerlilikTarihi { get; set; }

    public byte? PerTabiioldugukanun3 { get; set; }

    public short? PerMezuniyetyili { get; set; }

    public string? PerProjeKodu { get; set; }

    public bool? PerHazineDestegineTabiFl { get; set; }

    public string? PerKepAdresi { get; set; }

    public bool? PerSigaraFl { get; set; }

    public bool? PerOtobesFl { get; set; }

    public byte? PerOtobesSigorta { get; set; }

    public double? PerOtobesOrani { get; set; }

    public string? PerOtobesHesapNo { get; set; }

    public string? PerOtobesGrupSozlesmeNo { get; set; }

    public byte? PerOtobesFonTercihi { get; set; }

    public DateTime? PerOtobesGiris { get; set; }

    public DateTime? PerOtobesAyrilis { get; set; }

    public string? PerSosyalLinkedin { get; set; }

    public string? PerSosyalWebadresi { get; set; }

    public string? PerSosyalYoutube { get; set; }

    public string? PerSosyalTwitter { get; set; }

    public string? PerSosyalFacebook { get; set; }

    public string? PerSosyalGoogle { get; set; }

    public string? PerSosyalPinterest { get; set; }

    public string? PerSosyalInstagram { get; set; }

    public string? PerSosyalSnapchat { get; set; }

    public double? PerVergidenMuhafOdenek1 { get; set; }

    public double? PerVergidenMuhafOdenek2 { get; set; }

    public double? PerSabitGelirversiOrani { get; set; }

    public byte? PerSporDali { get; set; }

    public bool? PerKisacalismaFl { get; set; }

    public DateTime? PerKisacalismaBaslangic { get; set; }

    public DateTime? PerKisacalismaBitis { get; set; }

    public double? PerKisacalismaHaftaliksaat { get; set; }

    public byte? Per7252OrtalamaGun { get; set; }

    public byte? PerEngellilikOrani { get; set; }

    public int? PerCikisNakilSskSube { get; set; }

    public byte? Per4691CalismaTipi { get; set; }

    public string? PerTeknokentproje { get; set; }

    public bool? PerAsgucrverindYapilmasinFl { get; set; }
}
