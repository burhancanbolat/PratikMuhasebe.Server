using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokAnaGruplari
{
    public Guid SanGuid { get; set; }

    public short SanDbcno { get; set; }

    public int? SanSpecRecno { get; set; }

    public bool? SanIptal { get; set; }

    public short? SanFileid { get; set; }

    public bool? SanHidden { get; set; }

    public bool? SanKilitli { get; set; }

    public bool? SanDegisti { get; set; }

    public int? SanChecksum { get; set; }

    public short? SanCreateUser { get; set; }

    public DateTime SanCreateDate { get; set; }

    public short? SanLastupUser { get; set; }

    public DateTime? SanLastupDate { get; set; }

    public string? SanSpecial1 { get; set; }

    public string? SanSpecial2 { get; set; }

    public string? SanSpecial3 { get; set; }

    public string? SanKod { get; set; }

    public string? SanIsim { get; set; }
}
