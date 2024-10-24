using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IstasyonAdalari
{
    public Guid AdaGuid { get; set; }

    public short AdaDbcno { get; set; }

    public int? AdaSpecRecno { get; set; }

    public bool? AdaIptal { get; set; }

    public short? AdaFileid { get; set; }

    public bool? AdaHidden { get; set; }

    public bool? AdaKilitli { get; set; }

    public bool? AdaDegisti { get; set; }

    public int? AdaChecksum { get; set; }

    public short? AdaCreateUser { get; set; }

    public DateTime AdaCreateDate { get; set; }

    public short? AdaLastupUser { get; set; }

    public DateTime? AdaLastupDate { get; set; }

    public string? AdaSpecial1 { get; set; }

    public string? AdaSpecial2 { get; set; }

    public string? AdaSpecial3 { get; set; }

    public string? AdaKod { get; set; }

    public string? AdaIsmi { get; set; }

    public string? AdaAciklama { get; set; }
}
