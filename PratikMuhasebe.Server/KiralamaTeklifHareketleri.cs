using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiralamaTeklifHareketleri
{
    public Guid KtkfGuid { get; set; }

    public short KtkfDbcno { get; set; }

    public int? KtkfSpecRecNo { get; set; }

    public bool? KtkfIptal { get; set; }

    public short? KtkfFileid { get; set; }

    public bool? KtkfHidden { get; set; }

    public bool? KtkfKilitli { get; set; }

    public bool? KtkfDegisti { get; set; }

    public int? KtkfChecksum { get; set; }

    public short? KtkfCreateUser { get; set; }

    public DateTime KtkfCreateDate { get; set; }

    public short? KtkfLastupUser { get; set; }

    public DateTime? KtkfLastupDate { get; set; }

    public string? KtkfSpecial1 { get; set; }

    public string? KtkfSpecial2 { get; set; }

    public string? KtkfSpecial3 { get; set; }

    public int? KtkfFirmano { get; set; }

    public int? KtkfSubeno { get; set; }

    public DateTime? KtkfTarihi { get; set; }

    public string? KtkfEvraknoSeri { get; set; }

    public int? KtkfEvraknoSira { get; set; }

    public int? KtkfSatirno { get; set; }

    public int? KtkfRevizyonno { get; set; }

    public string? KtkfBelgeno { get; set; }

    public DateTime? KtkfBelgeTarihi { get; set; }

    public string? KtkfCariKodu { get; set; }

    public byte? KtkfDovizCinsi { get; set; }

    public string? KtkfAciklama { get; set; }

    public int? KtkfAdresNo { get; set; }

    public int? KtkfDepono { get; set; }

    public string? KtkfTemsilciKodu { get; set; }

    public Guid? KtkfYetkiliUid { get; set; }

    public int? KtkfOpno { get; set; }

    public byte? KtkfHareketTipi { get; set; }

    public string? KtkfHareketKodu { get; set; }

    public string? KtkfSeriNo { get; set; }

    public int? KtkfKiralamaSuresi { get; set; }

    public int? KtkfMiktari { get; set; }

    public double? KtkfGunlukListeFiyati { get; set; }

    public double? KtkfHaftalikListeFiyati { get; set; }

    public double? KtkfAylikListeFiyati { get; set; }

    public double? KtkfIsktutari { get; set; }

    public double? KtkfTutar { get; set; }

    public string? KtkfSatirAciklama { get; set; }

    public Guid? KtkfKtlpUid { get; set; }

    public byte? KtkfTeklifDurumu { get; set; }

    public string? KtkfKapamaNedeniKodu { get; set; }
}
