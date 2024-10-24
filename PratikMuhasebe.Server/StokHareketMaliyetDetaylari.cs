using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokHareketMaliyetDetaylari
{
    public Guid ShdGuid { get; set; }

    public short ShdDbcno { get; set; }

    public int? ShdSpecRecno { get; set; }

    public bool? ShdIptal { get; set; }

    public short? ShdFileid { get; set; }

    public bool? ShdHidden { get; set; }

    public bool? ShdKilitli { get; set; }

    public bool? ShdDegisti { get; set; }

    public int? ShdChecksum { get; set; }

    public short? ShdCreateUser { get; set; }

    public DateTime ShdCreateDate { get; set; }

    public short? ShdLastupUser { get; set; }

    public DateTime? ShdLastupDate { get; set; }

    public string? ShdSpecial1 { get; set; }

    public string? ShdSpecial2 { get; set; }

    public string? ShdSpecial3 { get; set; }

    public byte? ShdTipi { get; set; }

    public string? ShdHesapKodu { get; set; }

    public string? ShdSrmMerkezi { get; set; }

    public double? ShdYuklenenMaliyetAna { get; set; }

    public double? ShdYuklenenMaliyetAlt { get; set; }

    public double? ShdYuklenenMaliyetOrj { get; set; }

    public Guid? ShdStokHareketUid { get; set; }

    public Guid? ShdTuketimStokGirisUid { get; set; }

    public double? ShdTuketimStokMiktari { get; set; }
}
