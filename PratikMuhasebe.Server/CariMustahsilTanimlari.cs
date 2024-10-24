using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariMustahsilTanimlari
{
    public Guid CmGuid { get; set; }

    public short CmDbcno { get; set; }

    public int? CmSpecRecno { get; set; }

    public bool? CmIptal { get; set; }

    public short? CmFileid { get; set; }

    public bool? CmHidden { get; set; }

    public bool? CmKilitli { get; set; }

    public bool? CmDegisti { get; set; }

    public int? CmCheckSum { get; set; }

    public short? CmCreateUser { get; set; }

    public DateTime CmCreateDate { get; set; }

    public short? CmLastupUser { get; set; }

    public DateTime? CmLastupDate { get; set; }

    public string? CmSpecial1 { get; set; }

    public string? CmSpecial2 { get; set; }

    public string? CmSpecial3 { get; set; }

    public string? CmCarikodu { get; set; }

    public bool? CmBagkurlu { get; set; }

    public DateTime? CmBagkurBasTar { get; set; }

    public DateTime? CmBagkurBitTar { get; set; }

    public string? CmBabaAdi { get; set; }

    public string? CmDogumYer { get; set; }

    public DateTime? CmDogumTar { get; set; }

    public string? CmSosGuvDurumu { get; set; }

    public double? CmDonum { get; set; }

    public string? CmCuzdanNo { get; set; }

    public string? CmFabrikaKodu { get; set; }

    public string? CmFabrikaAdi { get; set; }

    public string? CmRuhsatNo { get; set; }

    public string? CmBelgeNo { get; set; }

    public DateTime? CmGecerlilikTarihi { get; set; }

    public string? CmZiraatOdasi { get; set; }

    public string? CmBagkurNo { get; set; }

    public string? CmTckimlikNo { get; set; }

    public string? CmKooperatif { get; set; }

    public string? CmUrunBirligi { get; set; }

    public bool? CmHastaliktanAriBelgesi { get; set; }

    public bool? CmAbsertifikasi { get; set; }

    public bool? CmDamizlikPrimi { get; set; }

    public bool? CmTesvikAliyor { get; set; }

    public DateTime? CmMuafiyetBaslangic { get; set; }

    public DateTime? CmMuafiyetBitis { get; set; }
}
