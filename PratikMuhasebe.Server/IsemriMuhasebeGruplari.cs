using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsemriMuhasebeGruplari
{
    public Guid IsmuhGuid { get; set; }

    public short IsmuhDbcno { get; set; }

    public int? IsmuhSpecRecno { get; set; }

    public bool? IsmuhIptal { get; set; }

    public short? IsmuhFileid { get; set; }

    public bool? IsmuhHidden { get; set; }

    public bool? IsmuhKilitli { get; set; }

    public bool? IsmuhDegisti { get; set; }

    public int? IsmuhChecksum { get; set; }

    public short? IsmuhCreateUser { get; set; }

    public DateTime IsmuhCreateDate { get; set; }

    public short? IsmuhLastupUser { get; set; }

    public DateTime? IsmuhLastupDate { get; set; }

    public string? IsmuhSpecial1 { get; set; }

    public string? IsmuhSpecial2 { get; set; }

    public string? IsmuhSpecial3 { get; set; }

    public string? IsmuhKod { get; set; }

    public string? IsmuhIsmi { get; set; }

    public string? IsmuhMuhKod { get; set; }

    public string? IsmuhStokBirikMuhKod { get; set; }

    public string? IsmuhHizmetBirikMuhKod { get; set; }

    public string? IsmuhStokYansitMuhKod { get; set; }

    public string? IsmuhHizmetYansitMuhKo { get; set; }

    public string? IsmuhYarimamulbirikimmuhko { get; set; }

    public string? IsmuhYarimamulyansitmamuhko { get; set; }

    public string? IsmuhMakineMalYanMuhKo { get; set; }

    public string? IsmuhElemanMalYanMuhKo { get; set; }

    public string? IsmuhYariMamulMuhKod { get; set; }

    public string? IsmuhGenMalYanMuhKod1 { get; set; }

    public string? IsmuhGenMalYanMuhKod2 { get; set; }

    public string? IsmuhGenMalYanMuhKod3 { get; set; }

    public string? IsmuhGenMalYanMuhKod4 { get; set; }

    public string? IsmuhGenMalYanMuhKod5 { get; set; }

    public string? IsmuhGenUrtMalYanMuhKod1 { get; set; }

    public string? IsmuhGenUrtMalYanMuhKod2 { get; set; }

    public string? IsmuhGenUrtMalYanMuhKod3 { get; set; }

    public string? IsmuhGenUrtMalYanMuhKod4 { get; set; }

    public string? IsmuhGenUrtMalYanMuhKod5 { get; set; }
}
