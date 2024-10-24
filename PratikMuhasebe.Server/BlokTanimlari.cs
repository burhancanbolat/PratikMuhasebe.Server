using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BlokTanimlari
{
    public Guid BlokGuid { get; set; }

    public short BlokDbcno { get; set; }

    public int? BlokSpecRecno { get; set; }

    public bool? BlokIptal { get; set; }

    public short? BlokFileid { get; set; }

    public bool? BlokHidden { get; set; }

    public bool? BlokKilitli { get; set; }

    public bool? BlokDegisti { get; set; }

    public int? BlokChecksum { get; set; }

    public short? BlokCreateUser { get; set; }

    public DateTime BlokCreateDate { get; set; }

    public short? BlokLastupUser { get; set; }

    public DateTime? BlokLastupDate { get; set; }

    public string? BlokSpecial1 { get; set; }

    public string? BlokSpecial2 { get; set; }

    public string? BlokSpecial3 { get; set; }

    public string? BlokSitekod { get; set; }

    public string? BlokKod { get; set; }

    public string? BlokIsmi { get; set; }
}
