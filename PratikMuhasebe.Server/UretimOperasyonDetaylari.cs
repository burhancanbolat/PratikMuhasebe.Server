using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimOperasyonDetaylari
{
    public Guid OpdGuid { get; set; }

    public short OpdDbcno { get; set; }

    public int? OpdSpecRecno { get; set; }

    public bool? OpdIptal { get; set; }

    public short? OpdFileid { get; set; }

    public bool? OpdHidden { get; set; }

    public bool? OpdKilitli { get; set; }

    public bool? OpdDegisti { get; set; }

    public int? OpdCheckSum { get; set; }

    public short? OpdCreateUser { get; set; }

    public DateTime OpdCreateDate { get; set; }

    public short? OpdLastupUser { get; set; }

    public DateTime? OpdLastupDate { get; set; }

    public string? OpdSpecial1 { get; set; }

    public string? OpdSpecial2 { get; set; }

    public string? OpdSpecial3 { get; set; }

    public string? OpdOpKodu { get; set; }

    public int? OpdSatirNo { get; set; }

    public byte? OpdOncelik { get; set; }

    public double? OpdAsgariMiktar { get; set; }

    public double? OpdAzamiMiktar { get; set; }

    public byte? OpdIsmerkeziTipi { get; set; }

    public string? OpdIsmerkeziorGrupKod { get; set; }

    public int? OpdSabitHazirlikSuresi { get; set; }

    public int? OpdOperasyonSuresi { get; set; }

    public double? OpdUretimMiktari { get; set; }

    public int? OpdSabitOperasyonSuresi { get; set; }

    public string? OpdKalipKodu { get; set; }

    public double? OpdHazirlikElemanIhtiyaci { get; set; }

    public double? OpdOperasyonElemanIhtiyaci { get; set; }
}
