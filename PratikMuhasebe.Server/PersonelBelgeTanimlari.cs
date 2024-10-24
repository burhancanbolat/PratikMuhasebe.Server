using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelBelgeTanimlari
{
    public Guid BelGuid { get; set; }

    public short BelDbcno { get; set; }

    public int? BelSpecRecno { get; set; }

    public bool? BelIptal { get; set; }

    public short? BelFileid { get; set; }

    public bool? BelHidden { get; set; }

    public bool? BelKilitli { get; set; }

    public bool? BelDegisti { get; set; }

    public int? BelChecksum { get; set; }

    public short? BelCreateUser { get; set; }

    public DateTime BelCreateDate { get; set; }

    public short? BelLastupUser { get; set; }

    public DateTime? BelLastupDate { get; set; }

    public string? BelSpecial1 { get; set; }

    public string? BelSpecial2 { get; set; }

    public string? BelSpecial3 { get; set; }

    public string? BelKod { get; set; }

    public string? BelIsim { get; set; }
}
