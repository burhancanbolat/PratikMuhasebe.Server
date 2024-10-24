using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EkipTanimlari
{
    public Guid EkpGuid { get; set; }

    public short EkpDbcno { get; set; }

    public int? EkpSpecRecno { get; set; }

    public bool? EkpIptal { get; set; }

    public short? EkpFileid { get; set; }

    public bool? EkpHidden { get; set; }

    public bool? EkpKilitli { get; set; }

    public bool? EkpDegisti { get; set; }

    public int? EkpCheckSum { get; set; }

    public short? EkpCreateUser { get; set; }

    public DateTime EkpCreateDate { get; set; }

    public short? EkpLastupUser { get; set; }

    public DateTime? EkpLastupDate { get; set; }

    public string? EkpSpecial1 { get; set; }

    public string? EkpSpecial2 { get; set; }

    public string? EkpSpecial3 { get; set; }

    public string? EkpKodu { get; set; }

    public string? EkpAdi { get; set; }

    public string? EkpCariKodu { get; set; }

    public string? EkpPersonelKodu1 { get; set; }

    public double? EkpPersonelAgirlikPuan1 { get; set; }

    public string? EkpPersonelKodu2 { get; set; }

    public double? EkpPersonelAgirlikPuan2 { get; set; }

    public string? EkpPersonelKodu3 { get; set; }

    public double? EkpPersonelAgirlikPuan3 { get; set; }

    public string? EkpPersonelKodu4 { get; set; }

    public double? EkpPersonelAgirlikPuan4 { get; set; }

    public string? EkpPersonelKodu5 { get; set; }

    public double? EkpPersonelAgirlikPuan5 { get; set; }

    public string? EkpPersonelKodu6 { get; set; }

    public double? EkpPersonelAgirlikPuan6 { get; set; }

    public string? EkpPersonelKodu7 { get; set; }

    public double? EkpPersonelAgirlikPuan7 { get; set; }

    public string? EkpPersonelKodu8 { get; set; }

    public double? EkpPersonelAgirlikPuan8 { get; set; }

    public string? EkpPersonelKodu9 { get; set; }

    public double? EkpPersonelAgirlikPuan9 { get; set; }

    public string? EkpPersonelKodu10 { get; set; }

    public double? EkpPersonelAgirlikPuan10 { get; set; }
}
