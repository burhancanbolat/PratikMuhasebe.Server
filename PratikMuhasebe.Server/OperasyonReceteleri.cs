using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OperasyonReceteleri
{
    public Guid OprGuid { get; set; }

    public short OprDbcno { get; set; }

    public int? OprSpecRecno { get; set; }

    public bool? OprIptal { get; set; }

    public short? OprFileid { get; set; }

    public bool? OprHidden { get; set; }

    public bool? OprKilitli { get; set; }

    public bool? OprDegisti { get; set; }

    public int? OprChecksum { get; set; }

    public short? OprCreateUser { get; set; }

    public DateTime OprCreateDate { get; set; }

    public short? OprLastupUser { get; set; }

    public DateTime? OprLastupDate { get; set; }

    public string? OprSpecial1 { get; set; }

    public string? OprSpecial2 { get; set; }

    public string? OprSpecial3 { get; set; }

    public string? OprOperasyonKodu { get; set; }

    public DateTime? OprDuzenlemeTarihi { get; set; }

    public string? OprAciklama { get; set; }

    public string? OprTuketimKodu { get; set; }

    public double? OprTuketimMiktari { get; set; }

    public byte? OprTuketimBirim { get; set; }

    public byte? OprHesapTipi { get; set; }

    public double? OprAnaMiktarSure { get; set; }

    public byte? OprUretimTuketim { get; set; }

    public int? OprSatirno { get; set; }

    public string? OprSatirAciklamasi { get; set; }

    public int? OprDepono { get; set; }

    public string? OprAltTukkod1 { get; set; }

    public double? OprAlt1Katsayi { get; set; }

    public string? OprAltTukkod2 { get; set; }

    public double? OprAlt2Katsayi { get; set; }

    public string? OprAltTukkod3 { get; set; }

    public double? OprAlt3Katsayi { get; set; }

    public string? OprAltTukkod4 { get; set; }

    public double? OprAlt4Katsayi { get; set; }

    public string? OprAltTukkod5 { get; set; }

    public double? OprAlt5Katsayi { get; set; }

    public byte? OprSarfTuru { get; set; }
}
