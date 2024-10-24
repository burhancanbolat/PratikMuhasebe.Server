using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiralamaTalepHareketleri
{
    public Guid KtlpGuid { get; set; }

    public short KtlpDbcno { get; set; }

    public int? KtlpSpecRecNo { get; set; }

    public bool? KtlpIptal { get; set; }

    public short? KtlpFileid { get; set; }

    public bool? KtlpHidden { get; set; }

    public bool? KtlpKilitli { get; set; }

    public bool? KtlpDegisti { get; set; }

    public int? KtlpChecksum { get; set; }

    public short? KtlpCreateUser { get; set; }

    public DateTime KtlpCreateDate { get; set; }

    public short? KtlpLastupUser { get; set; }

    public DateTime? KtlpLastupDate { get; set; }

    public string? KtlpSpecial1 { get; set; }

    public string? KtlpSpecial2 { get; set; }

    public string? KtlpSpecial3 { get; set; }

    public int? KtlpFirmano { get; set; }

    public int? KtlpSubeno { get; set; }

    public DateTime? KtlpTarihi { get; set; }

    public string? KtlpEvraknoSeri { get; set; }

    public int? KtlpEvraknoSira { get; set; }

    public int? KtlpSatirno { get; set; }

    public string? KtlpBelgeno { get; set; }

    public DateTime? KtlpBelgeTarihi { get; set; }

    public string? KtlpCariKodu { get; set; }

    public byte? KtlpTalepGelisSekli { get; set; }

    public string? KtlpAciklama { get; set; }

    public int? KtlpAdresNo { get; set; }

    public string? KtlpTemsilciKodu { get; set; }

    public Guid? KtlpYetkiliUid { get; set; }

    public byte? KtlpHareketTipi { get; set; }

    public string? KtlpHareketKodu { get; set; }

    public string? KtlpSatirAciklama { get; set; }

    public int? KtlpKiralamaSuresi { get; set; }

    public int? KtlpMiktari { get; set; }

    public byte? KtlpTalepDurumu { get; set; }

    public string? KtlpKapamaNedeniKodu { get; set; }

    public byte? KtlpSipTip { get; set; }

    public Guid? KtlpSipUid { get; set; }

    public short? KtlpOnaylayanKulNo { get; set; }

    public bool? KtlpCagrilabilirFl { get; set; }
}
