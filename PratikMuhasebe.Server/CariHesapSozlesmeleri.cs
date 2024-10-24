using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapSozlesmeleri
{
    public Guid CsozGuid { get; set; }

    public short CsozDbcno { get; set; }

    public int? CsozSpecRecno { get; set; }

    public bool? CsozIptal { get; set; }

    public short? CsozFileid { get; set; }

    public bool? CsozHidden { get; set; }

    public bool? CsozKilitli { get; set; }

    public bool? CsozDegisti { get; set; }

    public int? CsozChecksum { get; set; }

    public short? CsozCreateUser { get; set; }

    public DateTime CsozCreateDate { get; set; }

    public short? CsozLastupUser { get; set; }

    public DateTime? CsozLastupDate { get; set; }

    public string? CsozSpecial1 { get; set; }

    public string? CsozSpecial2 { get; set; }

    public string? CsozSpecial3 { get; set; }

    public string? CsozSozlesmekodu { get; set; }

    public string? CsozSozlesmeaciklamasi { get; set; }

    public string? CsozBaglicarikod { get; set; }

    public DateTime? CsozSozlesmebaslamatarihi { get; set; }

    public DateTime? CsozSozlesmebitistarihi { get; set; }

    public byte? CsozSozlesmeuygulama { get; set; }
}
