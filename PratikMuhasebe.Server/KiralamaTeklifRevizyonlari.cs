using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiralamaTeklifRevizyonlari
{
    public Guid KtrvGuid { get; set; }

    public short KtrvDbcno { get; set; }

    public int? KtrvSpecRecNo { get; set; }

    public bool? KtrvIptal { get; set; }

    public short? KtrvFileid { get; set; }

    public bool? KtrvHidden { get; set; }

    public bool? KtrvKilitli { get; set; }

    public bool? KtrvDegisti { get; set; }

    public int? KtrvChecksum { get; set; }

    public short? KtrvCreateUser { get; set; }

    public DateTime KtrvCreateDate { get; set; }

    public short? KtrvLastupUser { get; set; }

    public DateTime? KtrvLastupDate { get; set; }

    public string? KtrvSpecial1 { get; set; }

    public string? KtrvSpecial2 { get; set; }

    public string? KtrvSpecial3 { get; set; }

    public int? KtrvFirmano { get; set; }

    public int? KtrvSubeno { get; set; }

    public DateTime? KtrvTarihi { get; set; }

    public string? KtrvEvraknoSeri { get; set; }

    public int? KtrvEvraknoSira { get; set; }

    public int? KtrvRevizyonno { get; set; }

    public int? KtrvSatirno { get; set; }

    public byte? KtrvHareketTipi { get; set; }

    public string? KtrvHareketKodu { get; set; }

    public string? KtrvSeriNo { get; set; }

    public int? KtrvKiralamaSuresi { get; set; }

    public int? KtrvMiktari { get; set; }

    public double? KtrvGunlukListeFiyati { get; set; }

    public double? KtrvHaftalikListeFiyati { get; set; }

    public double? KtrvAylikListeFiyati { get; set; }

    public double? KtrvIsktutari { get; set; }

    public double? KtrvTutar { get; set; }

    public string? KtrvSatirAciklama { get; set; }

    public Guid? KtrvKtlpUid { get; set; }
}
