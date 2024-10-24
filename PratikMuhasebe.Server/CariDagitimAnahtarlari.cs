using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariDagitimAnahtarlari
{
    public Guid CdaganahGuid { get; set; }

    public short CdaganahDbcno { get; set; }

    public int? CdaganahSpecRecno { get; set; }

    public bool? CdaganahIptal { get; set; }

    public short? CdaganahFileid { get; set; }

    public bool? CdaganahHidden { get; set; }

    public bool? CdaganahKilitli { get; set; }

    public bool? CdaganahDegisti { get; set; }

    public int? CdaganahChecksum { get; set; }

    public short? CdaganahCreateUser { get; set; }

    public DateTime CdaganahCreateDate { get; set; }

    public short? CdaganahLastupUser { get; set; }

    public DateTime? CdaganahLastupDate { get; set; }

    public string? CdaganahSpecial1 { get; set; }

    public string? CdaganahSpecial2 { get; set; }

    public string? CdaganahSpecial3 { get; set; }

    public string? CdaganahKod { get; set; }

    public DateTime? CdaganahGecerliliktarihi { get; set; }

    public int? CdaganahSatirno { get; set; }

    public string? CdaganahIsmi { get; set; }

    public string? CdaganahHesapkodu { get; set; }

    public string? CdaganahProje { get; set; }

    public string? CdaganahSrmmrk { get; set; }

    public double? CdaganahPuan { get; set; }
}
