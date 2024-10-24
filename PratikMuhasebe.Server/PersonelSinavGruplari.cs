using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSinavGruplari
{
    public Guid SngGuid { get; set; }

    public short SngDbcno { get; set; }

    public int? SngSpecRecno { get; set; }

    public bool? SngIptal { get; set; }

    public short? SngFileid { get; set; }

    public bool? SngHidden { get; set; }

    public bool? SngKilitli { get; set; }

    public bool? SngDegisti { get; set; }

    public int? SngChecksum { get; set; }

    public short? SngCreateUser { get; set; }

    public DateTime SngCreateDate { get; set; }

    public short? SngLastupUser { get; set; }

    public DateTime? SngLastupDate { get; set; }

    public string? SngSpecial1 { get; set; }

    public string? SngSpecial2 { get; set; }

    public string? SngSpecial3 { get; set; }

    public string? SngKodu { get; set; }

    public string? SngAdi { get; set; }

    public string? SngAnagrupkodu { get; set; }
}
