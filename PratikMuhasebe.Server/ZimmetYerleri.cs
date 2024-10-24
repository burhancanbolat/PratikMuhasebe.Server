using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ZimmetYerleri
{
    public Guid ZimGuid { get; set; }

    public short ZimDbcno { get; set; }

    public int? ZimSpecRecno { get; set; }

    public bool? ZimIptal { get; set; }

    public short? ZimFileid { get; set; }

    public bool? ZimHidden { get; set; }

    public bool? ZimKilitli { get; set; }

    public bool? ZimDegisti { get; set; }

    public int? ZimChecksum { get; set; }

    public short? ZimCreateUser { get; set; }

    public DateTime ZimCreateDate { get; set; }

    public short? ZimLastupUser { get; set; }

    public DateTime? ZimLastupDate { get; set; }

    public string? ZimSpecial1 { get; set; }

    public string? ZimSpecial2 { get; set; }

    public string? ZimSpecial3 { get; set; }

    public string? ZimKod { get; set; }

    public string? ZimIsmi { get; set; }
}
