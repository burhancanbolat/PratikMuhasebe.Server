using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IkFormu
{
    public Guid IkfGuid { get; set; }

    public short IkfDbcno { get; set; }

    public int? IkfSpecRecno { get; set; }

    public bool? IkfIptal { get; set; }

    public short? IkfFileid { get; set; }

    public bool? IkfHidden { get; set; }

    public bool? IkfKilitli { get; set; }

    public bool? IkfDegisti { get; set; }

    public int? IkfChecksum { get; set; }

    public short? IkfCreateUser { get; set; }

    public DateTime IkfCreateDate { get; set; }

    public short? IkfLastupUser { get; set; }

    public DateTime? IkfLastupDate { get; set; }

    public string? IkfSpecial1 { get; set; }

    public string? IkfSpecial2 { get; set; }

    public string? IkfSpecial3 { get; set; }

    public int? IkfFirmano { get; set; }

    public int? IkfSubeno { get; set; }

    public DateTime? IkfTarih { get; set; }

    public byte? IkfTipi { get; set; }

    public string? IkfBelgeno { get; set; }

    public DateTime? IkfBelgeTarih { get; set; }

    public string? IkfKod { get; set; }

    public string? IkfAdi { get; set; }

    public string? IkfDept { get; set; }

    public string? IkfGorev { get; set; }

    public string? IkfVerenPers { get; set; }

    public string? IkfPerKodu { get; set; }

    public int? IkfSatirno { get; set; }

    public string? IkfKriter { get; set; }

    public double? IkfSatirpuan { get; set; }

    public bool? IkfDegerlendirFl { get; set; }

    public string? IkfKadro { get; set; }

    public string? IkfAciklama1 { get; set; }

    public string? IkfAciklama2 { get; set; }

    public string? IkfAciklama3 { get; set; }
}
