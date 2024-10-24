using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariPerformansKriterleri
{
    public Guid CpkGuid { get; set; }

    public short CpkDbcno { get; set; }

    public int? CpkSpecRecno { get; set; }

    public bool? CpkIptal { get; set; }

    public short? CpkFileid { get; set; }

    public bool? CpkHidden { get; set; }

    public bool? CpkKilitli { get; set; }

    public bool? CpkDegisti { get; set; }

    public int? CpkChecksum { get; set; }

    public short? CpkCreateUser { get; set; }

    public DateTime CpkCreateDate { get; set; }

    public short? CpkLastupUser { get; set; }

    public DateTime? CpkLastupDate { get; set; }

    public string? CpkSpecial1 { get; set; }

    public string? CpkSpecial2 { get; set; }

    public string? CpkSpecial3 { get; set; }

    public string? CpkKodu { get; set; }

    public string? CpkAdi { get; set; }

    public string? CpkAciklama1 { get; set; }

    public string? CpkAciklama2 { get; set; }

    public byte? CpkAktif { get; set; }

    public double? CpkMaxpuan { get; set; }

    public double? CpkToplamdakipayi { get; set; }

    public string? CpkSozelpuanlar { get; set; }

    public byte? CpkOtoveritipi { get; set; }
}
