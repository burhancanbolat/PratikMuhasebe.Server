using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EgitimAltGrupTanimlari
{
    public Guid EagGuid { get; set; }

    public short EagDbcno { get; set; }

    public int? EagSpecRecno { get; set; }

    public bool? EagIptal { get; set; }

    public short? EagFileid { get; set; }

    public bool? EagHidden { get; set; }

    public bool? EagKilitli { get; set; }

    public bool? EagDegisti { get; set; }

    public int? EagChecksum { get; set; }

    public short? EagCreateUser { get; set; }

    public DateTime EagCreateDate { get; set; }

    public short? EagLastupUser { get; set; }

    public DateTime? EagLastupDate { get; set; }

    public string? EagSpecial1 { get; set; }

    public string? EagSpecial2 { get; set; }

    public string? EagSpecial3 { get; set; }

    public int? EagFirmano { get; set; }

    public int? EagSubeno { get; set; }

    public string? EagKod { get; set; }

    public string? EagAdi { get; set; }

    public string? EagEgitimKodu { get; set; }
}
