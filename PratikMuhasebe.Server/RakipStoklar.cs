using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class RakipStoklar
{
    public Guid RaksGuid { get; set; }

    public short RaksDbcno { get; set; }

    public int? RaksSpecRecno { get; set; }

    public bool? RaksIptal { get; set; }

    public short? RaksFileid { get; set; }

    public bool? RaksHidden { get; set; }

    public bool? RaksKilitli { get; set; }

    public bool? RaksDegisti { get; set; }

    public int? RaksChecksum { get; set; }

    public short? RaksCreateUser { get; set; }

    public DateTime RaksCreateDate { get; set; }

    public short? RaksLastupUser { get; set; }

    public DateTime? RaksLastupDate { get; set; }

    public string? RaksSpecial1 { get; set; }

    public string? RaksSpecial2 { get; set; }

    public string? RaksSpecial3 { get; set; }

    public string? RaksKod { get; set; }

    public string? RaksIsim { get; set; }

    public string? RaksSatCariKod { get; set; }

    public byte? RaksCins { get; set; }

    public byte? RaksDovizCinsi { get; set; }

    public string? RaksBirim1Ad { get; set; }

    public double? RaksBirim1Katsayi { get; set; }

    public double? RaksBirim1Agirlik { get; set; }

    public double? RaksBirim1En { get; set; }

    public double? RaksBirim1Boy { get; set; }

    public double? RaksBirim1Yuksekli { get; set; }

    public double? RaksBirim1Dara { get; set; }

    public string? RaksBirim2Ad { get; set; }

    public double? RaksBirim2Katsayi { get; set; }

    public double? RaksBirim2Agirlik { get; set; }

    public double? RaksBirim2En { get; set; }

    public double? RaksBirim2Boy { get; set; }

    public double? RaksBirim2Yuksekli { get; set; }

    public double? RaksBirim2Dara { get; set; }

    public string? RaksBirim3Ad { get; set; }

    public double? RaksBirim3Katsayi { get; set; }

    public double? RaksBirim3Agirlik { get; set; }

    public double? RaksBirim3En { get; set; }

    public double? RaksBirim3Boy { get; set; }

    public double? RaksBirim3Yuksekli { get; set; }

    public double? RaksBirim3Dara { get; set; }

    public string? RaksBirim4Ad { get; set; }

    public double? RaksBirim4Katsayi { get; set; }

    public double? RaksBirim4Agirlik { get; set; }

    public double? RaksBirim4En { get; set; }

    public double? RaksBirim4Boy { get; set; }

    public double? RaksBirim4Yuksekli { get; set; }

    public double? RaksBirim4Dara { get; set; }

    public double? RaksKarorani { get; set; }

    public string? RaksReyonKodu { get; set; }

    public string? RaksAmbalajKodu { get; set; }

    public string? RaksBizStokKodu { get; set; }

    public double? RaksSatisfiat { get; set; }

    public byte? RaksFiatDoviz { get; set; }

    public int? RaksFiatOpno { get; set; }

    public string? RaksFiatIskonto { get; set; }

    public bool? RaksKdvdahil { get; set; }
}
