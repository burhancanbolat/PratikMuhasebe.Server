using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FirmaSerbestHareket
{
    public Guid SmGuid { get; set; }

    public short SmDbcno { get; set; }

    public int? SmSpecRecno { get; set; }

    public bool? SmIptal { get; set; }

    public short? SmFileid { get; set; }

    public bool? SmHidden { get; set; }

    public bool? SmKilitli { get; set; }

    public bool? SmDegisti { get; set; }

    public int? SmChecksum { get; set; }

    public short? SmCreateUser { get; set; }

    public DateTime SmCreateDate { get; set; }

    public short? SmLastupUser { get; set; }

    public DateTime? SmLastupDate { get; set; }

    public string? SmSpecial1 { get; set; }

    public string? SmSpecial2 { get; set; }

    public string? SmSpecial3 { get; set; }

    public DateTime? SmTarih { get; set; }

    public int? SmFirmano { get; set; }

    public string? SmEvrNoSeri { get; set; }

    public int? SmEvrNoSira { get; set; }

    public byte? SmIb { get; set; }

    public byte? SmIm { get; set; }

    public string? SmPveren { get; set; }

    public string? SmAdr1 { get; set; }

    public string? SmAdr2 { get; set; }

    public string? SmAdr3 { get; set; }

    public string? SmHesapNo { get; set; }

    public double? SmBrut { get; set; }

    public double? SmKdv { get; set; }

    public double? SmStopaj { get; set; }

    public double? SmSsdf { get; set; }

    public double? SmNet { get; set; }

    public string? SmVd { get; set; }

    public DateTime? SmFistarih { get; set; }

    public int? SmFissirano { get; set; }

    public bool? SmAcik { get; set; }

    public string? SmMuhkodu { get; set; }

    public string? SmDbkodu { get; set; }

    public string? SmTckimlikno { get; set; }

    public double? SmTevkifat { get; set; }

    public string? SmUcretAciklamasi { get; set; }

    public string? SmUuid { get; set; }

    public string? SmGibSeri { get; set; }

    public int? SmGibSira { get; set; }
}
