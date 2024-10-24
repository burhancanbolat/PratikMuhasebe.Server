using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmSayaclari
{
    public Guid AvmsycGuid { get; set; }

    public short AvmsycDbcno { get; set; }

    public int? AvmsycSpecRecno { get; set; }

    public bool? AvmsycIptal { get; set; }

    public short? AvmsycFileid { get; set; }

    public bool? AvmsycHidden { get; set; }

    public bool? AvmsycKilitli { get; set; }

    public bool? AvmsycDegisti { get; set; }

    public int? AvmsycChecksum { get; set; }

    public short? AvmsycCreateUser { get; set; }

    public DateTime AvmsycCreateDate { get; set; }

    public short? AvmsycLastupUser { get; set; }

    public DateTime? AvmsycLastupDate { get; set; }

    public string? AvmsycSpecial1 { get; set; }

    public string? AvmsycSpecial2 { get; set; }

    public string? AvmsycSpecial3 { get; set; }

    public byte? AvmsycTuru { get; set; }

    public byte? AvmsycCinsi { get; set; }

    public byte? AvmsycTipi { get; set; }

    public string? AvmsycKod { get; set; }

    public string? AvmsycIsmi { get; set; }

    public string? AvmsycSayacno { get; set; }

    public string? AvmsycSozlesmeno { get; set; }

    public string? AvmsycBlmkodu { get; set; }

    public string? AvmsycMasrafhizmetkodu { get; set; }

    public string? AvmsycMerkezisayackodu { get; set; }
}
