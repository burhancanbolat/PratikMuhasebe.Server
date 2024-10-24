using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DemirbasSayimSonuclari
{
    public Guid DsymGuid { get; set; }

    public short DsymDbcno { get; set; }

    public int? DsymSpecRecno { get; set; }

    public bool? DsymIptal { get; set; }

    public short? DsymFileid { get; set; }

    public bool? DsymHidden { get; set; }

    public bool? DsymKilitli { get; set; }

    public bool? DsymDegisti { get; set; }

    public int? DsymChecksum { get; set; }

    public short? DsymCreateUser { get; set; }

    public DateTime DsymCreateDate { get; set; }

    public short? DsymLastupUser { get; set; }

    public DateTime? DsymLastupDate { get; set; }

    public string? DsymSpecial1 { get; set; }

    public string? DsymSpecial2 { get; set; }

    public string? DsymSpecial3 { get; set; }

    public DateTime? DsymTarihi { get; set; }

    public string? DsymZimmetYeri { get; set; }

    public int? DsymEvrakno { get; set; }

    public int? DsymSatirno { get; set; }

    public string? DsymAtikKodu { get; set; }

    public double? DsymMiktar { get; set; }

    public string? DsymBarkod { get; set; }
}
