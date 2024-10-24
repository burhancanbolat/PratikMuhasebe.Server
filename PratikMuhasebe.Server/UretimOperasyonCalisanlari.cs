using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimOperasyonCalisanlari
{
    public Guid OpcGuid { get; set; }

    public short OpcDbcno { get; set; }

    public int? OpcSpecRecno { get; set; }

    public bool? OpcIptal { get; set; }

    public short? OpcFileid { get; set; }

    public bool? OpcHidden { get; set; }

    public bool? OpcKilitli { get; set; }

    public bool? OpcDegisti { get; set; }

    public int? OpcCheckSum { get; set; }

    public short? OpcCreateUser { get; set; }

    public DateTime OpcCreateDate { get; set; }

    public short? OpcLastupUser { get; set; }

    public DateTime? OpcLastupDate { get; set; }

    public string? OpcSpecial1 { get; set; }

    public string? OpcSpecial2 { get; set; }

    public string? OpcSpecial3 { get; set; }

    public Guid? OpcOpTamamUid { get; set; }

    public string? OpcPersonelKodu { get; set; }

    public int? OpcCalistigiSure { get; set; }
}
