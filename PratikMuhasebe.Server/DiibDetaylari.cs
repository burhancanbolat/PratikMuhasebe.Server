using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DiibDetaylari
{
    public Guid DdGuid { get; set; }

    public short DdDbcno { get; set; }

    public int? DdSpecRecNo { get; set; }

    public bool? DdIptal { get; set; }

    public short? DdFileid { get; set; }

    public bool? DdHidden { get; set; }

    public bool? DdKilitli { get; set; }

    public bool? DdDegisti { get; set; }

    public int? DdChecksum { get; set; }

    public short? DdCreateUser { get; set; }

    public DateTime DdCreateDate { get; set; }

    public short? DdLastupUser { get; set; }

    public DateTime? DdLastupDate { get; set; }

    public string? DdSpecial1 { get; set; }

    public string? DdSpecial2 { get; set; }

    public string? DdSpecial3 { get; set; }

    public string? DdNosu { get; set; }

    public byte? DdTip { get; set; }

    public int? DdSirano { get; set; }

    public string? DdGtip { get; set; }

    public double? DdMiktar { get; set; }

    public double? DdUsdTutar { get; set; }

    public double? DdTamUsdTutar { get; set; }

    public double? DdTamAbMiktar { get; set; }

    public double? DdTamAuMiktar { get; set; }

    public double? DdTam3ulkeMiktar { get; set; }

    public double? DdTamDahiliMiktar { get; set; }

    public double? DdMiktar2 { get; set; }

    public double? DdTamAbMiktar2 { get; set; }

    public double? DdTamAuMiktar2 { get; set; }

    public double? DdTam3ulkeMiktar2 { get; set; }

    public double? DdTamDahiliMiktar2 { get; set; }

    public string? DdKapEsya { get; set; }
}
