using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AsortiTanimKodlari
{
    public Guid AsortiTanGuid { get; set; }

    public short AsortiTanDbcno { get; set; }

    public int? AsortiTanSpecRecno { get; set; }

    public bool? AsortiTanIptal { get; set; }

    public short? AsortiTanFileid { get; set; }

    public bool? AsortiTanHidden { get; set; }

    public bool? AsortiTanKilitli { get; set; }

    public bool? AsortiTanDegisti { get; set; }

    public int? AsortiTanChecksum { get; set; }

    public short? AsortiTanCreateUser { get; set; }

    public DateTime AsortiTanCreateDate { get; set; }

    public short? AsortiTanLastupUser { get; set; }

    public DateTime? AsortiTanLastupDate { get; set; }

    public string? AsortiTanSpecial1 { get; set; }

    public string? AsortiTanSpecial2 { get; set; }

    public string? AsortiTanSpecial3 { get; set; }

    public string? AsortiTanKodu { get; set; }

    public string? AsortiTanAciklama { get; set; }
}
