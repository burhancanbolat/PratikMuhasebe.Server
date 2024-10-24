using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TransferSiparisleri
{
    public Guid TranssipGuid { get; set; }

    public short TranssipDbcno { get; set; }

    public int? TranssipSpecRecno { get; set; }

    public bool? TranssipIptal { get; set; }

    public short? TranssipFileid { get; set; }

    public bool? TranssipHidden { get; set; }

    public bool? TranssipKilitli { get; set; }

    public bool? TranssipDegisti { get; set; }

    public int? TranssipChecksum { get; set; }

    public short? TranssipCreateUser { get; set; }

    public DateTime TranssipCreateDate { get; set; }

    public short? TranssipLastupUser { get; set; }

    public DateTime? TranssipLastupDate { get; set; }

    public string? TranssipSpecial1 { get; set; }

    public string? TranssipSpecial2 { get; set; }

    public string? TranssipSpecial3 { get; set; }

    public int? TranssipFirmano { get; set; }

    public int? TranssipSubeno { get; set; }

    public DateTime? TranssipTarih { get; set; }

    public DateTime? TranssipTeslimTarih { get; set; }

    public string? TranssipEvraknoSeri { get; set; }

    public int? TranssipEvraknoSira { get; set; }

    public int? TranssipSatirno { get; set; }

    public string? TranssipBelgeno { get; set; }

    public DateTime? TranssipBelgeTarih { get; set; }

    public string? TranssipTalepcarikodu { get; set; }

    public int? TranssipTalepcariadresno { get; set; }

    public string? TranssipTemincarikodu { get; set; }

    public int? TranssipTemincariadresno { get; set; }

    public string? TranssipPlasiyerKodu { get; set; }

    public string? TranssipStokKod { get; set; }

    public double? TranssipBFiyat { get; set; }

    public double? TranssipMiktar { get; set; }

    public byte? TranssipBirimPntr { get; set; }

    public double? TranssipTeslimMiktar { get; set; }

    public double? TranssipTutar { get; set; }

    public double? TranssipIskonto1 { get; set; }

    public double? TranssipIskonto2 { get; set; }

    public double? TranssipIskonto3 { get; set; }

    public double? TranssipIskonto4 { get; set; }

    public double? TranssipIskonto5 { get; set; }

    public double? TranssipIskonto6 { get; set; }

    public double? TranssipMasraf1 { get; set; }

    public double? TranssipMasraf2 { get; set; }

    public double? TranssipMasraf3 { get; set; }

    public double? TranssipMasraf4 { get; set; }

    public byte? TranssipVergiPntr { get; set; }

    public double? TranssipVergi { get; set; }

    public byte? TranssipMasvergiPntr { get; set; }

    public double? TranssipMasvergi { get; set; }

    public int? TranssipOpno { get; set; }

    public string? TranssipAciklama { get; set; }

    public short? TranssipOnaylayanKulNo { get; set; }

    public bool? TranssipVergisizFl { get; set; }

    public bool? TranssipKapatFl { get; set; }

    public string? TranssipCariSormerk { get; set; }

    public string? TranssipStokSormerk { get; set; }

    public byte? TranssipDovizCinsi { get; set; }

    public double? TranssipDovizKuru { get; set; }

    public double? TranssipAltDovizKuru { get; set; }

    public string? TranssipTeslimturu { get; set; }

    public bool? TranssipCagrilabilirFl { get; set; }

    public byte? TranssipIskonto11 { get; set; }

    public byte? TranssipIskonto21 { get; set; }

    public byte? TranssipIskonto31 { get; set; }

    public byte? TranssipIskonto41 { get; set; }

    public byte? TranssipIskonto51 { get; set; }

    public byte? TranssipIskonto61 { get; set; }

    public byte? TranssipMasraf11 { get; set; }

    public byte? TranssipMasraf21 { get; set; }

    public byte? TranssipMasraf31 { get; set; }

    public byte? TranssipMasraf41 { get; set; }

    public bool? TranssipIsk1 { get; set; }

    public bool? TranssipIsk2 { get; set; }

    public bool? TranssipIsk3 { get; set; }

    public bool? TranssipIsk4 { get; set; }

    public bool? TranssipIsk5 { get; set; }

    public bool? TranssipIsk6 { get; set; }

    public bool? TranssipMas1 { get; set; }

    public bool? TranssipMas2 { get; set; }

    public bool? TranssipMas3 { get; set; }

    public bool? TranssipMas4 { get; set; }

    public string? TranssipAciklama2 { get; set; }

    public double? TranssipKarOrani { get; set; }

    public byte? TranssipDurumu { get; set; }

    public string? TranssipPartiKodu { get; set; }

    public int? TranssipLotNo { get; set; }

    public string? TranssipProjekodu { get; set; }

    public int? TranssipFiyatlisteno { get; set; }

    public byte? TranssipOtvpntr { get; set; }

    public double? TranssipOtvvergi { get; set; }

    public double? TranssipOtvtutari { get; set; }

    public byte? TranssipOtvvergisizFl { get; set; }

    public string? TranssipPaketKodu { get; set; }

    public string? TranssipKapatmanedenkod { get; set; }
}
