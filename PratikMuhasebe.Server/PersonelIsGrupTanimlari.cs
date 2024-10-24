using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelIsGrupTanimlari
{
    public Guid IgGuid { get; set; }

    public short IgDbcno { get; set; }

    public int? IgSpecRecno { get; set; }

    public bool? IgIptal { get; set; }

    public short? IgFileid { get; set; }

    public bool? IgHidden { get; set; }

    public bool? IgKilitli { get; set; }

    public bool? IgDegisti { get; set; }

    public int? IgChecksum { get; set; }

    public short? IgCreateUser { get; set; }

    public DateTime IgCreateDate { get; set; }

    public short? IgLastupUser { get; set; }

    public DateTime? IgLastupDate { get; set; }

    public string? IgSpecial1 { get; set; }

    public string? IgSpecial2 { get; set; }

    public string? IgSpecial3 { get; set; }

    public string? IgKod { get; set; }

    public string? IgAdi { get; set; }
}
