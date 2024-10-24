using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Bankalar
{
    public Guid BanGuid { get; set; }

    public short BanDbcno { get; set; }

    public int? BanSpecRecno { get; set; }

    public bool? BanIptal { get; set; }

    public short? BanFileid { get; set; }

    public bool? BanHidden { get; set; }

    public bool? BanKilitli { get; set; }

    public bool? BanDegisti { get; set; }

    public int? BanCheckSum { get; set; }

    public short? BanCreateUser { get; set; }

    public DateTime BanCreateDate { get; set; }

    public short? BanLastupUser { get; set; }

    public DateTime? BanLastupDate { get; set; }

    public string? BanSpecial1 { get; set; }

    public string? BanSpecial2 { get; set; }

    public string? BanSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }          
    public int BanVersionNo { get; set; }               
    public int BanMenuNo { get; set; }                 
    public string? BanMikroSpecial1 { get; set; }        
    public string? BanMikroSpecial2 { get; set; }        
    public string? BanMikroSpecial3 { get; set; }       
    public string? BanExternalProgramType { get; set; }  
    public int BanExternalProgramId { get; set; }       
    public string? BanHash { get; set; }

    public string? BanKod { get; set; }

    public string? BanIsmi { get; set; }

    public string? BanSube { get; set; }

    public string? BanSwiftKodu { get; set; }

    public string? BanIbankodu { get; set; }

    public string? BanHesapno { get; set; }

    public int? BanFirmaNo { get; set; }

    public byte? BanHesapTip { get; set; }

    public byte? BanMevduatTip { get; set; }

    public byte? BanKrediTip { get; set; }

    public string? BanMuhKod { get; set; }

    public string? BanVerCekMuhKod { get; set; }

    public string? BanTahCekMuhKod { get; set; }

    public string? BanTahSenMuhKod { get; set; }

    public string? BanTemCekMuhKod { get; set; }

    public string? BanTemSenMuhKod { get; set; }

    public string? BanMusKrdrkartMuhKod { get; set; }

    public string? BanFrmKrdrkartMuhKod { get; set; }

    public string? BanMustHavaleSozuMuhKodu { get; set; }

    public string? BanFirmaHavaleEmriMuhKodu { get; set; }

    public string? BanTemMuhKod { get; set; }

    public byte? BanDovizCinsi { get; set; }

    public double? BanVadeFarkYuzde { get; set; }

    public double? BanKrediTavan { get; set; }

    public double? BanRiskTavan { get; set; }

    public bool? BanNakakincelenmesi { get; set; }

    public string? BanTcmbKodu { get; set; }

    public string? BanTcmbSubeKodu { get; set; }

    public string? BanTcmbIlKodu { get; set; }

    public string? BanMusteriNo { get; set; }

    public byte? BanAyniBankaTahsilSuresi { get; set; }

    public byte? BanBaskaBankaTahsilSuresi { get; set; }

    public byte? BanOdulKatkisiHesapCinsi { get; set; }

    public string? BanOdulKatkisiHesabi { get; set; }

    public byte? BanServisKomisyonHesapCinsi { get; set; }

    public string? BanServisKomisyonHesabi { get; set; }

    public byte? BanErkenOdmFaizHesapCinsi { get; set; }

    public string? BanErkenOdmFaizHesabi { get; set; }

    public string? BanPosTahsilatCariHesabi { get; set; }

    public string? BanAdrCadde { get; set; }

    public string? BanAdrMahalle { get; set; }

    public string? BanAdrSokak { get; set; }

    public string? BanAdrSemt { get; set; }

    public string? BanAdrAptNo { get; set; }

    public string? BanAdrDaireNo { get; set; }

    public string? BanAdrPostaKodu { get; set; }

    public string? BanAdrIlce { get; set; }

    public string? BanAdrIl { get; set; }

    public string? BanAdrUlke { get; set; }

    public string? BanAdrAdresKodu { get; set; }

    public string? BanTelUlkeKodu { get; set; }

    public string? BanTelBolgeKodu { get; set; }

    public string? BanTelNo1 { get; set; }

    public string? BanTelNo2 { get; set; }

    public string? BanTelFaxno { get; set; }

    public string? BanTelModem { get; set; }

    public string? BanTemsilci { get; set; }

    public string? BanTemsilciEmail { get; set; }

    public string? BanUfrsMuhKod { get; set; }

    public string? BanUfrsVerCekMuhKod { get; set; }

    public string? BanUfrsTahCekMuhKod { get; set; }

    public string? BanUfrsTahSenMuhKod { get; set; }

    public string? BanUfrsTemCekMuhKod { get; set; }

    public string? BanUfrsTemSenMuhKod { get; set; }

    public string? BanUfrsMusKrdrkartMuhKod { get; set; }

    public string? BanUfrsFrmKrdrkartMuhKod { get; set; }

    public string? BanUfrsMustHavaleSozuMuhKodu { get; set; }

    public string? BanUfrsFirmaHavaleEmriMuhKodu { get; set; }

    public string? BanUfrsVerCekSinifMuhKod { get; set; }

    public string? BanUfrsFrmHavEmriSinifMuhKodu { get; set; }

    public string? BanUfrsTemMuhKod { get; set; }

    public byte? BanOnlineEntegrasyonDurumu { get; set; }

    public long? BanOnlineEntegrasyonId { get; set; }

    public DateTime? BanOnlineSonGuncelleme { get; set; }
}
