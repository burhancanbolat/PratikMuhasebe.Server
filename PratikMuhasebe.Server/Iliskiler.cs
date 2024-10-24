using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Iliskiler
{
    public Guid IlGuid { get; set; }

    public short IlDbcno { get; set; }

    public int? IlSpecRecno { get; set; }

    public bool? IlIptal { get; set; }

    public short? IlFileid { get; set; }

    public bool? IlHidden { get; set; }

    public bool? IlKilitli { get; set; }

    public bool? IlDegisti { get; set; }

    public int? IlChecksum { get; set; }

    public short? IlCreateUser { get; set; }

    public DateTime IlCreateDate { get; set; }

    public short? IlLastupUser { get; set; }

    public DateTime? IlLastupDate { get; set; }

    public string? IlSpecial1 { get; set; }

    public string? IlSpecial2 { get; set; }

    public string? IlSpecial3 { get; set; }

    public DateTime? IlBaszaman { get; set; }

    public DateTime? IlBitzaman { get; set; }

    public string? IlSorumluPersonel { get; set; }

    public byte? IlIliskiTipi { get; set; }

    public string? IlCarikodu { get; set; }

    public int? IlAdresNo { get; set; }

    public Guid? IlYetkiliUid { get; set; }

    public string? IlYetkiliadi { get; set; }

    public string? IlYer { get; set; }

    public string? IlKonu { get; set; }

    public string? IlRefno { get; set; }

    public string? IlProjekodu { get; set; }

    public byte? IlOncelik { get; set; }

    public byte? IlCariTipi { get; set; }
}
