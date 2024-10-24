using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsIlanDetaylari
{
    public Guid IldGuid { get; set; }

    public short IldDbcno { get; set; }

    public int? IldSpecRecno { get; set; }

    public bool? IldIptal { get; set; }

    public short? IldFileid { get; set; }

    public bool? IldHidden { get; set; }

    public bool? IldKilitli { get; set; }

    public bool? IldDegisti { get; set; }

    public int? IldChecksum { get; set; }

    public short? IldCreateUser { get; set; }

    public DateTime IldCreateDate { get; set; }

    public short? IldLastupUser { get; set; }

    public DateTime? IldLastupDate { get; set; }

    public string? IldSpecial1 { get; set; }

    public string? IldSpecial2 { get; set; }

    public string? IldSpecial3 { get; set; }

    public string? IldIlanKodu { get; set; }

    public byte? IldTipi { get; set; }

    public string? IldKodu { get; set; }

    public string? IldIlcekodu { get; set; }

    public string? IldAciklama1 { get; set; }

    public string? IldAciklama2 { get; set; }

    public string? IldAciklama3 { get; set; }
}
