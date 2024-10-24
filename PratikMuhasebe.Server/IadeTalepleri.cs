using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IadeTalepleri
{
    public Guid ItlpGuid { get; set; }

    public short ItlpDbcno { get; set; }

    public int? ItlpSpecRecno { get; set; }

    public bool? ItlpIptal { get; set; }

    public short? ItlpFileid { get; set; }

    public bool? ItlpHidden { get; set; }

    public bool? ItlpKilitli { get; set; }

    public bool? ItlpDegisti { get; set; }

    public int? ItlpChecksum { get; set; }

    public short? ItlpCreateUser { get; set; }

    public DateTime ItlpCreateDate { get; set; }

    public short? ItlpLastupUser { get; set; }

    public DateTime? ItlpLastupDate { get; set; }

    public string? ItlpSpecial1 { get; set; }

    public string? ItlpSpecial2 { get; set; }

    public string? ItlpSpecial3 { get; set; }

    public int? ItlpFirmano { get; set; }

    public int? ItlpSubeno { get; set; }

    public DateTime? ItlpTarihi { get; set; }

    public DateTime? ItlpTeslimTarihi { get; set; }

    public byte? ItlpTip { get; set; }

    public string? ItlpEvrakSeri { get; set; }

    public int? ItlpEvrakSira { get; set; }

    public int? ItlpSatirNo { get; set; }

    public string? ItlpBelgeNo { get; set; }

    public DateTime? ItlpBelgeTarihi { get; set; }

    public string? ItlpMusteriKodu { get; set; }

    public string? ItlpSorMerkKodu { get; set; }

    public int? ItlpOpno { get; set; }

    public string? ItlpStokKodu { get; set; }

    public string? ItlpSaticiKodu { get; set; }

    public double? ItlpMiktari { get; set; }

    public double? ItlpTeslimMiktari { get; set; }

    public string? ItlpAciklama { get; set; }

    public int? ItlpDepoNo { get; set; }

    public byte? ItlpCariGrupno { get; set; }

    public byte? ItlpDovizCinsi { get; set; }

    public byte? ItlpDovizKuru { get; set; }

    public double? ItlpBirimFiyat { get; set; }

    public int? ItlpFiyatListeno { get; set; }

    public double? ItlpTutar { get; set; }

    public bool? ItlpKapatFl { get; set; }

    public string? ItlpProjekodu { get; set; }

    public string? ItlpPartiKodu { get; set; }

    public int? ItlpLotNo { get; set; }

    public short? ItlpOnaylayanKulno { get; set; }

    public bool? ItlpCagrilabilirFl { get; set; }

    public string? ItlpKapatmanedenkod { get; set; }

    public double? ItlpIskonto1 { get; set; }

    public double? ItlpIskonto2 { get; set; }

    public double? ItlpIskonto3 { get; set; }

    public double? ItlpIskonto4 { get; set; }

    public double? ItlpIskonto5 { get; set; }

    public double? ItlpIskonto6 { get; set; }

    public double? ItlpMasraf1 { get; set; }

    public double? ItlpMasraf2 { get; set; }

    public double? ItlpMasraf3 { get; set; }

    public double? ItlpMasraf4 { get; set; }

    public byte? ItlpIskonto11 { get; set; }

    public byte? ItlpIskonto21 { get; set; }

    public byte? ItlpIskonto31 { get; set; }

    public byte? ItlpIskonto41 { get; set; }

    public byte? ItlpIskonto51 { get; set; }

    public byte? ItlpIskonto61 { get; set; }

    public byte? ItlpMasraf11 { get; set; }

    public byte? ItlpMasraf21 { get; set; }

    public byte? ItlpMasraf31 { get; set; }

    public byte? ItlpMasraf41 { get; set; }

    public bool? ItlpIsk1 { get; set; }

    public bool? ItlpIsk2 { get; set; }

    public bool? ItlpIsk3 { get; set; }

    public bool? ItlpIsk4 { get; set; }

    public bool? ItlpIsk5 { get; set; }

    public bool? ItlpIsk6 { get; set; }

    public bool? ItlpMas1 { get; set; }

    public bool? ItlpMas2 { get; set; }

    public bool? ItlpMas3 { get; set; }

    public bool? ItlpMas4 { get; set; }
}
