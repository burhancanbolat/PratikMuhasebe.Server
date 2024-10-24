using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizliSatisPromosyonEsasUrunler
{
    public Guid HspeuGuid { get; set; }

    public short HspeuDbcno { get; set; }

    public int? HspeuSpecRecno { get; set; }

    public bool? HspeuIptal { get; set; }

    public short? HspeuFileid { get; set; }

    public bool? HspeuHidden { get; set; }

    public bool? HspeuKilitli { get; set; }

    public bool? HspeuDegisti { get; set; }

    public int? HspeuChecksum { get; set; }

    public short? HspeuCreateUser { get; set; }

    public DateTime HspeuCreateDate { get; set; }

    public short? HspeuLastupUser { get; set; }

    public DateTime? HspeuLastupDate { get; set; }

    public string? HspeuSpecial1 { get; set; }

    public string? HspeuSpecial2 { get; set; }

    public string? HspeuSpecial3 { get; set; }

    public string HspeuPromosyonKodu { get; set; } = null!;

    public string HspeuStokKodu { get; set; } = null!;
}
