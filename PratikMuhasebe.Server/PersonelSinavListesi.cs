using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSinavListesi
{
    public Guid SltGuid { get; set; }

    public short SltDbcno { get; set; }

    public int? SltSpecRecno { get; set; }

    public bool? SltIptal { get; set; }

    public short? SltFileid { get; set; }

    public bool? SltHidden { get; set; }

    public bool? SltKilitli { get; set; }

    public bool? SltDegisti { get; set; }

    public int? SltChecksum { get; set; }

    public short? SltCreateUser { get; set; }

    public DateTime SltCreateDate { get; set; }

    public short? SltLastupUser { get; set; }

    public DateTime? SltLastupDate { get; set; }

    public string? SltSpecial1 { get; set; }

    public string? SltSpecial2 { get; set; }

    public string? SltSpecial3 { get; set; }

    public DateTime? SltTarih { get; set; }

    public string? SltSinavKodu { get; set; }

    public bool? SltKatilmadi { get; set; }

    public byte? SltKapsam { get; set; }

    public string? SltKapsamKodu { get; set; }

    public string? SltAciklama { get; set; }
}
