using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Makinalar
{
    public Guid MakGuid { get; set; }

    public short MakDbcno { get; set; }

    public int? MakSpecRecno { get; set; }

    public bool? MakIptal { get; set; }

    public short? MakFileid { get; set; }

    public bool? MakHidden { get; set; }

    public bool? MakKilitli { get; set; }

    public bool? MakDegisti { get; set; }

    public int? MakChecksum { get; set; }

    public short? MakCreateUser { get; set; }

    public DateTime MakCreateDate { get; set; }

    public short? MakLastupUser { get; set; }

    public DateTime? MakLastupDate { get; set; }

    public string? MakSpecial1 { get; set; }

    public string? MakSpecial2 { get; set; }

    public string? MakSpecial3 { get; set; }

    public string? MakKod { get; set; }

    public string? MakOzelIsim { get; set; }

    public string? MakGrupKod { get; set; }

    public DateTime? MakAltar { get; set; }

    public double? MakFiat { get; set; }

    public double? MakBakim { get; set; }

    public DateTime? MakSonbakimTarih { get; set; }

    public short? MakBakimSure { get; set; }

    public bool? MakAriza { get; set; }

    public double? MakMesgulSure { get; set; }

    public double? MakTopcalSure { get; set; }

    public string? MakServisKod { get; set; }

    public string? MakAtikKod { get; set; }

    public double? MakMasraf { get; set; }

    public short? MakSonReserv { get; set; }

    public double? MakBekSure { get; set; }

    public string? MakAciklama { get; set; }
}
