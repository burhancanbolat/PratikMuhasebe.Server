using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizliSatisPromosyonUrunleri
{
    public Guid HspuGuid { get; set; }

    public short HspuDbcno { get; set; }

    public int? HspuSpecRecno { get; set; }

    public bool? HspuIptal { get; set; }

    public short? HspuFileid { get; set; }

    public bool? HspuHidden { get; set; }

    public bool? HspuKilitli { get; set; }

    public bool? HspuDegisti { get; set; }

    public int? HspuChecksum { get; set; }

    public short? HspuCreateUser { get; set; }

    public DateTime HspuCreateDate { get; set; }

    public short? HspuLastupUser { get; set; }

    public DateTime? HspuLastupDate { get; set; }

    public string? HspuSpecial1 { get; set; }

    public string? HspuSpecial2 { get; set; }

    public string? HspuSpecial3 { get; set; }

    public string HspuPromosyonKodu { get; set; } = null!;

    public string HspuStokKodu { get; set; } = null!;
}
