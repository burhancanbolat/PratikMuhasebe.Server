using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MuhasebeFisGrubuTanimlari
{
    public Guid MfgGuid { get; set; }

    public short MfgDbcno { get; set; }

    public int? MfgSpecRecno { get; set; }

    public bool? MfgIptal { get; set; }

    public short? MfgFileid { get; set; }

    public bool? MfgHidden { get; set; }

    public bool? MfgKilitli { get; set; }

    public bool? MfgDegisti { get; set; }

    public int? MfgChecksum { get; set; }

    public short? MfgCreateUser { get; set; }

    public DateTime MfgCreateDate { get; set; }

    public short? MfgLastupUser { get; set; }

    public DateTime? MfgLastupDate { get; set; }

    public string? MfgSpecial1 { get; set; }

    public string? MfgSpecial2 { get; set; }

    public string? MfgSpecial3 { get; set; }

    public string? MfgKodu { get; set; }

    public string? MfgAciklama { get; set; }
}
