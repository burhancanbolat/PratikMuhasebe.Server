using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EgitimDevamKontrol
{
    public Guid DkGuid { get; set; }

    public short DkDbcno { get; set; }

    public int? DkSpecRecno { get; set; }

    public bool? DkIptal { get; set; }

    public short? DkFileid { get; set; }

    public bool? DkHidden { get; set; }

    public bool? DkKilitli { get; set; }

    public bool? DkDegisti { get; set; }

    public int? DkChecksum { get; set; }

    public short? DkCreateUser { get; set; }

    public DateTime DkCreateDate { get; set; }

    public short? DkLastupUser { get; set; }

    public DateTime? DkLastupDate { get; set; }

    public string? DkSpecial1 { get; set; }

    public string? DkSpecial2 { get; set; }

    public string? DkSpecial3 { get; set; }

    public string? DkEvraknoSeri { get; set; }

    public int? DkEvraknoSira { get; set; }

    public int? DkSatirno { get; set; }

    public string? DkEgitimkodu { get; set; }

    public string? DkPerskod { get; set; }

    public DateTime? DkTarih { get; set; }

    public DateTime? DkGirsaat { get; set; }

    public DateTime? DkCiksaat { get; set; }

    public string? DkMazeret { get; set; }
}
