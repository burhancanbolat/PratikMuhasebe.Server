using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FirmaKrediKartiTanimlari
{
    public Guid FkkGuid { get; set; }

    public short FkkDbcno { get; set; }

    public int? FkkSpecRecno { get; set; }

    public bool? FkkIptal { get; set; }

    public short? FkkFileid { get; set; }

    public bool? FkkHidden { get; set; }

    public bool? FkkKilitli { get; set; }

    public bool? FkkDegisti { get; set; }

    public int? FkkChecksum { get; set; }

    public short? FkkCreateUser { get; set; }

    public DateTime FkkCreateDate { get; set; }

    public short? FkkLastupUser { get; set; }

    public DateTime? FkkLastupDate { get; set; }

    public string? FkkSpecial1 { get; set; }

    public string? FkkSpecial2 { get; set; }

    public string? FkkSpecial3 { get; set; }

    public int? FkkFirmaNo { get; set; }

    public string? FkkKod { get; set; }

    public string? FkkIsim { get; set; }

    public string? FkkKartno { get; set; }

    public byte? FkkTip { get; set; }

    public byte? FkkCins { get; set; }

    public string? FkkBagliAsilKartKodu { get; set; }

    public string? FkkBagliBankaKodu { get; set; }

    public string? FkkBagliCariPersKodu { get; set; }

    public DateTime? FkkSonkullanimTarihi { get; set; }

    public short? FkkHesapKesimGunu { get; set; }

    public byte? FkkDovizCinsi { get; set; }

    public double? FkkHarcamaLimiti { get; set; }

    public double? FkkNakitLimiti { get; set; }

    public string? FkkDonemIciMuhKod { get; set; }

    public string? FkkGerceklesmisDonemMuhKod { get; set; }

    public string? FkkBagliKrediKartKodu { get; set; }

    public byte? FkkDurumu { get; set; }
}
