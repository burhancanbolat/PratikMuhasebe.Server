using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesaplar
{
    public Guid CariGuid { get; set; }

    public short CariDbcno { get; set; }

    public int? CariSpecRecno { get; set; }

    public bool? CariIptal { get; set; }

    public short? CariFileid { get; set; }

    public bool? CariHidden { get; set; }

    public bool? CariKilitli { get; set; }

    public bool? CariDegisti { get; set; }

    public int? CariChecksum { get; set; }

    public short? CariCreateUser { get; set; }

    public DateTime CariCreateDate { get; set; }

    public short? CariLastupUser { get; set; }

    public DateTime? CariLastupDate { get; set; }

    public string? CariSpecial1 { get; set; }

    public string? CariSpecial2 { get; set; }

    public string? CariSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public string? CariKod { get; set; }

    public string? CariUnvan1 { get; set; }

    public string? CariUnvan2 { get; set; }

    public byte? CariHareketTipi { get; set; }

    public byte? CariBaglantiTipi { get; set; }

    public byte? CariStokAlimCinsi { get; set; }

    public byte? CariStokSatimCinsi { get; set; }

    public string? CariMuhKod { get; set; }

    public string? CariMuhKod1 { get; set; }

    public string? CariMuhKod2 { get; set; }

    public byte? CariDovizCinsi { get; set; }

    public byte? CariDovizCinsi1 { get; set; }

    public byte? CariDovizCinsi2 { get; set; }

    public double? CariVadeFarkYuz { get; set; }

    public double? CariVadeFarkYuz1 { get; set; }

    public double? CariVadeFarkYuz2 { get; set; }

    public byte? CariKurHesapSekli { get; set; }

    public string? CariVdaireAdi { get; set; }

    public string? CariVdaireNo { get; set; }

    public string? CariSicilNo { get; set; }

    public string? CariVergiKimlikNo { get; set; }

    public int? CariSatisFk { get; set; }

    public byte? CariOdemeCinsi { get; set; }

    public byte? CariOdemeGunu { get; set; }

    public int? CariOdemeplanNo { get; set; }

    public int? CariOpsiyonGun { get; set; }

    public byte? CariCariodemetercihi { get; set; }

    public int? CariFaturaAdresNo { get; set; }

    public int? CariSevkAdresNo { get; set; }

    public string? CariBankaTcmbKod1 { get; set; }

    public string? CariBankaTcmbSubekod1 { get; set; }

    public string? CariBankaTcmbIlkod1 { get; set; }

    public string? CariBankaHesapno1 { get; set; }

    public string? CariBankaSwiftkodu1 { get; set; }

    public string? CariBankaTcmbKod2 { get; set; }

    public string? CariBankaTcmbSubekod2 { get; set; }

    public string? CariBankaTcmbIlkod2 { get; set; }

    public string? CariBankaHesapno2 { get; set; }

    public string? CariBankaSwiftkodu2 { get; set; }

    public string? CariBankaTcmbKod3 { get; set; }

    public string? CariBankaTcmbSubekod3 { get; set; }

    public string? CariBankaTcmbIlkod3 { get; set; }

    public string? CariBankaHesapno3 { get; set; }

    public string? CariBankaSwiftkodu3 { get; set; }

    public string? CariBankaTcmbKod4 { get; set; }

    public string? CariBankaTcmbSubekod4 { get; set; }

    public string? CariBankaTcmbIlkod4 { get; set; }

    public string? CariBankaHesapno4 { get; set; }

    public string? CariBankaSwiftkodu4 { get; set; }

    public string? CariBankaTcmbKod5 { get; set; }

    public string? CariBankaTcmbSubekod5 { get; set; }

    public string? CariBankaTcmbIlkod5 { get; set; }

    public string? CariBankaHesapno5 { get; set; }

    public string? CariBankaSwiftkodu5 { get; set; }

    public string? CariBankaTcmbKod6 { get; set; }

    public string? CariBankaTcmbSubekod6 { get; set; }

    public string? CariBankaTcmbIlkod6 { get; set; }

    public string? CariBankaHesapno6 { get; set; }

    public string? CariBankaSwiftkodu6 { get; set; }

    public string? CariBankaTcmbKod7 { get; set; }

    public string? CariBankaTcmbSubekod7 { get; set; }

    public string? CariBankaTcmbIlkod7 { get; set; }

    public string? CariBankaHesapno7 { get; set; }

    public string? CariBankaSwiftkodu7 { get; set; }

    public string? CariBankaTcmbKod8 { get; set; }

    public string? CariBankaTcmbSubekod8 { get; set; }

    public string? CariBankaTcmbIlkod8 { get; set; }

    public string? CariBankaHesapno8 { get; set; }

    public string? CariBankaSwiftkodu8 { get; set; }

    public string? CariBankaTcmbKod9 { get; set; }

    public string? CariBankaTcmbSubekod9 { get; set; }

    public string? CariBankaTcmbIlkod9 { get; set; }

    public string? CariBankaHesapno9 { get; set; }

    public string? CariBankaSwiftkodu9 { get; set; }

    public string? CariBankaTcmbKod10 { get; set; }

    public string? CariBankaTcmbSubekod10 { get; set; }

    public string? CariBankaTcmbIlkod10 { get; set; }

    public string? CariBankaHesapno10 { get; set; }

    public string? CariBankaSwiftkodu10 { get; set; }

    public byte? CariEftHesapNum { get; set; }

    public string? CariAnaCariKodu { get; set; }

    public string? CariSatisIskKod { get; set; }

    public string? CariSektorKodu { get; set; }

    public string? CariBolgeKodu { get; set; }

    public string? CariGrupKodu { get; set; }

    public string? CariTemsilciKodu { get; set; }

    public string? CariMuhartikeli { get; set; }

    public bool? CariFirmaAcikKapal { get; set; }

    public bool? CariBuvTabiFl { get; set; }

    public bool? CariCariKilitliFlg { get; set; }

    public bool? CariEtiketBasFl { get; set; }

    public bool? CariDetayInceleFlg { get; set; }

    public bool? CariEfaturaFl { get; set; }

    public double? CariPosOngpesyuzde { get; set; }

    public double? CariPosOngtaksayi { get; set; }

    public double? CariPosOngIskOran { get; set; }

    public DateTime? CariKaydagiristarihi { get; set; }

    public double? CariKabEdFcekTutar { get; set; }

    public byte? CariHalCaritip { get; set; }

    public double? CariHalKomYuzdesi { get; set; }

    public short? CariTeslimSuresi { get; set; }

    public string? CariWwwadresi { get; set; }

    public string? CariEmail { get; set; }

    public string? CariCepTel { get; set; }

    public int? CariVarsayilanGirisDepo { get; set; }

    public int? CariVarsayilanCikisDepo { get; set; }

    public bool? CariPortalEnabled { get; set; }

    public string? CariPortalPw { get; set; }

    public int? CariBagliOrtaklisaFirma { get; set; }

    public string? CariKampanyakodu { get; set; }

    public bool? CariBBakiyeDegerlendirilmesinFl { get; set; }

    public bool? CariABakiyeDegerlendirilmesinFl { get; set; }

    public bool? CariBIrsbakiyeDegerlendirilmesinFl { get; set; }

    public bool? CariAIrsbakiyeDegerlendirilmesinFl { get; set; }

    public bool? CariBSipbakiyeDegerlendirilmesinFl { get; set; }

    public bool? CariASipbakiyeDegerlendirilmesinFl { get; set; }

    public bool? CariKrediRiskTakibiVarFlg { get; set; }

    public string? CariUfrsFarkMuhKod { get; set; }

    public string? CariUfrsFarkMuhKod1 { get; set; }

    public string? CariUfrsFarkMuhKod2 { get; set; }

    public byte? CariOdemeSekli { get; set; }

    public string? CariTeminatMekAlacakMuhKodu { get; set; }

    public string? CariTeminatMekAlacakMuhKodu1 { get; set; }

    public string? CariTeminatMekAlacakMuhKodu2 { get; set; }

    public string? CariTeminatMekBorcMuhKodu { get; set; }

    public string? CariTeminatMekBorcMuhKodu1 { get; set; }

    public string? CariTeminatMekBorcMuhKodu2 { get; set; }

    public string? CariVerilenDepozitoTeminatMuhKodu { get; set; }

    public string? CariVerilenDepozitoTeminatMuhKodu1 { get; set; }

    public string? CariVerilenDepozitoTeminatMuhKodu2 { get; set; }

    public string? CariAlinanDepozitoTeminatMuhKodu { get; set; }

    public string? CariAlinanDepozitoTeminatMuhKodu1 { get; set; }

    public string? CariAlinanDepozitoTeminatMuhKodu2 { get; set; }

    public byte? CariDefEfaturaCinsi { get; set; }

    public bool? CariOtvTevkifatinaTabiiFl { get; set; }

    public string? CariKepAdresi { get; set; }

    public DateTime? CariEfaturaBaslangicTarihi { get; set; }

    public string? CariMutabakatMailAdresi { get; set; }

    public string? CariMersisNo { get; set; }

    public string? CariIstasyonCariKodu { get; set; }

    public bool? CariGonderionayiSms { get; set; }

    public bool? CariGonderionayiEmail { get; set; }

    public bool? CariEirsaliyeFl { get; set; }

    public DateTime? CariEirsaliyeBaslangicTarihi { get; set; }

    public string? CariVergidairekodu { get; set; }

    public bool? CariCrmSistemineAktarFl { get; set; }

    public string? CariEfaturaXsltDosya { get; set; }

    public string? CariPasaportNo { get; set; }

    public byte? CariKisiKimlikBilgisiAciklamaTuru { get; set; }

    public string? CariKisiKimlikBilgisiDigerAciklama { get; set; }

    public string? CariUtsKurumNo { get; set; }

    public bool? CariKamuKurumuFl { get; set; }

    public string? CariEarsivXsltDosya { get; set; }

    public bool? CariPerakendeFl { get; set; }

    public bool? CariYeniDoganMi { get; set; }

    public string? CariEirsaliyeXsltDosya { get; set; }

    public byte? CariDefEirsaliyeCinsi { get; set; }

    public string? CariOzelButceliKurumCarisi { get; set; }

    public bool? CariNakakincelenmesi { get; set; }

    public bool? CariVergimukellefidegilMi { get; set; }

    public string? CariTasiyicifirmaCariKodu { get; set; }

    public string? CariNacekodu1 { get; set; }

    public string? CariNacekodu2 { get; set; }

    public string? CariNacekodu3 { get; set; }

    public byte? CariSirketTuru { get; set; }

    public string? CariBabaAdi { get; set; }

    public byte? CariFaalTerk { get; set; }
}
