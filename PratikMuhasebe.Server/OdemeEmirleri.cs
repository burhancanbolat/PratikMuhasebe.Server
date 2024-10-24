using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OdemeEmirleri
{
    public Guid SckGuid { get; set; }

    public short SckDbcno { get; set; }

    public int? SckSpecRecno { get; set; }

    public bool? SckIptal { get; set; }

    public short? SckFileid { get; set; }

    public bool? SckHidden { get; set; }

    public bool? SckKilitli { get; set; }

    public bool? SckDegisti { get; set; }

    public int? SckChecksum { get; set; }

    public short? SckCreateUser { get; set; }

    public DateTime SckCreateDate { get; set; }

    public short? SckLastupUser { get; set; }

    public DateTime? SckLastupDate { get; set; }

    public string? SckSpecial1 { get; set; }

    public string? SckSpecial2 { get; set; }

    public string? SckSpecial3 { get; set; }

    public int? SckFirmano { get; set; }

    public int? SckSubeno { get; set; }

    public byte? SckTip { get; set; }

    public string? SckRefno { get; set; }

    public string? SckBankano { get; set; }

    public string? SckBorclu { get; set; }

    public string? SckVdaireNo { get; set; }

    public DateTime? SckVade { get; set; }

    public double? SckTutar { get; set; }

    public byte? SckDoviz { get; set; }

    public double? SckOdenen { get; set; }

    public byte? SckDegerlemeIslendi { get; set; }

    public string? SckBankaAdres1 { get; set; }

    public string? SckSubeAdres2 { get; set; }

    public string? SckBorcluTel { get; set; }

    public string? SckHesapnoSehir { get; set; }

    public string? SckNo { get; set; }

    public DateTime? SckDuzenTarih { get; set; }

    public byte? SckSahipCariCins { get; set; }

    public string? SckSahipCariKodu { get; set; }

    public byte? SckSahipCariGrupno { get; set; }

    public byte? SckNeredeCariCins { get; set; }

    public string? SckNeredeCariKodu { get; set; }

    public byte? SckNeredeCariGrupno { get; set; }

    public DateTime? SckIlkHareketTarihi { get; set; }

    public string? SckIlkEvrakSeri { get; set; }

    public int? SckIlkEvrakSiraNo { get; set; }

    public int? SckIlkEvrakSatirNo { get; set; }

    public DateTime? SckSonHareketTarihi { get; set; }

    public double? SckDovizKur { get; set; }

    public byte? SckSonpoz { get; set; }

    public byte? SckImza { get; set; }

    public string? SckSrmmrk { get; set; }

    public string? SckKesideyeri { get; set; }

    public string? SckTcmbBankaKodu { get; set; }

    public string? SckTcmbSubeKodu { get; set; }

    public string? SckTcmbIlKodu { get; set; }

    public bool? SckTasraFl { get; set; }

    public string? SckProjekodu { get; set; }

    public double? SckMasraf1 { get; set; }

    public byte? SckMasraf1Isleme { get; set; }

    public double? SckMasraf2 { get; set; }

    public byte? SckMasraf2Isleme { get; set; }

    public double? SckOdulKatkisiTutari { get; set; }

    public double? SckServisKomisyonTutari { get; set; }

    public double? SckErkenOdemeFaizTutari { get; set; }

    public bool? SckOdulKatkisiTutariIslendiFl { get; set; }

    public bool? SckServisKomisyonTutariIslendiFl { get; set; }

    public bool? SckErkenOdemeFaizTutariIslendiFl { get; set; }

    public byte? SckKrediKartiTipi { get; set; }

    public short? SckTaksitSayisi { get; set; }

    public short? SckKacinciTaksit { get; set; }

    public string? SckUyeIsyeriNo { get; set; }

    public string? SckKrediKartiNo { get; set; }

    public string? SckProvizyonKodu { get; set; }

    public string? SckDisyazilimid { get; set; }

    public byte? SckDisyazilimtip { get; set; }
}
