using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OzelMahsupDetayTanimlari
{
    public Guid MpGuid { get; set; }

    public short MpDbcno { get; set; }

    public int? MpSpecRecno { get; set; }

    public bool? MpIptal { get; set; }

    public short? MpFileid { get; set; }

    public bool? MpHidden { get; set; }

    public bool? MpKilitli { get; set; }

    public bool? MpDegisti { get; set; }

    public int? MpCheckSum { get; set; }

    public short? MpCreateUser { get; set; }

    public DateTime MpCreateDate { get; set; }

    public short? MpLastupUser { get; set; }

    public DateTime? MpLastupDate { get; set; }

    public string? MpSpecial1 { get; set; }

    public string? MpSpecial2 { get; set; }

    public string? MpSpecial3 { get; set; }

    public string? MpOzMahKodu { get; set; }

    public string? MpHesKodu { get; set; }

    public int? MpSatirNo { get; set; }

    public string? MpAciklama { get; set; }

    public byte? MpMahIslTip { get; set; }

    public double? MpBorc { get; set; }

    public double? MpAlacak { get; set; }

    public string? MpSrmMrkzKodu { get; set; }

    public string? MpProjeKodu { get; set; }
}
