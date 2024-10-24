using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimRotaPlanlari
{
    public Guid RtPGuid { get; set; }

    public short RtPDbcno { get; set; }

    public int? RtPSpecRecno { get; set; }

    public bool? RtPIptal { get; set; }

    public short? RtPFileid { get; set; }

    public bool? RtPHidden { get; set; }

    public bool? RtPKilitli { get; set; }

    public bool? RtPDegisti { get; set; }

    public int? RtPCheckSum { get; set; }

    public short? RtPCreateUser { get; set; }

    public DateTime RtPCreateDate { get; set; }

    public short? RtPLastupUser { get; set; }

    public DateTime? RtPLastupDate { get; set; }

    public string? RtPSpecial1 { get; set; }

    public string? RtPSpecial2 { get; set; }

    public string? RtPSpecial3 { get; set; }

    public string? RtPIsEmriKodu { get; set; }

    public int? RtPSatirNo { get; set; }

    public string? RtPUrunKodu { get; set; }

    public short? RtPOperasyonSafhaNo { get; set; }

    public string? RtPOperasyonKodu { get; set; }

    public int? RtPPlanlananSure { get; set; }

    public int? RtPTamamlananSure { get; set; }

    public double? RtPPlanlananMiktar { get; set; }

    public double? RtPTamamlananMiktar { get; set; }

    public DateTime? RtpPlanlananBaslamaTarihi { get; set; }

    public string? RtPPlanlananIsMerkezi { get; set; }

    public int? RtPOperasyonDetayPtr { get; set; }

    public double? RtPBozukMiktar { get; set; }

    public short? RtPSonrakiSafhaNo { get; set; }

    public int? RtPPlanlananSetupSuresi { get; set; }

    public int? RtPTamamlananSetupSuresi { get; set; }

    public bool? RtPKapandiFl { get; set; }

    public string? RtPAciklama { get; set; }

    public double? RtPPlanlananEnerji1 { get; set; }

    public double? RtPTuketilenEnerji1 { get; set; }

    public double? RtPPlanlananEnerji2 { get; set; }

    public double? RtPTuketilenEnerji2 { get; set; }

    public double? RtpCikisPartiMiktari { get; set; }

    public short? RtpCalisanSayisi { get; set; }

    public string? RtpPlanlananKalipKodu { get; set; }

    public double? RtpPlanlananHazirlikElemanIhtiyaci { get; set; }

    public double? RtpPlanlananOperasyonElemanIhtiyaci { get; set; }

    public bool? RtpKilitliFl { get; set; }

    public bool? RtpIsZamaniBelirliFl { get; set; }

    public bool? RtPBasladiFl { get; set; }

    public bool? RtPSetupBittiFl { get; set; }

    public bool? RtPBittiFl { get; set; }

    public DateTime? RtpPlanlananBitisTarihi { get; set; }
}
