using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EFaturaTemelItiraz
{
    public Guid EftGuid { get; set; }

    public short EftDbcno { get; set; }

    public int? EftSpecRecno { get; set; }

    public bool? EftIptal { get; set; }

    public short? EftFileid { get; set; }

    public bool? EftHidden { get; set; }

    public bool? EftKilitli { get; set; }

    public bool? EftDegisti { get; set; }

    public int? EftChecksum { get; set; }

    public short? EftCreateUser { get; set; }

    public DateTime EftCreateDate { get; set; }

    public short? EftLastupUser { get; set; }

    public DateTime? EftLastupDate { get; set; }

    public string? EftSpecial1 { get; set; }

    public string? EftSpecial2 { get; set; }

    public string? EftSpecial3 { get; set; }

    public string? EftZarfId { get; set; }

    public string? EftUuid { get; set; }

    public string? EftFaturaNo { get; set; }

    public string? EftVkn { get; set; }

    public byte? EftPozisyon { get; set; }

    public byte? EftKepNoter { get; set; }

    public DateTime? EftBelgeTarihi { get; set; }

    public string? EftFaturaTur { get; set; }

    public string? EftCariUnvan { get; set; }

    public string? EftTransactionUidd { get; set; }

    public string? EftAciklama { get; set; }

    public byte? EftImageTip { get; set; }
}
