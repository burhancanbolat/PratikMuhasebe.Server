using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UrunReceteleri
{
    public Guid RecGuid { get; set; }

    public short RecDbcno { get; set; }

    public int? RecSpecRecno { get; set; }

    public bool? RecIptal { get; set; }

    public short? RecFileid { get; set; }

    public bool? RecHidden { get; set; }

    public bool? RecKilitli { get; set; }

    public bool? RecDegisti { get; set; }

    public int? RecChecksum { get; set; }

    public short? RecCreateUser { get; set; }

    public DateTime RecCreateDate { get; set; }

    public short? RecLastupUser { get; set; }

    public DateTime? RecLastupDate { get; set; }

    public string? RecSpecial1 { get; set; }

    public string? RecSpecial2 { get; set; }

    public string? RecSpecial3 { get; set; }

    public byte? RecAnatipi { get; set; }

    public string? RecAnakod { get; set; }

    public string? RecTanimkod { get; set; }

    public byte? RecCinsi { get; set; }

    public DateTime? RecTarih { get; set; }

    public string? RecAciklama { get; set; }

    public byte? RecAnabirim { get; set; }

    public double? RecAnamiktar { get; set; }

    public byte? RecTuketimTur { get; set; }

    public string? RecTuketimKod { get; set; }

    public string? RecTuketimTanimKodu { get; set; }

    public byte? RecTuketimReceteCinsi { get; set; }

    public double? RecTuketimMiktar { get; set; }

    public byte? RecTuketimBirim { get; set; }

    public byte? RecUretimTuketim { get; set; }

    public int? RecSatirno { get; set; }

    public string? RecSatirAcik { get; set; }

    public int? RecDepono { get; set; }

    public double? RecFireyuzde { get; set; }

    public DateTime? RecBaslamaTarihi { get; set; }

    public DateTime? RecBitisTarihi { get; set; }

    public string? RecAltTukkod1 { get; set; }

    public double? RecAlt1Katsayi { get; set; }

    public string? RecAltTukkod2 { get; set; }

    public double? RecAlt2Katsayi { get; set; }

    public string? RecAltTukkod3 { get; set; }

    public double? RecAlt3Katsayi { get; set; }

    public string? RecAltTukkod4 { get; set; }

    public double? RecAlt4Katsayi { get; set; }

    public string? RecAltTukkod5 { get; set; }

    public double? RecAlt5Katsayi { get; set; }

    public short? RecSafhaNo { get; set; }

    public byte? RecSafhaTuru { get; set; }

    public byte? RecAnaRenkNo { get; set; }

    public byte? RecAnaBedenNo { get; set; }

    public byte? RecTuketimRenkNo { get; set; }

    public byte? RecTuketimBedenNo { get; set; }

    public byte? RecPlanlamaTipi { get; set; }

    public byte? RecEklenmeSarti { get; set; }

    public string? RecMiktarFonksiyonAdi { get; set; }
}
