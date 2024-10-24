using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokSektorleri
{
    public Guid SktrGuid { get; set; }

    public short SktrDbcno { get; set; }

    public int? SktrSpecRecno { get; set; }

    public bool? SktrIptal { get; set; }

    public short? SktrFileid { get; set; }

    public bool? SktrHidden { get; set; }

    public bool? SktrKilitli { get; set; }

    public bool? SktrDegisti { get; set; }

    public int? SktrChecksum { get; set; }

    public short? SktrCreateUser { get; set; }

    public DateTime SktrCreateDate { get; set; }

    public short? SktrLastupUser { get; set; }

    public DateTime? SktrLastupDate { get; set; }

    public string? SktrSpecial1 { get; set; }

    public string? SktrSpecial2 { get; set; }

    public string? SktrSpecial3 { get; set; }

    public string? SktrKod { get; set; }

    public string? SktrIsmi { get; set; }

    public string? SktrMuhkodu { get; set; }
}
