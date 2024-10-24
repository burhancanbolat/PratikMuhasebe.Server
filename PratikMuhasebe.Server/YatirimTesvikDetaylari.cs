using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class YatirimTesvikDetaylari
{
    public Guid YtdGuid { get; set; }

    public short YtdDbcno { get; set; }

    public int? YtdSpecRecno { get; set; }

    public bool? YtdIptal { get; set; }

    public short? YtdFileid { get; set; }

    public bool? YtdHidden { get; set; }

    public bool? YtdKilitli { get; set; }

    public bool? YtdDegisti { get; set; }

    public int? YtdChecksum { get; set; }

    public short? YtdCreateUser { get; set; }

    public DateTime YtdCreateDate { get; set; }

    public short? YtdLastupUser { get; set; }

    public DateTime? YtdLastupDate { get; set; }

    public string? YtdSpecial1 { get; set; }

    public string? YtdSpecial2 { get; set; }

    public string? YtdSpecial3 { get; set; }

    public string? YtdYtkodu { get; set; }

    public int? YtdSatirNo { get; set; }

    public byte? YtdCinsi { get; set; }

    public string? YtdCinsKodu { get; set; }

    public byte? YtdTeminCinsi { get; set; }

    public double? YtdMiktar { get; set; }

    public double? YtdTutari { get; set; }

    public double? YtdKdvtutari { get; set; }

    public bool? YtdKdvistKapFl { get; set; }

    public byte? YtdMenseDoviz { get; set; }

    public double? YtdMenseKuru { get; set; }

    public double? YtdFobKuru { get; set; }

    public string? YtdMuhkodartikeli { get; set; }

    public double? YtdFaturalasmismiktar { get; set; }
}
