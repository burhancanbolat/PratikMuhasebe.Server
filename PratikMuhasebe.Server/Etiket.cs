using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Etiket
{
    public Guid TeGuid { get; set; }

    public short TeDbcno { get; set; }

    public int? TeSpecRecno { get; set; }

    public bool? TeIptal { get; set; }

    public short? TeFileid { get; set; }

    public bool? TeHidden { get; set; }

    public bool? TeKilitli { get; set; }

    public bool? TeDegisti { get; set; }

    public int? TeChecksum { get; set; }

    public short? TeCreateUser { get; set; }

    public DateTime TeCreateDate { get; set; }

    public short? TeLastupUser { get; set; }

    public DateTime? TeLastupDate { get; set; }

    public string? TeSpecial1 { get; set; }

    public string? TeSpecial2 { get; set; }

    public string? TeSpecial3 { get; set; }

    public string? TeStokKodu { get; set; }

    public byte? TeRenkPntr { get; set; }

    public byte? TeBedenPntr { get; set; }

    public int? TeEtiketMiktari { get; set; }

    public byte? TeNedeni { get; set; }
}
