using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSinavSorulari
{
    public Guid PssGuid { get; set; }

    public short PssDbcno { get; set; }

    public int? PssSpecRecno { get; set; }

    public bool? PssIptal { get; set; }

    public short? PssFileid { get; set; }

    public bool? PssHidden { get; set; }

    public bool? PssKilitli { get; set; }

    public bool? PssDegisti { get; set; }

    public int? PssChecksum { get; set; }

    public short? PssCreateUser { get; set; }

    public DateTime PssCreateDate { get; set; }

    public short? PssLastupUser { get; set; }

    public DateTime? PssLastupDate { get; set; }

    public string? PssSpecial1 { get; set; }

    public string? PssSpecial2 { get; set; }

    public string? PssSpecial3 { get; set; }

    public byte? PssTipi { get; set; }

    public string? PssKodu { get; set; }

    public string? PssSorukodu { get; set; }

    public double? PssPuan { get; set; }

    public string? PssOlculennitelik { get; set; }
}
