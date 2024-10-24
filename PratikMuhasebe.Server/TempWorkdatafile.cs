using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TempWorkdatafile
{
    public Guid SessionId { get; set; }

    public Guid SthGuid { get; set; }

    public short SthDbcno { get; set; }

    public int? SthSpecRecno { get; set; }

    public bool? SthIptal { get; set; }

    public short? SthFileid { get; set; }

    public bool? SthHidden { get; set; }

    public bool? SthKilitli { get; set; }

    public bool? SthDegisti { get; set; }

    public int? SthChecksum { get; set; }

    public short? SthCreateUser { get; set; }

    public DateTime? SthCreateDate { get; set; }

    public short? SthLastupUser { get; set; }

    public DateTime? SthLastupDate { get; set; }

    public string? SthSpecial1 { get; set; }

    public string? SthSpecial2 { get; set; }

    public string? SthSpecial3 { get; set; }

    public int? SthFirmano { get; set; }

    public int? SthSubeno { get; set; }

    public DateTime? SthTarih { get; set; }

    public byte? SthTip { get; set; }

    public byte? SthCins { get; set; }

    public byte? SthNormalIade { get; set; }

    public byte? SthEvraktip { get; set; }

    public string? SthEvraknoSeri { get; set; }

    public int? SthEvraknoSira { get; set; }

    public int? SthSatirno { get; set; }

    public string? SthBelgeNo { get; set; }

    public DateTime? SthBelgeTarih { get; set; }

    public string? SthStokKod { get; set; }

    public byte? SthIskMas1 { get; set; }

    public byte? SthIskMas2 { get; set; }

    public byte? SthIskMas3 { get; set; }

    public byte? SthIskMas4 { get; set; }

    public byte? SthIskMas5 { get; set; }

    public byte? SthIskMas6 { get; set; }

    public byte? SthIskMas7 { get; set; }

    public byte? SthIskMas8 { get; set; }

    public byte? SthIskMas9 { get; set; }

    public byte? SthIskMas10 { get; set; }

    public bool? SthSatIskmas1 { get; set; }

    public bool? SthSatIskmas2 { get; set; }

    public bool? SthSatIskmas3 { get; set; }

    public bool? SthSatIskmas4 { get; set; }

    public bool? SthSatIskmas5 { get; set; }

    public bool? SthSatIskmas6 { get; set; }

    public bool? SthSatIskmas7 { get; set; }

    public bool? SthSatIskmas8 { get; set; }

    public bool? SthSatIskmas9 { get; set; }

    public bool? SthSatIskmas10 { get; set; }

    public byte? SthPosSatis { get; set; }

    public bool? SthPromosyonFl { get; set; }

    public byte? SthCariCinsi { get; set; }

    public string? SthCariKodu { get; set; }

    public byte? SthCariGrupNo { get; set; }

    public string? SthIsemriGiderKodu { get; set; }

    public string? SthPlasiyerKodu { get; set; }

    public byte? SthHarDovizCinsi { get; set; }

    public double? SthHarDovizKuru { get; set; }

    public double? SthAltDovizKuru { get; set; }

    public byte? SthStokDovizCinsi { get; set; }

    public double? SthStokDovizKuru { get; set; }

    public double? SthMiktar { get; set; }

    public double? SthMiktar2 { get; set; }

    public byte? SthBirimPntr { get; set; }

    public double? SthTutar { get; set; }

    public double? SthIskonto1 { get; set; }

    public double? SthIskonto2 { get; set; }

    public double? SthIskonto3 { get; set; }

    public double? SthIskonto4 { get; set; }

    public double? SthIskonto5 { get; set; }

    public double? SthIskonto6 { get; set; }

    public double? SthMasraf1 { get; set; }

    public double? SthMasraf2 { get; set; }

    public double? SthMasraf3 { get; set; }

    public double? SthMasraf4 { get; set; }

    public byte? SthVergiPntr { get; set; }

    public double? SthVergi { get; set; }

    public byte? SthMasrafVergiPntr { get; set; }

    public double? SthMasrafVergi { get; set; }

    public double? SthNetagirlik { get; set; }

    public int? SthOdemeOp { get; set; }

    public string? SthAciklama { get; set; }

    public Guid? SthSipUid { get; set; }

    public Guid? SthFatUid { get; set; }

    public int? SthGirisDepoNo { get; set; }

    public int? SthCikisDepoNo { get; set; }

    public DateTime? SthMalkblSevkTarihi { get; set; }

    public string? SthCariSrmMerkezi { get; set; }

    public string? SthStokSrmMerkezi { get; set; }

    public DateTime? SthFisTarihi { get; set; }

    public int? SthFisSirano { get; set; }

    public bool? SthVergisizFl { get; set; }

    public double? SthMaliyetAna { get; set; }

    public double? SthMaliyetAlternatif { get; set; }

    public double? SthMaliyetOrjinal { get; set; }

    public int? SthAdresNo { get; set; }

    public string? SthPartiKodu { get; set; }

    public int? SthLotNo { get; set; }

    public Guid? SthKonsUid { get; set; }

    public string? SthProjeKodu { get; set; }

    public string? SthEximKodu { get; set; }

    public byte? SthOtvPntr { get; set; }

    public double? SthOtvVergi { get; set; }

    public double? SthBrutagirlik { get; set; }

    public byte? SthDisticaretTuru { get; set; }

    public double? SthOtvtutari { get; set; }

    public bool? SthOtvvergisizFl { get; set; }

    public byte? SthOivPntr { get; set; }

    public double? SthOivVergi { get; set; }

    public bool? SthOivvergisizFl { get; set; }

    public int? SthFiyatListeNo { get; set; }

    public double? SthOivtutari { get; set; }

    public byte? SthTevkifatTuru { get; set; }

    public int? SthNakliyedeposu { get; set; }

    public byte? SthNakliyedurumu { get; set; }

    public Guid? SthYetkiliUid { get; set; }

    public bool? SthTaxfreeFl { get; set; }

    public double? SthIlaveEdilecekKdv { get; set; }
}
