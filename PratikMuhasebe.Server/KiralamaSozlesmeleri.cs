using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiralamaSozlesmeleri
{
    public Guid KsozGuid { get; set; }

    public short KsozDbcno { get; set; }

    public int? KsozSpecRecno { get; set; }

    public bool? KsozIptal { get; set; }

    public short? KsozFileid { get; set; }

    public bool? KsozHidden { get; set; }

    public bool? KsozKilitli { get; set; }

    public bool? KsozDegisti { get; set; }

    public int? KsozChecksum { get; set; }

    public short? KsozCreateUser { get; set; }

    public DateTime KsozCreateDate { get; set; }

    public short? KsozLastupUser { get; set; }

    public DateTime? KsozLastupDate { get; set; }

    public string? KsozSpecial1 { get; set; }

    public string? KsozSpecial2 { get; set; }

    public string? KsozSpecial3 { get; set; }

    public string? KsozKodu { get; set; }

    public DateTime? KsozTarihi { get; set; }

    public string? KsozCarikodu { get; set; }

    public DateTime? KsozBastar { get; set; }

    public DateTime? KsozBittar { get; set; }
}
