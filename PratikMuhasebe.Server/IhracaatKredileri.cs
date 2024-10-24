using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IhracaatKredileri
{
    public Guid IhkGuid { get; set; }

    public short IhkDbcno { get; set; }

    public int? IhkSpecRecno { get; set; }

    public bool? IhkIptal { get; set; }

    public short? IhkFileid { get; set; }

    public bool? IhkHidden { get; set; }

    public bool? IhkKilitli { get; set; }

    public bool? IhkDegisti { get; set; }

    public int? IhkCheckSum { get; set; }

    public short? IhkCreateUser { get; set; }

    public DateTime IhkCreateDate { get; set; }

    public short? IhkLastupUser { get; set; }

    public DateTime? IhkLastupDate { get; set; }

    public string? IhkSpecial1 { get; set; }

    public string? IhkSpecial2 { get; set; }

    public string? IhkSpecial3 { get; set; }

    public string? IhkKodu { get; set; }

    public string? IhkAdi { get; set; }

    public string? IhkBankakodu { get; set; }

    public double? IhkTutar { get; set; }

    public byte? IhkDovizcinsi { get; set; }

    public double? IhkDoviztutar { get; set; }

    public double? IhkUsdtutar { get; set; }

    public double? IhkFaizorani { get; set; }

    public double? IhkFaiztutari { get; set; }

    public DateTime? IhkAlindigitarih { get; set; }

    public DateTime? IhkOdemetarih { get; set; }

    public double? IhkKapananusdtutar { get; set; }
}
