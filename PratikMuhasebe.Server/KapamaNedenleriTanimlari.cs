using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KapamaNedenleriTanimlari
{
    public Guid KpmGuid { get; set; }

    public short KpmDbcno { get; set; }

    public int? KpmSpecRecno { get; set; }

    public bool? KpmIptal { get; set; }

    public short? KpmFileid { get; set; }

    public bool? KpmHidden { get; set; }

    public bool? KpmKilitli { get; set; }

    public bool? KpmDegisti { get; set; }

    public int? KpmChecksum { get; set; }

    public short? KpmCreateUser { get; set; }

    public DateTime KpmCreateDate { get; set; }

    public short? KpmLastupUser { get; set; }

    public DateTime? KpmLastupDate { get; set; }

    public string? KpmSpecial1 { get; set; }

    public string? KpmSpecial2 { get; set; }

    public string? KpmSpecial3 { get; set; }

    public string? KpmKod { get; set; }

    public string? KpmIsmi { get; set; }

    public string? KpmAciklama { get; set; }
}
