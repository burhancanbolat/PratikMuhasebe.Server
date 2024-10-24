using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class YasakliKayitlar
{
    public Guid YkGuid { get; set; }

    public short YkDbcno { get; set; }

    public int? YkSpecRecno { get; set; }

    public bool? YkIptal { get; set; }

    public short? YkFileid { get; set; }

    public bool? YkHidden { get; set; }

    public bool? YkKilitli { get; set; }

    public bool? YkDegisti { get; set; }

    public int? YkChecksum { get; set; }

    public short? YkCreateUser { get; set; }

    public DateTime YkCreateDate { get; set; }

    public short? YkLastupUser { get; set; }

    public DateTime? YkLastupDate { get; set; }

    public string? YkSpecial1 { get; set; }

    public string? YkSpecial2 { get; set; }

    public string? YkSpecial3 { get; set; }

    public int? YkKullanicino { get; set; }

    public short? YkTablono { get; set; }

    public Guid? YkKayitid { get; set; }
}
