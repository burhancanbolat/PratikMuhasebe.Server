using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PromosyonTanimlari
{
    public Guid PromoGuid { get; set; }

    public short PromoDbcno { get; set; }

    public int? PromoSpecRecno { get; set; }

    public bool? PromoIptal { get; set; }

    public short? PromoFileid { get; set; }

    public bool? PromoHidden { get; set; }

    public bool? PromoKilitli { get; set; }

    public bool? PromoDegisti { get; set; }

    public int? PromoCheckSum { get; set; }

    public short? PromoCreateUser { get; set; }

    public DateTime PromoCreateDate { get; set; }

    public short? PromoLastupUser { get; set; }

    public DateTime? PromoLastupDate { get; set; }

    public string? PromoSpecial1 { get; set; }

    public string? PromoSpecial2 { get; set; }

    public string? PromoSpecial3 { get; set; }

    public string? PromoKodu { get; set; }

    public string? PromoIsmi { get; set; }

    public int PromoSiraNo { get; set; }

    public byte? PromoStokKriterTipi { get; set; }

    public string? PromoStokKriterYapisi { get; set; }

    public string? PromoStokSorguCumlesi { get; set; }

    public string? PromoMatrisStokKriteri1 { get; set; }

    public double? PromoMatrisStokMiktari1 { get; set; }

    public string? PromoMatrisStokKriteri2 { get; set; }

    public double? PromoMatrisStokMiktari2 { get; set; }

    public string? PromoMatrisStokKriteri3 { get; set; }

    public double? PromoMatrisStokMiktari3 { get; set; }

    public string? PromoMatrisStokKriteri4 { get; set; }

    public double? PromoMatrisStokMiktari4 { get; set; }

    public string? PromoMatrisStokKriteri5 { get; set; }

    public double? PromoMatrisStokMiktari5 { get; set; }

    public string? PromoMusteriKodYapisi { get; set; }

    public byte? PromoStokPromosyonTipi { get; set; }

    public byte? PromoBelgePromosyonTipi { get; set; }

    public byte? PromoZamanPromosyonTipi { get; set; }

    public byte? PromoCarprazPromosyonTipi { get; set; }

    public double? PromoD1 { get; set; }

    public double? PromoD2 { get; set; }

    public double? PromoD3 { get; set; }

    public double? PromoD4 { get; set; }

    public string? PromoHediyeKodu { get; set; }

    public double? PromoHediyeD1 { get; set; }

    public double? PromoHediyeD2 { get; set; }

    public DateTime? PromoBaslangicGunu { get; set; }

    public DateTime? PromoBitisGunu { get; set; }

    public bool? PromoUygulamaGunleri1 { get; set; }

    public bool? PromoUygulamaGunleri2 { get; set; }

    public bool? PromoUygulamaGunleri3 { get; set; }

    public bool? PromoUygulamaGunleri4 { get; set; }

    public bool? PromoUygulamaGunleri5 { get; set; }

    public bool? PromoUygulamaGunleri6 { get; set; }

    public bool? PromoUygulamaGunleri7 { get; set; }

    public DateTime? PromoGunIciBaslangicSaati { get; set; }

    public DateTime? PromoGunIciBitisSaati { get; set; }

    public string? PromoKasayaGidecekMesaj { get; set; }
}
