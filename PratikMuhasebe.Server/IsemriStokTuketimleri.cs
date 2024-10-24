using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsemriStokTuketimleri
{
    public Guid TktGuid { get; set; }

    public short TktDbcno { get; set; }

    public int? TktSpecRecno { get; set; }

    public bool? TktIptal { get; set; }

    public short? TktFileid { get; set; }

    public bool? TktHidden { get; set; }

    public bool? TktKilitli { get; set; }

    public bool? TktDegisti { get; set; }

    public int? TktChecksum { get; set; }

    public short? TktCreateUser { get; set; }

    public DateTime TktCreateDate { get; set; }

    public short? TktLastupUser { get; set; }

    public DateTime? TktLastupDate { get; set; }

    public string? TktSpecial1 { get; set; }

    public string? TktSpecial2 { get; set; }

    public string? TktSpecial3 { get; set; }

    public string? TktIsemri { get; set; }

    public int? TktSatirno { get; set; }

    public string? TktStokkodu { get; set; }

    public string? TktFasoncukodu { get; set; }

    public string? TktIsmerkeziKodu { get; set; }

    public double? TktMiktari { get; set; }

    public double? TktDegerAna { get; set; }

    public double? TktDegerAlt { get; set; }

    public double? TktDegerOrj { get; set; }

    public string? TktUretimStokKodu { get; set; }

    public double? TktUretimMiktari { get; set; }

    public byte? TktBirimpntr { get; set; }

    public byte? TktUretimbirimpntr { get; set; }
}
