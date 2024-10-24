using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IptalNedenleri
{
    public Guid IptGuid { get; set; }

    public short IptDbcno { get; set; }

    public int? IptSpecRecno { get; set; }

    public bool? IptIptal { get; set; }

    public short? IptFileid { get; set; }

    public bool? IptHidden { get; set; }

    public bool? IptKilitli { get; set; }

    public bool? IptDegisti { get; set; }

    public int? IptChecksum { get; set; }

    public short? IptCreateUser { get; set; }

    public DateTime IptCreateDate { get; set; }

    public short? IptLastupUser { get; set; }

    public DateTime? IptLastupDate { get; set; }

    public string? IptSpecial1 { get; set; }

    public string? IptSpecial2 { get; set; }

    public string? IptSpecial3 { get; set; }

    public string? IptKodu { get; set; }

    public string? IptAdi { get; set; }
}
