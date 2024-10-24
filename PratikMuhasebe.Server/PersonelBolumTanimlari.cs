using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelBolumTanimlari
{
    public Guid BlGuid { get; set; }

    public short BlDbcno { get; set; }

    public int? BlSpecRecno { get; set; }

    public bool? BlIptal { get; set; }

    public short? BlFileid { get; set; }

    public bool? BlHidden { get; set; }

    public bool? BlKilitli { get; set; }

    public bool? BlDegisti { get; set; }

    public int? BlChecksum { get; set; }

    public short? BlCreateUser { get; set; }

    public DateTime BlCreateDate { get; set; }

    public short? BlLastupUser { get; set; }

    public DateTime? BlLastupDate { get; set; }

    public string? BlSpecial1 { get; set; }

    public string? BlSpecial2 { get; set; }

    public string? BlSpecial3 { get; set; }

    public string? BlKod { get; set; }

    public string? BlAdi { get; set; }
}
