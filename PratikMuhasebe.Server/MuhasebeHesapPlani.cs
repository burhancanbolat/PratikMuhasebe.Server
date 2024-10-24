using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MuhasebeHesapPlani
{
    public Guid MuhGuid { get; set; }

    public short MuhDbcno { get; set; }

    public int? MuhSpecRecno { get; set; }

    public bool? MuhIptal { get; set; }

    public short? MuhFileid { get; set; }

    public bool? MuhHidden { get; set; }

    public bool? MuhKilitli { get; set; }

    public bool? MuhDegisti { get; set; }

    public int? MuhChecksum { get; set; }

    public short? MuhCreateUser { get; set; }

    public DateTime MuhCreateDate { get; set; }

    public short? MuhLastupUser { get; set; }

    public DateTime? MuhLastupDate { get; set; }

    public string? MuhSpecial1 { get; set; }

    public string? MuhSpecial2 { get; set; }

    public string? MuhSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public string? MuhHesapKod { get; set; }

    public string? MuhHesapIsim1 { get; set; }

    public string? MuhHesapIsim2 { get; set; }

    public byte? MuhHesapTip { get; set; }

    public byte? MuhDovizCinsi { get; set; }

    public bool? MuhKurfarkiFl { get; set; }

    public byte? MuhSorumMerk { get; set; }

    public DateTime? MuhKilittarihi { get; set; }

    public byte? MuhHesDavBicimi { get; set; }

    public byte? MuhKdvTipi { get; set; }

    public byte? MuhCalismaSekli { get; set; }

    public byte? MuhMaliyetDagitimSekli { get; set; }

    public string? MuhGrupkodu { get; set; }

    public bool? MuhEnfFarkMaliyetFl { get; set; }

    public byte? MuhKdvDagitimSekli { get; set; }

    public bool? MuhMiktarOtoFl { get; set; }

    public bool? MuhTicaridenBilgiGirisiFl { get; set; }

    public byte? MuhProjeDetayi { get; set; }

    public string? MuhKesinMizanHesapKodu { get; set; }
}
