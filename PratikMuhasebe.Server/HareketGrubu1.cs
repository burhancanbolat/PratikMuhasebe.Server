using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HareketGrubu1
{
    public Guid Hg1Guid { get; set; }

    public short Hg1Dbcno { get; set; }

    public int? Hg1SpecRecno { get; set; }

    public bool? Hg1Iptal { get; set; }

    public short? Hg1Fileid { get; set; }

    public bool? Hg1Hidden { get; set; }

    public bool? Hg1Kilitli { get; set; }

    public bool? Hg1Degisti { get; set; }

    public int? Hg1Checksum { get; set; }

    public short? Hg1CreateUser { get; set; }

    public DateTime Hg1CreateDate { get; set; }

    public short? Hg1LastupUser { get; set; }

    public DateTime? Hg1LastupDate { get; set; }

    public string? Hg1Special1 { get; set; }

    public string? Hg1Special2 { get; set; }

    public string? Hg1Special3 { get; set; }

    public string? Hg1Kod { get; set; }

    public string? Hg1Isim { get; set; }

    public string? Hg1Muhartikeli { get; set; }
}
