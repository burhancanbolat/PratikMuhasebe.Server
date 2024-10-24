using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UrunRotalari
{
    public Guid UrtGuid { get; set; }

    public short UrtDbcno { get; set; }

    public int? UrtSpecRecno { get; set; }

    public bool? UrtIptal { get; set; }

    public short? UrtFileid { get; set; }

    public bool? UrtHidden { get; set; }

    public bool? UrtKilitli { get; set; }

    public bool? UrtDegisti { get; set; }

    public int? UrtCheckSum { get; set; }

    public short? UrtCreateUser { get; set; }

    public DateTime UrtCreateDate { get; set; }

    public short? UrtLastupUser { get; set; }

    public DateTime? UrtLastupDate { get; set; }

    public string? UrtSpecial1 { get; set; }

    public string? UrtSpecial2 { get; set; }

    public string? UrtSpecial3 { get; set; }

    public string? UrtRotaUrunKodu { get; set; }

    public byte? UrtCinsi { get; set; }

    public int? UrtSatirNo { get; set; }

    public short? UrtId { get; set; }

    public short? UrtBagliRotaId { get; set; }

    public string? UrtOpKod { get; set; }

    public byte? UrtRotaIsMerkeziveSureTespitTipi { get; set; }

    public byte? UrtIsmerkeziTipi { get; set; }

    public string? UrtIsmerkeziveyaGrupKod { get; set; }

    public int? UrtSabitHazirlikSuresi { get; set; }

    public int? UrtDegiskenOperasyonSuresi { get; set; }

    public double? UrtUretimMiktari { get; set; }

    public int? UrtSabitOperasyonSuresi { get; set; }

    public double? UrtCikisPartiMiktari { get; set; }

    public double? UrtOperasyonSureCarpani { get; set; }

    public byte? UrtOperasyonTekrarSayisi { get; set; }

    public double? UrtEnerji1Miktari { get; set; }

    public double? UrtEnerji2Miktari { get; set; }

    public string? UrtAciklama { get; set; }

    public short? UrtCalisanSayisi { get; set; }

    public string? UrtKalipKodu { get; set; }

    public double? UrtHazirlikElemanIhtiyaci { get; set; }

    public double? UrtOperasyonElemanIhtiyaci { get; set; }
}
