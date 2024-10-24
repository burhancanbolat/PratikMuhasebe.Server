using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelDevamKontrol
{
    public Guid PdkGuid { get; set; }

    public short PdkDbcno { get; set; }

    public int? PdkSpecRecno { get; set; }

    public bool? PdkIptal { get; set; }

    public short? PdkFileid { get; set; }

    public bool? PdkHidden { get; set; }

    public bool? PdkKilitli { get; set; }

    public bool? PdkDegisti { get; set; }

    public int? PdkChecksum { get; set; }

    public short? PdkCreateUser { get; set; }

    public DateTime PdkCreateDate { get; set; }

    public short? PdkLastupUser { get; set; }

    public DateTime? PdkLastupDate { get; set; }

    public string? PdkSpecial1 { get; set; }

    public string? PdkSpecial2 { get; set; }

    public string? PdkSpecial3 { get; set; }

    public string? PdkKod { get; set; }

    public DateTime? PdkZaman { get; set; }

    public byte? PdkTip { get; set; }

    public string? PdkTakvimkodu { get; set; }

    public string? PdkVardiyakodu { get; set; }

    public byte? PdkVardiyano { get; set; }

    public string? PdkProjekodu { get; set; }

    public string? PdkSormerkodu { get; set; }

    public string? PdkNedenkodu { get; set; }

    public string? PdkIsmerkezikodu { get; set; }
}
