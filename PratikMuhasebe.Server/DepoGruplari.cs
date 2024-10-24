using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DepoGruplari
{
    public Guid DgrGuid { get; set; }

    public short DgrDbcno { get; set; }

    public int? DgrSpecRecno { get; set; }

    public bool? DgrIptal { get; set; }

    public short? DgrFileid { get; set; }

    public bool? DgrHidden { get; set; }

    public bool? DgrKilitli { get; set; }

    public bool? DgrDegisti { get; set; }

    public int? DgrChecksum { get; set; }

    public short? DgrCreateUser { get; set; }

    public DateTime DgrCreateDate { get; set; }

    public short? DgrLastupUser { get; set; }

    public DateTime? DgrLastupDate { get; set; }

    public string? DgrSpecial1 { get; set; }

    public string? DgrSpecial2 { get; set; }

    public string? DgrSpecial3 { get; set; }

    public string? DgrKod { get; set; }

    public string? DgrIsmi { get; set; }
}
