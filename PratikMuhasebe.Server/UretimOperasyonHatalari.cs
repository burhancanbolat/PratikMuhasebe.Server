using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimOperasyonHatalari
{
    public Guid OphGuid { get; set; }

    public short OphDbcno { get; set; }

    public int? OphSpecRecno { get; set; }

    public bool? OphIptal { get; set; }

    public short? OphFileid { get; set; }

    public bool? OphHidden { get; set; }

    public bool? OphKilitli { get; set; }

    public bool? OphDegisti { get; set; }

    public int? OphCheckSum { get; set; }

    public short? OphCreateUser { get; set; }

    public DateTime OphCreateDate { get; set; }

    public short? OphLastupUser { get; set; }

    public DateTime? OphLastupDate { get; set; }

    public string? OphSpecial1 { get; set; }

    public string? OphSpecial2 { get; set; }

    public string? OphSpecial3 { get; set; }

    public Guid? OphOpTamamUid { get; set; }

    public string? OphHataKodlari { get; set; }

    public string? OphPersonel { get; set; }

    public DateTime? OphTarih { get; set; }

    public double? OphHataliMiktar { get; set; }
}
