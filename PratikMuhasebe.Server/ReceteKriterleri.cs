using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ReceteKriterleri
{
    public Guid RkGuid { get; set; }

    public short RkDbcno { get; set; }

    public int? RkSpecRecno { get; set; }

    public bool? RkIptal { get; set; }

    public short? RkFileid { get; set; }

    public bool? RkHidden { get; set; }

    public bool? RkKilitli { get; set; }

    public bool? RkDegisti { get; set; }

    public int? RkChecksum { get; set; }

    public short? RkCreateUser { get; set; }

    public DateTime RkCreateDate { get; set; }

    public short? RkLastupUser { get; set; }

    public DateTime? RkLastupDate { get; set; }

    public string? RkSpecial1 { get; set; }

    public string? RkSpecial2 { get; set; }

    public string? RkSpecial3 { get; set; }

    public Guid? RkReceteUid { get; set; }

    public int? RkSatirno { get; set; }

    public byte? RkTablo { get; set; }

    public string? RkAlanAdi { get; set; }

    public byte? RkIslem { get; set; }

    public string? RkStringdata { get; set; }

    public byte? RkBaglantiTipi { get; set; }
}
