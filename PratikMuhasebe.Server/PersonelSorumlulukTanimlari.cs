using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSorumlulukTanimlari
{
    public Guid SrGuid { get; set; }

    public short SrDbcno { get; set; }

    public int? SrSpecRecno { get; set; }

    public bool? SrIptal { get; set; }

    public short? SrFileid { get; set; }

    public bool? SrHidden { get; set; }

    public bool? SrKilitli { get; set; }

    public bool? SrDegisti { get; set; }

    public int? SrChecksum { get; set; }

    public short? SrCreateUser { get; set; }

    public DateTime SrCreateDate { get; set; }

    public short? SrLastupUser { get; set; }

    public DateTime? SrLastupDate { get; set; }

    public string? SrSpecial1 { get; set; }

    public string? SrSpecial2 { get; set; }

    public string? SrSpecial3 { get; set; }

    public string? SrKod { get; set; }

    public string? SrAciklama { get; set; }
}
