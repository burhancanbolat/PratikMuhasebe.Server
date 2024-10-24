using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelPerformanslar
{
    public Guid AprfGuid { get; set; }

    public short AprfDbcno { get; set; }

    public int? AprfSpecRecno { get; set; }

    public bool? AprfIptal { get; set; }

    public short? AprfFileid { get; set; }

    public bool? AprfHidden { get; set; }

    public bool? AprfKilitli { get; set; }

    public bool? AprfDegisti { get; set; }

    public int? AprfChecksum { get; set; }

    public short? AprfCreateUser { get; set; }

    public DateTime AprfCreateDate { get; set; }

    public short? AprfLastupUser { get; set; }

    public DateTime? AprfLastupDate { get; set; }

    public string? AprfSpecial1 { get; set; }

    public string? AprfSpecial2 { get; set; }

    public string? AprfSpecial3 { get; set; }

    public int? AprfFirmano { get; set; }

    public int? AprfSubeno { get; set; }

    public DateTime? AprfTarih { get; set; }

    public byte? AprfTip { get; set; }

    public string? AprfEvraknoSeri { get; set; }

    public int? AprfEvraknoSira { get; set; }

    public int? AprfSatirno { get; set; }

    public string? AprfBelgeno { get; set; }

    public DateTime? AprfBelgeTarih { get; set; }

    public string? AprfVerenPers { get; set; }

    public string? AprfPerKodu { get; set; }

    public string? AprfPerformKodu { get; set; }

    public string? AprfAciklama { get; set; }

    public double? AprfMiktar { get; set; }
}
