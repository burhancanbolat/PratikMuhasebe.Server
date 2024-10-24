using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TakvimVardiyaDetaylari
{
    public Guid TakvimhrGuid { get; set; }

    public short TakvimhrDbcno { get; set; }

    public int? TakvimhrSpecRecno { get; set; }

    public bool? TakvimhrIptal { get; set; }

    public short? TakvimhrFileid { get; set; }

    public bool? TakvimhrHidden { get; set; }

    public bool? TakvimhrKilitli { get; set; }

    public bool? TakvimhrDegisti { get; set; }

    public int? TakvimhrCheckSum { get; set; }

    public short? TakvimhrCreateUser { get; set; }

    public DateTime TakvimhrCreateDate { get; set; }

    public short? TakvimhrLastupUser { get; set; }

    public DateTime? TakvimhrLastupDate { get; set; }

    public string? TakvimhrSpecial1 { get; set; }

    public string? TakvimhrSpecial2 { get; set; }

    public string? TakvimhrSpecial3 { get; set; }

    public string? TakvimhrTakkodu { get; set; }

    public DateTime? TakvimhrTarih { get; set; }

    public string? TakvimhrVardkodu { get; set; }
}
