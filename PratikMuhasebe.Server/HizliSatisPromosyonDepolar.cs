using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizliSatisPromosyonDepolar
{
    public Guid HspdGuid { get; set; }

    public short HspdDbcno { get; set; }

    public int? HspdSpecRecno { get; set; }

    public bool? HspdIptal { get; set; }

    public short? HspdFileid { get; set; }

    public bool? HspdHidden { get; set; }

    public bool? HspdKilitli { get; set; }

    public bool? HspdDegisti { get; set; }

    public int? HspdChecksum { get; set; }

    public short? HspdCreateUser { get; set; }

    public DateTime HspdCreateDate { get; set; }

    public short? HspdLastupUser { get; set; }

    public DateTime? HspdLastupDate { get; set; }

    public string? HspdSpecial1 { get; set; }

    public string? HspdSpecial2 { get; set; }

    public string? HspdSpecial3 { get; set; }

    public string HspdPromosyonKodu { get; set; } = null!;

    public int HspdDepoNo { get; set; }
}
