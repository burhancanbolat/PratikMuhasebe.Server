using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelEgitimYeriTanimlari
{
    public Guid PeyGuid { get; set; }

    public short PeyDbcno { get; set; }

    public int? PeySpecRecno { get; set; }

    public bool? PeyIptal { get; set; }

    public short? PeyFileid { get; set; }

    public bool? PeyHidden { get; set; }

    public bool? PeyKilitli { get; set; }

    public bool? PeyDegisti { get; set; }

    public int? PeyChecksum { get; set; }

    public short? PeyCreateUser { get; set; }

    public DateTime PeyCreateDate { get; set; }

    public short? PeyLastupUser { get; set; }

    public DateTime? PeyLastupDate { get; set; }

    public string? PeySpecial1 { get; set; }

    public string? PeySpecial2 { get; set; }

    public string? PeySpecial3 { get; set; }

    public string? PeyKod { get; set; }

    public string? PeyAdi { get; set; }

    public double? PeyUcret { get; set; }

    public byte? PeyDovizCinsi { get; set; }

    public byte? PeyUcretBirimi { get; set; }

    public string? PeyBagliCariKodu { get; set; }
}
