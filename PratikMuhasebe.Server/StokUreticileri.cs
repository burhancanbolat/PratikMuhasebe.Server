using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokUreticileri
{
    public Guid UrtGuid { get; set; }

    public short UrtDbcno { get; set; }

    public int? UrtSpecRecno { get; set; }

    public bool? UrtIptal { get; set; }

    public short? UrtFileid { get; set; }

    public bool? UrtHidden { get; set; }

    public bool? UrtKilitli { get; set; }

    public bool? UrtDegisti { get; set; }

    public int? UrtChecksum { get; set; }

    public short? UrtCreateUser { get; set; }

    public DateTime UrtCreateDate { get; set; }

    public short? UrtLastupUser { get; set; }

    public DateTime? UrtLastupDate { get; set; }

    public string? UrtSpecial1 { get; set; }

    public string? UrtSpecial2 { get; set; }

    public string? UrtSpecial3 { get; set; }

    public string? UrtKod { get; set; }

    public string? UrtIsmi { get; set; }

    public string? UrtUtsKurumNo { get; set; }
}
