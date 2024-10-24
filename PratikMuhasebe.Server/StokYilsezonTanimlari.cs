using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokYilsezonTanimlari
{
    public Guid YsnGuid { get; set; }

    public short YsnDbcno { get; set; }

    public int? YsnSpecRecno { get; set; }

    public bool? YsnIptal { get; set; }

    public short? YsnFileid { get; set; }

    public bool? YsnHidden { get; set; }

    public bool? YsnKilitli { get; set; }

    public bool? YsnDegisti { get; set; }

    public int? YsnCheckSum { get; set; }

    public short? YsnCreateUser { get; set; }

    public DateTime YsnCreateDate { get; set; }

    public short? YsnLastupUser { get; set; }

    public DateTime? YsnLastupDate { get; set; }

    public string? YsnSpecial1 { get; set; }

    public string? YsnSpecial2 { get; set; }

    public string? YsnSpecial3 { get; set; }

    public string? YsnKodu { get; set; }

    public string? YsnIsmi { get; set; }
}
