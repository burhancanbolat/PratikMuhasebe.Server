using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizmetHesaplari
{
    public Guid HizGuid { get; set; }

    public short HizDbcno { get; set; }

    public int? HizSpecRecno { get; set; }

    public bool? HizIptal { get; set; }

    public short? HizFileid { get; set; }

    public bool? HizHidden { get; set; }

    public bool? HizKilitli { get; set; }

    public bool? HizDegisti { get; set; }

    public int? HizChecksum { get; set; }

    public short? HizCreateUser { get; set; }

    public DateTime HizCreateDate { get; set; }

    public short? HizLastupUser { get; set; }

    public DateTime? HizLastupDate { get; set; }

    public string? HizSpecial1 { get; set; }

    public string? HizSpecial2 { get; set; }

    public string? HizSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public byte? HizTip { get; set; }

    public string? HizKod { get; set; }

    public string? HizIsim { get; set; }

    public string? HizYabanciIsim { get; set; }

    public string? HizTipkod { get; set; }

    public string? HizSinifkod { get; set; }

    public string? HizGrupkod { get; set; }

    public string? HizSatMuhKod { get; set; }

    public string? HizSatIadeMuhKod { get; set; }

    public string? HizMalMuhKod { get; set; }

    public string? HizSatMalMuhKod { get; set; }

    public string? HizMalYanMuhKod { get; set; }

    public double? HizFiyat { get; set; }

    public byte? HizDovizCinsi { get; set; }

    public string? HizIskGrup { get; set; }

    public byte? HizKdv { get; set; }

    public string? HizMuhSatIskKod { get; set; }

    public string? HizMuhAIiskmuhkod { get; set; }

    public string? HizIlavemasmuhkod { get; set; }

    public int? HizOperasyonSuresi { get; set; }

    public byte? HizOivuygulama { get; set; }

    public double? HizOivtutar { get; set; }

    public byte? HizOivturu { get; set; }

    public string? HizSatUfrsFarkMuhKod { get; set; }

    public string? HizSatIadeUfrsFarkMuhKod { get; set; }

    public string? HizMalUfrsFarkMuhKod { get; set; }

    public string? HizSatMalUfrsFarkMuhKod { get; set; }

    public string? HizMalYanUfrsFarkMuhKod { get; set; }

    public string? HizMuhSatUfrsFarkIskKod { get; set; }

    public string? HizMuhAIiskufrsFarkMuhkod { get; set; }

    public string? HizIlavemasufrsFarkMuhkod { get; set; }

    public string? HizBirimAd { get; set; }

    public byte? HizBsbayadahil { get; set; }

    public short? HizVergifonid1 { get; set; }

    public short? HizVergifonid2 { get; set; }

    public short? HizVergifonid3 { get; set; }

    public short? HizVergifonid4 { get; set; }

    public short? HizVergifonid5 { get; set; }

    public string? HizEfatSinifKodu { get; set; }

    public string? HizEfatSinifListesi { get; set; }

    public string? HizEfatSinifVersiyonu { get; set; }

    public byte? HizTevkifatTuru { get; set; }
}
