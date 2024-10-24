using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsletmeHareketleri
{
    public Guid DfisGuid { get; set; }

    public short DfisDbcno { get; set; }

    public int? DfisSpecRecno { get; set; }

    public bool? DfisIptal { get; set; }

    public short? DfisFileid { get; set; }

    public bool? DfisHidden { get; set; }

    public bool? DfisKilitli { get; set; }

    public bool? DfisDegisti { get; set; }

    public int? DfisChecksum { get; set; }

    public short? DfisCreateUser { get; set; }

    public DateTime DfisCreateDate { get; set; }

    public short? DfisLastupUser { get; set; }

    public DateTime? DfisLastupDate { get; set; }

    public string? DfisSpecial1 { get; set; }

    public string? DfisSpecial2 { get; set; }

    public string? DfisSpecial3 { get; set; }

    public int? DfisFirmano { get; set; }

    public int? DfisSubeno { get; set; }

    public int? DfisMaliyil { get; set; }

    public DateTime? DfisTarih { get; set; }

    public string? DfisHesapKod { get; set; }

    public string? DfisAciklama1 { get; set; }

    public double? DfisMeblag0 { get; set; }

    public double? DfisMeblag1 { get; set; }

    public double? DfisMeblag2 { get; set; }

    public double? DfisMeblag3 { get; set; }

    public double? DfisMeblag4 { get; set; }

    public double? DfisMeblag5 { get; set; }

    public double? DfisMeblag6 { get; set; }

    public DateTime? DfisFevraktarih { get; set; }

    public byte? DfisFcinsi { get; set; }

    public byte? DfisFvergipnt { get; set; }

    public double? DfisFvergi { get; set; }

    public byte? DfisFtip { get; set; }

    public byte? DfisTicariTip { get; set; }

    public byte? DfisTicariEvraktip { get; set; }

    public string? DfisEvraknoSeri { get; set; }

    public int? DfisEvraknoSira { get; set; }

    public string? DfisBelgeno { get; set; }

    public string? DfisFozelmahkod { get; set; }

    public byte? DfisEvraktip { get; set; }

    public string? DfisId { get; set; }

    public string? DfisSatirId { get; set; }

    public string? DfisVergiDairesiKodu { get; set; }

    public string? DfisTcknVkn { get; set; }

    public string? DfisAd { get; set; }

    public string? DfisSoyad { get; set; }

    public bool? DfisAdresiGuncelleme { get; set; }

    public string? DfisAdresBilgisi { get; set; }

    public double? DfisMiktar { get; set; }

    public string? DfisBirimKodu { get; set; }

    public string? DfisKismiTevkifatKodu { get; set; }

    public double? DfisKismiTevkifatOrani { get; set; }

    public string? DfisStopajKodu { get; set; }

    public double? DfisStopajOrani { get; set; }

    public double? DfisStopajTutari { get; set; }

    public string? DfisGiderBelgeTuruKodu { get; set; }

    public string? DfisAlisTuruKodu { get; set; }

    public string? DfisGiderKayitTuruKodu { get; set; }

    public string? DfisGiderKayitAltTuruKodu { get; set; }

    public string? DfisOdemeTuruKodu { get; set; }

    public string? DfisHesaplamaYontemiKodu { get; set; }

    public string? DfisAmortismanYontemiKodu { get; set; }

    public string? DfisSabitKiymetTuruKodu { get; set; }

    public string? DfisOzelKodKodu { get; set; }

    public string? DfisKodu { get; set; }

    public string? DfisAdi { get; set; }

    public string? DfisIktisadiKiymetKodu { get; set; }

    public byte? DfisPeriyot { get; set; }

    public byte? DfisTevkifatDurumKodu { get; set; }

    public string? DfisDamgaVergisiKodu { get; set; }

    public int? DfisBelgeAdedi { get; set; }

    public string? DfisGelirBelgeTuruKodu { get; set; }

    public string? DfisSatisTuruKodu { get; set; }

    public string? DfisGelirKayitTuruKodu { get; set; }

    public string? DfisGelirKayitAltTuruKodu { get; set; }

    public string? DfisKismiIstisnaKodu { get; set; }

    public double? DfisKismiIstisnaOrani { get; set; }

    public string? DfisTamIstisnaKodu { get; set; }

    public double? DfisTamIstisnaOrani { get; set; }

    public string? DfisIhracKayitliTeslimKodu { get; set; }

    public double? DfisIhracKayitliTeslimOrani { get; set; }

    public string? DfisDigerIadeHakkiKodu { get; set; }

    public double? DfisDigerIadeHakkiOrani { get; set; }

    public string? DfisDigerIslemlerKodu { get; set; }

    public double? DfisDigerIslemlerOrani { get; set; }

    public double? DfisNetDefterDegeri { get; set; }

    public string? DfisSabitKiymetId { get; set; }

    public string? DfisIadeKismiTevkifatKodu { get; set; }

    public double? DfisIadeKismiTevkifatOrani { get; set; }

    public double? DfisKrediKartiTutari { get; set; }

    public double? DfisBelgeTutari { get; set; }

    public bool? DfisNihaiTuketici { get; set; }

    public bool? DfisKdvsizIslem { get; set; }

    public bool? DfisDonemsellik { get; set; }

    public string? DfisDonemsellikId { get; set; }

    public string? DfisNaceKodu { get; set; }
}
