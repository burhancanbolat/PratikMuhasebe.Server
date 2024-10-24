using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OdemePlanlari
{
    public Guid OdpGuid { get; set; }

    public short OdpDbcno { get; set; }

    public int? OdpSpecRecno { get; set; }

    public bool? OdpIptal { get; set; }

    public short? OdpFileid { get; set; }

    public bool? OdpHidden { get; set; }

    public bool? OdpKilitli { get; set; }

    public bool? OdpDegisti { get; set; }

    public int? OdpChecksum { get; set; }

    public short? OdpCreateUser { get; set; }

    public DateTime OdpCreateDate { get; set; }

    public short? OdpLastupUser { get; set; }

    public DateTime? OdpLastupDate { get; set; }

    public string? OdpSpecial1 { get; set; }

    public string? OdpSpecial2 { get; set; }

    public string? OdpSpecial3 { get; set; }

    public int? OdpNo { get; set; }

    public string? OdpKodu { get; set; }

    public string? OdpAdi { get; set; }

    public string? OdpAratop { get; set; }

    public string? OdpMasraf { get; set; }

    public string? OdpVergi { get; set; }

    public int? OdpOrtgun { get; set; }
}
