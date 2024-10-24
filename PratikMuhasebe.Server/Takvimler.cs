using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Takvimler
{
    public Guid TakvimGuid { get; set; }

    public short TakvimDbcno { get; set; }

    public int? TakvimSpecRecno { get; set; }

    public bool? TakvimIptal { get; set; }

    public short? TakvimFileid { get; set; }

    public bool? TakvimHidden { get; set; }

    public bool? TakvimKilitli { get; set; }

    public bool? TakvimDegisti { get; set; }

    public int? TakvimCheckSum { get; set; }

    public short? TakvimCreateUser { get; set; }

    public DateTime TakvimCreateDate { get; set; }

    public short? TakvimLastupUser { get; set; }

    public DateTime? TakvimLastupDate { get; set; }

    public string? TakvimSpecial1 { get; set; }

    public string? TakvimSpecial2 { get; set; }

    public string? TakvimSpecial3 { get; set; }

    public string? TakvimKodu { get; set; }

    public string? TakvimIsmi { get; set; }
}
