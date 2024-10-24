using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Kasalar
{
    public Guid KasGuid { get; set; }

    public short KasDbcno { get; set; }

    public int? KasSpecRecno { get; set; }

    public bool? KasIptal { get; set; }

    public short? KasFileid { get; set; }

    public bool? KasHidden { get; set; }

    public bool? KasKilitli { get; set; }

    public bool? KasDegisti { get; set; }

    public int? KasChecksum { get; set; }

    public short? KasCreateUser { get; set; }

    public DateTime KasCreateDate { get; set; }

    public short? KasLastupUser { get; set; }

    public DateTime? KasLastupDate { get; set; }

    public string? KasSpecial1 { get; set; }

    public string? KasSpecial2 { get; set; }

    public string? KasSpecial3 { get; set; }

    public byte? KasTip { get; set; }

    public int? KasFirmaNo { get; set; }

    public string? KasKod { get; set; }

    public string? KasIsim { get; set; }

    public string? KasMuhKod { get; set; }

    public byte? KasDovizCinsi { get; set; }

    public string? KasBankakodu { get; set; }

    public bool? KasNakakincelenmesi { get; set; }

    public string? KasUfrsMuhKod { get; set; }
}
