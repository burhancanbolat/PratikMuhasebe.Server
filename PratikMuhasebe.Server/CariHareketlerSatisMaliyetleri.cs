using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHareketlerSatisMaliyetleri
{
    public Guid StmlyGuid { get; set; }

    public short StmlyDbcno { get; set; }

    public int? StmlySpecRecno { get; set; }

    public bool? StmlyIptal { get; set; }

    public short? StmlyFileid { get; set; }

    public bool? StmlyHidden { get; set; }

    public bool? StmlyKilitli { get; set; }

    public bool? StmlyDegisti { get; set; }

    public int? StmlyChecksum { get; set; }

    public short? StmlyCreateUser { get; set; }

    public DateTime? StmlyCreateDate { get; set; }

    public short? StmlyLastupUser { get; set; }

    public DateTime? StmlyLastupDate { get; set; }

    public string? StmlySpecial1 { get; set; }

    public string? StmlySpecial2 { get; set; }

    public string? StmlySpecial3 { get; set; }

    public Guid? StmlyChUid { get; set; }

    public double? StmlyUretimAna { get; set; }

    public double? StmlyUretimAlt { get; set; }

    public double? StmlyArastirmagelistirme750Ana { get; set; }

    public double? StmlyArastirmagelistirme750Alt { get; set; }

    public double? StmlyPazarlamasatis760Ana { get; set; }

    public double? StmlyPazarlamasatis760Alt { get; set; }

    public double? StmlyGenelyonetim770Ana { get; set; }

    public double? StmlyGenelyonetim770Alt { get; set; }

    public double? StmlyFinansman780Ana { get; set; }

    public double? StmlyFinansman780Alt { get; set; }

    public double? StmlyDigerAna { get; set; }

    public double? StmlyDigerAlt { get; set; }
}
