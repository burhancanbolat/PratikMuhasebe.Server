using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapTeminatlari
{
    public Guid CtGuid { get; set; }

    public short CtDbcno { get; set; }

    public int? CtSpecRecno { get; set; }

    public bool? CtIptal { get; set; }

    public short? CtFileid { get; set; }

    public bool? CtHidden { get; set; }

    public bool? CtKilitli { get; set; }

    public bool? CtDegisti { get; set; }

    public int? CtChecksum { get; set; }

    public short? CtCreateUser { get; set; }

    public DateTime CtCreateDate { get; set; }

    public short? CtLastupUser { get; set; }

    public DateTime? CtLastupDate { get; set; }

    public string? CtSpecial1 { get; set; }

    public string? CtSpecial2 { get; set; }

    public string? CtSpecial3 { get; set; }

    public string CtCarikodu { get; set; } = null!;

    public byte? CtAciklamaNo { get; set; }

    public double? CtTutari { get; set; }

    public byte? CtDovizCinsi { get; set; }

    public DateTime? CtVade { get; set; }

    public byte? CtIcerigi { get; set; }

    public int? CtGecerliFirma { get; set; }

    public DateTime? CtGirisTarihi { get; set; }

    public string? CtSrmrkkodu { get; set; }

    public byte? CtBgevrakTip { get; set; }

    public string? CtBgevraknoSeri { get; set; }

    public int? CtBgevraknoSira { get; set; }
}
