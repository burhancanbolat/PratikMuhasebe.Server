using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ETicaretUrunEsleme
{
    public Guid EuGuid { get; set; }

    public short EuDbcno { get; set; }

    public int? EuSpecRecno { get; set; }

    public bool? EuIptal { get; set; }

    public short? EuFileid { get; set; }

    public bool? EuHidden { get; set; }

    public bool? EuKilitli { get; set; }

    public bool? EuDegisti { get; set; }

    public int? EuChecksum { get; set; }

    public short? EuCreateUser { get; set; }

    public DateTime EuCreateDate { get; set; }

    public short? EuLastupUser { get; set; }

    public DateTime? EuLastupDate { get; set; }

    public string? EuSpecial1 { get; set; }

    public string? EuSpecial2 { get; set; }

    public string? EuSpecial3 { get; set; }

    public string? EuEticaretPlatformId { get; set; }

    public string? EuEticaretUrunId { get; set; }

    public string? EuEticaretVendorId { get; set; }

    public string? EuEticaretBarkodu { get; set; }

    public string? EuEticaretUrunAdi { get; set; }

    public string? EuStokKodu { get; set; }

    public byte? EuBirimPntr { get; set; }
}
