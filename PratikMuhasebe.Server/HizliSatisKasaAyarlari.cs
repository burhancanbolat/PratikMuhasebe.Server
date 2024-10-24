using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizliSatisKasaAyarlari
{
    public Guid HskaGuid { get; set; }

    public short HskaDbcno { get; set; }

    public int? HskaSpecRecno { get; set; }

    public bool? HskaIptal { get; set; }

    public short? HskaFileid { get; set; }

    public bool? HskaHidden { get; set; }

    public bool? HskaKilitli { get; set; }

    public bool? HskaDegisti { get; set; }

    public int? HskaChecksum { get; set; }

    public short? HskaCreateUser { get; set; }

    public DateTime HskaCreateDate { get; set; }

    public short? HskaLastupUser { get; set; }

    public DateTime? HskaLastupDate { get; set; }

    public string? HskaSpecial1 { get; set; }

    public string? HskaSpecial2 { get; set; }

    public string? HskaSpecial3 { get; set; }

    public short? HskaKasaNo { get; set; }

    public string? HskaMakineId { get; set; }

    public string? HskaPerakendeCariKodu { get; set; }

    public string? HskaAnaKasaKodu { get; set; }

    public string? HskaKasaKodu { get; set; }

    public int? HskaDepoNo { get; set; }

    public string? HskaSorumlulukMerkeziKodu { get; set; }

    public string? HskaProjeKodu { get; set; }

    public int? HskaFiyatListeNo { get; set; }

    public string? HskaEvrakSeri { get; set; }

    public byte? HskaIadeEvrakCalismaTipi { get; set; }

    public string? HskaSonradanMuhasebelesenEvrakSeri { get; set; }

    public string? HskaEarsivSeri { get; set; }

    public byte? HskaCariKaydedebilirMi { get; set; }

    public string? HskaCariKodYapisi { get; set; }

    public string? HskaYeniCariKartMuhKodu { get; set; }

    public byte? HskaAyniUrunSatirBirlestir { get; set; }

    public int? HskaSatisEvrakBaskiSayisi { get; set; }

    public double? HskaFisLimitTl { get; set; }

    public byte? HskaBilgiFisiBasimiSorulsun { get; set; }

    public byte? HskaEvrakSonlandirmaSekli { get; set; }

    public string? HskaEfaturaSeri { get; set; }

    public byte? HskaEarsivKasaMi { get; set; }

    public string? HskaFaturaSeri { get; set; }

    public string? HskaIadeSeri { get; set; }

    public double? HskaEarsivFisLimitTl { get; set; }

    public string? HskaKasaAdi { get; set; }
}
