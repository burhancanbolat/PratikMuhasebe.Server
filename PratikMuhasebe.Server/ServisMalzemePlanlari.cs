using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ServisMalzemePlanlari
{
    public Guid SmplGuid { get; set; }

    public short SmplDbcno { get; set; }

    public int? SmplSpecRecno { get; set; }

    public bool? SmplIptal { get; set; }

    public short? SmplFileid { get; set; }

    public bool? SmplHidden { get; set; }

    public bool? SmplKilitli { get; set; }

    public bool? SmplDegisti { get; set; }

    public int? SmplChecksum { get; set; }

    public short? SmplCreateUser { get; set; }

    public DateTime SmplCreateDate { get; set; }

    public short? SmplLastupUser { get; set; }

    public DateTime? SmplLastupDate { get; set; }

    public string? SmplSpecial1 { get; set; }

    public string? SmplSpecial2 { get; set; }

    public string? SmplSpecial3 { get; set; }

    public string? SmplIsemriKodu { get; set; }

    public int? SmplSatirno { get; set; }

    public DateTime? SmplHarTarihi { get; set; }

    public string? SmplMalzemeKodu { get; set; }

    public double? SmplMiktar { get; set; }

    public double? SmplTutar { get; set; }

    public double? SmplIskonto { get; set; }

    public string? SmplAciklama { get; set; }

    public int? SmplDepono { get; set; }

    public bool? SmplGarantiDahiliFl { get; set; }

    public bool? SmplOnaylandiFl { get; set; }
}
