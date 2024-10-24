using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapBolgeleri
{
    public Guid BolGuid { get; set; }

    public short BolDbcno { get; set; }

    public int? BolSpecRecno { get; set; }

    public bool? BolIptal { get; set; }

    public short? BolFileid { get; set; }

    public bool? BolHidden { get; set; }

    public bool? BolKilitli { get; set; }

    public bool? BolDegisti { get; set; }

    public int? BolChecksum { get; set; }

    public short? BolCreateUser { get; set; }

    public DateTime BolCreateDate { get; set; }

    public short? BolLastupUser { get; set; }

    public DateTime? BolLastupDate { get; set; }

    public string? BolSpecial1 { get; set; }

    public string? BolSpecial2 { get; set; }

    public string? BolSpecial3 { get; set; }

    public string? BolKod { get; set; }

    public string? BolIsmi { get; set; }
}
