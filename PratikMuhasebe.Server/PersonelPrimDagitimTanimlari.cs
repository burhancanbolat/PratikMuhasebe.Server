using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelPrimDagitimTanimlari
{
    public Guid PrprmGuid { get; set; }

    public short PrprmDbcno { get; set; }

    public int? PrprmSpecRecno { get; set; }

    public bool? PrprmIptal { get; set; }

    public short? PrprmFileid { get; set; }

    public bool? PrprmHidden { get; set; }

    public bool? PrprmKilitli { get; set; }

    public bool? PrprmDegisti { get; set; }

    public int? PrprmChecksum { get; set; }

    public short? PrprmCreateUser { get; set; }

    public DateTime PrprmCreateDate { get; set; }

    public short? PrprmLastupUser { get; set; }

    public DateTime? PrprmLastupDate { get; set; }

    public string? PrprmSpecial1 { get; set; }

    public string? PrprmSpecial2 { get; set; }

    public string? PrprmSpecial3 { get; set; }

    public string? PrprmPerKod { get; set; }

    public double? PrprmDgtYuzde1 { get; set; }

    public byte? PrprmDgtTip1 { get; set; }

    public string? PrprmDgtPerKod1 { get; set; }

    public double? PrprmDgtYuzde2 { get; set; }

    public byte? PrprmDgtTip2 { get; set; }

    public string? PrprmDgtPerKod2 { get; set; }

    public double? PrprmDgtYuzde3 { get; set; }

    public byte? PrprmDgtTip3 { get; set; }

    public string? PrprmDgtPerKod3 { get; set; }

    public double? PrprmDgtYuzde4 { get; set; }

    public byte? PrprmDgtTip4 { get; set; }

    public string? PrprmDgtPerKod4 { get; set; }

    public double? PrprmDgtYuzde5 { get; set; }

    public byte? PrprmDgtTip5 { get; set; }

    public string? PrprmDgtPerKod5 { get; set; }
}
