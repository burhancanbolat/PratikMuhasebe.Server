using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokAnahammaddeleri
{
    public Guid AhmGuid { get; set; }

    public short AhmDbcno { get; set; }

    public int? AhmSpecRecno { get; set; }

    public bool? AhmIptal { get; set; }

    public short? AhmFileid { get; set; }

    public bool? AhmHidden { get; set; }

    public bool? AhmKilitli { get; set; }

    public bool? AhmDegisti { get; set; }

    public int? AhmCheckSum { get; set; }

    public short? AhmCreateUser { get; set; }

    public DateTime AhmCreateDate { get; set; }

    public short? AhmLastupUser { get; set; }

    public DateTime? AhmLastupDate { get; set; }

    public string? AhmSpecial1 { get; set; }

    public string? AhmSpecial2 { get; set; }

    public string? AhmSpecial3 { get; set; }

    public string? AhmKodu { get; set; }

    public string? AhmIsmi { get; set; }
}
