using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokSarfReceteleri
{
    public Guid SrGuid { get; set; }

    public short SrDbcno { get; set; }

    public int? SrSpecRecno { get; set; }

    public bool? SrIptal { get; set; }

    public short? SrFileid { get; set; }

    public bool? SrHidden { get; set; }

    public bool? SrKilitli { get; set; }

    public bool? SrDegisti { get; set; }

    public int? SrChecksum { get; set; }

    public short? SrCreateUser { get; set; }

    public DateTime SrCreateDate { get; set; }

    public short? SrLastupUser { get; set; }

    public DateTime? SrLastupDate { get; set; }

    public string? SrSpecial1 { get; set; }

    public string? SrSpecial2 { get; set; }

    public string? SrSpecial3 { get; set; }

    public string? SrAnakod { get; set; }

    public DateTime? SrTarih { get; set; }

    public string? SrAciklama { get; set; }

    public byte? SrAnabirim { get; set; }

    public double? SrAnamiktar { get; set; }

    public string? SrTuketimKod { get; set; }

    public double? SrTuketimMiktar { get; set; }

    public byte? SrTuketimBirim { get; set; }

    public int? SrSatirno { get; set; }

    public string? SrSatirAcik { get; set; }

    public int? SrDepono { get; set; }

    public double? SrFireyuzde { get; set; }

    public double? SrPartiMiktari { get; set; }

    public byte? SrRecetecinsi { get; set; }
}
