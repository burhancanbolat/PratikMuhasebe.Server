using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EgitimGrupTanimlari
{
    public Guid EgrGuid { get; set; }

    public short EgrDbcno { get; set; }

    public int? EgrSpecRecno { get; set; }

    public bool? EgrIptal { get; set; }

    public short? EgrFileid { get; set; }

    public bool? EgrHidden { get; set; }

    public bool? EgrKilitli { get; set; }

    public bool? EgrDegisti { get; set; }

    public int? EgrChecksum { get; set; }

    public short? EgrCreateUser { get; set; }

    public DateTime EgrCreateDate { get; set; }

    public short? EgrLastupUser { get; set; }

    public DateTime? EgrLastupDate { get; set; }

    public string? EgrSpecial1 { get; set; }

    public string? EgrSpecial2 { get; set; }

    public string? EgrSpecial3 { get; set; }

    public int? EgrFirmano { get; set; }

    public int? EgrSubeno { get; set; }

    public string? EgrKod { get; set; }

    public string? EgrAdi { get; set; }

    public string? EgrTipKodu { get; set; }

    public string? EgrAltGrupKodu { get; set; }
}
