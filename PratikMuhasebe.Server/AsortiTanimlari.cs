using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AsortiTanimlari
{
    public Guid AsortiGuid { get; set; }

    public short AsortiDbcno { get; set; }

    public int? AsortiSpecRecno { get; set; }

    public bool? AsortiIptal { get; set; }

    public short? AsortiFileid { get; set; }

    public bool? AsortiHidden { get; set; }

    public bool? AsortiKilitli { get; set; }

    public bool? AsortiDegisti { get; set; }

    public int? AsortiChecksum { get; set; }

    public short? AsortiCreateUser { get; set; }

    public DateTime AsortiCreateDate { get; set; }

    public short? AsortiLastupUser { get; set; }

    public DateTime? AsortiLastupDate { get; set; }

    public string? AsortiSpecial1 { get; set; }

    public string? AsortiSpecial2 { get; set; }

    public string? AsortiSpecial3 { get; set; }

    public string? AsortiStokKodu { get; set; }

    public string? AsortiTanimKodu { get; set; }

    public short? AsortiBedenNo { get; set; }

    public double? AsortiMiktar { get; set; }
}
