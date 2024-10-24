using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SikayetTanimlari
{
    public Guid SkytGuid { get; set; }

    public short SkytDbcno { get; set; }

    public int? SkytSpecRecno { get; set; }

    public bool? SkytIptal { get; set; }

    public short? SkytFileid { get; set; }

    public bool? SkytHidden { get; set; }

    public bool? SkytKilitli { get; set; }

    public bool? SkytDegisti { get; set; }

    public int? SkytChecksum { get; set; }

    public short? SkytCreateUser { get; set; }

    public DateTime SkytCreateDate { get; set; }

    public short? SkytLastupUser { get; set; }

    public DateTime? SkytLastupDate { get; set; }

    public string? SkytSpecial1 { get; set; }

    public string? SkytSpecial2 { get; set; }

    public string? SkytSpecial3 { get; set; }

    public string? SkytKod { get; set; }

    public string? SkytIsim { get; set; }

    public string? SkytPersonelKod { get; set; }
}
