using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class YatirimTesvikleri
{
    public Guid YttsGuid { get; set; }

    public short YttsDbcno { get; set; }

    public int? YttsSpecRecNo { get; set; }

    public bool? YttsIptal { get; set; }

    public short? YttsFileid { get; set; }

    public bool? YttsHidden { get; set; }

    public bool? YttsKilitli { get; set; }

    public bool? YttsDegisti { get; set; }

    public int? YttsChecksum { get; set; }

    public short? YttsCreateUser { get; set; }

    public DateTime YttsCreateDate { get; set; }

    public short? YttsLastupUser { get; set; }

    public DateTime? YttsLastupDate { get; set; }

    public string? YttsSpecial1 { get; set; }

    public string? YttsSpecial2 { get; set; }

    public string? YttsSpecial3 { get; set; }

    public string YttsKodu { get; set; } = null!;

    public string? YttsIsmi { get; set; }

    public string? YttsMuhkodartikeli { get; set; }

    public string? YttsYurticiMuhartikeli { get; set; }

    public string? YttsYurtdisiMuhartikeli { get; set; }

    public DateTime? YttsTarihi { get; set; }

    public string? YttsSayisi { get; set; }

    public byte? YttsFobdoviz { get; set; }
}
