using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsletmeHesapPlani
{
    public Guid DinmGuid { get; set; }

    public short DinmDbcno { get; set; }

    public int? DinmSpecRecno { get; set; }

    public bool? DinmIptal { get; set; }

    public short? DinmFileid { get; set; }

    public bool? DinmHidden { get; set; }

    public bool? DinmKilitli { get; set; }

    public bool? DinmDegisti { get; set; }

    public int? DinmChecksum { get; set; }

    public short? DinmCreateUser { get; set; }

    public DateTime DinmCreateDate { get; set; }

    public short? DinmLastupUser { get; set; }

    public DateTime? DinmLastupDate { get; set; }

    public string? DinmSpecial1 { get; set; }

    public string? DinmSpecial2 { get; set; }

    public string? DinmSpecial3 { get; set; }

    public string? DinmHesapKod { get; set; }

    public string? DinmHesapIsim1 { get; set; }

    public string? DinmHesapIsim2 { get; set; }

    public byte? DinmDovizCinsi { get; set; }

    public bool? DinmKurfarkiFl { get; set; }

    public byte? DinmSorumMerk { get; set; }

    public DateTime? DinmKilittarihi { get; set; }

    public byte? DinmHesDavBicimi { get; set; }

    public byte? DinmHhtip { get; set; }

    public bool? DinmHhVtipFl { get; set; }

    public byte? DinmHhVergi { get; set; }

    public byte? DinmHhAsgKarGrubu { get; set; }

    public byte? DinmHhtopPer { get; set; }

    public double? DinmHhiademeblag { get; set; }

    public byte? DinmHvergiHesaplama { get; set; }

    public bool? DinmMiktarOtoFl { get; set; }

    public byte? DinmEvraktip { get; set; }

    public string? DinmGiderBelgeTuruKodu { get; set; }

    public string? DinmAlisTuruKodu { get; set; }

    public string? DinmGiderKayitTuruKodu { get; set; }

    public string? DinmGiderKayitAltTuruKodu { get; set; }

    public string? DinmGelirBelgeTuruKodu { get; set; }

    public string? DinmSatisTuruKodu { get; set; }

    public string? DinmGelirKayitTuruKodu { get; set; }

    public string? DinmGelirKayitAltTuruKodu { get; set; }

    public string? DinmStopajkodu { get; set; }

    public double? DinmStopajorani { get; set; }

    public string? DnimKismiTevkifatKodu { get; set; }

    public double? DnimKismiTevkifatOrani { get; set; }

    public string? DnimOdemeTuruKodu { get; set; }

    public string? DnimHesaplamaYontemiKodu { get; set; }

    public string? DnimAmortismanYontemiKodu { get; set; }

    public string? DnimSabitKiymetTuruKodu { get; set; }

    public string? DnimOzelKodKodu { get; set; }

    public string? DnimKodu { get; set; }

    public string? DnimAdi { get; set; }

    public string? DnimIktisadiKiymetKodu { get; set; }

    public byte? DnimPeriyot { get; set; }

    public byte? DnimTevkifatDurumKodu { get; set; }

    public string? DnimDamgaVergisiKodu { get; set; }

    public string? DnimKismiIstisnaKodu { get; set; }

    public double? DnimKismiIstisnaOrani { get; set; }

    public string? DnimTamIstisnaKodu { get; set; }

    public double? DnimTamIstisnaOrani { get; set; }

    public string? DnimIhracKayitliTeslimKodu { get; set; }

    public double? DnimIhracKayitliTeslimOrani { get; set; }

    public string? DnimDigerIadeHakkiKodu { get; set; }

    public double? DnimDigerIadeHakkiOrani { get; set; }

    public string? DnimDigerIslemlerKodu { get; set; }

    public double? DnimDigerIslemlerOrani { get; set; }

    public string? DnimSabitKiymetId { get; set; }

    public string? DnimIadeKismiTevkifatKodu { get; set; }

    public double? DnimIadeKismiTevkifatOrani { get; set; }

    public bool? DnimNihaiTuketici { get; set; }

    public bool? DnimKdvsizIslem { get; set; }

    public bool? DnimDonemsellik { get; set; }

    public string? DnimDonemsellikId { get; set; }

    public string? DnimNaceKodu { get; set; }
}
