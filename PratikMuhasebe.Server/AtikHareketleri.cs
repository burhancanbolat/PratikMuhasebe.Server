using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AtikHareketleri
{
    public Guid AthGuid { get; set; }

    public short AthDbcno { get; set; }

    public int? AthSpecRecno { get; set; }

    public bool? AthIptal { get; set; }

    public short? AthFileid { get; set; }

    public bool? AthHidden { get; set; }

    public bool? AthKilitli { get; set; }

    public bool? AthDegisti { get; set; }

    public int? AthChecksum { get; set; }

    public short? AthCreateUser { get; set; }

    public DateTime AthCreateDate { get; set; }

    public short? AthLastupUser { get; set; }

    public DateTime? AthLastupDate { get; set; }

    public string? AthSpecial1 { get; set; }

    public string? AthSpecial2 { get; set; }

    public string? AthSpecial3 { get; set; }

    public int? AthFirmano { get; set; }

    public int? AthSubeno { get; set; }

    public byte? AthCins { get; set; }

    public DateTime? AthTarih { get; set; }

    public byte? AthTip { get; set; }

    public byte? AthNormalIade { get; set; }

    public byte? AthEvraktip { get; set; }

    public string? AthEvraknoSeri { get; set; }

    public int? AthEvraknoSira { get; set; }

    public int? AthSatirno { get; set; }

    public string? AthBelgeNo { get; set; }

    public DateTime? AthBelgeTarih { get; set; }

    public string? AthAtikKod { get; set; }

    public byte? AthIskMas1 { get; set; }

    public byte? AthIskMas2 { get; set; }

    public byte? AthIskMas3 { get; set; }

    public byte? AthIskMas4 { get; set; }

    public byte? AthIskMas5 { get; set; }

    public byte? AthIskMas6 { get; set; }

    public byte? AthIskMas7 { get; set; }

    public byte? AthIskMas8 { get; set; }

    public byte? AthIskMas9 { get; set; }

    public byte? AthIskMas10 { get; set; }

    public bool? AthSatIskmas1 { get; set; }

    public bool? AthSatIskmas2 { get; set; }

    public bool? AthSatIskmas3 { get; set; }

    public bool? AthSatIskmas4 { get; set; }

    public bool? AthSatIskmas5 { get; set; }

    public bool? AthSatIskmas6 { get; set; }

    public bool? AthSatIskmas7 { get; set; }

    public bool? AthSatIskmas8 { get; set; }

    public bool? AthSatIskmas9 { get; set; }

    public bool? AthSatIskmas10 { get; set; }

    public string? AthCariKodu { get; set; }

    public string? AthPlasiyerKodu { get; set; }

    public byte? AthHarDovizCinsi { get; set; }

    public double? AthHarDovizKuru { get; set; }

    public double? AthAltDovizKuru { get; set; }

    public byte? AthAtikDovizCinsi { get; set; }

    public double? AthAtikDovizKuru { get; set; }

    public double? AthMiktar { get; set; }

    public double? AthTutar { get; set; }

    public double? AthIskonto1 { get; set; }

    public double? AthIskonto2 { get; set; }

    public double? AthIskonto3 { get; set; }

    public double? AthIskonto4 { get; set; }

    public double? AthIskonto5 { get; set; }

    public double? AthIskonto6 { get; set; }

    public double? AthMasraf1 { get; set; }

    public double? AthMasraf2 { get; set; }

    public double? AthMasraf3 { get; set; }

    public double? AthMasraf4 { get; set; }

    public byte? AthVergiPntr { get; set; }

    public double? AthVergi { get; set; }

    public byte? AthMasrafVergiPntr { get; set; }

    public double? AthMasrafVergi { get; set; }

    public int? AthOdemeOp { get; set; }

    public string? AthAciklama { get; set; }

    public Guid? AthSipUid { get; set; }

    public Guid? AthFatUid { get; set; }

    public int? AthGirisDepoNo { get; set; }

    public int? AthCikisDepoNo { get; set; }

    public DateTime? AthMalkblSevkTarihi { get; set; }

    public string? AthCariSrmMerkezi { get; set; }

    public string? AthAtikSrmMerkezi { get; set; }

    public bool? AthVergisizFl { get; set; }

    public double? AthMaliyetAna { get; set; }

    public double? AthMaliyetAlternatif { get; set; }

    public double? AthMaliyetOrjinal { get; set; }

    public int? AthAdresNo { get; set; }

    public Guid? AthKonsUid { get; set; }

    public string? AthProjeKodu { get; set; }

    public byte? AthOtvPntr { get; set; }

    public double? AthOtvVergi { get; set; }

    public double? AthOtvtutari { get; set; }

    public bool? AthOtvvergisizFl { get; set; }

    public Guid? AthYetkiliUid { get; set; }

    public bool? AthTaxfreeFl { get; set; }

    public double? AthIlaveEdilecekKdv { get; set; }

    public string? AthHareketGrupKodu1 { get; set; }

    public string? AthHareketGrupKodu2 { get; set; }

    public string? AthHareketGrupKodu3 { get; set; }

    public byte? AthEirsSenaryo { get; set; }

    public byte? AthEirsTipi { get; set; }

    public DateTime? AthTeslimTarihi { get; set; }

    public bool? AthMatbuFl { get; set; }

    public byte? AthSatisFiyatDovizCinsi { get; set; }

    public double? AthSatisFiyatDovizKuru { get; set; }
}
