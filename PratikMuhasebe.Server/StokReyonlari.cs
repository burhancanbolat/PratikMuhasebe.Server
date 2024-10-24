using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokReyonlari
{
    public Guid RynGuid { get; set; }

    public short RynDbcno { get; set; }

    public int? RynSpecRecno { get; set; }

    public bool? RynIptal { get; set; }

    public short? RynFileid { get; set; }

    public bool? RynHidden { get; set; }

    public bool? RynKilitli { get; set; }

    public bool? RynDegisti { get; set; }

    public int? RynChecksum { get; set; }

    public short? RynCreateUser { get; set; }

    public DateTime RynCreateDate { get; set; }

    public short? RynLastupUser { get; set; }

    public DateTime? RynLastupDate { get; set; }

    public string? RynSpecial1 { get; set; }

    public string? RynSpecial2 { get; set; }

    public string? RynSpecial3 { get; set; }

    public string? RynKod { get; set; }

    public string? RynIsmi { get; set; }
}
