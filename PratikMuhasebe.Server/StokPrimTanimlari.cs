using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokPrimTanimlari
{
    public Guid PrimGuid { get; set; }

    public short PrimDbcno { get; set; }

    public int? PrimSpecRecno { get; set; }

    public bool? PrimIptal { get; set; }

    public short? PrimFileid { get; set; }

    public bool? PrimHidden { get; set; }

    public bool? PrimKilitli { get; set; }

    public bool? PrimDegisti { get; set; }

    public int? PrimChecksum { get; set; }

    public short? PrimCreateUser { get; set; }

    public DateTime PrimCreateDate { get; set; }

    public short? PrimLastupUser { get; set; }

    public DateTime? PrimLastupDate { get; set; }

    public string? PrimSpecial1 { get; set; }

    public string? PrimSpecial2 { get; set; }

    public string? PrimSpecial3 { get; set; }

    public string? PrimKod { get; set; }

    public string? PrimAdi { get; set; }

    public int? PrimSatirno { get; set; }

    public double? PrimYuzdesi { get; set; }

    public double? PrimMinIsk { get; set; }

    public double? PrimMaxIsk { get; set; }

    public int? PrimMinVadeSapma { get; set; }

    public int? PrimMaxVadeSapma { get; set; }

    public byte? PrimHesapSekli { get; set; }

    public bool? PrimOdemeyeBagli { get; set; }
}
