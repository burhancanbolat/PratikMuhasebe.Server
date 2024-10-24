using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DagitimKontrol
{
    public Guid DknGuid { get; set; }

    public short DknDbcno { get; set; }

    public int? DknSpecRecno { get; set; }

    public bool? DknIptal { get; set; }

    public short? DknFileid { get; set; }

    public bool? DknHidden { get; set; }

    public bool? DknKilitli { get; set; }

    public bool? DknDegisti { get; set; }

    public int? DknChecksum { get; set; }

    public short? DknCreateUser { get; set; }

    public DateTime DknCreateDate { get; set; }

    public short? DknLastupUser { get; set; }

    public DateTime? DknLastupDate { get; set; }

    public string? DknSpecial1 { get; set; }

    public string? DknSpecial2 { get; set; }

    public string? DknSpecial3 { get; set; }

    public string? DknBorcluHesapKodu { get; set; }

    public string? DknBorcluSrmMerkezi { get; set; }

    public string? DknBorcluProje { get; set; }

    public string? DknAlacakliHesapKodu { get; set; }

    public string? DknAlacakliSrmMerkezi { get; set; }

    public string? DknAlacakliProje { get; set; }

    public string? DknDagitimAnahtarKodu { get; set; }

    public double? DknToplamAnahtar { get; set; }

    public double? DknAnahtar { get; set; }

    public double? DknDagitilanTutarAna { get; set; }

    public double? DknDagitilanTutarAlt { get; set; }

    public double? DknDagitilanTutarOrj { get; set; }
}
