using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokSerinoTanimlari
{
    public Guid ChzGuid { get; set; }

    public short ChzDbcno { get; set; }

    public int? ChzSpecRecNo { get; set; }

    public bool? ChzIptal { get; set; }

    public short? ChzFileid { get; set; }

    public bool? ChzHidden { get; set; }

    public bool? ChzKilitli { get; set; }

    public bool? ChzDegisti { get; set; }

    public int? ChzChecksum { get; set; }

    public short? ChzCreateUser { get; set; }

    public DateTime ChzCreateDate { get; set; }

    public short? ChzLastupUser { get; set; }

    public DateTime? ChzLastupDate { get; set; }

    public string? ChzSpecial1 { get; set; }

    public string? ChzSpecial2 { get; set; }

    public string? ChzSpecial3 { get; set; }

    public string? ChzSerino { get; set; }

    public string? ChzStokKodu { get; set; }

    public string? ChzGrupKodu { get; set; }

    public string? ChzTuktckodu { get; set; }

    public DateTime? ChzGrnBasTarihi { get; set; }

    public DateTime? ChzGrnBitTarihi { get; set; }

    public string? ChzAciklama1 { get; set; }

    public string? ChzAciklama2 { get; set; }

    public string? ChzAciklama3 { get; set; }

    public DateTime? ChzAlTarih { get; set; }

    public string? ChzAlEvrSeri { get; set; }

    public int? ChzAlEvrSira { get; set; }

    public string? ChzAlCariKodu { get; set; }

    public DateTime? ChzAlWdTarih { get; set; }

    public string? ChzAlWdEvrSeri { get; set; }

    public int? ChzAlWdEvrSira { get; set; }

    public DateTime? ChzStTarih { get; set; }

    public string? ChzStEvrSeri { get; set; }

    public int? ChzStEvrSira { get; set; }

    public string? ChzStCariKodu { get; set; }

    public DateTime? ChzStWdTarih { get; set; }

    public string? ChzStWdEvrSeri { get; set; }

    public int? ChzStWdEvrSira { get; set; }

    public double? ChzBrutFiati { get; set; }

    public double? ChzAlFiatiAna { get; set; }

    public double? ChzAlFiatiAlt { get; set; }

    public double? ChzAlFiatiOrj { get; set; }

    public double? ChzStFiatiAna { get; set; }

    public double? ChzStFiatiAlt { get; set; }

    public double? ChzStFiatiOrj { get; set; }

    public bool? ChzParcaGarantisi { get; set; }

    public string? ChzParcaSerino { get; set; }

    public DateTime? ChzParcaGarantiBaslangic { get; set; }

    public DateTime? ChzParcaGarantiBitis { get; set; }

    public byte? ChzMakinaTipi { get; set; }

    public string? ChzModelYili { get; set; }

    public DateTime? ChzKirayaAcilmaTarihi { get; set; }

    public DateTime? ChzMusteriGarantiBaslangic { get; set; }

    public DateTime? ChzMusteriGarantiBitis { get; set; }

    public string? ChzDemirbasKodu { get; set; }

    public DateTime? ChzTescilTarihi { get; set; }

    public byte? ChzBakimTipi { get; set; }

    public DateTime? ChzBakimTarihi { get; set; }

    public int? ChzAraBakimSayisi { get; set; }

    public byte? ChzBakimPeryodu { get; set; }

    public byte? ChzSayacTipi { get; set; }

    public double? ChzSonSayacDegeri { get; set; }

    public string? ChzMotorSeriNo { get; set; }

    public string? ChzSaseNo { get; set; }

    public bool? ChzHgsFl { get; set; }

    public string? ChzHgsNo { get; set; }

    public bool? ChzOgsFl { get; set; }

    public string? ChzOgsNo { get; set; }

    public string? ChzRuhsatNo { get; set; }

    public string? ChzRuhsatSahibi { get; set; }

    public bool? ChzRehinFl { get; set; }

    public string? ChzRehinNedeni { get; set; }

    public double? ChzSifirlamaOncesiSayac { get; set; }

    public double? ChzDevirServisSayac { get; set; }

    public double? ChzDevirServisPeryodu { get; set; }
}
