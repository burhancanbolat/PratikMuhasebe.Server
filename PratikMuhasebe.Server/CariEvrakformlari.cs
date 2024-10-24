using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariEvrakformlari
{
    public Guid CfGuid { get; set; }

    public short CfDbcno { get; set; }

    public int? CfSpecRecno { get; set; }

    public bool? CfIptal { get; set; }

    public short? CfFileid { get; set; }

    public bool? CfHidden { get; set; }

    public bool? CfKilitli { get; set; }

    public bool? CfDegisti { get; set; }

    public int? CfChecksum { get; set; }

    public short? CfCreateUser { get; set; }

    public DateTime CfCreateDate { get; set; }

    public short? CfLastupUser { get; set; }

    public DateTime? CfLastupDate { get; set; }

    public string? CfSpecial1 { get; set; }

    public string? CfSpecial2 { get; set; }

    public string? CfSpecial3 { get; set; }

    public byte? CfFormtipi { get; set; }

    public string? CfCarikodu { get; set; }

    public string? CfYenitipformadi { get; set; }

    public string? CfEskitipformadi { get; set; }
}
