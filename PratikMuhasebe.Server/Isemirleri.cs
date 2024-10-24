using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Isemirleri
{
    public Guid IsGuid { get; set; }

    public short IsDbcno { get; set; }

    public int? IsSpecRecNo { get; set; }

    public bool? IsIptal { get; set; }

    public short? IsFileid { get; set; }

    public bool? IsHidden { get; set; }

    public bool? IsKilitli { get; set; }

    public bool? IsDegisti { get; set; }

    public int? IsChecksum { get; set; }

    public short? IsCreateUser { get; set; }

    public DateTime IsCreateDate { get; set; }

    public short? IsLastupUser { get; set; }

    public DateTime? IsLastupDate { get; set; }

    public string? IsSpecial1 { get; set; }

    public string? IsSpecial2 { get; set; }

    public string? IsSpecial3 { get; set; }

    public int? IsFirmano { get; set; }

    public int? IsSubeno { get; set; }

    public string? IsKod { get; set; }

    public string? IsIsmi { get; set; }

    public bool? IsFasonFl { get; set; }

    public byte? IsIsemriTipi { get; set; }

    public DateTime? IsBaslangicTarihi { get; set; }

    public DateTime? IsKapanisTarihi { get; set; }

    public string? IsStokBirikMuhKod { get; set; }

    public string? IsHizmetBirikMuhKod { get; set; }

    public string? IsStokYansitMuhKod { get; set; }

    public string? IsHizmetYansitMuhKo { get; set; }

    public string? IsYarimamulBirikimMuhkodu { get; set; }

    public string? IsYarimamulYansitmaMuhkodu { get; set; }

    public string? IsGenMalYanMuhKod1 { get; set; }

    public string? IsGenMalYanMuhKod2 { get; set; }

    public string? IsGenMalYanMuhKod3 { get; set; }

    public string? IsGenMalYanMuhKod4 { get; set; }

    public string? IsGenMalYanMuhKod5 { get; set; }

    public string? IsMakineMalYanMuhKo { get; set; }

    public string? IsElemanMalYanMuhKo { get; set; }

    public string? IsYariMamulMuhKod { get; set; }

    public string? IsSiparisNoSeri { get; set; }

    public int? IsSiparisNoSira { get; set; }

    public int? IsSipSatirno { get; set; }

    public string? IsSipSafha { get; set; }

    public short? IsSipBatchId { get; set; }

    public byte? IsEmriDurumu { get; set; }

    public DateTime? IsEmriAktiflesmeTarihi { get; set; }

    public DateTime? IsEmriPlanBaslamaTarihi { get; set; }

    public DateTime? IsEmriPlanBitisTarihi { get; set; }

    public string? IsGenUrtMalYanMuhKod1 { get; set; }

    public string? IsGenUrtMalYanMuhKod2 { get; set; }

    public string? IsGenUrtMalYanMuhKod3 { get; set; }

    public string? IsGenUrtMalYanMuhKod4 { get; set; }

    public string? IsGenUrtMalYanMuhKod5 { get; set; }

    public string? IsMuhgrupKodu { get; set; }

    public string? IsBagliOlduguIsemri { get; set; }

    public byte? IsBaglantiTipi { get; set; }

    public Guid? IsBaglantiUid { get; set; }

    public short? IsOnaylayanKulNo { get; set; }

    public bool? IsOnayliFl { get; set; }

    public byte? IsOnceligi { get; set; }

    public string? IsSorumlulukMerkezi { get; set; }

    public string? IsProjeKodu { get; set; }

    public string? IsAciklama { get; set; }

    public DateTime? IsKaynakPlanlamaTerminTarihi { get; set; }
}
