using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BedenHareketleri
{
    public Guid BdnHarGuid { get; set; }

    public short BdnHarDbcno { get; set; }

    public int? BdnHarSpecRecNo { get; set; }

    public bool? BdnHarIptal { get; set; }

    public short? BdnHarFileid { get; set; }

    public bool? BdnHarHidden { get; set; }

    public bool? BdnHarKilitli { get; set; }

    public bool? BdnHarDegisti { get; set; }

    public int? BdnHarChecksum { get; set; }

    public short? BdnHarCreateUser { get; set; }

    public DateTime? BdnHarCreateDate { get; set; }

    public short? BdnHarLastupUser { get; set; }

    public DateTime? BdnHarLastupDate { get; set; }

    public string? BdnHarSpecial1 { get; set; }

    public string? BdnHarSpecial2 { get; set; }

    public string? BdnHarSpecial3 { get; set; }

    public byte? BdnHarTipi { get; set; }

    public Guid? BdnHarHarUid { get; set; }

    public short? BdnHarBedenNo { get; set; }

    public double? BdnHarHarGor { get; set; }

    public double? BdnHarKnsIsGor { get; set; }

    public double? BdnHarKnsFat { get; set; }

    public double? BdnHarTesMik { get; set; }

    public double? BdnHarRezervasyonMiktari { get; set; }

    public double? BdnHarRezervedenTeslimEdilen { get; set; }
}
