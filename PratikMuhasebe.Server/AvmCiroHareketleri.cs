using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmCiroHareketleri
{
    public Guid AchGuid { get; set; }

    public short AchDbcno { get; set; }

    public int? AchSpecRecNo { get; set; }

    public bool? AchIptal { get; set; }

    public short? AchFileid { get; set; }

    public bool? AchHidden { get; set; }

    public bool? AchKilitli { get; set; }

    public bool? AchDegisti { get; set; }

    public int? AchChecksum { get; set; }

    public short? AchCreateUser { get; set; }

    public DateTime AchCreateDate { get; set; }

    public short? AchLastupUser { get; set; }

    public DateTime? AchLastupDate { get; set; }

    public string? AchSpecial1 { get; set; }

    public string? AchSpecial2 { get; set; }

    public string? AchSpecial3 { get; set; }

    public int? AchFirmano { get; set; }

    public int? AchSubeno { get; set; }

    public string? AchCariKodu { get; set; }

    public string? AchKiraKodu { get; set; }

    public DateTime? AchTarih { get; set; }

    public int? AchFisSayisi { get; set; }

    public double? AchTutar { get; set; }

    public Guid? AchChUid { get; set; }

    public Guid? AchCh2Uid { get; set; }

    public Guid? AchCh3Uid { get; set; }

    public int? AchFisSayisi2 { get; set; }

    public double? AchTutar2 { get; set; }

    public int? AchFisSayisi3 { get; set; }

    public double? AchTutar3 { get; set; }
}
