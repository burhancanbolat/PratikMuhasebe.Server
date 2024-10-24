using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HareketGrubu2
{
    public Guid Hg2Guid { get; set; }

    public short Hg2Dbcno { get; set; }

    public int? Hg2SpecRecno { get; set; }

    public bool? Hg2Iptal { get; set; }

    public short? Hg2Fileid { get; set; }

    public bool? Hg2Hidden { get; set; }

    public bool? Hg2Kilitli { get; set; }

    public bool? Hg2Degisti { get; set; }

    public int? Hg2Checksum { get; set; }

    public short? Hg2CreateUser { get; set; }

    public DateTime Hg2CreateDate { get; set; }

    public short? Hg2LastupUser { get; set; }

    public DateTime? Hg2LastupDate { get; set; }

    public string? Hg2Special1 { get; set; }

    public string? Hg2Special2 { get; set; }

    public string? Hg2Special3 { get; set; }

    public string? Hg2Kod { get; set; }

    public string? Hg2Isim { get; set; }

    public string? Hg2Muhartikeli { get; set; }
}
