using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariDegerlendirmeFormu
{
    public Guid CdfGuid { get; set; }

    public short CdfDbcno { get; set; }

    public int? CdfSpecRecno { get; set; }

    public bool? CdfIptal { get; set; }

    public short? CdfFileid { get; set; }

    public bool? CdfHidden { get; set; }

    public bool? CdfKilitli { get; set; }

    public bool? CdfDegisti { get; set; }

    public int? CdfChecksum { get; set; }

    public short? CdfCreateUser { get; set; }

    public DateTime CdfCreateDate { get; set; }

    public short? CdfLastupUser { get; set; }

    public DateTime? CdfLastupDate { get; set; }

    public string? CdfSpecial1 { get; set; }

    public string? CdfSpecial2 { get; set; }

    public string? CdfSpecial3 { get; set; }

    public string? CdfFormKodu { get; set; }

    public string? CdfCariKodu { get; set; }

    public int? CdfSatirno { get; set; }

    public DateTime? CdfTarih { get; set; }

    public string? CdfKriterKodu { get; set; }

    public double? CdfPuan { get; set; }

    public byte? CdfSozelpuan { get; set; }
}
