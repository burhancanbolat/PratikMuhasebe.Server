using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Etiketba
{
    public Guid EtkbGuid { get; set; }

    public short EtkbDbcno { get; set; }

    public int? EtkbSpecRecno { get; set; }

    public bool? EtkbIptal { get; set; }

    public short? EtkbFileid { get; set; }

    public bool? EtkbHidden { get; set; }

    public bool? EtkbKilitli { get; set; }

    public bool? EtkbDegisti { get; set; }

    public int? EtkbChecksum { get; set; }

    public short? EtkbCreateUser { get; set; }

    public DateTime EtkbCreateDate { get; set; }

    public short? EtkbLastupUser { get; set; }

    public DateTime? EtkbLastupDate { get; set; }

    public string? EtkbSpecial1 { get; set; }

    public string? EtkbSpecial2 { get; set; }

    public string? EtkbSpecial3 { get; set; }

    public string? EtkbEvraknoSeri { get; set; }

    public int? EtkbEvraknoSira { get; set; }

    public DateTime? EtkbEvrakTarihi { get; set; }

    public string? EtkbAciklama { get; set; }

    public int? EtkbSatirno { get; set; }

    public string? EtkbBelgeNo { get; set; }

    public DateTime? EtkbBelgeTarih { get; set; }

    public byte? EtkbEtiketTip { get; set; }

    public byte? EtkbBasimTipi { get; set; }

    public short? EtkbBasimAdet { get; set; }

    public int? EtkbDepoNo { get; set; }

    public string? EtkbStokKodu { get; set; }

    public int? EtkbRenkNo { get; set; }

    public int? EtkbBedenNo { get; set; }

    public string? EtkbBarkodu { get; set; }

    public short? EtkbBasilacakMiktar { get; set; }
}
