using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHareketBorcAlacakEsleme
{
    public Guid ChkGuid { get; set; }

    public short ChkDbcno { get; set; }

    public int? ChkSpecRecno { get; set; }

    public bool? ChkIptal { get; set; }

    public short? ChkFileid { get; set; }

    public bool? ChkHidden { get; set; }

    public bool? ChkKilitli { get; set; }

    public bool? ChkDegisti { get; set; }

    public int? ChkChecksum { get; set; }

    public short? ChkCreateUser { get; set; }

    public DateTime ChkCreateDate { get; set; }

    public short? ChkLastupUser { get; set; }

    public DateTime? ChkLastupDate { get; set; }

    public string? ChkSpecial1 { get; set; }

    public string? ChkSpecial2 { get; set; }

    public string? ChkSpecial3 { get; set; }

    public byte? ChkChCinsi { get; set; }

    public string? ChkChKodu { get; set; }

    public Guid? ChkBorcUid { get; set; }

    public DateTime? ChkBorcVade { get; set; }

    public double? ChkTutar { get; set; }

    public Guid? ChkAlcUid { get; set; }

    public DateTime? ChkAlacakvade { get; set; }

    public string? ChkAciklama1 { get; set; }

    public string? ChkAciklama2 { get; set; }

    public double? ChkOrjBorcTutar { get; set; }

    public double? ChkOrjAlacakTutar { get; set; }
}
