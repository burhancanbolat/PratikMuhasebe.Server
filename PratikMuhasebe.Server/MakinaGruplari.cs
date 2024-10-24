using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MakinaGruplari
{
    public Guid MakgGuid { get; set; }

    public short MakgDbcno { get; set; }

    public int? MakgSpecRecno { get; set; }

    public bool? MakgIptal { get; set; }

    public short? MakgFileid { get; set; }

    public bool? MakgHidden { get; set; }

    public bool? MakgKilitli { get; set; }

    public bool? MakgDegisti { get; set; }

    public int? MakgChecksum { get; set; }

    public short? MakgCreateUser { get; set; }

    public DateTime MakgCreateDate { get; set; }

    public short? MakgLastupUser { get; set; }

    public DateTime? MakgLastupDate { get; set; }

    public string? MakgSpecial1 { get; set; }

    public string? MakgSpecial2 { get; set; }

    public string? MakgSpecial3 { get; set; }

    public string? MakgKodu { get; set; }

    public string? MakgAciklama { get; set; }
}
