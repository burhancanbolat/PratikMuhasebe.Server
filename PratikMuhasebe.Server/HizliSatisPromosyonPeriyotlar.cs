using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizliSatisPromosyonPeriyotlar
{
    public Guid HsppGuid { get; set; }

    public short HsppDbcno { get; set; }

    public int? HsppSpecRecno { get; set; }

    public bool? HsppIptal { get; set; }

    public short? HsppFileid { get; set; }

    public bool? HsppHidden { get; set; }

    public bool? HsppKilitli { get; set; }

    public bool? HsppDegisti { get; set; }

    public int? HsppChecksum { get; set; }

    public short? HsppCreateUser { get; set; }

    public DateTime HsppCreateDate { get; set; }

    public short? HsppLastupUser { get; set; }

    public DateTime? HsppLastupDate { get; set; }

    public string? HsppSpecial1 { get; set; }

    public string? HsppSpecial2 { get; set; }

    public string? HsppSpecial3 { get; set; }

    public string HsppPromosyonKodu { get; set; } = null!;

    public DateTime HsppBaslangicTarihi { get; set; }

    public DateTime HsppBitisTarihi { get; set; }

    public bool HsppPazartesi { get; set; }

    public bool HsppSali { get; set; }

    public bool HsppCarsamba { get; set; }

    public bool HsppPersembe { get; set; }

    public bool HsppCuma { get; set; }

    public bool HsppCumartesi { get; set; }

    public bool HsppPazar { get; set; }
}
