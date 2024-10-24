using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelDevamKontrolNedenleri
{
    public Guid PdnGuid { get; set; }

    public short PdnDbcno { get; set; }

    public int? PdnSpecRecno { get; set; }

    public bool? PdnIptal { get; set; }

    public short? PdnFileid { get; set; }

    public bool? PdnHidden { get; set; }

    public bool? PdnKilitli { get; set; }

    public bool? PdnDegisti { get; set; }

    public int? PdnChecksum { get; set; }

    public short? PdnCreateUser { get; set; }

    public DateTime PdnCreateDate { get; set; }

    public short? PdnLastupUser { get; set; }

    public DateTime? PdnLastupDate { get; set; }

    public string? PdnSpecial1 { get; set; }

    public string? PdnSpecial2 { get; set; }

    public string? PdnSpecial3 { get; set; }

    public string? PdnNedenKodu { get; set; }

    public string? PdnAciklama { get; set; }
}
