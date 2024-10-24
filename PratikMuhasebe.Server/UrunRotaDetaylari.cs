using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UrunRotaDetaylari
{
    public Guid UrdGuid { get; set; }

    public short UrdDbcno { get; set; }

    public int? UrdSpecRecno { get; set; }

    public bool? UrdIptal { get; set; }

    public short? UrdFileid { get; set; }

    public bool? UrdHidden { get; set; }

    public bool? UrdKilitli { get; set; }

    public bool? UrdDegisti { get; set; }

    public int? UrdCheckSum { get; set; }

    public short? UrdCreateUser { get; set; }

    public DateTime UrdCreateDate { get; set; }

    public short? UrdLastupUser { get; set; }

    public DateTime? UrdLastupDate { get; set; }

    public string? UrdSpecial1 { get; set; }

    public string? UrdSpecial2 { get; set; }

    public string? UrdSpecial3 { get; set; }

    public Guid? UrdBagliRotaUid { get; set; }

    public int? UrdDetaySatirNo { get; set; }

    public byte? UrdKriterDegeri1 { get; set; }

    public double? UrdMaxDeger1 { get; set; }

    public double? UrdMinDeger1 { get; set; }

    public byte? UrdKriterDegeri2 { get; set; }

    public double? UrdMaxDeger2 { get; set; }

    public double? UrdMinDeger2 { get; set; }

    public byte? UrdKriterDegeri3 { get; set; }

    public double? UrdMaxDeger3 { get; set; }

    public double? UrdMinDeger3 { get; set; }

    public byte? UrdIsmerkeziTipi { get; set; }

    public string? UrdIsmerkeziveyaGrupKod { get; set; }

    public int? UrdSabitHazirlikSuresi { get; set; }

    public int? UrdDegiskenOperasyonSuresi { get; set; }

    public int? UrdSabitOperasyonSuresi { get; set; }

    public double? UrdUretimMiktari { get; set; }

    public double? UrdCikisPartiMiktari { get; set; }

    public double? UrdEnerji1Miktari { get; set; }

    public double? UrdEnerji2Miktari { get; set; }

    public string? UrdAciklama { get; set; }

    public short? UrdCalisanSayisi { get; set; }

    public string? UrdKalipKodu { get; set; }

    public double? UrdHazirlikElemanIhtiyaci { get; set; }

    public double? UrdOperasyonElemanIhtiyaci { get; set; }
}
