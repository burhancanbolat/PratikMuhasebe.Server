using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroPerformanslari
{
    public Guid KpGuid { get; set; }

    public short KpDbcno { get; set; }

    public int? KpSpecRecno { get; set; }

    public bool? KpIptal { get; set; }

    public short? KpFileid { get; set; }

    public bool? KpHidden { get; set; }

    public bool? KpKilitli { get; set; }

    public bool? KpDegisti { get; set; }

    public int? KpChecksum { get; set; }

    public short? KpCreateUser { get; set; }

    public DateTime KpCreateDate { get; set; }

    public short? KpLastupUser { get; set; }

    public DateTime? KpLastupDate { get; set; }

    public string? KpSpecial1 { get; set; }

    public string? KpSpecial2 { get; set; }

    public string? KpSpecial3 { get; set; }

    public string? KpKadrokod { get; set; }

    public int? KpKadrosirano { get; set; }

    public int? KpSatirno { get; set; }

    public byte? KpPerformanstipi { get; set; }

    public string? KpPerformanskod { get; set; }

    public DateTime? KpGecerliliktarihi { get; set; }
}
