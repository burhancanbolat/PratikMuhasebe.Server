using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimHatalari
{
    public Guid UhGuid { get; set; }

    public short UhDbcno { get; set; }

    public int? UhSpecRecno { get; set; }

    public bool? UhIptal { get; set; }

    public short? UhFileid { get; set; }

    public bool? UhHidden { get; set; }

    public bool? UhKilitli { get; set; }

    public bool? UhDegisti { get; set; }

    public int? UhCheckSum { get; set; }

    public short? UhCreateUser { get; set; }

    public DateTime UhCreateDate { get; set; }

    public short? UhLastupUser { get; set; }

    public DateTime? UhLastupDate { get; set; }

    public string? UhSpecial1 { get; set; }

    public string? UhSpecial2 { get; set; }

    public string? UhSpecial3 { get; set; }

    public string? UhKod { get; set; }

    public string? UhAciklama { get; set; }
}
