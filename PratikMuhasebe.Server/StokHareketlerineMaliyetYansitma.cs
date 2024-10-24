using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokHareketlerineMaliyetYansitma
{
    public Guid ShmyGuid { get; set; }

    public short ShmyDbcno { get; set; }

    public int? ShmySpecRecno { get; set; }

    public bool? ShmyIptal { get; set; }

    public short? ShmyFileid { get; set; }

    public bool? ShmyHidden { get; set; }

    public bool? ShmyKilitli { get; set; }

    public bool? ShmyDegisti { get; set; }

    public int? ShmyChecksum { get; set; }

    public short? ShmyCreateUser { get; set; }

    public DateTime ShmyCreateDate { get; set; }

    public short? ShmyLastupUser { get; set; }

    public DateTime? ShmyLastupDate { get; set; }

    public string? ShmySpecial1 { get; set; }

    public string? ShmySpecial2 { get; set; }

    public string? ShmySpecial3 { get; set; }

    public DateTime? ShmyTarihi { get; set; }

    public string? ShmyEvraknoSeri { get; set; }

    public int? ShmyEvraknoSira { get; set; }

    public int? ShmySatirno { get; set; }

    public Guid? ShmyHarUid { get; set; }

    public double? ShmyIlaveMaliyetAna { get; set; }

    public double? ShmyIlaveMaliyetAlt { get; set; }

    public double? ShmyIlaveMaliyetOrj { get; set; }

    public string? ShmyAciklama { get; set; }
}
