using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IstasyonSayacHareketleri
{
    public Guid ShGuid { get; set; }

    public short ShDbcno { get; set; }

    public int? ShSpecRecno { get; set; }

    public bool? ShIptal { get; set; }

    public short? ShFileid { get; set; }

    public bool? ShHidden { get; set; }

    public bool? ShKilitli { get; set; }

    public bool? ShDegisti { get; set; }

    public int? ShChecksum { get; set; }

    public short? ShCreateUser { get; set; }

    public DateTime ShCreateDate { get; set; }

    public short? ShLastupUser { get; set; }

    public DateTime? ShLastupDate { get; set; }

    public string? ShSpecial1 { get; set; }

    public string? ShSpecial2 { get; set; }

    public string? ShSpecial3 { get; set; }

    public int? ShFirmaNo { get; set; }

    public int? ShSubeNo { get; set; }

    public string? ShKodu { get; set; }

    public double? ShAcilis { get; set; }

    public double? ShKapanis { get; set; }

    public double? ShAktarma { get; set; }

    public double? ShBirimfiyati { get; set; }

    public DateTime? ShVardiyatarihi { get; set; }

    public byte? ShVardiyano { get; set; }
}
