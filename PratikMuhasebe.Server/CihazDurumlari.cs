using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CihazDurumlari
{
    public Guid CdrGuid { get; set; }

    public short CdrDbcno { get; set; }

    public int? CdrSpecRecno { get; set; }

    public bool? CdrIptal { get; set; }

    public short? CdrFileid { get; set; }

    public bool? CdrHidden { get; set; }

    public bool? CdrKilitli { get; set; }

    public bool? CdrDegisti { get; set; }

    public int? CdrChecksum { get; set; }

    public short? CdrCreateUser { get; set; }

    public DateTime CdrCreateDate { get; set; }

    public short? CdrLastupUser { get; set; }

    public DateTime? CdrLastupDate { get; set; }

    public string? CdrSpecial1 { get; set; }

    public string? CdrSpecial2 { get; set; }

    public string? CdrSpecial3 { get; set; }

    public string? CdrKod { get; set; }

    public string? CdrIsim { get; set; }
}
