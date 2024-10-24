using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FinansalSozlesmeTaksitleri
{
    public Guid FstGuid { get; set; }

    public short FstDbcno { get; set; }

    public int? FstSpecRecNo { get; set; }

    public bool? FstIptal { get; set; }

    public short? FstFileid { get; set; }

    public bool? FstHidden { get; set; }

    public bool? FstKilitli { get; set; }

    public bool? FstDegisti { get; set; }

    public int? FstChecksum { get; set; }

    public short? FstCreateUser { get; set; }

    public DateTime FstCreateDate { get; set; }

    public short? FstLastupUser { get; set; }

    public DateTime? FstLastupDate { get; set; }

    public string? FstSpecial1 { get; set; }

    public string? FstSpecial2 { get; set; }

    public string? FstSpecial3 { get; set; }

    public string? FstSozkodu { get; set; }

    public short? FstTaksitno { get; set; }

    public DateTime? FstVade { get; set; }

    public double? FstAnapara { get; set; }

    public double? FstFaiz { get; set; }

    public bool? FstUzunvade { get; set; }

    public string? FstFaturaseri { get; set; }

    public int? FstFaturasira { get; set; }
}
