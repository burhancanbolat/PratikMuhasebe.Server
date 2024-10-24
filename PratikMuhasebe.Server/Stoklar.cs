using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Stoklar
{
    public string StoKod { get; set; } = null!;

    public Guid StoGuid { get; set; }

    public short StoDbcno { get; set; }

    public int? StoSpecRecno { get; set; }

    public bool? StoIptal { get; set; }

    public short? StoFileid { get; set; }

    public bool? StoHidden { get; set; }

    public bool? StoKilitli { get; set; }

    public bool? StoDegisti { get; set; }

    public int? StoChecksum { get; set; }

    public short? StoCreateUser { get; set; }

    public DateTime StoCreateDate { get; set; }

    public short? StoLastupUser { get; set; }

    public DateTime? StoLastupDate { get; set; }

    public string? StoSpecial1 { get; set; }

    public string? StoSpecial2 { get; set; }

    public string? StoSpecial3 { get; set; }

    public string? StoIsim { get; set; }

    public string? StoKisaIsmi { get; set; }

    public string? StoYabanciIsim { get; set; }

    public string? StoSatCariKod { get; set; }

    public byte? StoCins { get; set; }

    public byte? StoDovizCinsi { get; set; }

    public byte? StoDetayTakip { get; set; }

    public string? StoBirim1Ad { get; set; }

    public double? StoBirim1Katsayi { get; set; }

    public double? StoBirim1Agirlik { get; set; }

    public double? StoBirim1En { get; set; }

    public double? StoBirim1Boy { get; set; }

    public double? StoBirim1Yukseklik { get; set; }

    public double? StoBirim1Dara { get; set; }

    public string? StoBirim2Ad { get; set; }

    public double? StoBirim2Katsayi { get; set; }

    public double? StoBirim2Agirlik { get; set; }

    public double? StoBirim2En { get; set; }

    public double? StoBirim2Boy { get; set; }

    public double? StoBirim2Yukseklik { get; set; }

    public double? StoBirim2Dara { get; set; }

    public string? StoBirim3Ad { get; set; }

    public double? StoBirim3Katsayi { get; set; }

    public double? StoBirim3Agirlik { get; set; }

    public double? StoBirim3En { get; set; }

    public double? StoBirim3Boy { get; set; }

    public double? StoBirim3Yukseklik { get; set; }

    public double? StoBirim3Dara { get; set; }

    public string? StoBirim4Ad { get; set; }

    public double? StoBirim4Katsayi { get; set; }

    public double? StoBirim4Agirlik { get; set; }

    public double? StoBirim4En { get; set; }

    public double? StoBirim4Boy { get; set; }

    public double? StoBirim4Yukseklik { get; set; }

    public double? StoBirim4Dara { get; set; }

    public string? StoMuhKod { get; set; }

    public string? StoMuhIadeKod { get; set; }

    public string? StoMuhSatMuhKod { get; set; }

    public string? StoMuhSatIadmuhkod { get; set; }

    public string? StoMuhSatIskKod { get; set; }

    public string? StoMuhAIiskmuhkod { get; set; }

    public string? StoMuhSatmalmuhkod { get; set; }

    public string? StoYurtdisiSatmuhk { get; set; }

    public string? StoIlavemasmuhkod { get; set; }

    public string? StoYatirimtesmuhkod { get; set; }

    public string? StoDepsatmuhkod { get; set; }

    public string? StoDepsatmalmuhkod { get; set; }

    public string? StoBagortsatmuhkod { get; set; }

    public string? StoBagortsatIadmuhkod { get; set; }

    public string? StoBagortsatIskmuhkod { get; set; }

    public string? StoSatfiyfarkmuhkod { get; set; }

    public string? StoYurtdisisatmalmuhkod { get; set; }

    public string? StoBagortsatmalmuhkod { get; set; }

    public string? StoSifirbedsatmalmuhkod { get; set; }

    public string? StoIhrackayitlisatismuhkod { get; set; }

    public string? StoIhrackayitlisatismaliyetimuhkod { get; set; }

    public double? StoKarorani { get; set; }

    public double? StoMinStok { get; set; }

    public double? StoSiparisStok { get; set; }

    public double? StoMaxStok { get; set; }

    public byte? StoVerSipBirim { get; set; }

    public byte? StoAlSipBirim { get; set; }

    public short? StoSiparisSure { get; set; }

    public byte? StoPerakendeVergi { get; set; }

    public byte? StoToptanVergi { get; set; }

    public string? StoYerKod { get; set; }

    public byte? StoElkEtkTipi { get; set; }

    public byte? StoRafEtiketli { get; set; }

    public byte? StoEtiketBas { get; set; }

    public byte? StoSatisDursun { get; set; }

    public byte? StoSiparisDursun { get; set; }

    public byte? StoMalkabulDursun { get; set; }

    public bool? StoMalkabulGun1 { get; set; }

    public bool? StoMalkabulGun2 { get; set; }

    public bool? StoMalkabulGun3 { get; set; }

    public bool? StoMalkabulGun4 { get; set; }

    public bool? StoMalkabulGun5 { get; set; }

    public bool? StoMalkabulGun6 { get; set; }

    public bool? StoMalkabulGun7 { get; set; }

    public bool? StoSiparisGun1 { get; set; }

    public bool? StoSiparisGun2 { get; set; }

    public bool? StoSiparisGun3 { get; set; }

    public bool? StoSiparisGun4 { get; set; }

    public bool? StoSiparisGun5 { get; set; }

    public bool? StoSiparisGun6 { get; set; }

    public bool? StoSiparisGun7 { get; set; }

    public bool? StoIskonYapilamaz { get; set; }

    public bool? StoTasfiyede { get; set; }

    public short? StoAltGrupNo { get; set; }

    public string? StoKategoriKodu { get; set; }

    public string? StoUrunSorkod { get; set; }

    public string? StoAltgrupKod { get; set; }

    public string? StoAnagrupKod { get; set; }

    public string? StoUreticiKodu { get; set; }

    public string? StoSektorKodu { get; set; }

    public string? StoReyonKodu { get; set; }

    public string? StoMuhgrupKodu { get; set; }

    public string? StoAmbalajKodu { get; set; }

    public string? StoMarkaKodu { get; set; }

    public string? StoBedenKodu { get; set; }

    public string? StoRenkKodu { get; set; }

    public string? StoModelKodu { get; set; }

    public string? StoSezonKodu { get; set; }

    public string? StoHammaddeKodu { get; set; }

    public string? StoPrimKodu { get; set; }

    public string? StoKalkonKodu { get; set; }

    public string? StoPaketKodu { get; set; }

    public string? StoPozisyonbayrakKodu { get; set; }

    public string? StoMkodArtik { get; set; }

    public bool? StoKasaTartiFl { get; set; }

    public bool? StoBedenliTakip { get; set; }

    public bool? StoRenkDetayli { get; set; }

    public bool? StoMiktarondalikliFl { get; set; }

    public bool? StoPasifFl { get; set; }

    public bool? StoEksiyedusebilirFl { get; set; }

    public string? StoGtipNo { get; set; }

    public double? StoPuan { get; set; }

    public string? StoKomisyonHzmkodu { get; set; }

    public double? StoKomisyonOrani { get; set; }

    public byte? StoOtvuygulama { get; set; }

    public double? StoOtvtutar { get; set; }

    public byte? StoOtvliste { get; set; }

    public byte? StoOtvbirimi { get; set; }

    public double? StoPrimOrani { get; set; }

    public short? StoGarantiSure { get; set; }

    public byte? StoGarantiSureTipi { get; set; }

    public double? StoIplikNeNo { get; set; }

    public double? StoStandartmaliyet { get; set; }

    public double? StoKanbanKasaMiktari { get; set; }

    public byte? StoOivuygulama { get; set; }

    public bool? StoZraporuStokuFl { get; set; }

    public double? StoMaxiskontoOrani { get; set; }

    public bool? StoDetayTakibindeDepoKontroluFl { get; set; }

    public string? StoTamamlayiciKodu { get; set; }

    public byte? StoOtoBarkodAcmaSekli { get; set; }

    public string? StoOtoBarkodKodYapisi { get; set; }

    public double? StoKasaIskontoOrani { get; set; }

    public double? StoKasaIskontoTutari { get; set; }

    public double? StoGelirpayi { get; set; }

    public double? StoOivtutar { get; set; }

    public byte? StoOivturu { get; set; }

    public string? StoGiderkodu { get; set; }

    public byte? StoOivvergipntr { get; set; }

    public byte? StoTevkifatTuru { get; set; }

    public bool? StoSktFl { get; set; }

    public short? StoTeraziSkt { get; set; }

    public short? StoRafOmru { get; set; }

    public bool? StoKasadaTaksitlenebilirFl { get; set; }

    public string? StoUfrsfarkKod { get; set; }

    public string? StoIadeUfrsfarkKod { get; set; }

    public string? StoYurticisatUfrsfarkKod { get; set; }

    public string? StoSatiadeUfrsfarkKod { get; set; }

    public string? StoSatiskUfrsfarkKod { get; set; }

    public string? StoAliskUfrsfarkKod { get; set; }

    public string? StoSatmalUfrsfarkKod { get; set; }

    public string? StoYurtdisisatUfrsfarkKod { get; set; }

    public string? StoIlavemasUfrsfarkKod { get; set; }

    public string? StoYatirimtesUfrsfarkKod { get; set; }

    public string? StoDepsatUfrsfarkKod { get; set; }

    public string? StoDepsatmalUfrsfarkKod { get; set; }

    public string? StoBagortsatUfrsfarkKod { get; set; }

    public string? StoBagortsatiadeUfrsfarkKod { get; set; }

    public string? StoBagortsatiskUfrsfarkKod { get; set; }

    public string? StoSatfiyfarkUfrsfarkKod { get; set; }

    public string? StoYurtdisisatmalUfrsfarkKod { get; set; }

    public string? StoBagortsatmalUfrsfarkKod { get; set; }

    public string? StoSifirbedsatmalUfrsfarkKod { get; set; }

    public string? StoUretimmaliyetUfrsfarkKod { get; set; }

    public string? StoUretimkapasiteUfrsfarkKod { get; set; }

    public string? StoDegerdusukluguUfrsKod { get; set; }

    public double? StoHalrusumyudesi { get; set; }

    public bool? StoWebeGonderilecekFl { get; set; }

    public short? StoMinStokBelirlemeGun { get; set; }

    public short? StoSipStokBelirlemeGun { get; set; }

    public short? StoMaxStokBelirlemeGun { get; set; }

    public bool? StoSevBelOprDegerlendimeFl { get; set; }

    public byte? StoOtvTevkifatTuru { get; set; }

    public byte? StoKayPlanDegerlendir { get; set; }

    public bool? StoCrmSistemineAktarFl { get; set; }

    public int StoPluNo { get; set; }

    public byte? StoYerliYabanci { get; set; }

    public string? StoMensei { get; set; }

    public bool? StoOtoPartiLotKodFl { get; set; }

    public string? StoEfatSinifKodu { get; set; }

    public string? StoEfatSinifListesi { get; set; }

    public string? StoEfatSinifVersiyonu { get; set; }

    public bool? StoUtssisteminegonderilsinFl { get; set; }

    public bool? StoPosetbeyannamekonusuFl { get; set; }

    public short? StoSttOncesiKaldirma { get; set; }

    public short? StoToplamRafomru { get; set; }

    public bool? StoFiyatKasadaBelirlenirFl { get; set; }

    public byte? StoFranchiseSiparisDursun { get; set; }

    public string? StoGekap { get; set; }

    public byte? StoGekapBirim { get; set; }

    public string? StoResimUrl { get; set; }

    public string? StoGekapDepozitoonaykodu { get; set; }

    public bool? StoCabukBozulabilenUrunFl { get; set; }

    public byte? StoSatinAlmaTalepBirim { get; set; }
}
