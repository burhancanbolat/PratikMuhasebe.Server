using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizmetMasrafSiniflari
{
    public Guid HmsnfGuid { get; set; }

    public short HmsnfDbcno { get; set; }

    public int? HmsnfSpecRecno { get; set; }

    public bool? HmsnfIptal { get; set; }

    public short? HmsnfFileid { get; set; }

    public bool? HmsnfHidden { get; set; }

    public bool? HmsnfKilitli { get; set; }

    public bool? HmsnfDegisti { get; set; }

    public int? HmsnfChecksum { get; set; }

    public short? HmsnfCreateUser { get; set; }

    public DateTime HmsnfCreateDate { get; set; }

    public short? HmsnfLastupUser { get; set; }

    public DateTime? HmsnfLastupDate { get; set; }

    public string? HmsnfSpecial1 { get; set; }

    public string? HmsnfSpecial2 { get; set; }

    public string? HmsnfSpecial3 { get; set; }

    public string? HmsnfKod { get; set; }

    public string? HmsnfIsmi { get; set; }
}
