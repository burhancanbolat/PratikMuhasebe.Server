using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BakimKabulHareketleri
{
    public Guid BkmkbGuid { get; set; }

    public short BkmkbDbcno { get; set; }

    public int? BkmkbSpecRecNo { get; set; }

    public bool? BkmkbIptal { get; set; }

    public short? BkmkbFileid { get; set; }

    public bool? BkmkbHidden { get; set; }

    public bool? BkmkbKilitli { get; set; }

    public bool? BkmkbDegisti { get; set; }

    public int? BkmkbChecksum { get; set; }

    public short? BkmkbCreateUser { get; set; }

    public DateTime BkmkbCreateDate { get; set; }

    public short? BkmkbLastupUser { get; set; }

    public DateTime? BkmkbLastupDate { get; set; }

    public string? BkmkbSpecial1 { get; set; }

    public string? BkmkbSpecial2 { get; set; }

    public string? BkmkbSpecial3 { get; set; }

    public int? BkmkbFirmano { get; set; }

    public int? BkmkbSubeno { get; set; }

    public DateTime? BkmkbTarihi { get; set; }

    public string? BkmkbEvraknoSeri { get; set; }

    public int? BkmkbEvraknoSira { get; set; }

    public int? BkmkbSatirno { get; set; }

    public string? BkmkbBelgeno { get; set; }

    public DateTime? BkmkbBelgeTarihi { get; set; }

    public string? BkmkbCihazSerino { get; set; }

    public string? BkmkbFisStokKodu { get; set; }

    public string? BkmkbTuketiciKodu { get; set; }

    public byte? BkmkbTalepGelisSekli { get; set; }

    public string? BkmkbGelisKargoKodu { get; set; }

    public string? BkmkbGelisKargoBelgeno { get; set; }

    public string? BkmkbGelisIrsaliyeno { get; set; }

    public byte? BkmkbServisTuru { get; set; }

    public byte? BkmkbServisYeri { get; set; }

    public string? BkmkbAksesuarlar { get; set; }

    public string? BkmkbBildirilenArizalar { get; set; }

    public DateTime? BkmkbTeslimAlinmaTarihi { get; set; }

    public DateTime? BkmkbTeslimEdilmeTarihi { get; set; }

    public byte? BkmkbTeslimEdilmeSekli { get; set; }

    public string? BkmkbArizaKodu1 { get; set; }

    public string? BkmkbArizaKodu2 { get; set; }

    public string? BkmkbArizaKodu3 { get; set; }

    public string? BkmkbArizaKodu4 { get; set; }

    public string? BkmkbArizaKodu5 { get; set; }

    public string? BkmkbArizaKodu6 { get; set; }

    public string? BkmkbArizaKodu7 { get; set; }

    public string? BkmkbArizaKodu8 { get; set; }

    public string? BkmkbArizaKodu9 { get; set; }

    public string? BkmkbArizaKodu10 { get; set; }

    public byte? BkmkbBilgilendirmeSekli { get; set; }

    public string? BkmkbInceleyecekEkipKodu { get; set; }

    public int? BkmkbDepono { get; set; }

    public string? BkmkbAciklama { get; set; }

    public byte? BkmkbHareketTipi { get; set; }

    public string? BkmkbStokHizmetKodu { get; set; }

    public int? BkmkbOperasyonSuresi { get; set; }

    public double? BkmkbMiktari { get; set; }

    public string? BkmkbSatirAciklama { get; set; }

    public bool? BkmkbPlanlandiFl { get; set; }

    public int? BkmkbAdresNo { get; set; }

    public Guid? BkmkbSozlesmeUid { get; set; }
}
