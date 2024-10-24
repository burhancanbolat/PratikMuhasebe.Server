using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MaliyetDevir
{
    public Guid MdGuid { get; set; }

    public short MdDbcno { get; set; }

    public int? MdSpecRecno { get; set; }

    public bool? MdIptal { get; set; }

    public short? MdFileid { get; set; }

    public bool? MdHidden { get; set; }

    public bool? MdKilitli { get; set; }

    public bool? MdDegisti { get; set; }

    public int? MdChecksum { get; set; }

    public short? MdCreateUser { get; set; }

    public DateTime MdCreateDate { get; set; }

    public short? MdLastupUser { get; set; }

    public DateTime? MdLastupDate { get; set; }

    public string? MdSpecial1 { get; set; }

    public string? MdSpecial2 { get; set; }

    public string? MdSpecial3 { get; set; }

    public string? MdStokkodu { get; set; }

    public DateTime? MdDevirtarihi { get; set; }

    public Guid? MdHarUid { get; set; }

    public DateTime? MdTarih { get; set; }

    public byte? MdHartip { get; set; }

    public byte? MdHarnormaliade { get; set; }

    public byte? MdHarevraktip { get; set; }

    public byte? MdHarcins { get; set; }

    public string? MdHarevraknoSeri { get; set; }

    public int? MdHarevraknoSira { get; set; }

    public double? MdMiktar { get; set; }

    public double? MdDegerAna { get; set; }

    public double? MdDegerAlt { get; set; }

    public double? MdDegerOrj { get; set; }

    public double? MdDegerAnaUfrs { get; set; }

    public double? MdDegerAltUfrs { get; set; }

    public double? MdDegerOrjUfrs { get; set; }

    public int? MdHardepono { get; set; }

    public string? MdPartikodu { get; set; }

    public int? MdLotno { get; set; }

    public string? MdEximkodu { get; set; }

    public short? MdBdnharbedenno { get; set; }

    public string? MdCihazserino { get; set; }
}
