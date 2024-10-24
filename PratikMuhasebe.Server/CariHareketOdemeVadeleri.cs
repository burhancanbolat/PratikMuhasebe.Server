using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHareketOdemeVadeleri
{
    public Guid CopGuid { get; set; }

    public short CopDbcno { get; set; }

    public int? CopSpecRecno { get; set; }

    public bool? CopIptal { get; set; }

    public short? CopFileid { get; set; }

    public bool? CopHidden { get; set; }

    public bool? CopKilitli { get; set; }

    public bool? CopDegisti { get; set; }

    public int? CopChecksum { get; set; }

    public short? CopCreateUser { get; set; }

    public DateTime CopCreateDate { get; set; }

    public short? CopLastupUser { get; set; }

    public DateTime? CopLastupDate { get; set; }

    public string? CopSpecial1 { get; set; }

    public string? CopSpecial2 { get; set; }

    public string? CopSpecial3 { get; set; }

    public byte? CopEvrakTip { get; set; }

    public string? CopEvraknoSeri { get; set; }

    public int? CopEvraknoSira { get; set; }

    public DateTime? CopVade { get; set; }

    public double? CopTutar { get; set; }
}
