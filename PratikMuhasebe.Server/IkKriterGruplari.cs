using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IkKriterGruplari
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

    public byte? IkgTipi { get; set; }

    public string? IkgKod { get; set; }

    public string? IkgAdi { get; set; }

    public string? IkgKriterKodu { get; set; }
}
