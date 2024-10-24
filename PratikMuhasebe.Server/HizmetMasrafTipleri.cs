using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizmetMasrafTipleri
{
    public Guid HmtipGuid { get; set; }

    public short HmtipDbcno { get; set; }

    public int? HmtipSpecRecno { get; set; }

    public bool? HmtipIptal { get; set; }

    public short? HmtipFileid { get; set; }

    public bool? HmtipHidden { get; set; }

    public bool? HmtipKilitli { get; set; }

    public bool? HmtipDegisti { get; set; }

    public int? HmtipChecksum { get; set; }

    public short? HmtipCreateUser { get; set; }

    public DateTime HmtipCreateDate { get; set; }

    public short? HmtipLastupUser { get; set; }

    public DateTime? HmtipLastupDate { get; set; }

    public string? HmtipSpecial1 { get; set; }

    public string? HmtipSpecial2 { get; set; }

    public string? HmtipSpecial3 { get; set; }

    public string? HmtipKod { get; set; }

    public string? HmtipIsmi { get; set; }
}
