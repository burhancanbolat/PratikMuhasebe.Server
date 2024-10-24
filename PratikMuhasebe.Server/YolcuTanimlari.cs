using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class YolcuTanimlari
{
    public Guid YlcGuid { get; set; }

    public short YlcDbcno { get; set; }

    public int? YlcSpecRecno { get; set; }

    public bool? YlcIptal { get; set; }

    public short? YlcFileid { get; set; }

    public bool? YlcHidden { get; set; }

    public bool? YlcKilitli { get; set; }

    public bool? YlcDegisti { get; set; }

    public int? YlcCheckSum { get; set; }

    public short? YlcCreateUser { get; set; }

    public DateTime YlcCreateDate { get; set; }

    public short? YlcLastupUser { get; set; }

    public DateTime? YlcLastupDate { get; set; }

    public string? YlcSpecial1 { get; set; }

    public string? YlcSpecial2 { get; set; }

    public string? YlcSpecial3 { get; set; }

    public string? YlcKodu { get; set; }

    public string? YlcAdi { get; set; }

    public string? YlcSoyadi { get; set; }

    public string? YlcPasaportno { get; set; }

    public DateTime? YlcPasaporttarihi { get; set; }

    public string? YlcUyruk { get; set; }

    public string? YlcSehir { get; set; }

    public string? YlcUlke { get; set; }

    public string? YlcBankahesap { get; set; }

    public string? YlcBankaadi { get; set; }

    public string? YlcBankasube { get; set; }
}
