using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelBasvuruPuanTanimlari
{
    public Guid BspGuid { get; set; }

    public short BspDbcno { get; set; }

    public int? BspSpecRecno { get; set; }

    public bool? BspIptal { get; set; }

    public short? BspFileid { get; set; }

    public bool? BspHidden { get; set; }

    public bool? BspKilitli { get; set; }

    public bool? BspDegisti { get; set; }

    public int? BspChecksum { get; set; }

    public short? BspCreateUser { get; set; }

    public DateTime BspCreateDate { get; set; }

    public short? BspLastupUser { get; set; }

    public DateTime? BspLastupDate { get; set; }

    public string? BspSpecial1 { get; set; }

    public string? BspSpecial2 { get; set; }

    public string? BspSpecial3 { get; set; }

    public string? BspKodu { get; set; }

    public string? BspAdi { get; set; }

    public double? BspMaxpuan { get; set; }

    public double? BspAgirlik { get; set; }
}
