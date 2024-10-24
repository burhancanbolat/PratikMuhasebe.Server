using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IstasyonVardiyaSatislari
{
    public Guid VpGuid { get; set; }

    public short VpDbcno { get; set; }

    public int? VpSpecRecno { get; set; }

    public bool? VpIptal { get; set; }

    public short? VpFileid { get; set; }

    public bool? VpHidden { get; set; }

    public bool? VpKilitli { get; set; }

    public bool? VpDegisti { get; set; }

    public int? VpChecksum { get; set; }

    public short? VpCreateUser { get; set; }

    public DateTime VpCreateDate { get; set; }

    public short? VpLastupUser { get; set; }

    public DateTime? VpLastupDate { get; set; }

    public string? VpSpecial1 { get; set; }

    public string? VpSpecial2 { get; set; }

    public string? VpSpecial3 { get; set; }

    public int? VpFirmano { get; set; }

    public int? VpSubeno { get; set; }

    public DateTime? VpTarihi { get; set; }

    public byte? VpNumarasi { get; set; }

    public string? VpPersKodu { get; set; }

    public string? VpStokKodu { get; set; }

    public double? VpSatisMiktari { get; set; }

    public double? VpSatisTutari { get; set; }
}
