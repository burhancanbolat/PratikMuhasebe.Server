using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Departmanlar
{
    public Guid PdpGuid { get; set; }

    public short PdpDbcno { get; set; }

    public int? PdpSpecRecno { get; set; }

    public bool? PdpIptal { get; set; }

    public short? PdpFileid { get; set; }

    public bool? PdpHidden { get; set; }

    public bool? PdpKilitli { get; set; }

    public bool? PdpDegisti { get; set; }

    public int? PdpChecksum { get; set; }

    public short? PdpCreateUser { get; set; }

    public DateTime PdpCreateDate { get; set; }

    public short? PdpLastupUser { get; set; }

    public DateTime? PdpLastupDate { get; set; }

    public string? PdpSpecial1 { get; set; }

    public string? PdpSpecial2 { get; set; }

    public string? PdpSpecial3 { get; set; }

    public string? PdpKodu { get; set; }

    public string? PdpAdi { get; set; }

    public string? PdpMuhkodu { get; set; }

    public string? PdpSormer { get; set; }

    public double? PdpKtprimyuzde { get; set; }

    public double? PdpTtprimyuzde { get; set; }

    public string? PdpProjekodu { get; set; }

    public string? PdpCalismakodu { get; set; }
}
