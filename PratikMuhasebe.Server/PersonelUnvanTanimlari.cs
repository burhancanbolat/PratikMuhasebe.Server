using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelUnvanTanimlari
{
    public Guid UnGuid { get; set; }

    public short UnDbcno { get; set; }

    public int? UnSpecRecno { get; set; }

    public bool? UnIptal { get; set; }

    public short? UnFileid { get; set; }

    public bool? UnHidden { get; set; }

    public bool? UnKilitli { get; set; }

    public bool? UnDegisti { get; set; }

    public int? UnChecksum { get; set; }

    public short? UnCreateUser { get; set; }

    public DateTime UnCreateDate { get; set; }

    public short? UnLastupUser { get; set; }

    public DateTime? UnLastupDate { get; set; }

    public string? UnSpecial1 { get; set; }

    public string? UnSpecial2 { get; set; }

    public string? UnSpecial3 { get; set; }

    public string? UnKod { get; set; }

    public string? UnAciklama { get; set; }
}
