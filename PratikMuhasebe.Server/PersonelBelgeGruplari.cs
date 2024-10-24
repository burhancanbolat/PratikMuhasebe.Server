using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelBelgeGruplari
{
    public Guid BgrGuid { get; set; }

    public short BgrDbcno { get; set; }

    public int? BgrSpecRecno { get; set; }

    public bool? BgrIptal { get; set; }

    public short? BgrFileid { get; set; }

    public bool? BgrHidden { get; set; }

    public bool? BgrKilitli { get; set; }

    public bool? BgrDegisti { get; set; }

    public int? BgrChecksum { get; set; }

    public short? BgrCreateUser { get; set; }

    public DateTime BgrCreateDate { get; set; }

    public short? BgrLastupUser { get; set; }

    public DateTime? BgrLastupDate { get; set; }

    public string? BgrSpecial1 { get; set; }

    public string? BgrSpecial2 { get; set; }

    public string? BgrSpecial3 { get; set; }

    public int? BgrFirmano { get; set; }

    public int? BgrSubeno { get; set; }

    public string? BgrKod { get; set; }

    public string? BgrIsim { get; set; }

    public string? BgrBelgeKod { get; set; }

    public bool? BgrZorunluFl { get; set; }
}
