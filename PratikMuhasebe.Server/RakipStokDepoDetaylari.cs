using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class RakipStokDepoDetaylari
{
    public Guid RsdpGuid { get; set; }

    public short RsdpDbcno { get; set; }

    public int? RsdpSpecRecno { get; set; }

    public bool? RsdpIptal { get; set; }

    public short? RsdpFileid { get; set; }

    public bool? RsdpHidden { get; set; }

    public bool? RsdpKilitli { get; set; }

    public bool? RsdpDegisti { get; set; }

    public int? RsdpChecksum { get; set; }

    public short? RsdpCreateUser { get; set; }

    public DateTime RsdpCreateDate { get; set; }

    public short? RsdpLastupUser { get; set; }

    public DateTime? RsdpLastupDate { get; set; }

    public string? RsdpSpecial1 { get; set; }

    public string? RsdpSpecial2 { get; set; }

    public string? RsdpSpecial3 { get; set; }

    public string? RsdpDepoKod { get; set; }

    public int? RsdpDepoNo { get; set; }

    public double? RsdpKarOrani { get; set; }

    public double? RsdpSatisfiat { get; set; }

    public byte? RsdpFiatDoviz { get; set; }

    public int? RsdpFiatOpno { get; set; }

    public string? RsdpFiatIskKod { get; set; }

    public bool? RsdpKdvdahil { get; set; }
}
