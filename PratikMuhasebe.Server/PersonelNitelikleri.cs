using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelNitelikleri
{
    public Guid PnGuid { get; set; }

    public short PnDbcno { get; set; }

    public int? PnSpecRecno { get; set; }

    public bool? PnIptal { get; set; }

    public short? PnFileid { get; set; }

    public bool? PnHidden { get; set; }

    public bool? PnKilitli { get; set; }

    public bool? PnDegisti { get; set; }

    public int? PnChecksum { get; set; }

    public short? PnCreateUser { get; set; }

    public DateTime PnCreateDate { get; set; }

    public short? PnLastupUser { get; set; }

    public DateTime? PnLastupDate { get; set; }

    public string? PnSpecial1 { get; set; }

    public string? PnSpecial2 { get; set; }

    public string? PnSpecial3 { get; set; }

    public string? PnPerskod { get; set; }

    public int? PnSatirno { get; set; }

    public string? PnNitelikkod { get; set; }

    public double? PnPuan { get; set; }

    public byte? PnSozelpuan { get; set; }
}
