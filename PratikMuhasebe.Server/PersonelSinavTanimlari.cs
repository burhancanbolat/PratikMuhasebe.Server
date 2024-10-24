using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSinavTanimlari
{
    public Guid SnvGuid { get; set; }

    public short SnvDbcno { get; set; }

    public int? SnvSpecRecno { get; set; }

    public bool? SnvIptal { get; set; }

    public short? SnvFileid { get; set; }

    public bool? SnvHidden { get; set; }

    public bool? SnvKilitli { get; set; }

    public bool? SnvDegisti { get; set; }

    public int? SnvChecksum { get; set; }

    public short? SnvCreateUser { get; set; }

    public DateTime SnvCreateDate { get; set; }

    public short? SnvLastupUser { get; set; }

    public DateTime? SnvLastupDate { get; set; }

    public string? SnvSpecial1 { get; set; }

    public string? SnvSpecial2 { get; set; }

    public string? SnvSpecial3 { get; set; }

    public string? SnvKodu { get; set; }

    public string? SnvAdi { get; set; }

    public double? SnvMaxpuan { get; set; }

    public byte? SnvTipi { get; set; }

    public byte? SnvKapsam { get; set; }

    public string? SnvNitelik { get; set; }

    public int? SnvtSuresi { get; set; }
}
