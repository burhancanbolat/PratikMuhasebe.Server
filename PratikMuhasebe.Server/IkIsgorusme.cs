using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IkIsgorusme
{
    public Guid IkgGuid { get; set; }

    public short IkgDbcno { get; set; }

    public int? IkgSpecRecno { get; set; }

    public bool? IkgIptal { get; set; }

    public short? IkgFileid { get; set; }

    public bool? IkgHidden { get; set; }

    public bool? IkgKilitli { get; set; }

    public bool? IkgDegisti { get; set; }

    public int? IkgChecksum { get; set; }

    public short? IkgCreateUser { get; set; }

    public DateTime IkgCreateDate { get; set; }

    public short? IkgLastupUser { get; set; }

    public DateTime? IkgLastupDate { get; set; }

    public string? IkgSpecial1 { get; set; }

    public string? IkgSpecial2 { get; set; }

    public string? IkgSpecial3 { get; set; }

    public int? IkgFirmano { get; set; }

    public int? IkgSubeno { get; set; }

    public DateTime? IkgTarih { get; set; }

    public Guid? IkgBasUid { get; set; }

    public string? IkgPersKod { get; set; }

    public int? IkgSatirno { get; set; }

    public string? IkgIkdKodu { get; set; }

    public double? IkgPuan { get; set; }

    public string? IkgDegerNotu { get; set; }

    public string? IkgIlanKodu { get; set; }

    public string? IkgKadroKodu { get; set; }
}
