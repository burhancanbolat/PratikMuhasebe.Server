using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EgitimGrupTipleri
{
    public Guid EgtGuid { get; set; }

    public short EgtDbcno { get; set; }

    public int? EgtSpecRecno { get; set; }

    public bool? EgtIptal { get; set; }

    public short? EgtFileid { get; set; }

    public bool? EgtHidden { get; set; }

    public bool? EgtKilitli { get; set; }

    public bool? EgtDegisti { get; set; }

    public int? EgtChecksum { get; set; }

    public short? EgtCreateUser { get; set; }

    public DateTime EgtCreateDate { get; set; }

    public short? EgtLastupUser { get; set; }

    public DateTime? EgtLastupDate { get; set; }

    public string? EgtSpecial1 { get; set; }

    public string? EgtSpecial2 { get; set; }

    public string? EgtSpecial3 { get; set; }

    public string? EgtKodu { get; set; }

    public string? EgtAdi { get; set; }
}
