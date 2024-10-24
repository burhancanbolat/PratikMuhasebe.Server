using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelEgitmenleri
{
    public Guid EgmGuid { get; set; }

    public short EgmDbcno { get; set; }

    public int? EgmSpecRecno { get; set; }

    public bool? EgmIptal { get; set; }

    public short? EgmFileid { get; set; }

    public bool? EgmHidden { get; set; }

    public bool? EgmKilitli { get; set; }

    public bool? EgmDegisti { get; set; }

    public int? EgmChecksum { get; set; }

    public short? EgmCreateUser { get; set; }

    public DateTime EgmCreateDate { get; set; }

    public short? EgmLastupUser { get; set; }

    public DateTime? EgmLastupDate { get; set; }

    public string? EgmSpecial1 { get; set; }

    public string? EgmSpecial2 { get; set; }

    public string? EgmSpecial3 { get; set; }

    public string? EgmKodu { get; set; }

    public string? EgmAdi { get; set; }

    public string? EgmFirma { get; set; }

    public string? EgmBagliCariKodu { get; set; }

    public string? EgmBagliPersKodu { get; set; }

    public byte? EgmTipi { get; set; }

    public string? EgmMailadres { get; set; }

    public double? EgmUcret { get; set; }

    public byte? EgmUcretTipi { get; set; }

    public byte? EgmDovizCinsi { get; set; }

    public string? EgmKonuKodu { get; set; }
}
