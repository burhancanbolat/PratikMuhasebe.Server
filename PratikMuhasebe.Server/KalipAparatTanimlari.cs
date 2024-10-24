using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KalipAparatTanimlari
{
    public Guid KlpGuid { get; set; }

    public short KlpDbcno { get; set; }

    public int? KlpSpecRecno { get; set; }

    public bool? KlpIptal { get; set; }

    public short? KlpFileid { get; set; }

    public bool? KlpHidden { get; set; }

    public bool? KlpKilitli { get; set; }

    public bool? KlpDegisti { get; set; }

    public int? KlpChecksum { get; set; }

    public short? KlpCreateUser { get; set; }

    public DateTime KlpCreateDate { get; set; }

    public short? KlpLastupUser { get; set; }

    public DateTime? KlpLastupDate { get; set; }

    public string? KlpSpecial1 { get; set; }

    public string? KlpSpecial2 { get; set; }

    public string? KlpSpecial3 { get; set; }

    public string? KlpKodu { get; set; }

    public string? KlpAdi { get; set; }

    public string? KlpUrunkodu { get; set; }

    public double? KlpUretimMiktari { get; set; }

    public bool? KlpAktifFl { get; set; }

    public string? KlpCalismaTakvimkodu { get; set; }

    public bool? KlpKurulumVardiyaNosu1 { get; set; }

    public bool? KlpKurulumVardiyaNosu2 { get; set; }

    public bool? KlpKurulumVardiyaNosu3 { get; set; }

    public bool? KlpKurulumVardiyaNosu4 { get; set; }

    public int? KlpKurulumSuresi { get; set; }

    public string? KlpKurulumYetkilisi { get; set; }

    public string? KlpBakimYetkilisi { get; set; }

    public string? KlpSrmmrkKodu { get; set; }

    public string? KlpMasterKalipKodu { get; set; }

    public string? KlpSabitKiymetKodu { get; set; }

    public short? KlpBakimPeriyodu { get; set; }

    public DateTime? KlpSonBakimTarihi { get; set; }

    public int? KlpRenk { get; set; }

    public double? KlpYollukFireKatsayisi { get; set; }

    public short? KlpGozSayisi { get; set; }

    public string? KlpImalatciKodu { get; set; }

    public DateTime? KlpImalTarihi { get; set; }

    public int? KlpEn { get; set; }

    public int? KlpBoy { get; set; }

    public int? KlpYukseklik { get; set; }

    public double? KlpAgirlik { get; set; }
}
