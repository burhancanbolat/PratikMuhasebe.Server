using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HareketGrubu3
{
    public Guid Hg3Guid { get; set; }

    public short Hg3Dbcno { get; set; }

    public int? Hg3SpecRecno { get; set; }

    public bool? Hg3Iptal { get; set; }

    public short? Hg3Fileid { get; set; }

    public bool? Hg3Hidden { get; set; }

    public bool? Hg3Kilitli { get; set; }

    public bool? Hg3Degisti { get; set; }

    public int? Hg3Checksum { get; set; }

    public short? Hg3CreateUser { get; set; }

    public DateTime Hg3CreateDate { get; set; }

    public short? Hg3LastupUser { get; set; }

    public DateTime? Hg3LastupDate { get; set; }

    public string? Hg3Special1 { get; set; }

    public string? Hg3Special2 { get; set; }

    public string? Hg3Special3 { get; set; }

    public string? Hg3Kod { get; set; }

    public string? Hg3Isim { get; set; }

    public string? Hg3Muhartikeli { get; set; }
}
