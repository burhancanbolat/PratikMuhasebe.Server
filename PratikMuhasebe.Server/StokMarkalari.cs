using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokMarkalari
{
    public Guid MrkGuid { get; set; }

    public short MrkDbcno { get; set; }

    public int? MrkSpecRecno { get; set; }

    public bool? MrkIptal { get; set; }

    public short? MrkFileid { get; set; }

    public bool? MrkHidden { get; set; }

    public bool? MrkKilitli { get; set; }

    public bool? MrkDegisti { get; set; }

    public int? MrkChecksum { get; set; }

    public short? MrkCreateUser { get; set; }

    public DateTime MrkCreateDate { get; set; }

    public short? MrkLastupUser { get; set; }

    public DateTime? MrkLastupDate { get; set; }

    public string? MrkSpecial1 { get; set; }

    public string? MrkSpecial2 { get; set; }

    public string? MrkSpecial3 { get; set; }

    public string? MrkKod { get; set; }

    public string? MrkIsmi { get; set; }
}
