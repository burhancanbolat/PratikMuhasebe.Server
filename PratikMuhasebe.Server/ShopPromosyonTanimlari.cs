using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ShopPromosyonTanimlari
{
    public Guid SpGuid { get; set; }

    public short SpDbcno { get; set; }

    public int? SpSpecRecno { get; set; }

    public bool? SpIptal { get; set; }

    public short? SpFileid { get; set; }

    public bool? SpHidden { get; set; }

    public bool? SpKilitli { get; set; }

    public bool? SpDegisti { get; set; }

    public int? SpCheckSum { get; set; }

    public short? SpCreateUser { get; set; }

    public DateTime SpCreateDate { get; set; }

    public short? SpLastupUser { get; set; }

    public DateTime? SpLastupDate { get; set; }

    public string? SpSpecial1 { get; set; }

    public string? SpSpecial2 { get; set; }

    public string? SpSpecial3 { get; set; }

    public string SpKodu { get; set; } = null!;

    public string? SpIsmi { get; set; }

    public byte? SpPromosyonEvraktipi { get; set; }

    public byte? SpPosTipleri { get; set; }

    public bool? SpAktif { get; set; }

    public short? SpMatrahGrubu { get; set; }

    public short? SpMatrahGrubuSiraNo { get; set; }

    public DateTime? SpBaslangicZamani { get; set; }

    public DateTime? SpBitisZamani { get; set; }

    public DateTime? SpGunIciBaslangicSaati { get; set; }

    public DateTime? SpGunIciBitisSaati { get; set; }

    public byte? SpUygulamaGunleri { get; set; }

    public byte? SpDepoKisitTipi { get; set; }

    public string? SpDepoListesi { get; set; }

    public bool? SpUygulamaZorunlu { get; set; }

    public int? SpMaksimumIterasyon { get; set; }

    public int? SpMusteriKisitlariPromoTip { get; set; }

    public string? SpMusteriKisitlariSorgu { get; set; }

    public string? SpMusteriKisitlariStrData { get; set; }

    public double? SpMusteriKisitlariDblData { get; set; }

    public int? SpMusteriKisitlariIntData { get; set; }

    public int? SpUrunKisitlariPromoTip { get; set; }

    public int? SpUrunKosullar1Tip { get; set; }

    public string? SpUrunKosullar1Sorgu { get; set; }

    public double? SpUrunKosullar1Min { get; set; }

    public double? SpUrunKosullar1Max { get; set; }

    public double? SpUrunKosullar1Haric { get; set; }

    public double? SpUrunKosullar1Group { get; set; }

    public double? SpUrunKosullar1Deger { get; set; }

    public int? SpUrunKosullar1YakinTip { get; set; }

    public double? SpUrunKosullar1YakinDeger { get; set; }

    public int? SpUrunKosullar2Tip { get; set; }

    public string? SpUrunKosullar2Sorgu { get; set; }

    public double? SpUrunKosullar2Min { get; set; }

    public double? SpUrunKosullar2Max { get; set; }

    public double? SpUrunKosullar2Haric { get; set; }

    public double? SpUrunKosullar2Group { get; set; }

    public double? SpUrunKosullar2Deger { get; set; }

    public int? SpUrunKosullar2YakinTip { get; set; }

    public double? SpUrunKosullar2YakinDeger { get; set; }

    public int? SpUrunKosullar3Tip { get; set; }

    public string? SpUrunKosullar3Sorgu { get; set; }

    public double? SpUrunKosullar3Min { get; set; }

    public double? SpUrunKosullar3Max { get; set; }

    public double? SpUrunKosullar3Haric { get; set; }

    public double? SpUrunKosullar3Group { get; set; }

    public double? SpUrunKosullar3Deger { get; set; }

    public int? SpUrunKosullar3YakinTip { get; set; }

    public double? SpUrunKosullar3YakinDeger { get; set; }

    public int? SpUrunKosullar4Tip { get; set; }

    public string? SpUrunKosullar4Sorgu { get; set; }

    public double? SpUrunKosullar4Min { get; set; }

    public double? SpUrunKosullar4Max { get; set; }

    public double? SpUrunKosullar4Haric { get; set; }

    public double? SpUrunKosullar4Group { get; set; }

    public double? SpUrunKosullar4Deger { get; set; }

    public int? SpUrunKosullar4YakinTip { get; set; }

    public double? SpUrunKosullar4YakinDeger { get; set; }

    public int? SpUrunKosullar5Tip { get; set; }

    public string? SpUrunKosullar5Sorgu { get; set; }

    public double? SpUrunKosullar5Min { get; set; }

    public double? SpUrunKosullar5Max { get; set; }

    public double? SpUrunKosullar5Haric { get; set; }

    public double? SpUrunKosullar5Group { get; set; }

    public double? SpUrunKosullar5Deger { get; set; }

    public int? SpUrunKosullar5YakinTip { get; set; }

    public double? SpUrunKosullar5YakinDeger { get; set; }

    public int? SpUrunKosullar6Tip { get; set; }

    public string? SpUrunKosullar6Sorgu { get; set; }

    public double? SpUrunKosullar6Min { get; set; }

    public double? SpUrunKosullar6Max { get; set; }

    public double? SpUrunKosullar6Haric { get; set; }

    public double? SpUrunKosullar6Group { get; set; }

    public double? SpUrunKosullar6Deger { get; set; }

    public int? SpUrunKosullar6YakinTip { get; set; }

    public double? SpUrunKosullar6YakinDeger { get; set; }

    public int? SpUrunKosullar7Tip { get; set; }

    public string? SpUrunKosullar7Sorgu { get; set; }

    public double? SpUrunKosullar7Min { get; set; }

    public double? SpUrunKosullar7Max { get; set; }

    public double? SpUrunKosullar7Haric { get; set; }

    public double? SpUrunKosullar7Group { get; set; }

    public double? SpUrunKosullar7Deger { get; set; }

    public int? SpUrunKosullar7YakinTip { get; set; }

    public double? SpUrunKosullar7YakinDeger { get; set; }

    public int? SpUrunKosullar8Tip { get; set; }

    public string? SpUrunKosullar8Sorgu { get; set; }

    public double? SpUrunKosullar8Min { get; set; }

    public double? SpUrunKosullar8Max { get; set; }

    public double? SpUrunKosullar8Haric { get; set; }

    public double? SpUrunKosullar8Group { get; set; }

    public double? SpUrunKosullar8Deger { get; set; }

    public int? SpUrunKosullar8YakinTip { get; set; }

    public double? SpUrunKosullar8YakinDeger { get; set; }

    public int? SpStdUygulamaKodu { get; set; }

    public string? SpStdUygulamaUrunler { get; set; }

    public double? SpStdUygulamaMiktarDbl { get; set; }

    public double? SpStdUygulamaDegerDbl { get; set; }

    public byte? SpStdUygulamaOzelDurum { get; set; }

    public byte? SpStdUygulamaIskontoDagitimSekli { get; set; }

    public byte? SpStdUygulamaIskontoIndex { get; set; }

    public byte? SpStdUygulamaYuvarlamaTipi { get; set; }

    public double? SpStdUygulamaYuvarlamaMiktar { get; set; }

    public string? SpStdUygulamaEksikseMesaj { get; set; }

    public string? SpStdUygulamaKasaMesaji { get; set; }

    public string? SpStdUygulamaEkbilgi { get; set; }

    public string? SpKazanmaKriteri { get; set; }

    public string? SpUygulamaSekli { get; set; }

    public string? SpKazanmayaYakinKriteri { get; set; }
}
