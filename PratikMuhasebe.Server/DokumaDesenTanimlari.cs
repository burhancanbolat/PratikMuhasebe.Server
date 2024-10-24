using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DokumaDesenTanimlari
{
    public Guid DdGuid { get; set; }

    public short DdDbcno { get; set; }

    public int? DdSpecRecno { get; set; }

    public bool? DdIptal { get; set; }

    public short? DdFileid { get; set; }

    public bool? DdHidden { get; set; }

    public bool? DdKilitli { get; set; }

    public bool? DdDegisti { get; set; }

    public int? DdChecksum { get; set; }

    public short? DdCreateUser { get; set; }

    public DateTime DdCreateDate { get; set; }

    public short? DdLastupUser { get; set; }

    public DateTime? DdLastupDate { get; set; }

    public string? DdSpecial1 { get; set; }

    public string? DdSpecial2 { get; set; }

    public string? DdSpecial3 { get; set; }

    public string? DdStokKodu { get; set; }

    public string? DdAciklama { get; set; }

    public DateTime? DdTanimTarihi { get; set; }

    public string? DdTanimlayanKisi { get; set; }

    public double? DdEndenCekmeYuzdesi { get; set; }

    public double? DdBoydanCekmeYuzdesi { get; set; }

    public string? DdMusteri1 { get; set; }

    public string? DdMusteri2 { get; set; }

    public string? DdMusteri3 { get; set; }

    public string? DdZeminCozguStokKodu { get; set; }

    public double? DdZeminCozguSikligi { get; set; }

    public string? DdHavCozguStokKodu { get; set; }

    public double? DdHavCozguSikligi { get; set; }

    public double? DdHavOraniHesaplanan { get; set; }

    public double? DdHavOraniOlculen { get; set; }

    public double? DdBoyhavoraniHesaplanandan { get; set; }

    public double? DdBoyhavoraniOlculenden { get; set; }

    public double? DdUretimGramaji { get; set; }

    public double? DdMamulGramaji { get; set; }

    public double? DdMamulEniCm { get; set; }

    public double? DdUretimEniCm { get; set; }

    public short? DdDokumaEnSayisi { get; set; }

    public double? DdUretimBoyu { get; set; }

    public double? DdMamulBoyu { get; set; }

    public double? DdFaydaliTarakEni { get; set; }

    public short? DdIlmekAtkiSayisi { get; set; }

    public double? DdHavdanHavaBoy { get; set; }

    public double? DdHavdanHavaEn { get; set; }
}
