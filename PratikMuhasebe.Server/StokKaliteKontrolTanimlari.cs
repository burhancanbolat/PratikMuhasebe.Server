using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokKaliteKontrolTanimlari
{
    public Guid KkonGuid { get; set; }

    public short KkonDbcno { get; set; }

    public int? KkonSpecRecno { get; set; }

    public bool? KkonIptal { get; set; }

    public short? KkonFileid { get; set; }

    public bool? KkonHidden { get; set; }

    public bool? KkonKilitli { get; set; }

    public bool? KkonDegisti { get; set; }

    public int? KkonChecksum { get; set; }

    public short? KkonCreateUser { get; set; }

    public DateTime KkonCreateDate { get; set; }

    public short? KkonLastupUser { get; set; }

    public DateTime? KkonLastupDate { get; set; }

    public string? KkonSpecial1 { get; set; }

    public string? KkonSpecial2 { get; set; }

    public string? KkonSpecial3 { get; set; }

    public string? KkonKod { get; set; }

    public string? KkonIsmi { get; set; }
}
