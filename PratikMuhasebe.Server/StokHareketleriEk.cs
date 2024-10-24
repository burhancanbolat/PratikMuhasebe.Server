using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokHareketleriEk
{
    public Guid SthekGuid { get; set; }

    public short SthekDbcno { get; set; }

    public int? SthekSpecRecno { get; set; }

    public bool? SthekIptal { get; set; }

    public short? SthekFileid { get; set; }

    public bool? SthekHidden { get; set; }

    public bool? SthekKilitli { get; set; }

    public bool? SthekDegisti { get; set; }

    public int? SthekChecksum { get; set; }

    public short? SthekCreateUser { get; set; }

    public DateTime SthekCreateDate { get; set; }

    public short? SthekLastupUser { get; set; }

    public DateTime? SthekLastupDate { get; set; }

    public string? SthekSpecial1 { get; set; }

    public string? SthekSpecial2 { get; set; }

    public string? SthekSpecial3 { get; set; }

    public Guid? SthekRelatedUid { get; set; }

    public Guid? SthSubesipUid { get; set; }

    public Guid? SthBkmUid { get; set; }

    public Guid? SthKarsikonsUid { get; set; }

    public Guid? SthRezUid { get; set; }

    public Guid? SthOptamamUid { get; set; }

    public Guid? SthIadeTlpUid { get; set; }

    public Guid? SthHalSatisUid { get; set; }

    public Guid? SthCiroprimUid { get; set; }

    public string? SthIadeEvrakSeri { get; set; }

    public int? SthIadeEvrakSira { get; set; }

    public string? SthYatTesKodu { get; set; }

    public string? SthIhracatKrediKodu { get; set; }

    public string? SthDiibBelgeNo { get; set; }

    public byte? SthDiibSatirNo { get; set; }

    public byte? SthMenseyUlkeTipi { get; set; }

    public string? SthMenseyUlkeKodu { get; set; }

    public double? SthHalrehmiktari { get; set; }

    public double? SthHalrehfiyati { get; set; }

    public double? SthHalsandikmiktari { get; set; }

    public double? SthHalsandikfiyati { get; set; }

    public double? SthHalsandikkdvtutari { get; set; }

    public double? SthHalKomisyonuKdv { get; set; }

    public double? SthHalRusum { get; set; }

    public byte? SthSatistipi { get; set; }

    public DateTime? SthVardiyaTarihi { get; set; }

    public byte? SthVardiyaNo { get; set; }

    public double? SthDirektIscilik1 { get; set; }

    public double? SthDirektIscilik2 { get; set; }

    public double? SthDirektIscilik3 { get; set; }

    public double? SthDirektIscilik4 { get; set; }

    public double? SthDirektIscilik5 { get; set; }

    public double? SthGenelUretim1 { get; set; }

    public double? SthGenelUretim2 { get; set; }

    public double? SthGenelUretim3 { get; set; }

    public double? SthGenelUretim4 { get; set; }

    public double? SthGenelUretim5 { get; set; }

    public DateTime? SthFisTarihi2 { get; set; }

    public int? SthFisSirano2 { get; set; }

    public string? SthFiyfarkEsasEvrakSeri { get; set; }

    public int? SthFiyfarkEsasEvrakSira { get; set; }

    public int? SthFiyfarkEsasSatirNo { get; set; }

    public string? SthIstisna { get; set; }

    public byte? SthOtvTevkifatTuru { get; set; }

    public double? SthOtvTevkifatTutari { get; set; }

    public Guid? SthServisharUid { get; set; }

    public Guid? SthBakimsarfUid { get; set; }

    public byte? SthUtsbildirimturu { get; set; }

    public byte? SthUtshekzayiatturu { get; set; }

    public byte? SthUtsimhabertarafgerekcesi { get; set; }

    public string? SthUtsdigergerekceaciklamasi { get; set; }

    public string? SthHizlisatisPromosyonkodu1 { get; set; }

    public string? SthHizlisatisPromosyonkodu2 { get; set; }

    public string? SthHizlisatisPromosyonkodu3 { get; set; }

    public string? SthHksKunyeNo { get; set; }

    public string? SthHksCarikodu { get; set; }

    public byte? SthTevkifatIslemTuruIdx { get; set; }
}
