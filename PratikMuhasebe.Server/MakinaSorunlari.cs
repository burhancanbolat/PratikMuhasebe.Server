using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MakinaSorunlari
{
    public Guid MksGuid { get; set; }

    public short MksDbcno { get; set; }

    public int? MksSpecRecno { get; set; }

    public bool? MksIptal { get; set; }

    public short? MksFileid { get; set; }

    public bool? MksHidden { get; set; }

    public bool? MksKilitli { get; set; }

    public bool? MksDegisti { get; set; }

    public int? MksChecksum { get; set; }

    public short? MksCreateUser { get; set; }

    public DateTime MksCreateDate { get; set; }

    public short? MksLastupUser { get; set; }

    public DateTime? MksLastupDate { get; set; }

    public string? MksSpecial1 { get; set; }

    public string? MksSpecial2 { get; set; }

    public string? MksSpecial3 { get; set; }

    public string? MksKod { get; set; }

    public string? MksIsmi { get; set; }
}
