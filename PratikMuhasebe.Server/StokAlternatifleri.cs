using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokAlternatifleri
{
    public Guid SaGuid { get; set; }

    public short SaDbcno { get; set; }

    public int? SaSpecRecno { get; set; }

    public bool? SaIptal { get; set; }

    public short? SaFileid { get; set; }

    public bool? SaHidden { get; set; }

    public bool? SaKilitli { get; set; }

    public bool? SaDegisti { get; set; }

    public int? SaChecksum { get; set; }

    public short? SaCreateUser { get; set; }

    public DateTime SaCreateDate { get; set; }

    public short? SaLastupUser { get; set; }

    public DateTime? SaLastupDate { get; set; }

    public string? SaSpecial1 { get; set; }

    public string? SaSpecial2 { get; set; }

    public string? SaSpecial3 { get; set; }

    public string? SaKod { get; set; }

    public string? SaAlternatifkod { get; set; }
}
