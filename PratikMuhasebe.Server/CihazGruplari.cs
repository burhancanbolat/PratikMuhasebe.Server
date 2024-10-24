using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CihazGruplari
{
    public Guid CgGuid { get; set; }

    public short CgDbcno { get; set; }

    public int? CgSpecRecno { get; set; }

    public bool? CgIptal { get; set; }

    public short? CgFileid { get; set; }

    public bool? CgHidden { get; set; }

    public bool? CgKilitli { get; set; }

    public bool? CgDegisti { get; set; }

    public int? CgChecksum { get; set; }

    public short? CgCreateUser { get; set; }

    public DateTime CgCreateDate { get; set; }

    public short? CgLastupUser { get; set; }

    public DateTime? CgLastupDate { get; set; }

    public string? CgSpecial1 { get; set; }

    public string? CgSpecial2 { get; set; }

    public string? CgSpecial3 { get; set; }

    public string? CgKodu { get; set; }

    public string? CgAciklama { get; set; }
}
