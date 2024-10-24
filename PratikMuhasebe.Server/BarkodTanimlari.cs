using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BarkodTanimlari
{
    public Guid BarGuid { get; set; }

    public short BarDbcno { get; set; }

    public int? BarSpecRecno { get; set; }

    public bool? BarIptal { get; set; }

    public short? BarFileid { get; set; }

    public bool? BarHidden { get; set; }

    public bool? BarKilitli { get; set; }

    public bool? BarDegisti { get; set; }

    public int? BarChecksum { get; set; }

    public short? BarCreateUser { get; set; }

    public DateTime BarCreateDate { get; set; }

    public short? BarLastupUser { get; set; }

    public DateTime? BarLastupDate { get; set; }

    public string? BarSpecial1 { get; set; }

    public string? BarSpecial2 { get; set; }

    public string? BarSpecial3 { get; set; }

    public string? BarKodu { get; set; }

    public string? BarStokkodu { get; set; }

    public string? BarPartikodu { get; set; }

    public int? BarLotno { get; set; }

    public string? BarSerinoVeyaBagkodu { get; set; }

    public byte? BarBarkodtipi { get; set; }

    public byte? BarIcerigi { get; set; }

    public byte? BarBirimpntr { get; set; }

    public bool? BarMaster { get; set; }

    public byte? BarBedenpntr { get; set; }

    public byte? BarRenkpntr { get; set; }

    public byte? BarBaglantitipi { get; set; }

    public Guid? BarHarUid { get; set; }

    public string? BarAsortitanimkodu { get; set; }
}
