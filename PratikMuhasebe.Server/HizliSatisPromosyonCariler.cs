using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizliSatisPromosyonCariler
{
    public Guid HspcGuid { get; set; }

    public short HspcDbcno { get; set; }

    public int? HspcSpecRecno { get; set; }

    public bool? HspcIptal { get; set; }

    public short? HspcFileid { get; set; }

    public bool? HspcHidden { get; set; }

    public bool? HspcKilitli { get; set; }

    public bool? HspcDegisti { get; set; }

    public int? HspcChecksum { get; set; }

    public short? HspcCreateUser { get; set; }

    public DateTime HspcCreateDate { get; set; }

    public short? HspcLastupUser { get; set; }

    public DateTime? HspcLastupDate { get; set; }

    public string? HspcSpecial1 { get; set; }

    public string? HspcSpecial2 { get; set; }

    public string? HspcSpecial3 { get; set; }

    public string HspcPromosyonKodu { get; set; } = null!;

    public string HspcCariKodu { get; set; } = null!;
}
