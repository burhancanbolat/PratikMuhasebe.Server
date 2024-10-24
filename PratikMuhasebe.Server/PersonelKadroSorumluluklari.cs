using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroSorumluluklari
{
    public Guid KsGuid { get; set; }

    public short KsDbcno { get; set; }

    public int? KsSpecRecno { get; set; }

    public bool? KsIptal { get; set; }

    public short? KsFileid { get; set; }

    public bool? KsHidden { get; set; }

    public bool? KsKilitli { get; set; }

    public bool? KsDegisti { get; set; }

    public int? KsChecksum { get; set; }

    public short? KsCreateUser { get; set; }

    public DateTime KsCreateDate { get; set; }

    public short? KsLastupUser { get; set; }

    public DateTime? KsLastupDate { get; set; }

    public string? KsSpecial1 { get; set; }

    public string? KsSpecial2 { get; set; }

    public string? KsSpecial3 { get; set; }

    public string? KsKadrokod { get; set; }

    public int? KsKadrosirano { get; set; }

    public int? KsSatirno { get; set; }

    public string? KsSorumlulukkod { get; set; }

    public DateTime? KsGecerliliktarihi { get; set; }
}
