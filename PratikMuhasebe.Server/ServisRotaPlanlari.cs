using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ServisRotaPlanlari
{
    public Guid SrplGuid { get; set; }

    public short SrplDbcno { get; set; }

    public int? SrplSpecRecno { get; set; }

    public bool? SrplIptal { get; set; }

    public short? SrplFileid { get; set; }

    public bool? SrplHidden { get; set; }

    public bool? SrplKilitli { get; set; }

    public bool? SrplDegisti { get; set; }

    public int? SrplCheckSum { get; set; }

    public short? SrplCreateUser { get; set; }

    public DateTime SrplCreateDate { get; set; }

    public short? SrplLastupUser { get; set; }

    public DateTime? SrplLastupDate { get; set; }

    public string? SrplSpecial1 { get; set; }

    public string? SrplSpecial2 { get; set; }

    public string? SrplSpecial3 { get; set; }

    public string? SrplIsemriKodu { get; set; }

    public int? SrplSatirno { get; set; }

    public string? SrplOperasyonKodu { get; set; }

    public string? SrplAtananEkip { get; set; }

    public int? SrplPlanlananSure { get; set; }

    public int? SrplTamamlananSure { get; set; }

    public double? SrplPlanlananMiktar { get; set; }

    public double? SrplTutar { get; set; }

    public DateTime? SrplPlanlananBaslamaTarihi { get; set; }

    public string? SrplAciklama { get; set; }

    public bool? SrplGarantiDahiliFl { get; set; }

    public bool? SrplOnaylandiFl { get; set; }

    public bool? SrplKapandiFl { get; set; }

    public double? SrplIskonto { get; set; }
}
