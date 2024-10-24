using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BagimsizBolumTanimlari
{
    public Guid BlmGuid { get; set; }

    public short BlmDbcno { get; set; }

    public int? BlmSpecRecno { get; set; }

    public bool? BlmIptal { get; set; }

    public short? BlmFileid { get; set; }

    public bool? BlmHidden { get; set; }

    public bool? BlmKilitli { get; set; }

    public bool? BlmDegisti { get; set; }

    public int? BlmChecksum { get; set; }

    public short? BlmCreateUser { get; set; }

    public DateTime BlmCreateDate { get; set; }

    public short? BlmLastupUser { get; set; }

    public DateTime? BlmLastupDate { get; set; }

    public string? BlmSpecial1 { get; set; }

    public string? BlmSpecial2 { get; set; }

    public string? BlmSpecial3 { get; set; }

    public string? BlmSitekod { get; set; }

    public string? BlmBlokkod { get; set; }

    public string? BlmKatkod { get; set; }

    public string? BlmKod { get; set; }

    public string? BlmIsmi { get; set; }

    public byte? BlmAcikkapali { get; set; }

    public byte? BlmTuru { get; set; }

    public double? BlmIccephe { get; set; }

    public double? BlmDiscephe { get; set; }

    public double? BlmVitrinsinifi { get; set; }

    public double? BlmBrutalan { get; set; }

    public double? BlmNetalan { get; set; }

    public byte? BlmCinsi { get; set; }

    public string? BlmKiraHizmetKodu { get; set; }

    public string? BlmOrtakGiderHizmetKodu { get; set; }
}
