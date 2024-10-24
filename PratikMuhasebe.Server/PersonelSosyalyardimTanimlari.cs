using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSosyalyardimTanimlari
{
    public Guid PsyGuid { get; set; }

    public short PsyDbcno { get; set; }

    public int? PsySpecRecno { get; set; }

    public bool? PsyIptal { get; set; }

    public short? PsyFileid { get; set; }

    public bool? PsyHidden { get; set; }

    public bool? PsyKilitli { get; set; }

    public bool? PsyDegisti { get; set; }

    public int? PsyChecksum { get; set; }

    public short? PsyCreateUser { get; set; }

    public DateTime PsyCreateDate { get; set; }

    public short? PsyLastupUser { get; set; }

    public DateTime? PsyLastupDate { get; set; }

    public string? PsySpecial1 { get; set; }

    public string? PsySpecial2 { get; set; }

    public string? PsySpecial3 { get; set; }

    public string? PsyKodu { get; set; }

    public short? PsySiraNo { get; set; }

    public double? PsyTutar1 { get; set; }

    public double? PsyTutar2 { get; set; }

    public double? PsyTutar3 { get; set; }

    public double? PsyTutar4 { get; set; }

    public double? PsyTutar5 { get; set; }

    public double? PsyTutar6 { get; set; }

    public double? PsyTutar7 { get; set; }

    public double? PsyTutar8 { get; set; }

    public double? PsyTutar9 { get; set; }

    public double? PsyTutar10 { get; set; }

    public double? PsyTutar11 { get; set; }

    public double? PsyTutar12 { get; set; }

    public byte? PsyTahno { get; set; }

    public string? PsyGunAy { get; set; }

    public byte? PsyBrutNet { get; set; }

    public byte? PsySsk { get; set; }

    public byte? PsyGv { get; set; }

    public byte? PsyDv { get; set; }

    public double? PsyGvMuaf { get; set; }

    public double? PsySskMuaf { get; set; }

    public double? PsyDvMuaf { get; set; }

    public byte? PsyKazancgunhesaplansin1 { get; set; }

    public byte? PsyKazancgunhesaplansin2 { get; set; }

    public byte? PsyKazancgunhesaplansin3 { get; set; }

    public byte? PsyKazancgunhesaplansin4 { get; set; }

    public byte? PsyKazancgunhesaplansin5 { get; set; }

    public byte? PsyKazancgunhesaplansin6 { get; set; }

    public byte? PsyKazancgunhesaplansin7 { get; set; }

    public byte? PsyUcretKapsamindaDegildir { get; set; }
}
