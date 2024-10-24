using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DemirbasGruplari
{
    public Guid GrpGuid { get; set; }

    public short GrpDbcno { get; set; }

    public int? GrpSpecRecno { get; set; }

    public bool? GrpIptal { get; set; }

    public short? GrpFileid { get; set; }

    public bool? GrpHidden { get; set; }

    public bool? GrpKilitli { get; set; }

    public bool? GrpDegisti { get; set; }

    public int? GrpChecksum { get; set; }

    public short? GrpCreateUser { get; set; }

    public DateTime GrpCreateDate { get; set; }

    public short? GrpLastupUser { get; set; }

    public DateTime? GrpLastupDate { get; set; }

    public string? GrpSpecial1 { get; set; }

    public string? GrpSpecial2 { get; set; }

    public string? GrpSpecial3 { get; set; }

    public string? GrpKod { get; set; }

    public string? GrpIsmi { get; set; }
}
