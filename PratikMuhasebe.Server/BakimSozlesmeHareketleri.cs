using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BakimSozlesmeHareketleri
{
    public Guid BsozGuid { get; set; }

    public short BsozDbcno { get; set; }

    public int? BsozSpecRecNo { get; set; }

    public bool? BsozIptal { get; set; }

    public short? BsozFileid { get; set; }

    public bool? BsozHidden { get; set; }

    public bool? BsozKilitli { get; set; }

    public bool? BsozDegisti { get; set; }

    public int? BsozChecksum { get; set; }

    public short? BsozCreateUser { get; set; }

    public DateTime BsozCreateDate { get; set; }

    public short? BsozLastupUser { get; set; }

    public DateTime? BsozLastupDate { get; set; }

    public string? BsozSpecial1 { get; set; }

    public string? BsozSpecial2 { get; set; }

    public string? BsozSpecial3 { get; set; }

    public int? BsozFirmano { get; set; }

    public int? BsozSubeno { get; set; }

    public DateTime? BsozTarihi { get; set; }

    public string? BsozEvraknoSeri { get; set; }

    public int? BsozEvraknoSira { get; set; }

    public int? BsozSatirno { get; set; }

    public string? BsozBelgeno { get; set; }

    public DateTime? BsozBelgeTarihi { get; set; }

    public string? BsozCariKodu { get; set; }

    public byte? BsozDovizCinsi { get; set; }

    public DateTime? BsozBaslangicTarihi { get; set; }

    public DateTime? BsozBitisTarihi { get; set; }

    public double? BsozIscilikBedeli { get; set; }

    public double? BsozKmYolBedeli { get; set; }

    public double? BsozKontrolBedeli { get; set; }

    public string? BsozAciklama { get; set; }

    public string? BsozStokKodu { get; set; }

    public string? BsozSeriNo { get; set; }

    public string? BsozBakimReceteKodu { get; set; }

    public double? BsozBakimBedeli { get; set; }

    public byte? BsozBakimPeryodu { get; set; }

    public byte? BsozBakimTipi { get; set; }
}
