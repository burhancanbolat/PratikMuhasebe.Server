using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSinavSoruTanimlari
{
    public Guid PstGuid { get; set; }

    public short PstDbcno { get; set; }

    public int? PstSpecRecno { get; set; }

    public bool? PstIptal { get; set; }

    public short? PstFileid { get; set; }

    public bool? PstHidden { get; set; }

    public bool? PstKilitli { get; set; }

    public bool? PstDegisti { get; set; }

    public int? PstChecksum { get; set; }

    public short? PstCreateUser { get; set; }

    public DateTime PstCreateDate { get; set; }

    public short? PstLastupUser { get; set; }

    public DateTime? PstLastupDate { get; set; }

    public string? PstSpecial1 { get; set; }

    public string? PstSpecial2 { get; set; }

    public string? PstSpecial3 { get; set; }

    public string? PstKodu { get; set; }

    public string? PstSoru { get; set; }

    public byte? PstSorutipi { get; set; }
}
