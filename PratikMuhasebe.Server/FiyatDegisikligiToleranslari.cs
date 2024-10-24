using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FiyatDegisikligiToleranslari
{
    public Guid FdtGuid { get; set; }

    public short FdtDbcno { get; set; }

    public int? FdtSpecRecNo { get; set; }

    public bool? FdtIptal { get; set; }

    public short? FdtFileid { get; set; }

    public bool? FdtHidden { get; set; }

    public bool? FdtKilitli { get; set; }

    public bool? FdtDegisti { get; set; }

    public int? FdtChecksum { get; set; }

    public short? FdtCreateUser { get; set; }

    public DateTime FdtCreateDate { get; set; }

    public short? FdtLastupUser { get; set; }

    public DateTime? FdtLastupDate { get; set; }

    public string? FdtSpecial1 { get; set; }

    public string? FdtSpecial2 { get; set; }

    public string? FdtSpecial3 { get; set; }

    public int FdtSatirNo { get; set; }

    public bool? FdtStokCins1 { get; set; }

    public bool? FdtStokCins2 { get; set; }

    public bool? FdtStokCins3 { get; set; }

    public bool? FdtStokCins4 { get; set; }

    public bool? FdtStokCins5 { get; set; }

    public bool? FdtStokCins6 { get; set; }

    public bool? FdtStokCins7 { get; set; }

    public bool? FdtStokCins8 { get; set; }

    public bool? FdtStokCins9 { get; set; }

    public bool? FdtStokCins10 { get; set; }

    public bool? FdtStokCins11 { get; set; }

    public bool? FdtStokCins12 { get; set; }

    public byte? FdtStokindex { get; set; }

    public string? FdtStokbaglantikodu { get; set; }

    public byte? FdtStokindex2 { get; set; }

    public string? FdtStokbaglantikodu2 { get; set; }

    public byte? FdtStokindex3 { get; set; }

    public string? FdtStokbaglantikodu3 { get; set; }

    public double? FdtMaxArtisOrani { get; set; }

    public int? FdtFiyatListesirano { get; set; }
}
