using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapGruplari
{
    public Guid CrgGuid { get; set; }

    public short CrgDbcno { get; set; }

    public int? CrgSpecRecno { get; set; }

    public bool? CrgIptal { get; set; }

    public short? CrgFileid { get; set; }

    public bool? CrgHidden { get; set; }

    public bool? CrgKilitli { get; set; }

    public bool? CrgDegisti { get; set; }

    public int? CrgCheckSum { get; set; }

    public short? CrgCreateUser { get; set; }

    public DateTime CrgCreateDate { get; set; }

    public short? CrgLastupUser { get; set; }

    public DateTime? CrgLastupDate { get; set; }

    public string? CrgSpecial1 { get; set; }

    public string? CrgSpecial2 { get; set; }

    public string? CrgSpecial3 { get; set; }

    public string? CrgKod { get; set; }

    public string? CrgIsim { get; set; }

    public string? CrgMuhasebeKodu { get; set; }
}
