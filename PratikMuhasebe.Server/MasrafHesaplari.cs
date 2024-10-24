using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MasrafHesaplari
{
    public Guid HisGuid { get; set; }

    public short HisDbcno { get; set; }

    public int? HisSpecRecNo { get; set; }

    public bool? HisIptal { get; set; }

    public short? HisFileid { get; set; }

    public bool? HisHidden { get; set; }

    public bool? HisKilitli { get; set; }

    public bool? HisDegisti { get; set; }

    public int? HisChecksum { get; set; }

    public short? HisCreateUser { get; set; }

    public DateTime HisCreateDate { get; set; }

    public short? HisLastupUser { get; set; }

    public DateTime? HisLastupDate { get; set; }

    public string? HisSpecial1 { get; set; }

    public string? HisSpecial2 { get; set; }

    public string? HisSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public string? HisKod { get; set; }

    public string? HisIsim { get; set; }

    public string? HisYabanciIsim { get; set; }

    public string? HisTipkod { get; set; }

    public string? HisSinifkod { get; set; }

    public string? HisGrupkod { get; set; }

    public string? HisMuhkod { get; set; }

    public string? HisMalYanMuhkod { get; set; }

    public string? HisKkegMuhkod { get; set; }

    public byte? HisDovcinsi { get; set; }

    public string? HisMuhSatIskKod { get; set; }

    public string? HisMuhAIiskmuhkod { get; set; }

    public string? HisIlavemasmuhkod { get; set; }

    public byte? HisOivuygulama { get; set; }

    public double? HisOivtutar { get; set; }

    public byte? HisOivturu { get; set; }

    public string? HisUfrsFarkMuhkod { get; set; }

    public string? HisMalYanUfrsFarkMuhkod { get; set; }

    public string? HisKkegUfrsFarkMuhkod { get; set; }

    public string? HisMuhSatIskUfrsFarkKod { get; set; }

    public string? HisMuhAIiskufrsFarkMuhkod { get; set; }

    public string? HisIlavemasufrsFarkMuhkod { get; set; }

    public string? HisBirimAd { get; set; }

    public byte? HisBsbayadahil { get; set; }

    public short? HisVergifonid1 { get; set; }

    public short? HisVergifonid2 { get; set; }

    public short? HisVergifonid3 { get; set; }

    public short? HisVergifonid4 { get; set; }

    public short? HisVergifonid5 { get; set; }

    public byte? HisKdv { get; set; }

    public byte? HisKkegtipi { get; set; }
}
