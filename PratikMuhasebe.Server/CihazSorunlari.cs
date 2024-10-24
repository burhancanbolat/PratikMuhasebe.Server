using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CihazSorunlari
{
    public Guid ChsGuid { get; set; }

    public short ChsDbcno { get; set; }

    public int? ChsSpecRecNo { get; set; }

    public bool? ChsIptal { get; set; }

    public short? ChsFileid { get; set; }

    public bool? ChsHidden { get; set; }

    public bool? ChsKilitli { get; set; }

    public bool? ChsDegisti { get; set; }

    public int? ChsChecksum { get; set; }

    public short? ChsCreateUser { get; set; }

    public DateTime ChsCreateDate { get; set; }

    public short? ChsLastupUser { get; set; }

    public DateTime? ChsLastupDate { get; set; }

    public string? ChsSpecial1 { get; set; }

    public string? ChsSpecial2 { get; set; }

    public string? ChsSpecial3 { get; set; }

    public string? ChsKodu { get; set; }

    public string? ChsCihaz { get; set; }

    public string? ChsSorun { get; set; }

    public string? ChsStokAnaGrupKodu { get; set; }

    public string? ChsGrupKodu { get; set; }

    public string? ChsSinifKodu { get; set; }

    public int? ChsSorunGidermeSuresi { get; set; }
}
