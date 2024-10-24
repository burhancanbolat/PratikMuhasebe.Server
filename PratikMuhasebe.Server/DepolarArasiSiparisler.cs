using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DepolarArasiSiparisler
{
    public Guid SsipGuid { get; set; }

    public short SsipDbcno { get; set; }

    public int? SsipSpecRecno { get; set; }

    public bool? SsipIptal { get; set; }

    public short? SsipFileid { get; set; }

    public bool? SsipHidden { get; set; }

    public bool? SsipKilitli { get; set; }

    public bool? SsipDegisti { get; set; }

    public int? SsipChecksum { get; set; }

    public short? SsipCreateUser { get; set; }

    public DateTime SsipCreateDate { get; set; }

    public short? SsipLastupUser { get; set; }

    public DateTime? SsipLastupDate { get; set; }

    public string? SsipSpecial1 { get; set; }

    public string? SsipSpecial2 { get; set; }

    public string? SsipSpecial3 { get; set; }

    public int? SsipFirmano { get; set; }

    public int? SsipSubeno { get; set; }

    public DateTime? SsipTarih { get; set; }

    public DateTime? SsipTeslimTarih { get; set; }

    public string? SsipEvraknoSeri { get; set; }

    public int? SsipEvraknoSira { get; set; }

    public int? SsipSatirno { get; set; }

    public string? SsipBelgeno { get; set; }

    public DateTime? SsipBelgeTarih { get; set; }

    public string? SsipStokKod { get; set; }

    public double? SsipMiktar { get; set; }

    public double? SsipBFiyat { get; set; }

    public double? SsipTutar { get; set; }

    public double? SsipTeslimMiktar { get; set; }

    public string? SsipAciklama { get; set; }

    public int? SsipGirdepo { get; set; }

    public int? SsipCikdepo { get; set; }

    public bool? SsipKapatFl { get; set; }

    public byte? SsipBirimPntr { get; set; }

    public int? SsipFiyatListeNo { get; set; }

    public Guid? SsipStalUid { get; set; }

    public string? SsipPaketKod { get; set; }

    public string? SsipKapatmanedenkod { get; set; }

    public string? SsipProjekodu { get; set; }

    public string? SsipSormerkezi { get; set; }

    public DateTime? SsipGecerlilikTarihi { get; set; }

    public double? SsipRezervasyonMiktari { get; set; }

    public double? SsipRezervedenTeslimEdilen { get; set; }
}
