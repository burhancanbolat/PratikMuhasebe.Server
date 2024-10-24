using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ArizaGruplari
{
    public Guid AgrGuid { get; set; }

    public short AgrDbcno { get; set; }

    public int? AgrSpecRecno { get; set; }

    public bool? AgrIptal { get; set; }

    public short? AgrFileid { get; set; }

    public bool? AgrHidden { get; set; }

    public bool? AgrKilitli { get; set; }

    public bool? AgrDegisti { get; set; }

    public int? AgrChecksum { get; set; }

    public short? AgrCreateUser { get; set; }

    public DateTime AgrCreateDate { get; set; }

    public short? AgrLastupUser { get; set; }

    public DateTime? AgrLastupDate { get; set; }

    public string? AgrSpecial1 { get; set; }

    public string? AgrSpecial2 { get; set; }

    public string? AgrSpecial3 { get; set; }

    public string? AgrKodu { get; set; }

    public string? AgrAdi { get; set; }
}
