using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelBolgeleri
{
    public Guid PblGuid { get; set; }

    public short PblDbcno { get; set; }

    public int? PblSpecRecno { get; set; }

    public bool? PblIptal { get; set; }

    public short? PblFileid { get; set; }

    public bool? PblHidden { get; set; }

    public bool? PblKilitli { get; set; }

    public bool? PblDegisti { get; set; }

    public int? PblChecksum { get; set; }

    public short? PblCreateUser { get; set; }

    public DateTime PblCreateDate { get; set; }

    public short? PblLastupUser { get; set; }

    public DateTime? PblLastupDate { get; set; }

    public string? PblSpecial1 { get; set; }

    public string? PblSpecial2 { get; set; }

    public string? PblSpecial3 { get; set; }

    public string? PblBolgeKodu { get; set; }

    public string? PblBolgeAdi { get; set; }
}
