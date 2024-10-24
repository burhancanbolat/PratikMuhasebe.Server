using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelPerformansTanimlari
{
    public Guid PrfGuid { get; set; }

    public short PrfDbcno { get; set; }

    public int? PrfSpecRecno { get; set; }

    public bool? PrfIptal { get; set; }

    public short? PrfFileid { get; set; }

    public bool? PrfHidden { get; set; }

    public bool? PrfKilitli { get; set; }

    public bool? PrfDegisti { get; set; }

    public int? PrfChecksum { get; set; }

    public short? PrfCreateUser { get; set; }

    public DateTime PrfCreateDate { get; set; }

    public short? PrfLastupUser { get; set; }

    public DateTime? PrfLastupDate { get; set; }

    public string? PrfSpecial1 { get; set; }

    public string? PrfSpecial2 { get; set; }

    public string? PrfSpecial3 { get; set; }

    public string? PrfKodu { get; set; }

    public string? PrfAdi { get; set; }

    public byte? PrfTip { get; set; }

    public byte? PrfSekil { get; set; }

    public byte? PrfBirim { get; set; }

    public byte? PrfSosyrdmksntmo { get; set; }

    public double? PrfMaxmiktar { get; set; }

    public bool? PrfDegerlendirFl { get; set; }
}
