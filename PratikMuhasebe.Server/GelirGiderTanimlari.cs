using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class GelirGiderTanimlari
{
    public Guid GgtGuid { get; set; }

    public short GgtDbcno { get; set; }

    public int? GgtSpecRecNo { get; set; }

    public bool? GgtIptal { get; set; }

    public short? GgtFileid { get; set; }

    public bool? GgtHidden { get; set; }

    public bool? GgtKilitli { get; set; }

    public bool? GgtDegisti { get; set; }

    public int? GgtChecksum { get; set; }

    public short? GgtCreateUser { get; set; }

    public DateTime GgtCreateDate { get; set; }

    public short? GgtLastupUser { get; set; }

    public DateTime? GgtLastupDate { get; set; }

    public string? GgtSpecial1 { get; set; }

    public string? GgtSpecial2 { get; set; }

    public string? GgtSpecial3 { get; set; }

    public string? GgtHesapKod { get; set; }

    public string? GgtSrmKod { get; set; }

    public double? GgtBorc { get; set; }

    public double? GgtAlacak { get; set; }

    public int? GgtFirmano { get; set; }

    public int? GgtMaliyil { get; set; }

    public short? GgtDonem { get; set; }
}
