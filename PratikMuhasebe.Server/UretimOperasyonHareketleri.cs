using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimOperasyonHareketleri
{
    public Guid OpTGuid { get; set; }

    public short OpTDbcno { get; set; }

    public int? OpTSpecRecno { get; set; }

    public bool? OpTIptal { get; set; }

    public short? OpTFileid { get; set; }

    public bool? OpTHidden { get; set; }

    public bool? OpTKilitli { get; set; }

    public bool? OpTDegisti { get; set; }

    public int? OpTCheckSum { get; set; }

    public short? OpTCreateUser { get; set; }

    public DateTime OpTCreateDate { get; set; }

    public short? OpTLastupUser { get; set; }

    public DateTime? OpTLastupDate { get; set; }

    public string? OpTSpecial1 { get; set; }

    public string? OpTSpecial2 { get; set; }

    public string? OpTSpecial3 { get; set; }

    public int? OpTFirmano { get; set; }

    public int? OpTSubeno { get; set; }

    public string? OpTEvrakNoSeri { get; set; }

    public int? OpTEvrakNoSira { get; set; }

    public int? OpTEvrakSatirNo { get; set; }

    public Guid? OpTRotaPlanUid { get; set; }

    public DateTime? OpTBaslamatarihi { get; set; }

    public DateTime? OpTBitisTarihi { get; set; }

    public string? OpTIsEmriKodu { get; set; }

    public string? OpTUrunKodu { get; set; }

    public short? OpTOperasyonSafhaNo { get; set; }

    public string? OpTOperasyonKodu { get; set; }

    public short? OptSonrakiSafhaNo { get; set; }

    public string? OpTIsmerkezi { get; set; }

    public double? OpTIsmerkeziHizi { get; set; }

    public string? OpTPersonelKodu { get; set; }

    public double? OpTTamamlananMiktar { get; set; }

    public double? OptTamamlananMiktar2 { get; set; }

    public double? OptTamamlananMiktar3 { get; set; }

    public double? OptTamamlananMiktar4 { get; set; }

    public double? OptBozukMiktar { get; set; }

    public double? OptBozukMiktar2 { get; set; }

    public double? OptBozukMiktar3 { get; set; }

    public double? OptBozukMiktar4 { get; set; }

    public int? OptSetupSuresi { get; set; }

    public int? OpTTamamlananSure { get; set; }

    public int? OptGecikmeSuresi { get; set; }

    public double? OptIscilikMaliyetAna { get; set; }

    public double? OptIscilikMaliyetAlt { get; set; }

    public double? OptIscilikMaliyetOrj { get; set; }

    public double? OptGenelUretimMaliyetAna { get; set; }

    public double? OptGenelUretimMaliyetAlt { get; set; }

    public double? OptGenelUretimMaliyetOrj { get; set; }

    public bool? OptKapatFl { get; set; }

    public double? OptCalisanAdam { get; set; }

    public double? OptIslenenAlan { get; set; }

    public double? OptIslenenHacim { get; set; }

    public double? OptIslenenAgirlik { get; set; }

    public double? OptTuketilenEnerji1 { get; set; }

    public double? OptTuketilenEnerji2 { get; set; }

    public string? OptAciklama { get; set; }

    public double? OptUfrsIscilikMaliyetAna { get; set; }

    public double? OptUfrsIscilikMaliyetAlt { get; set; }

    public double? OptUfrsIscilikMaliyetOrj { get; set; }

    public double? OptUfrsGenelUretimMaliyetAna { get; set; }

    public double? OptUfrsGenelUretimMaliyetAlt { get; set; }

    public double? OptUfrsGenelUretimMaliyetOrj { get; set; }

    public string? OptKalipkodu { get; set; }

    public double? OptHazirlikElemanSayisi { get; set; }

    public double? OptOperasyonElemanSayisi { get; set; }

    public string? OptHareketGrupKodu1 { get; set; }

    public string? OptHareketGrupKodu2 { get; set; }

    public string? OptHareketGrupKodu3 { get; set; }
}
