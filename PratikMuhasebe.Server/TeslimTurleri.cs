using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TeslimTurleri
{
    public Guid TsltGuid { get; set; }

    public short TsltDbcno { get; set; }

    public int? TsltSpecRecno { get; set; }

    public bool? TsltIptal { get; set; }

    public short? TsltFileid { get; set; }

    public bool? TsltHidden { get; set; }

    public bool? TsltKilitli { get; set; }

    public bool? TsltDegisti { get; set; }

    public int? TsltChecksum { get; set; }

    public short? TsltCreateUser { get; set; }

    public DateTime TsltCreateDate { get; set; }

    public short? TsltLastupUser { get; set; }

    public DateTime? TsltLastupDate { get; set; }

    public string? TsltSpecial1 { get; set; }

    public string? TsltSpecial2 { get; set; }

    public string? TsltSpecial3 { get; set; }

    public string? TsltKod { get; set; }

    public string? TsltIsmi { get; set; }
}
