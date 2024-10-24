using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapHareketleriEk
{
    public Guid ChaekGuid { get; set; }

    public short ChaekDbcno { get; set; }

    public int? ChaekSpecRecNo { get; set; }

    public bool? ChaekIptal { get; set; }

    public short? ChaekFileid { get; set; }

    public bool? ChaekHidden { get; set; }

    public bool? ChaekKilitli { get; set; }

    public bool? ChaekDegisti { get; set; }

    public int? ChaekCheckSum { get; set; }

    public short? ChaekCreateUser { get; set; }

    public DateTime ChaekCreateDate { get; set; }

    public short? ChaekLastupUser { get; set; }

    public DateTime? ChaekLastupDate { get; set; }

    public string? ChaekSpecial1 { get; set; }

    public string? ChaekSpecial2 { get; set; }

    public string? ChaekSpecial3 { get; set; }

    public Guid? ChaekRelatedUid { get; set; }

    public double? ChaMustahsilBorsa { get; set; }

    public double? ChaMustahsilBagkur { get; set; }

    public double? ChaMustahsilDiger { get; set; }

    public double? ChaHalMsdf { get; set; }

    public double? ChaHalHamaliye { get; set; }

    public double? ChaHalStopaj { get; set; }

    public double? ChaHalKomisyonu { get; set; }

    public double? ChaHalRusum { get; set; }

    public double? ChaHalNavlunTut { get; set; }

    public double? ChaHalRehinFuture { get; set; }

    public double? ChaHalKomisyon { get; set; }

    public double? ChaHalRehinSandikmiktari { get; set; }

    public double? ChaHalSandikVrMiktar { get; set; }

    public double? ChaHalSandikTutari { get; set; }

    public double? ChaHalSandikKdvtutari { get; set; }

    public double? ChaHalrehinSandikTutari { get; set; }

    public double? ChaHalHamaliyeKdv { get; set; }

    public bool? ChaHalHamaliyeVergisizFl { get; set; }

    public double? ChaHalRusumKdv { get; set; }

    public double? ChaHalDiger { get; set; }

    public double? ChaHalDigerKdv { get; set; }

    public bool? ChaHalDigerVergisizFl { get; set; }

    public bool? ChaHalrusumVergisizFl { get; set; }

    public bool? ChaHalrusumsuzFl { get; set; }

    public Guid? ChaSozlesmeUid { get; set; }

    public Guid? ChaCiroprimUid { get; set; }

    public Guid? ChaBakimharUid { get; set; }

    public Guid? ChaAvanstalepUid { get; set; }

    public Guid? ChaGidkatsozUid { get; set; }

    public byte? ChaTevkifatTuru { get; set; }

    public double? ChaTevkifat1Yok { get; set; }

    public double? ChaTevkifat131 { get; set; }

    public double? ChaTevkifat191 { get; set; }

    public double? ChaTevkifat121 { get; set; }

    public double? ChaTevkifat132 { get; set; }

    public double? ChaTevkifat161 { get; set; }

    public double? ChaTevkifat145 { get; set; }

    public double? ChaTevkifat1Tam { get; set; }

    public double? ChaTevkifat1102 { get; set; }

    public double? ChaTevkifat1105 { get; set; }

    public double? ChaTevkifat1107 { get; set; }

    public double? ChaTevkifat2Yok { get; set; }

    public double? ChaTevkifat231 { get; set; }

    public double? ChaTevkifat291 { get; set; }

    public double? ChaTevkifat221 { get; set; }

    public double? ChaTevkifat232 { get; set; }

    public double? ChaTevkifat261 { get; set; }

    public double? ChaTevkifat245 { get; set; }

    public double? ChaTevkifat2Tam { get; set; }

    public double? ChaTevkifat2102 { get; set; }

    public double? ChaTevkifat2105 { get; set; }

    public double? ChaTevkifat2107 { get; set; }

    public double? ChaTevkifat3Yok { get; set; }

    public double? ChaTevkifat331 { get; set; }

    public double? ChaTevkifat391 { get; set; }

    public double? ChaTevkifat321 { get; set; }

    public double? ChaTevkifat332 { get; set; }

    public double? ChaTevkifat361 { get; set; }

    public double? ChaTevkifat345 { get; set; }

    public double? ChaTevkifat3Tam { get; set; }

    public double? ChaTevkifat3102 { get; set; }

    public double? ChaTevkifat3105 { get; set; }

    public double? ChaTevkifat3107 { get; set; }

    public double? ChaTevkifat4Yok { get; set; }

    public double? ChaTevkifat431 { get; set; }

    public double? ChaTevkifat491 { get; set; }

    public double? ChaTevkifat421 { get; set; }

    public double? ChaTevkifat432 { get; set; }

    public double? ChaTevkifat461 { get; set; }

    public double? ChaTevkifat445 { get; set; }

    public double? ChaTevkifat4Tam { get; set; }

    public double? ChaTevkifat4102 { get; set; }

    public double? ChaTevkifat4105 { get; set; }

    public double? ChaTevkifat4107 { get; set; }

    public double? ChaTevkifat5Yok { get; set; }

    public double? ChaTevkifat531 { get; set; }

    public double? ChaTevkifat591 { get; set; }

    public double? ChaTevkifat521 { get; set; }

    public double? ChaTevkifat532 { get; set; }

    public double? ChaTevkifat561 { get; set; }

    public double? ChaTevkifat545 { get; set; }

    public double? ChaTevkifat5Tam { get; set; }

    public double? ChaTevkifat5102 { get; set; }

    public double? ChaTevkifat5105 { get; set; }

    public double? ChaTevkifat5107 { get; set; }

    public double? ChaTevkifat6Yok { get; set; }

    public double? ChaTevkifat631 { get; set; }

    public double? ChaTevkifat691 { get; set; }

    public double? ChaTevkifat621 { get; set; }

    public double? ChaTevkifat632 { get; set; }

    public double? ChaTevkifat661 { get; set; }

    public double? ChaTevkifat645 { get; set; }

    public double? ChaTevkifat6Tam { get; set; }

    public double? ChaTevkifat6102 { get; set; }

    public double? ChaTevkifat6105 { get; set; }

    public double? ChaTevkifat6107 { get; set; }

    public double? ChaTevkifat7Yok { get; set; }

    public double? ChaTevkifat731 { get; set; }

    public double? ChaTevkifat791 { get; set; }

    public double? ChaTevkifat721 { get; set; }

    public double? ChaTevkifat732 { get; set; }

    public double? ChaTevkifat761 { get; set; }

    public double? ChaTevkifat745 { get; set; }

    public double? ChaTevkifat7Tam { get; set; }

    public double? ChaTevkifat7102 { get; set; }

    public double? ChaTevkifat7105 { get; set; }

    public double? ChaTevkifat7107 { get; set; }

    public double? ChaTevkifat8Yok { get; set; }

    public double? ChaTevkifat831 { get; set; }

    public double? ChaTevkifat891 { get; set; }

    public double? ChaTevkifat821 { get; set; }

    public double? ChaTevkifat832 { get; set; }

    public double? ChaTevkifat861 { get; set; }

    public double? ChaTevkifat845 { get; set; }

    public double? ChaTevkifat8Tam { get; set; }

    public double? ChaTevkifat8102 { get; set; }

    public double? ChaTevkifat8105 { get; set; }

    public double? ChaTevkifat8107 { get; set; }

    public double? ChaTevkifat9Yok { get; set; }

    public double? ChaTevkifat931 { get; set; }

    public double? ChaTevkifat991 { get; set; }

    public double? ChaTevkifat921 { get; set; }

    public double? ChaTevkifat932 { get; set; }

    public double? ChaTevkifat961 { get; set; }

    public double? ChaTevkifat945 { get; set; }

    public double? ChaTevkifat9Tam { get; set; }

    public double? ChaTevkifat9102 { get; set; }

    public double? ChaTevkifat9105 { get; set; }

    public double? ChaTevkifat9107 { get; set; }

    public double? ChaTevkifat10Yok { get; set; }

    public double? ChaTevkifat1031 { get; set; }

    public double? ChaTevkifat1091 { get; set; }

    public double? ChaTevkifat1021 { get; set; }

    public double? ChaTevkifat1032 { get; set; }

    public double? ChaTevkifat1061 { get; set; }

    public double? ChaTevkifat1045 { get; set; }

    public double? ChaTevkifat10Tam { get; set; }

    public double? ChaTevkifat10102 { get; set; }

    public double? ChaTevkifat10105 { get; set; }

    public double? ChaTevkifat10107 { get; set; }

    public string? ChaIstisna1 { get; set; }

    public string? ChaIstisna2 { get; set; }

    public string? ChaIstisna3 { get; set; }

    public string? ChaIstisna4 { get; set; }

    public string? ChaIstisna5 { get; set; }

    public string? ChaIstisna6 { get; set; }

    public string? ChaIstisna7 { get; set; }

    public string? ChaIstisna8 { get; set; }

    public string? ChaIstisna9 { get; set; }

    public string? ChaIstisna10 { get; set; }

    public byte? ChaOtvTevkifatTuru { get; set; }

    public double? ChaOtvTevkifatTam { get; set; }

    public Guid? ChaServisharUid { get; set; }

    public string? ChaOzelMatrahKodu { get; set; }

    public Guid? ChaPeriyodikUid { get; set; }

    public int? ChaPeriyodikDonemNo { get; set; }

    public short? ChaVergifonid1 { get; set; }

    public double? ChaVergifontutari1 { get; set; }

    public short? ChaVergifonid2 { get; set; }

    public double? ChaVergifontutari2 { get; set; }

    public short? ChaVergifonid3 { get; set; }

    public double? ChaVergifontutari3 { get; set; }

    public short? ChaVergifonid4 { get; set; }

    public double? ChaVergifontutari4 { get; set; }

    public short? ChaVergifonid5 { get; set; }

    public double? ChaVergifontutari5 { get; set; }

    public string? ChaYolcuberaberKodu { get; set; }

    public string? ChaYetkiliaracikurumkodu { get; set; }

    public Guid? ChaIcraodemeUid { get; set; }

    public string? ChaEarsivUnvaniAd { get; set; }

    public string? ChaEarsivUnvaniSoyad { get; set; }

    public string? ChaEarsivDaireAdi { get; set; }

    public string? ChaEarsivVkn { get; set; }

    public string? ChaEarsivUlke { get; set; }

    public string? ChaEarsivIl { get; set; }

    public string? ChaEarsivTelUlkeKod { get; set; }

    public string? ChaEarsivTelBolgeKod { get; set; }

    public string? ChaEarsivTelNo { get; set; }

    public string? ChaEarsivMail { get; set; }

    public string? ChaEarsivCadde { get; set; }

    public string? ChaEarsivSokak { get; set; }

    public string? ChaEarsivIlce { get; set; }

    public string? ChaEarsivCeptel { get; set; }

    public string? ChaEarsivPostaKodu { get; set; }

    public double? ChaKkegmatrahi { get; set; }

    public double? ChaKkegvergi { get; set; }

    public double? ChaOtvVergi1 { get; set; }

    public double? ChaOtvVergi2 { get; set; }

    public double? ChaOtvVergi3 { get; set; }

    public double? ChaOtvVergi4 { get; set; }

    public double? ChaOtvVergi5 { get; set; }

    public double? ChaOtvVergi6 { get; set; }

    public double? ChaOtvVergi7 { get; set; }

    public double? ChaOtvVergi8 { get; set; }

    public double? ChaOtvVergi9 { get; set; }

    public double? ChaOtvVergi10 { get; set; }

    public byte? ChaTevkifatIslemTuruIdx { get; set; }
}
