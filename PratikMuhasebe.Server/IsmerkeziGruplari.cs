using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsmerkeziGruplari
{
    public Guid ImgrGuid { get; set; }

    public short ImgrDbcno { get; set; }

    public int? ImgrSpecRecno { get; set; }

    public bool? ImgrIptal { get; set; }

    public short? ImgrFileid { get; set; }

    public bool? ImgrHidden { get; set; }

    public bool? ImgrKilitli { get; set; }

    public bool? ImgrDegisti { get; set; }

    public int? ImgrCheckSum { get; set; }

    public short? ImgrCreateUser { get; set; }

    public DateTime ImgrCreateDate { get; set; }

    public short? ImgrLastupUser { get; set; }

    public DateTime? ImgrLastupDate { get; set; }

    public string? ImgrSpecial1 { get; set; }

    public string? ImgrSpecial2 { get; set; }

    public string? ImgrSpecial3 { get; set; }

    public string? ImgrKod { get; set; }

    public string? ImgrIsim { get; set; }
}
