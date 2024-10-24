using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroCalisanlari
{
    public Guid KdrcGuid { get; set; }

    public short KdrcDbcno { get; set; }

    public int? KdrcSpecRecno { get; set; }

    public bool? KdrcIptal { get; set; }

    public short? KdrcFileid { get; set; }

    public bool? KdrcHidden { get; set; }

    public bool? KdrcKilitli { get; set; }

    public bool? KdrcDegisti { get; set; }

    public int? KdrcChecksum { get; set; }

    public short? KdrcCreateUser { get; set; }

    public DateTime KdrcCreateDate { get; set; }

    public short? KdrcLastupUser { get; set; }

    public DateTime? KdrcLastupDate { get; set; }

    public string? KdrcSpecial1 { get; set; }

    public string? KdrcSpecial2 { get; set; }

    public string? KdrcSpecial3 { get; set; }

    public string? KdrcKod { get; set; }

    public int? KdrcSirano { get; set; }

    public string? KdrcPersonel { get; set; }

    public byte? KdrcPersAsilVekil { get; set; }

    public string? KdrcYedekPersonel { get; set; }

    public bool? KdrcSemadaGosterme { get; set; }

    public DateTime? KdrcAtamatarihi { get; set; }

    public int? KdrcIdariAmirNo { get; set; }

    public int? KdrcTeknikAmirNo { get; set; }

    public int? KdrcRaporlamaYapKadroNo { get; set; }

    public int? KdrcVekaletKadroNo { get; set; }

    public string? KdrcBolgeKodu { get; set; }

    public string? KdrcBolumKodu { get; set; }

    public string? KdrcDepartmanKodu { get; set; }

    public string? KdrcUlke { get; set; }

    public string? KdrcSormrkz { get; set; }

    public string? KdrcAltDepartmanKodu { get; set; }

    public double? KdrcButcesi { get; set; }
}
