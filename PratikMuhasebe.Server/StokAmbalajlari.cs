using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokAmbalajlari
{
    public Guid AmbGuid { get; set; }

    public short AmbDbcno { get; set; }

    public int? AmbSpecRecno { get; set; }

    public bool? AmbIptal { get; set; }

    public short? AmbFileid { get; set; }

    public bool? AmbHidden { get; set; }

    public bool? AmbKilitli { get; set; }

    public bool? AmbDegisti { get; set; }

    public int? AmbChecksum { get; set; }

    public short? AmbCreateUser { get; set; }

    public DateTime AmbCreateDate { get; set; }

    public short? AmbLastupUser { get; set; }

    public DateTime? AmbLastupDate { get; set; }

    public string? AmbSpecial1 { get; set; }

    public string? AmbSpecial2 { get; set; }

    public string? AmbSpecial3 { get; set; }

    public string? AmbKod { get; set; }

    public string? AmbIsmi { get; set; }

    public double? AmbMiktar { get; set; }

    public double? AmbDara { get; set; }

    public double? AmbFiyat { get; set; }
}
