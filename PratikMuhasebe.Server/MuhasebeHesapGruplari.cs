using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MuhasebeHesapGruplari
{
    public Guid MhgGuid { get; set; }

    public short MhgDbcno { get; set; }

    public int? MhgSpecRecno { get; set; }

    public bool? MhgIptal { get; set; }

    public short? MhgFileid { get; set; }

    public bool? MhgHidden { get; set; }

    public bool? MhgKilitli { get; set; }

    public bool? MhgDegisti { get; set; }

    public int? MhgChecksum { get; set; }

    public short? MhgCreateUser { get; set; }

    public DateTime MhgCreateDate { get; set; }

    public short? MhgLastupUser { get; set; }

    public DateTime? MhgLastupDate { get; set; }

    public string? MhgSpecial1 { get; set; }

    public string? MhgSpecial2 { get; set; }

    public string? MhgSpecial3 { get; set; }

    public string? MhgKodu { get; set; }

    public string? MhgAciklama { get; set; }
}
