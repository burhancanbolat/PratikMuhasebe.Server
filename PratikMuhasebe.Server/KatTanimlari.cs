using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KatTanimlari
{
    public Guid KatGuid { get; set; }

    public short KatDbcno { get; set; }

    public int? KatSpecRecno { get; set; }

    public bool? KatIptal { get; set; }

    public short? KatFileid { get; set; }

    public bool? KatHidden { get; set; }

    public bool? KatKilitli { get; set; }

    public bool? KatDegisti { get; set; }

    public int? KatChecksum { get; set; }

    public short? KatCreateUser { get; set; }

    public DateTime KatCreateDate { get; set; }

    public short? KatLastupUser { get; set; }

    public DateTime? KatLastupDate { get; set; }

    public string? KatSpecial1 { get; set; }

    public string? KatSpecial2 { get; set; }

    public string? KatSpecial3 { get; set; }

    public string? KatSitekod { get; set; }

    public string? KatBlokkod { get; set; }

    public string? KatKod { get; set; }

    public string? KatIsmi { get; set; }
}
