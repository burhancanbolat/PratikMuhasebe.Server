using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroYetkileri
{
    public Guid KyGuid { get; set; }

    public short KyDbcno { get; set; }

    public int? KySpecRecno { get; set; }

    public bool? KyIptal { get; set; }

    public short? KyFileid { get; set; }

    public bool? KyHidden { get; set; }

    public bool? KyKilitli { get; set; }

    public bool? KyDegisti { get; set; }

    public int? KyChecksum { get; set; }

    public short? KyCreateUser { get; set; }

    public DateTime KyCreateDate { get; set; }

    public short? KyLastupUser { get; set; }

    public DateTime? KyLastupDate { get; set; }

    public string? KySpecial1 { get; set; }

    public string? KySpecial2 { get; set; }

    public string? KySpecial3 { get; set; }

    public string? KyKadrokod { get; set; }

    public int? KyKadrosirano { get; set; }

    public int? KySatirno { get; set; }

    public string? KyYetkikod { get; set; }

    public DateTime? KyGecerliliktarihi { get; set; }
}
