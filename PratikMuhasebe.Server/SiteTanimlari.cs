using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SiteTanimlari
{
    public Guid SiteGuid { get; set; }

    public short SiteDbcno { get; set; }

    public int? SiteSpecRecno { get; set; }

    public bool? SiteIptal { get; set; }

    public short? SiteFileid { get; set; }

    public bool? SiteHidden { get; set; }

    public bool? SiteKilitli { get; set; }

    public bool? SiteDegisti { get; set; }

    public int? SiteChecksum { get; set; }

    public short? SiteCreateUser { get; set; }

    public DateTime SiteCreateDate { get; set; }

    public short? SiteLastupUser { get; set; }

    public DateTime? SiteLastupDate { get; set; }

    public string? SiteSpecial1 { get; set; }

    public string? SiteSpecial2 { get; set; }

    public string? SiteSpecial3 { get; set; }

    public string? SiteKod { get; set; }

    public string? SiteIsmi { get; set; }

    public double? SiteOtoparkacikalan { get; set; }

    public double? SiteOtoparkkapalialan { get; set; }

    public double? SiteToplamacikalan { get; set; }

    public double? SiteToplamkapalialan { get; set; }
}
