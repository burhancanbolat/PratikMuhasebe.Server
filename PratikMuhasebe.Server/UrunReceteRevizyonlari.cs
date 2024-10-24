using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UrunReceteRevizyonlari
{
    public Guid UrrGuid { get; set; }

    public short UrrDbcno { get; set; }

    public int? UrrSpecRecno { get; set; }

    public bool? UrrIptal { get; set; }

    public short? UrrFileid { get; set; }

    public bool? UrrHidden { get; set; }

    public bool? UrrKilitli { get; set; }

    public bool? UrrDegisti { get; set; }

    public int? UrrChecksum { get; set; }

    public short? UrrCreateUser { get; set; }

    public DateTime UrrCreateDate { get; set; }

    public short? UrrLastupUser { get; set; }

    public DateTime? UrrLastupDate { get; set; }

    public string? UrrSpecial1 { get; set; }

    public string? UrrSpecial2 { get; set; }

    public string? UrrSpecial3 { get; set; }

    public byte? UrrAnatipi { get; set; }

    public string? UrrAnakod { get; set; }

    public string? UrrTanimkod { get; set; }

    public byte? UrrCinsi { get; set; }

    public bool? UrrReceteDegisti { get; set; }

    public bool? UrrRotaDegisti { get; set; }

    public int? UrrReceteRevizyonNo { get; set; }

    public int? UrrRotaRevizyonNo { get; set; }

    public DateTime? UrrRevizyonTarihi { get; set; }

    public string? UrrRevizyonAciklama { get; set; }

    public Guid? UrrRecGuid { get; set; }

    public short? UrrRecDbcno { get; set; }

    public int? UrrRecSpecRecno { get; set; }

    public bool? UrrRecIptal { get; set; }

    public short? UrrRecFileid { get; set; }

    public bool? UrrRecHidden { get; set; }

    public bool? UrrRecKilitli { get; set; }

    public bool? UrrRecDegisti { get; set; }

    public int? UrrRecChecksum { get; set; }

    public short? UrrRecCreateUser { get; set; }

    public DateTime? UrrRecCreateDate { get; set; }

    public short? UrrRecLastupUser { get; set; }

    public DateTime? UrrRecLastupDate { get; set; }

    public string? UrrRecSpecial1 { get; set; }

    public string? UrrRecSpecial2 { get; set; }

    public string? UrrRecSpecial3 { get; set; }

    public byte? UrrRecAnatipi { get; set; }

    public string? UrrRecAnakod { get; set; }

    public string? UrrRecTanimkod { get; set; }

    public byte? UrrRecCinsi { get; set; }

    public DateTime? UrrRecTarih { get; set; }

    public string? UrrRecAciklama { get; set; }

    public byte? UrrRecAnabirim { get; set; }

    public double? UrrRecAnamiktar { get; set; }

    public byte? UrrRecTuketimTur { get; set; }

    public string? UrrRecTuketimKod { get; set; }

    public string? UrrRecTuketimTanimKodu { get; set; }

    public byte? UrrRecTuketimReceteCinsi { get; set; }

    public double? UrrRecTuketimMiktar { get; set; }

    public byte? UrrRecTuketimBirim { get; set; }

    public byte? UrrRecUretimTuketim { get; set; }

    public int? UrrRecSatirno { get; set; }

    public string? UrrRecSatirAcik { get; set; }

    public int? UrrRecDepono { get; set; }

    public double? UrrRecFireyuzde { get; set; }

    public DateTime? UrrRecBaslamaTarihi { get; set; }

    public DateTime? UrrRecBitisTarihi { get; set; }

    public string? UrrRecAltTukkod1 { get; set; }

    public double? UrrRecAlt1Katsayi { get; set; }

    public string? UrrRecAltTukkod2 { get; set; }

    public double? UrrRecAlt2Katsayi { get; set; }

    public string? UrrRecAltTukkod3 { get; set; }

    public double? UrrRecAlt3Katsayi { get; set; }

    public string? UrrRecAltTukkod4 { get; set; }

    public double? UrrRecAlt4Katsayi { get; set; }

    public string? UrrRecAltTukkod5 { get; set; }

    public double? UrrRecAlt5Katsayi { get; set; }

    public short? UrrRecSafhaNo { get; set; }

    public byte? UrrRecSafhaTuru { get; set; }

    public byte? UrrRecAnaRenkNo { get; set; }

    public byte? UrrRecAnaBedenNo { get; set; }

    public byte? UrrRecTuketimRenkNo { get; set; }

    public byte? UrrRecTuketimBedenNo { get; set; }

    public byte? UrrRecPlanlamaTipi { get; set; }

    public byte? UrrRecEklenmeSarti { get; set; }

    public string? UrrRecMiktarFonksiyonAdi { get; set; }

    public int? UrrRecTuketimReceteRevizyonNo { get; set; }

    public int? UrrRecTuketimRotaRevizyonNo { get; set; }

    public Guid? UrrUrtGuid { get; set; }

    public short? UrrUrtDbcno { get; set; }

    public int? UrrUrtSpecRecno { get; set; }

    public bool? UrrUrtIptal { get; set; }

    public short? UrrUrtFileid { get; set; }

    public bool? UrrUrtHidden { get; set; }

    public bool? UrrUrtKilitli { get; set; }

    public bool? UrrUrtDegisti { get; set; }

    public int? UrrUrtCheckSum { get; set; }

    public short? UrrUrtCreateUser { get; set; }

    public DateTime? UrrUrtCreateDate { get; set; }

    public short? UrrUrtLastupUser { get; set; }

    public DateTime? UrrUrtLastupDate { get; set; }

    public string? UrrUrtSpecial1 { get; set; }

    public string? UrrUrtSpecial2 { get; set; }

    public string? UrrUrtSpecial3 { get; set; }

    public string? UrrUrtRotaUrunKodu { get; set; }

    public byte? UrrUrtCinsi { get; set; }

    public int? UrrUrtSatirNo { get; set; }

    public short? UrrUrtId { get; set; }

    public short? UrrUrtBagliRotaId { get; set; }

    public string? UrrUrtOpKod { get; set; }

    public byte? UrrUrtRotaIsMerkeziveSureTespitTipi { get; set; }

    public byte? UrrUrtIsmerkeziTipi { get; set; }

    public string? UrrUrtIsmerkeziveyaGrupKod { get; set; }

    public int? UrrUrtSabitHazirlikSuresi { get; set; }

    public int? UrrUrtDegiskenOperasyonSuresi { get; set; }

    public double? UrrUrtUretimMiktari { get; set; }

    public int? UrrUrtSabitOperasyonSuresi { get; set; }

    public double? UrrUrtCikisPartiMiktari { get; set; }

    public double? UrrUrtOperasyonSureCarpani { get; set; }

    public byte? UrrUrtOperasyonTekrarSayisi { get; set; }

    public double? UrrUrtEnerji1Miktari { get; set; }

    public double? UrrUrtEnerji2Miktari { get; set; }

    public string? UrrUrtAciklama { get; set; }

    public short? UrrUrtCalisanSayisi { get; set; }

    public string? UrrUrtKalipKodu { get; set; }

    public double? UrrUrtHazirlikElemanIhtiyaci { get; set; }

    public double? UrrUrtOperasyonElemanIhtiyaci { get; set; }

    public Guid? UrrRkGuid { get; set; }

    public short? UrrRkDbcno { get; set; }

    public int? UrrRkSpecRecno { get; set; }

    public bool? UrrRkIptal { get; set; }

    public short? UrrRkFileid { get; set; }

    public bool? UrrRkHidden { get; set; }

    public bool? UrrRkKilitli { get; set; }

    public bool? UrrRkDegisti { get; set; }

    public int? UrrRkChecksum { get; set; }

    public short? UrrRkCreateUser { get; set; }

    public DateTime? UrrRkCreateDate { get; set; }

    public short? UrrRkLastupUser { get; set; }

    public DateTime? UrrRkLastupDate { get; set; }

    public string? UrrRkSpecial1 { get; set; }

    public string? UrrRkSpecial2 { get; set; }

    public string? UrrRkSpecial3 { get; set; }

    public Guid? UrrRkReceteUid { get; set; }

    public int? UrrRkSatirno { get; set; }

    public byte? UrrRkTablo { get; set; }

    public string? UrrRkAlanAdi { get; set; }

    public byte? UrrRkIslem { get; set; }

    public string? UrrRkStringdata { get; set; }

    public byte? UrrRkBaglantiTipi { get; set; }

    public Guid? UrrUrdGuid { get; set; }

    public short? UrrUrdDbcno { get; set; }

    public int? UrrUrdSpecRecno { get; set; }

    public bool? UrrUrdIptal { get; set; }

    public short? UrrUrdFileid { get; set; }

    public bool? UrrUrdHidden { get; set; }

    public bool? UrrUrdKilitli { get; set; }

    public bool? UrrUrdDegisti { get; set; }

    public int? UrrUrdCheckSum { get; set; }

    public short? UrrUrdCreateUser { get; set; }

    public DateTime? UrrUrdCreateDate { get; set; }

    public short? UrrUrdLastupUser { get; set; }

    public DateTime? UrrUrdLastupDate { get; set; }

    public string? UrrUrdSpecial1 { get; set; }

    public string? UrrUrdSpecial2 { get; set; }

    public string? UrrUrdSpecial3 { get; set; }

    public Guid? UrrUrdBagliRotaUid { get; set; }

    public int? UrrUrdDetaySatirNo { get; set; }

    public byte? UrrUrdKriterDegeri1 { get; set; }

    public double? UrrUrdMaxDeger1 { get; set; }

    public double? UrrUrdMinDeger1 { get; set; }

    public byte? UrrUrdKriterDegeri2 { get; set; }

    public double? UrrUrdMaxDeger2 { get; set; }

    public double? UrrUrdMinDeger2 { get; set; }

    public byte? UrrUrdKriterDegeri3 { get; set; }

    public double? UrrUrdMaxDeger3 { get; set; }

    public double? UrrUrdMinDeger3 { get; set; }

    public byte? UrrUrdIsmerkeziTipi { get; set; }

    public string? UrrUrdIsmerkeziveyaGrupKod { get; set; }

    public int? UrrUrdSabitHazirlikSuresi { get; set; }

    public int? UrrUrdDegiskenOperasyonSuresi { get; set; }

    public int? UrrUrdSabitOperasyonSuresi { get; set; }

    public double? UrrUrdUretimMiktari { get; set; }

    public double? UrrUrdCikisPartiMiktari { get; set; }

    public double? UrrUrdEnerji1Miktari { get; set; }

    public double? UrrUrdEnerji2Miktari { get; set; }

    public string? UrrUrdAciklama { get; set; }

    public short? UrrUrdCalisanSayisi { get; set; }

    public string? UrrUrdKalipKodu { get; set; }

    public double? UrrUrdHazirlikElemanIhtiyaci { get; set; }

    public double? UrrUrdOperasyonElemanIhtiyaci { get; set; }
}
