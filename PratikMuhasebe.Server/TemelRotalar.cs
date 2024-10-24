using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TemelRotalar
{
    public Guid RtGuid { get; set; }

    public short RtDbcno { get; set; }

    public int? RtSpecRecno { get; set; }

    public bool? RtIptal { get; set; }

    public short? RtFileid { get; set; }

    public bool? RtHidden { get; set; }

    public bool? RtKilitli { get; set; }

    public bool? RtDegisti { get; set; }

    public int? RtCheckSum { get; set; }

    public short? RtCreateUser { get; set; }

    public DateTime RtCreateDate { get; set; }

    public short? RtLastupUser { get; set; }

    public DateTime? RtLastupDate { get; set; }

    public string? RtSpecial1 { get; set; }

    public string? RtSpecial2 { get; set; }

    public string? RtSpecial3 { get; set; }

    public string? RtRotaUrunKodu { get; set; }

    public string? RtUstAciklama { get; set; }

    public int? RtSatirNo { get; set; }

    public short? RtId { get; set; }

    public short? RtBagliRotaId { get; set; }

    public string? RtOpKod { get; set; }

    public byte? RtRotaIsMerkeziveSureTespitTipi { get; set; }

    public byte? RtIsmerkeziTipi { get; set; }

    public string? RtIsmerkeziveyaGrupKod { get; set; }

    public int? RtSabitHazirlikSuresi { get; set; }

    public int? RtDegiskenOperasyonSuresi { get; set; }

    public double? RtUretimMiktari { get; set; }

    public int? RtSabitOperasyonSuresi { get; set; }

    public double? RtCikisPartiMiktari { get; set; }

    public double? RtOperasyonSureCarpani { get; set; }

    public byte? RtOperasyonTekrarSayisi { get; set; }

    public double? RtEnerji1Miktari { get; set; }

    public double? RtEnerji2Miktari { get; set; }

    public string? RtAciklama { get; set; }

    public short? RtCalisanSayisi { get; set; }

    public string? RtKalipKodu { get; set; }

    public double? RtHazirlikElemanIhtiyaci { get; set; }

    public double? RtOperasyonElemanIhtiyaci { get; set; }
}
