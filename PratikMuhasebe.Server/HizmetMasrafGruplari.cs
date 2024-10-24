using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizmetMasrafGruplari
{
    public Guid HmgrpGuid { get; set; }

    public short HmgrpDbcno { get; set; }

    public int? HmgrpSpecRecno { get; set; }

    public bool? HmgrpIptal { get; set; }

    public short? HmgrpFileid { get; set; }

    public bool? HmgrpHidden { get; set; }

    public bool? HmgrpKilitli { get; set; }

    public bool? HmgrpDegisti { get; set; }

    public int? HmgrpChecksum { get; set; }

    public short? HmgrpCreateUser { get; set; }

    public DateTime HmgrpCreateDate { get; set; }

    public short? HmgrpLastupUser { get; set; }

    public DateTime? HmgrpLastupDate { get; set; }

    public string? HmgrpSpecial1 { get; set; }

    public string? HmgrpSpecial2 { get; set; }

    public string? HmgrpSpecial3 { get; set; }

    public string? HmgrpKod { get; set; }

    public string? HmgrpIsmi { get; set; }
}
