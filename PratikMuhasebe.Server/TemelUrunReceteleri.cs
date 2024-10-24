using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TemelUrunReceteleri
{
    public Guid MreGuid { get; set; }

    public short MreDbcno { get; set; }

    public int? MreSpecRecno { get; set; }

    public bool? MreIptal { get; set; }

    public short? MreFileid { get; set; }

    public bool? MreHidden { get; set; }

    public bool? MreKilitli { get; set; }

    public bool? MreDegisti { get; set; }

    public int? MreChecksum { get; set; }

    public short? MreCreateUser { get; set; }

    public DateTime MreCreateDate { get; set; }

    public short? MreLastupUser { get; set; }

    public DateTime? MreLastupDate { get; set; }

    public string? MreSpecial1 { get; set; }

    public string? MreSpecial2 { get; set; }

    public string? MreSpecial3 { get; set; }

    public string? MreAnaKodu { get; set; }

    public DateTime? MreTarih { get; set; }

    public string? MreAciklama { get; set; }

    public byte? MreAnaBirim { get; set; }

    public double? MreAnaMiktar { get; set; }

    public byte? MreTuketimTuru { get; set; }

    public string? MreTuketimKodu { get; set; }

    public double? MreTuketimMiktari { get; set; }

    public byte? MreTuketimBirim { get; set; }

    public byte? MreUretimtuketim { get; set; }

    public int? MreSatirno { get; set; }

    public string? MreStrdetayAcik { get; set; }

    public int? MreDepono { get; set; }

    public double? MreFireYuzdesi { get; set; }

    public byte? MrePlanlamaTipi { get; set; }
}
