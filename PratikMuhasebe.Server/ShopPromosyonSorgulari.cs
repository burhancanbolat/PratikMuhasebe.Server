using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ShopPromosyonSorgulari
{
    public Guid PrqGuid { get; set; }

    public short PrqDbcno { get; set; }

    public int? PrqSpecRecno { get; set; }

    public bool? PrqIptal { get; set; }

    public short? PrqFileid { get; set; }

    public bool? PrqHidden { get; set; }

    public bool? PrqKilitli { get; set; }

    public bool? PrqDegisti { get; set; }

    public int? PrqCheckSum { get; set; }

    public short? PrqCreateUser { get; set; }

    public DateTime PrqCreateDate { get; set; }

    public short? PrqLastupUser { get; set; }

    public DateTime? PrqLastupDate { get; set; }

    public string? PrqSpecial1 { get; set; }

    public string? PrqSpecial2 { get; set; }

    public string? PrqSpecial3 { get; set; }

    public string? PrqKodu { get; set; }

    public string? PrqIsmi { get; set; }

    public byte? PrqTipi { get; set; }

    public byte? PrqPosTipleri { get; set; }

    public byte? PrqOzellikler { get; set; }
}
