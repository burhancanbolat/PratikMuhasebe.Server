using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroNitelikleri
{
    public Guid KnGuid { get; set; }

    public short KnDbcno { get; set; }

    public int? KnSpecRecno { get; set; }

    public bool? KnIptal { get; set; }

    public short? KnFileid { get; set; }

    public bool? KnHidden { get; set; }

    public bool? KnKilitli { get; set; }

    public bool? KnDegisti { get; set; }

    public int? KnChecksum { get; set; }

    public short? KnCreateUser { get; set; }

    public DateTime KnCreateDate { get; set; }

    public short? KnLastupUser { get; set; }

    public DateTime? KnLastupDate { get; set; }

    public string? KnSpecial1 { get; set; }

    public string? KnSpecial2 { get; set; }

    public string? KnSpecial3 { get; set; }

    public string? KnKadrokod { get; set; }

    public int? KnKadrosirano { get; set; }

    public int? KnSatirno { get; set; }

    public string? KnNitelikkod { get; set; }

    public DateTime? KnGecerliliktarihi { get; set; }
}
