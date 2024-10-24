using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapTasitPlakalari
{
    public Guid PlkGuid { get; set; }

    public short PlkDbcno { get; set; }

    public int? PlkSpecRecno { get; set; }

    public bool? PlkIptal { get; set; }

    public short? PlkFileid { get; set; }

    public bool? PlkHidden { get; set; }

    public bool? PlkKilitli { get; set; }

    public bool? PlkDegisti { get; set; }

    public int? PlkChecksum { get; set; }

    public short? PlkCreateUser { get; set; }

    public DateTime PlkCreateDate { get; set; }

    public short? PlkLastupUser { get; set; }

    public DateTime? PlkLastupDate { get; set; }

    public string? PlkSpecial1 { get; set; }

    public string? PlkSpecial2 { get; set; }

    public string? PlkSpecial3 { get; set; }

    public string? PlkKod { get; set; }

    public string? PlkArac { get; set; }

    public string? PlkMusterikodu { get; set; }
}
