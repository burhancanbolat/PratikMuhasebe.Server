using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EDefterSilinenDosyalar
{
    public Guid EdefsilGuid { get; set; }

    public short? EdefsilCreateUser { get; set; }

    public DateTime EdefsilCreateDate { get; set; }

    public int? EdefsilFirmano { get; set; }

    public int? EdefsilMaliyil { get; set; }

    public int? EdefsilMalidonem { get; set; }

    public int? EdefsilDonemsirano { get; set; }

    public string? EdefsilDosyaadi { get; set; }

    public byte[]? EdefsilDosya { get; set; }
}
