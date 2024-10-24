using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmkiraOdemeleri
{
    public Guid AvmkoGuid { get; set; }

    public short AvmkoDbcno { get; set; }

    public int? AvmkoSpecRecno { get; set; }

    public bool? AvmkoIptal { get; set; }

    public short? AvmkoFileid { get; set; }

    public bool? AvmkoHidden { get; set; }

    public bool? AvmkoKilitli { get; set; }

    public bool? AvmkoDegisti { get; set; }

    public int? AvmkoChecksum { get; set; }

    public short? AvmkoCreateUser { get; set; }

    public DateTime AvmkoCreateDate { get; set; }

    public short? AvmkoLastupUser { get; set; }

    public DateTime? AvmkoLastupDate { get; set; }

    public string? AvmkoSpecial1 { get; set; }

    public string? AvmkoSpecial2 { get; set; }

    public string? AvmkoSpecial3 { get; set; }

    public int? AvmkoFirmaNo { get; set; }

    public int? AvmkoSubeNo { get; set; }

    public DateTime? AvmkoTarihi { get; set; }

    public string? AvmkoEvraknoSeri { get; set; }

    public int? AvmkoEvraknoSira { get; set; }

    public int? AvmkoSatirno { get; set; }

    public string? AvmkoBelgeNo { get; set; }

    public DateTime? AvmkoBelgeTarih { get; set; }

    public string? AvmkoKirakodu { get; set; }

    public double? AvmkoTutar { get; set; }
}
