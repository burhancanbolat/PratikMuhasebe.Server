using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimGecikmeNedenleri
{
    public Guid GckNdnGuid { get; set; }

    public short GckNdnDbcno { get; set; }

    public int? GckNdnSpecRecno { get; set; }

    public bool? GckNdnIptal { get; set; }

    public short? GckNdnFileid { get; set; }

    public bool? GckNdnHidden { get; set; }

    public bool? GckNdnKilitli { get; set; }

    public bool? GckNdnDegisti { get; set; }

    public int? GckNdnCheckSum { get; set; }

    public short? GckNdnCreateUser { get; set; }

    public DateTime GckNdnCreateDate { get; set; }

    public short? GckNdnLastupUser { get; set; }

    public DateTime? GckNdnLastupDate { get; set; }

    public string? GckNdnSpecial1 { get; set; }

    public string? GckNdnSpecial2 { get; set; }

    public string? GckNdnSpecial3 { get; set; }

    public string? GckNdnKod { get; set; }

    public string? GckNdnAciklama { get; set; }

    public bool? GckNdnPersonelKaynakliFl { get; set; }

    public byte? GckNdnMaliyeteEtkiTipi { get; set; }
}
