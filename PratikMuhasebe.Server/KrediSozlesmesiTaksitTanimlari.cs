using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KrediSozlesmesiTaksitTanimlari
{
    public Guid KrsoztaksitGuid { get; set; }

    public short KrsoztaksitDbcno { get; set; }

    public int? KrsoztaksitSpecRecNo { get; set; }

    public bool? KrsoztaksitIptal { get; set; }

    public short? KrsoztaksitFileid { get; set; }

    public bool? KrsoztaksitHidden { get; set; }

    public bool? KrsoztaksitKilitli { get; set; }

    public bool? KrsoztaksitDegisti { get; set; }

    public int? KrsoztaksitChecksum { get; set; }

    public short? KrsoztaksitCreateUser { get; set; }

    public DateTime KrsoztaksitCreateDate { get; set; }

    public short? KrsoztaksitLastupUser { get; set; }

    public DateTime? KrsoztaksitLastupDate { get; set; }

    public string? KrsoztaksitSpecial1 { get; set; }

    public string? KrsoztaksitSpecial2 { get; set; }

    public string? KrsoztaksitSpecial3 { get; set; }

    public string? KrsoztaksitSozkodu { get; set; }

    public short? KrsoztaksitTaksitno { get; set; }

    public DateTime? KrsoztaksitVade { get; set; }

    public double? KrsoztaksitTaksit { get; set; }

    public double? KrsoztaksitAnapara { get; set; }

    public double? KrsoztaksitFaizorani { get; set; }

    public double? KrsoztaksitFaiz { get; set; }

    public double? KrsoztaksitBsmv { get; set; }

    public double? KrsoztaksitKkdf { get; set; }

    public double? KrsoztaksitKalananapara { get; set; }

    public double? KrsoztaksitGunlukerkenodemeind { get; set; }

    public string? KrsoztaksitOdemeevrakseri { get; set; }

    public int? KrsoztaksitOdemeevraksira { get; set; }

    public double? KrsoztaksitOdenenAna { get; set; }

    public double? KrsoztaksitOdenenAlt { get; set; }

    public double? KrsoztaksitOdenenOrj { get; set; }
}
