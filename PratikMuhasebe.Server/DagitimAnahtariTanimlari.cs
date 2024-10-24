using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DagitimAnahtariTanimlari
{
    public Guid DanGuid { get; set; }

    public short DanDbcno { get; set; }

    public int? DanSpecRecno { get; set; }

    public bool? DanIptal { get; set; }

    public short? DanFileid { get; set; }

    public bool? DanHidden { get; set; }

    public bool? DanKilitli { get; set; }

    public bool? DanDegisti { get; set; }

    public int? DanChecksum { get; set; }

    public short? DanCreateUser { get; set; }

    public DateTime DanCreateDate { get; set; }

    public short? DanLastupUser { get; set; }

    public DateTime? DanLastupDate { get; set; }

    public string? DanSpecial1 { get; set; }

    public string? DanSpecial2 { get; set; }

    public string? DanSpecial3 { get; set; }

    public string? DanKod { get; set; }

    public DateTime? DanGecerliliktarihi { get; set; }

    public int? DanSatirno { get; set; }

    public string? DanIsmi { get; set; }

    public byte? DanTipi { get; set; }

    public string? DanHesapKodu { get; set; }

    public string? DanSrmmrkKodu { get; set; }

    public string? DanProjeKodu { get; set; }

    public double? DanPuan { get; set; }

    public byte? DanPuantipi { get; set; }
}
