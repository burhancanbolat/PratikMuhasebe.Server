using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelBasvuruPuanDegerlendirmeleri
{
    public Guid BsdGuid { get; set; }

    public short BsdDbcno { get; set; }

    public int? BsdSpecRecno { get; set; }

    public bool? BsdIptal { get; set; }

    public short? BsdFileid { get; set; }

    public bool? BsdHidden { get; set; }

    public bool? BsdKilitli { get; set; }

    public bool? BsdDegisti { get; set; }

    public int? BsdChecksum { get; set; }

    public short? BsdCreateUser { get; set; }

    public DateTime BsdCreateDate { get; set; }

    public short? BsdLastupUser { get; set; }

    public DateTime? BsdLastupDate { get; set; }

    public string? BsdSpecial1 { get; set; }

    public string? BsdSpecial2 { get; set; }

    public string? BsdSpecial3 { get; set; }

    public DateTime? BsdTarih { get; set; }

    public string? BsdPerKodu { get; set; }

    public Guid? BsdBasUid { get; set; }

    public string? BsdPuanKodu { get; set; }

    public double? BsdPuan { get; set; }

    public string? BsdAciklama { get; set; }
}
