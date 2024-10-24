using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TamamlayiciStoklar
{
    public Guid TsGuid { get; set; }

    public short TsDbcno { get; set; }

    public int? TsSpecRecno { get; set; }

    public bool? TsIptal { get; set; }

    public short? TsFileid { get; set; }

    public bool? TsHidden { get; set; }

    public bool? TsKilitli { get; set; }

    public bool? TsDegisti { get; set; }

    public int? TsChecksum { get; set; }

    public short? TsCreateUser { get; set; }

    public DateTime TsCreateDate { get; set; }

    public short? TsLastupUser { get; set; }

    public DateTime? TsLastupDate { get; set; }

    public string? TsSpecial1 { get; set; }

    public string? TsSpecial2 { get; set; }

    public string? TsSpecial3 { get; set; }

    public string TsKodu { get; set; } = null!;

    public string TsStokkodu { get; set; } = null!;

    public double? TsMiktar { get; set; }

    public int? TsSatirno { get; set; }
}
