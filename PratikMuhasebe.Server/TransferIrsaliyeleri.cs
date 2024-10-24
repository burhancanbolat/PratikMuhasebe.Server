using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TransferIrsaliyeleri
{
    public Guid TransirsGuid { get; set; }

    public short TransirsDbcno { get; set; }

    public int? TransirsSpecRecno { get; set; }

    public bool? TransirsIptal { get; set; }

    public short? TransirsFileid { get; set; }

    public bool? TransirsHidden { get; set; }

    public bool? TransirsKilitli { get; set; }

    public bool? TransirsDegisti { get; set; }

    public int? TransirsChecksum { get; set; }

    public short? TransirsCreateUser { get; set; }

    public DateTime TransirsCreateDate { get; set; }

    public short? TransirsLastupUser { get; set; }

    public DateTime? TransirsLastupDate { get; set; }

    public string? TransirsSpecial1 { get; set; }

    public string? TransirsSpecial2 { get; set; }

    public string? TransirsSpecial3 { get; set; }

    public int? TransirsFirmano { get; set; }

    public int? TransirsSubeno { get; set; }

    public DateTime? TransirsTarih { get; set; }

    public string? TransirsEvraknoSeri { get; set; }

    public int? TransirsEvraknoSira { get; set; }

    public int? TransirsSatirno { get; set; }

    public string? TransirsBelgeNo { get; set; }

    public DateTime? TransirsBelgeTarih { get; set; }

    public string? TransirsTalepcarikodu { get; set; }

    public byte? TransirsTalepcarigrupno { get; set; }

    public int? TransirsTalepcariadresno { get; set; }

    public string? TransirsTemincarikodu { get; set; }

    public byte? TransirsTemincarigrupno { get; set; }

    public int? TransirsTemincariadresno { get; set; }

    public string? TransirsPlasiyerKodu { get; set; }

    public string? TransirsStokKod { get; set; }

    public byte? TransirsIskMas1 { get; set; }

    public byte? TransirsIskMas2 { get; set; }

    public byte? TransirsIskMas3 { get; set; }

    public byte? TransirsIskMas4 { get; set; }

    public byte? TransirsIskMas5 { get; set; }

    public byte? TransirsIskMas6 { get; set; }

    public byte? TransirsIskMas7 { get; set; }

    public byte? TransirsIskMas8 { get; set; }

    public byte? TransirsIskMas9 { get; set; }

    public byte? TransirsIskMas10 { get; set; }

    public bool? TransirsSatIskmas1 { get; set; }

    public bool? TransirsSatIskmas2 { get; set; }

    public bool? TransirsSatIskmas3 { get; set; }

    public bool? TransirsSatIskmas4 { get; set; }

    public bool? TransirsSatIskmas5 { get; set; }

    public bool? TransirsSatIskmas6 { get; set; }

    public bool? TransirsSatIskmas7 { get; set; }

    public bool? TransirsSatIskmas8 { get; set; }

    public bool? TransirsSatIskmas9 { get; set; }

    public bool? TransirsSatIskmas10 { get; set; }

    public string? TransirsPaketKodu { get; set; }

    public byte? TransirsHarDovizCinsi { get; set; }

    public double? TransirsHarDovizKuru { get; set; }

    public double? TransirsAltDovizKuru { get; set; }

    public byte? TransirsStokDovizCinsi { get; set; }

    public double? TransirsStokDovizKuru { get; set; }

    public double? TransirsMiktar { get; set; }

    public double? TransirsMiktar2 { get; set; }

    public byte? TransirsBirimPntr { get; set; }

    public double? TransirsBirimfiyati { get; set; }

    public double? TransirsTutar { get; set; }

    public double? TransirsIskonto1 { get; set; }

    public double? TransirsIskonto2 { get; set; }

    public double? TransirsIskonto3 { get; set; }

    public double? TransirsIskonto4 { get; set; }

    public double? TransirsIskonto5 { get; set; }

    public double? TransirsIskonto6 { get; set; }

    public double? TransirsMasraf1 { get; set; }

    public double? TransirsMasraf2 { get; set; }

    public double? TransirsMasraf3 { get; set; }

    public double? TransirsMasraf4 { get; set; }

    public byte? TransirsVergiPntr { get; set; }

    public double? TransirsVergi { get; set; }

    public byte? TransirsMasrafVergiPntr { get; set; }

    public double? TransirsMasrafVergi { get; set; }

    public double? TransirsNetagirlik { get; set; }

    public int? TransirsOdemeOp { get; set; }

    public string? TransirsAciklama { get; set; }

    public Guid? TransirsSipUid { get; set; }

    public DateTime? TransirsMalkblSevkTarihi { get; set; }

    public string? TransirsCariSrmMerkezi { get; set; }

    public string? TransirsStokSrmMerkezi { get; set; }

    public bool? TransirsVergisizFl { get; set; }

    public double? TransirsMaliyetAna { get; set; }

    public double? TransirsMaliyetAlternatif { get; set; }

    public double? TransirsMaliyetOrjinal { get; set; }

    public string? TransirsPartiKodu { get; set; }

    public int? TransirsLotNo { get; set; }

    public string? TransirsProjeKodu { get; set; }

    public byte? TransirsOtvPntr { get; set; }

    public double? TransirsOtvVergi { get; set; }

    public double? TransirsBrutagirlik { get; set; }

    public double? TransirsOtvtutari { get; set; }

    public bool? TransirsOtvvergisizFl { get; set; }

    public byte? TransirsOivPntr { get; set; }

    public double? TransirsOivTutar { get; set; }

    public double? TransirsOivVergi { get; set; }

    public bool? TransirsOivvergisizFl { get; set; }

    public int? TransirsFiyatlisteno { get; set; }

    public Guid? TransirsTalepkomfatUid { get; set; }

    public Guid? TransirsTeminkomfatUid { get; set; }
}
