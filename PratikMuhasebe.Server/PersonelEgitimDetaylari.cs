using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelEgitimDetaylari
{
    public Guid EdetGuid { get; set; }

    public short EdetDbcno { get; set; }

    public int? EdetSpecRecno { get; set; }

    public bool? EdetIptal { get; set; }

    public short? EdetFileid { get; set; }

    public bool? EdetHidden { get; set; }

    public bool? EdetKilitli { get; set; }

    public bool? EdetDegisti { get; set; }

    public int? EdetChecksum { get; set; }

    public short? EdetCreateUser { get; set; }

    public DateTime EdetCreateDate { get; set; }

    public short? EdetLastupUser { get; set; }

    public DateTime? EdetLastupDate { get; set; }

    public string? EdetSpecial1 { get; set; }

    public string? EdetSpecial2 { get; set; }

    public string? EdetSpecial3 { get; set; }

    public string? EdetKodu { get; set; }

    public byte? EdetDetaytipi { get; set; }

    public int? EdetSatirno { get; set; }

    public byte? EdetHartipi { get; set; }

    public string? EdetHarkodu { get; set; }

    public string? EdetAciklama { get; set; }

    public double? EdetMiktar { get; set; }

    public byte? EdetBirim { get; set; }

    public double? EdetTutar { get; set; }

    public byte? EdetDovizCinsi { get; set; }

    public double? EdetDovizKuru { get; set; }

    public string? EdetAegEvraknoSeri { get; set; }

    public int? EdetAegEvraknoSira { get; set; }
}
