using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ShopsidePazaryeriEsleme
{
    public Guid SpeGuid { get; set; }

    public short SpeDbcno { get; set; }

    public int? SpeSpecRecno { get; set; }

    public bool? SpeIptal { get; set; }

    public short? SpeFileid { get; set; }

    public bool? SpeHidden { get; set; }

    public bool? SpeKilitli { get; set; }

    public bool? SpeDegisti { get; set; }

    public int? SpeChecksum { get; set; }

    public short? SpeCreateUser { get; set; }

    public DateTime SpeCreateDate { get; set; }

    public short? SpeLastupUser { get; set; }

    public DateTime? SpeLastupDate { get; set; }

    public string? SpeSpecial1 { get; set; }

    public string? SpeSpecial2 { get; set; }

    public string? SpeSpecial3 { get; set; }

    public string? SpePazaryeriKodu { get; set; }

    public string? SpePazaryeriAdi { get; set; }

    public string? SpeSorumlulukMerkeziKodu { get; set; }
}
