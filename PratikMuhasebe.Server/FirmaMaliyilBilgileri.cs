using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FirmaMaliyilBilgileri
{
    public Guid FmyGuid { get; set; }

    public short FmyDbcno { get; set; }

    public int? FmySpecRecno { get; set; }

    public bool? FmyIptal { get; set; }

    public short? FmyFileid { get; set; }

    public bool? FmyHidden { get; set; }

    public bool? FmyKilitli { get; set; }

    public bool? FmyDegisti { get; set; }

    public int? FmyChecksum { get; set; }

    public short? FmyCreateUser { get; set; }

    public DateTime FmyCreateDate { get; set; }

    public short? FmyLastupUser { get; set; }

    public DateTime? FmyLastupDate { get; set; }

    public string? FmySpecial1 { get; set; }

    public string? FmySpecial2 { get; set; }

    public string? FmySpecial3 { get; set; }

    public int? FmySirano { get; set; }

    public int? FmyMaliyil { get; set; }

    public DateTime? FmyYevmiyeTarih { get; set; }

    public double? FmyFaizOrani1 { get; set; }

    public double? FmyFaizOrani2 { get; set; }

    public double? FmyFaizOrani3 { get; set; }

    public double? FmyFaizOrani4 { get; set; }

    public double? FmyFaizOrani5 { get; set; }

    public double? FmyFaizOrani6 { get; set; }

    public double? FmyFaizOrani7 { get; set; }

    public double? FmyFaizOrani8 { get; set; }

    public double? FmyFaizOrani9 { get; set; }

    public double? FmyFaizOrani10 { get; set; }

    public double? FmyFaizOrani11 { get; set; }

    public double? FmyFaizOrani12 { get; set; }

    public DateTime? FmyEvrakIlkTarih { get; set; }

    public DateTime? FmyEvrakSonTarih { get; set; }

    public string? FmyFirmaMuhKodu { get; set; }

    public double? FmyFirmamuhucret { get; set; }

    public string? FmyKapaliBrutMeblagKodu { get; set; }

    public string? FmyAcikBrutMeblagKodu { get; set; }

    public string? FmyKdvKodu { get; set; }

    public string? FmyNetMeblagKodu { get; set; }

    public string? FmyStopajKodu { get; set; }

    public string? FmySsdfKodu { get; set; }

    public string? FmyIsletmeKodu { get; set; }

    public double? FmyStopajOrani { get; set; }

    public double? FmySsdfOrani { get; set; }

    public double? FmyKdvOrani { get; set; }

    public string? FmySatistevkifatmuhkodu { get; set; }

    public string? FmyAlistevkifatmuhkodu { get; set; }

    public string? FmyKaryuvarlamamuhkodu { get; set; }

    public string? FmyZararyuvarlamamuhkodu { get; set; }

    public string? FmyOtvmuhkodu { get; set; }

    public string? FmyIstisnaotvmuhkodu { get; set; }

    public string? FmyIadeotvmuhkodu { get; set; }

    public string? FmyDamgapulumuhkodu { get; set; }

    public string? FmyMustahsilborsamuhkodu { get; set; }

    public string? FmyMustahsilbagkurmuhkodu { get; set; }

    public string? FmyMustahsildigermuhkodu { get; set; }

    public string? FmySebzemeyvemsdfmuhkodu { get; set; }

    public string? FmySebzemeyvehamalmuhkodu { get; set; }

    public string? FmySebzemeyvestopajmuhkodu { get; set; }

    public string? FmySebzemeyvekomkdvmuhkodu { get; set; }

    public string? FmyHalkomisyonmuhkodu { get; set; }

    public string? FmyHalnavlunmuhkodu { get; set; }

    public string? FmyHalnavlunkdvmuhkodu { get; set; }

    public string? FmyHalsandikrehinmuhkodu { get; set; }

    public string? FmyHalsandikrehinkdvmuhkodu { get; set; }

    public string? FmyRusummuhkodu { get; set; }

    public string? FmyYansitmaHesaplari1 { get; set; }

    public string? FmyYansitmaHesaplari2 { get; set; }

    public string? FmyYansitmaHesaplari3 { get; set; }

    public string? FmyYansitmaHesaplari4 { get; set; }

    public string? FmyYansitmaHesaplari5 { get; set; }

    public string? FmyYansitmaHesaplari6 { get; set; }

    public string? FmyYansitmaHesaplari7 { get; set; }

    public string? FmyYansitmaHesaplari8 { get; set; }

    public string? FmyYansitmaHesaplari9 { get; set; }

    public string? FmyYansitmaHesaplari10 { get; set; }

    public string? FmyYansitmaHesaplari11 { get; set; }

    public string? FmyYansitmaHesaplari12 { get; set; }

    public string? FmyYansitmaHesaplari13 { get; set; }

    public string? FmyYansitmaHesaplari14 { get; set; }

    public string? FmyOdemeEmriMasraf1Kodu { get; set; }

    public string? FmyOdemeEmriMasraf2Kodu { get; set; }

    public string? FmyAlisIrsMalBedMuhkodu { get; set; }

    public string? FmySatisIrsMalBedMuhkodu { get; set; }

    public string? FmySebzemeyvehamalkdvmuhkodu { get; set; }

    public string? FmyEbeyankullanici { get; set; }

    public string? FmyEbeyanparola { get; set; }

    public string? FmyEbeyansifre { get; set; }

    public string? FmyEVdkullanici { get; set; }

    public string? FmyEVdparola { get; set; }

    public string? FmyEVdsifre { get; set; }

    public string? FmyOivmuhkodu { get; set; }

    public string? FmyIstisnaoivmuhkodu { get; set; }

    public string? FmyIadeoivmuhkodu { get; set; }

    public string? FmyAlisOivmuhkodu { get; set; }

    public string? FmyAlisIadeOivmuhkodu { get; set; }

    public string? FmyAlisOtvmuhkodu { get; set; }

    public string? FmyAlisIadeOtvmuhkodu { get; set; }

    public string? FmyTevkifatKodu { get; set; }

    public string? FmyTevkifatliFirmaMuhKodu { get; set; }

    public byte? FmyTevkifatUygulama { get; set; }

    public string? FmyMustahsilborsamuhkoduS { get; set; }

    public string? FmyMustahsilbagkurmuhkoduS { get; set; }

    public string? FmyMustahsildigermuhkoduS { get; set; }

    public string? FmySebzemeyvemsdfmuhkoduS { get; set; }

    public string? FmySebzemeyvehamalmuhkoduS { get; set; }

    public string? FmySebzemeyvehamalkdvmuhkoduS { get; set; }

    public string? FmySebzemeyvestopajmuhkoduS { get; set; }

    public string? FmyHalkomisyonmuhkoduS { get; set; }

    public string? FmySebzemeyvekomkdvmuhkoduS { get; set; }

    public string? FmyHalnavlunmuhkoduS { get; set; }

    public string? FmyHalnavlunkdvmuhkoduS { get; set; }

    public string? FmyHalsandikrehinmuhkoduS { get; set; }

    public string? FmyHalsandikrehinkdvmuhkoduS { get; set; }

    public string? FmyRusummuhkoduS { get; set; }

    public string? FmyKazanilmisfaizgelirimuhkodu { get; set; }

    public string? FmyGerceklesmisfaizgiderimuhkodu { get; set; }

    public string? FmyAlacaksenedireeskontmuhkodu { get; set; }

    public string? FmyBorcsenedireeskontmuhkodu { get; set; }

    public string? FmyKapasitemaliyetbirikimmuhkodu { get; set; }

    public string? FmyStokdegerdusuklugumuhkodu { get; set; }

    public string? FmyStokdegerdusuklugugiderimuhkodu { get; set; }

    public string? FmyIzingiderimuhkodu { get; set; }

    public string? FmyIzinkarsiligimuhkodu { get; set; }

    public string? FmyTazminatgiderimuhkodu { get; set; }

    public string? FmyTazminatkarsiligimuhkodu { get; set; }

    public string? FmyRusumkdvmuhkodu { get; set; }

    public string? FmyRusumkdvmuhkoduS { get; set; }

    public string? FmySebzemeyvedigermuhkoduS { get; set; }

    public string? FmySebzemeyvedigerkdvmuhkoduS { get; set; }

    public string? FmyTecilotvmuhkodu { get; set; }

    public string? FmyArgeGiderHesapkodu { get; set; }

    public string? FmyPazarlamaGiderHesapkodu { get; set; }

    public string? FmyYonetimGiderHesapkodu { get; set; }

    public string? FmyFinansmanGiderHesapkodu { get; set; }

    public string? FmyAlisotvtevkifatmuhkodu { get; set; }

    public string? FmySatisotvtevkifatmuhkodu { get; set; }

    public string? FmyOdemeEmriKarsiliksizMasrafKodu { get; set; }

    public string? FmyBeyannameDosyaYolu { get; set; }

    public string? FmyCariKodu { get; set; }

    public byte? FmyKapalicaricinsi { get; set; }

    public string? FmyKapalicariKodu { get; set; }

    public string? FmyMasrafKodu { get; set; }

    public byte? FmyStopajfonpntr { get; set; }

    public double? FmyBinekotoMaxVergiTutar { get; set; }

    public double? FmyBinekotoMaxSifirTutar { get; set; }

    public double? FmyBinekotoMaxIkincielTutar { get; set; }

    public double? FmyBinekotoMaxKiraTutar { get; set; }

    public double? FmyBinekotoMaxGiderOrani { get; set; }

    public string? FmyEbeyankullanici2 { get; set; }

    public string? FmyEbeyanparola2 { get; set; }

    public string? FmyEbeyansifre2 { get; set; }

    public string? FmyCariMuhkod1 { get; set; }

    public string? FmyCariMuhkod2 { get; set; }

    public string? FmyCariMuhkod3 { get; set; }

    public string? FmyCariTeminatMekAlacakMuhKodu1 { get; set; }

    public string? FmyCariTeminatMekAlacakMuhKodu2 { get; set; }

    public string? FmyCariTeminatMekAlacakMuhKodu3 { get; set; }

    public string? FmyCariTeminatMekBorcMuhKodu1 { get; set; }

    public string? FmyCariTeminatMekBorcMuhKodu2 { get; set; }

    public string? FmyCariTeminatMekBorcMuhKodu3 { get; set; }

    public string? FmyCariVerilenDepozitoTeminatMuhKodu1 { get; set; }

    public string? FmyCariVerilenDepozitoTeminatMuhKodu2 { get; set; }

    public string? FmyCariVerilenDepozitoTeminatMuhKodu3 { get; set; }

    public string? FmyCariAlinanDepozitoTeminatMuhKodu1 { get; set; }

    public string? FmyCariAlinanDepozitoTeminatMuhKodu2 { get; set; }

    public string? FmyCariAlinanDepozitoTeminatMuhKodu3 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl1 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl2 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl3 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl4 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl5 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl6 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl7 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl8 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl9 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl10 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl11 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl12 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl13 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl14 { get; set; }

    public bool? FmyCariAltHesapAcilsinFl15 { get; set; }

    public string? FmyStoMuhKod { get; set; }

    public string? FmyStoMuhIadeKod { get; set; }

    public string? FmyStoSatMuhKod { get; set; }

    public string? FmyStoMuhSatmalmuhkod { get; set; }

    public string? FmyStoYurtdisiSatmuhk { get; set; }

    public string? FmyStoYurtdisisatmalmuhkod { get; set; }

    public string? FmyStoMuhSatIadmuhkod { get; set; }

    public string? FmyStoMuhSatIskKod { get; set; }

    public string? FmyStoMuhAIiskkod { get; set; }

    public string? FmyStoIlavemasmuhkod { get; set; }

    public string? FmyStoYatirimtesmuhkod { get; set; }

    public string? FmyStoDepsatmuhkod { get; set; }

    public string? FmyStoDepsatmalmuhkod { get; set; }

    public string? FmyStoBagortsatmuhkod { get; set; }

    public string? FmyStoBagortsatIadmuhkod { get; set; }

    public string? FmyStoBagortsatIskmuhkod { get; set; }

    public string? FmyStoBagortsatmalmuhkod { get; set; }

    public string? FmyStoSatfiyfarkmuhkod { get; set; }

    public string? FmyStoSifirbedsatmalmuhkod { get; set; }

    public string? FmyStoIhrackayitlisatismuhkod { get; set; }

    public string? FmyStoIhrackayitlisatismaliyetimuhkod { get; set; }

    public bool? FmyStoAltHesapAcilsinFl1 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl2 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl3 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl4 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl5 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl6 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl7 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl8 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl9 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl10 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl11 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl12 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl13 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl14 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl15 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl16 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl17 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl18 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl19 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl20 { get; set; }

    public bool? FmyStoAltHesapAcilsinFl21 { get; set; }

    public string? FmyDemMuhKod { get; set; }

    public string? FmyDemMuhKoduKkeg { get; set; }

    public string? FmyDemBirikAmortMuh { get; set; }

    public string? FmyDemYdfMuhKod { get; set; }

    public string? FmyDemAmorgiderMuhkod { get; set; }

    public string? FmyDemAmorgidkarMuhkod { get; set; }

    public string? FmyDemMaliyetArtisMu { get; set; }

    public string? FmyDemSatisKarMuhkod { get; set; }

    public string? FmyDemSatisZararMuhk { get; set; }

    public string? FmyDemYeniFonMuhkodu { get; set; }

    public string? FmyDemSermEkgmStsKazM { get; set; }

    public string? FmyDemYatirimtesMuhkod { get; set; }

    public string? FmyDemKkegMuhKodu { get; set; }

    public bool? FmyDemAltHesapAcilsinFl1 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl2 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl3 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl4 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl5 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl6 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl7 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl8 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl9 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl10 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl11 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl12 { get; set; }

    public bool? FmyDemAltHesapAcilsinFl13 { get; set; }

    public string? FmyHizSatMuhKod { get; set; }

    public string? FmyHizSatIadeMuhKod { get; set; }

    public string? FmyHizMalMuhKod { get; set; }

    public string? FmyHizSatMalMuhKod { get; set; }

    public string? FmyHizMalYanMuhKod { get; set; }

    public string? FmyHizMuhSatIskKod { get; set; }

    public string? FmyHizMuhAIiskmuhkod { get; set; }

    public string? FmyHizIlavemasmuhkod { get; set; }

    public bool? FmyHizAltHesapAcilsinFl1 { get; set; }

    public bool? FmyHizAltHesapAcilsinFl2 { get; set; }

    public bool? FmyHizAltHesapAcilsinFl3 { get; set; }

    public bool? FmyHizAltHesapAcilsinFl4 { get; set; }

    public bool? FmyHizAltHesapAcilsinFl5 { get; set; }

    public bool? FmyHizAltHesapAcilsinFl6 { get; set; }

    public bool? FmyHizAltHesapAcilsinFl7 { get; set; }

    public bool? FmyHizAltHesapAcilsinFl8 { get; set; }

    public string? FmyMasMuhkod { get; set; }

    public string? FmyMasMalYanMuhkod { get; set; }

    public string? FmyMasKkegMuhkod { get; set; }

    public string? FmyMasMuhSatIskKod { get; set; }

    public string? FmyMasMuhAIiskmuhkod { get; set; }

    public string? FmyMasIlavemasmuhkod { get; set; }

    public bool? FmyMasAltHesapAcilsinFl1 { get; set; }

    public bool? FmyMasAltHesapAcilsinFl2 { get; set; }

    public bool? FmyMasAltHesapAcilsinFl3 { get; set; }

    public bool? FmyMasAltHesapAcilsinFl4 { get; set; }

    public bool? FmyMasAltHesapAcilsinFl5 { get; set; }

    public bool? FmyMasAltHesapAcilsinFl6 { get; set; }

    public string? FmyCariperIsAvansiMuhkod { get; set; }

    public string? FmyCariperBordroAvansiMuhkod { get; set; }

    public string? FmyCariperPrimHesabiMuhkod { get; set; }

    public string? FmyCariperKvadeliBorcMuhkod { get; set; }

    public string? FmyCariperUvadeliBorcMuhkod { get; set; }

    public bool? FmyCariperAltHesapAcilsinFl1 { get; set; }

    public bool? FmyCariperAltHesapAcilsinFl2 { get; set; }

    public bool? FmyCariperAltHesapAcilsinFl3 { get; set; }

    public bool? FmyCariperAltHesapAcilsinFl4 { get; set; }

    public bool? FmyCariperAltHesapAcilsinFl5 { get; set; }

    public string? FmyIthNavlunMuhkod { get; set; }

    public string? FmyIthSigortaMuhkod { get; set; }

    public string? FmyIthGumrukVergiMuhkod { get; set; }

    public string? FmyIthBankaMasrafMuhkod { get; set; }

    public string? FmyIthDigerMasrafMuhkod1 { get; set; }

    public string? FmyIthDigerMasrafMuhkod2 { get; set; }

    public string? FmyIthDigerMasrafMuhkod3 { get; set; }

    public string? FmyIthDigerMasrafMuhkod4 { get; set; }

    public string? FmyIthDigerMasrafMuhkod5 { get; set; }

    public string? FmyIthDigerMasrafMuhkod6 { get; set; }

    public string? FmyIthDigerMasrafMuhkod7 { get; set; }

    public string? FmyIthDigerMasrafMuhkod8 { get; set; }

    public string? FmyIthDigerMasrafMuhkod9 { get; set; }

    public string? FmyIthDigerMasrafMuhkod10 { get; set; }

    public string? FmyIthDigerMasrafMuhkod11 { get; set; }

    public string? FmyIthDigerMasrafMuhkod12 { get; set; }

    public string? FmyIthDigerMasrafMuhkod13 { get; set; }

    public string? FmyIthDigerMasrafMuhkod14 { get; set; }

    public string? FmyIthDigerMasrafMuhkod15 { get; set; }

    public string? FmyIthDigerMasrafMuhkod16 { get; set; }

    public string? FmyIthMalBedeliMuhkod { get; set; }

    public bool? FmyIthAltHesapAcilsinFl1 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl2 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl3 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl4 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl5 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl6 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl7 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl8 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl9 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl10 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl11 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl12 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl13 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl14 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl15 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl16 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl17 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl18 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl19 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl20 { get; set; }

    public bool? FmyIthAltHesapAcilsinFl21 { get; set; }
}
