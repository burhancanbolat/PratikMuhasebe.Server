using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class YuklemeKabul
{
    public Guid YkGuid { get; set; }

    public short YkDbcno { get; set; }

    public int? YkSpecRecno { get; set; }

    public bool? YkIptal { get; set; }

    public short? YkFileid { get; set; }

    public bool? YkHidden { get; set; }

    public bool? YkKilitli { get; set; }

    public bool? YkDegisti { get; set; }

    public int? YkChecksum { get; set; }

    public short? YkCreateUser { get; set; }

    public DateTime YkCreateDate { get; set; }

    public short? YkLastupUser { get; set; }

    public DateTime? YkLastupDate { get; set; }

    public string? YkSpecial1 { get; set; }

    public string? YkSpecial2 { get; set; }

    public string? YkSpecial3 { get; set; }

    public byte? YkTipi { get; set; }

    public string? YkKodu { get; set; }

    public string? YkPlaka { get; set; }

    public string? YkAciklama { get; set; }

    public DateTime? YkTarihi { get; set; }

    public DateTime? YkSevktarihi { get; set; }
}
