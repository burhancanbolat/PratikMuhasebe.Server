using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokAltGruplari
{
    public Guid StaGuid { get; set; }

    public short StaDbcno { get; set; }

    public int? StaSpecRecno { get; set; }

    public bool? StaIptal { get; set; }

    public short? StaFileid { get; set; }

    public bool? StaHidden { get; set; }

    public bool? StaKilitli { get; set; }

    public bool? StaDegisti { get; set; }

    public int? StaChecksum { get; set; }

    public short? StaCreateUser { get; set; }

    public DateTime StaCreateDate { get; set; }

    public short? StaLastupUser { get; set; }

    public DateTime? StaLastupDate { get; set; }

    public string? StaSpecial1 { get; set; }

    public string? StaSpecial2 { get; set; }

    public string? StaSpecial3 { get; set; }

    public string? StaKod { get; set; }

    public string? StaIsim { get; set; }

    public string? StaAnaGrupKod { get; set; }
}
