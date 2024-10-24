using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ProformaSiparisler
{
    public Guid ProGuid { get; set; }

    public short ProDbcno { get; set; }

    public int? ProSpecRecNo { get; set; }

    public bool? ProIptal { get; set; }

    public short? ProFileid { get; set; }

    public bool? ProHidden { get; set; }

    public bool? ProKilitli { get; set; }

    public bool? ProDegisti { get; set; }

    public int? ProChecksum { get; set; }

    public short? ProCreateUser { get; set; }

    public DateTime ProCreateDate { get; set; }

    public short? ProLastupUser { get; set; }

    public DateTime? ProLastupDate { get; set; }

    public string? ProSpecial1 { get; set; }

    public string? ProSpecial2 { get; set; }

    public string? ProSpecial3 { get; set; }

    public int? ProFirmano { get; set; }

    public int? ProSubeno { get; set; }

    public DateTime? ProTarihi { get; set; }

    public DateTime? ProTestarihi { get; set; }

    public byte? ProTipi { get; set; }

    public byte? ProCinsi { get; set; }

    public string? ProEvraknoSeri { get; set; }

    public int? ProEvraknoSira { get; set; }

    public int? ProSatirno { get; set; }

    public string? ProBelgeNo { get; set; }

    public DateTime? ProBelgeTarihi { get; set; }

    public string? ProSaticikodu { get; set; }

    public string? ProMustkodu { get; set; }

    public string? ProStokkodu { get; set; }

    public double? ProBfiyati { get; set; }

    public double? ProMiktar { get; set; }

    public byte? ProBirimPntr { get; set; }

    public double? ProTesmiktari { get; set; }

    public double? ProTutari { get; set; }

    public double? ProIskonto1 { get; set; }

    public double? ProIskonto2 { get; set; }

    public double? ProIskonto3 { get; set; }

    public double? ProIskonto4 { get; set; }

    public double? ProIskonto5 { get; set; }

    public double? ProIskonto6 { get; set; }

    public double? ProMasraf1 { get; set; }

    public double? ProMasraf2 { get; set; }

    public double? ProMasraf3 { get; set; }

    public double? ProMasraf4 { get; set; }

    public byte? ProVergipntr { get; set; }

    public double? ProVergi { get; set; }

    public byte? ProMasrafvergipntr { get; set; }

    public double? ProMasrafvergi { get; set; }

    public int? ProOpno { get; set; }

    public string? ProAciklama { get; set; }

    public string? ProAciklama2 { get; set; }

    public int? ProDepono { get; set; }

    public short? ProOnaylayanKulNo { get; set; }

    public bool? ProVergisiz { get; set; }

    public bool? ProKapat { get; set; }

    public bool? ProPromosyonFl { get; set; }

    public string? ProCariSormerk { get; set; }

    public string? ProStokSormerk { get; set; }

    public byte? ProCariGrupno { get; set; }

    public byte? ProDovizcinsi { get; set; }

    public double? ProDovizkuru { get; set; }

    public double? ProAltdovizkuru { get; set; }

    public int? ProAdresno { get; set; }

    public string? ProTeslimturu { get; set; }

    public bool? ProCagrilabilirFl { get; set; }

    public Guid? ProSipUid { get; set; }

    public byte? ProIskMas1 { get; set; }

    public byte? ProIskMas2 { get; set; }

    public byte? ProIskMas3 { get; set; }

    public byte? ProIskMas4 { get; set; }

    public byte? ProIskMas5 { get; set; }

    public byte? ProIskMas6 { get; set; }

    public byte? ProIskMas7 { get; set; }

    public byte? ProIskMas8 { get; set; }

    public byte? ProIskMas9 { get; set; }

    public byte? ProIskMas10 { get; set; }

    public bool? ProSatIskMas1 { get; set; }

    public bool? ProSatIskMas2 { get; set; }

    public bool? ProSatIskMas3 { get; set; }

    public bool? ProSatIskMas4 { get; set; }

    public bool? ProSatIskMas5 { get; set; }

    public bool? ProSatIskMas6 { get; set; }

    public bool? ProSatIskMas7 { get; set; }

    public bool? ProSatIskMas8 { get; set; }

    public bool? ProSatIskMas9 { get; set; }

    public bool? ProSatIskMas10 { get; set; }

    public string? ProExpImpKodu { get; set; }

    public double? ProKaroani { get; set; }

    public byte? ProDurumu { get; set; }

    public Guid? ProStalUid { get; set; }

    public double? ProPlanlananmiktar { get; set; }

    public Guid? ProTeklifUid { get; set; }

    public string? ProPartiKodu { get; set; }

    public int? ProLotNo { get; set; }

    public string? ProProjekodu { get; set; }

    public int? ProFiyatListeNo { get; set; }

    public byte? ProOtvPntr { get; set; }

    public double? ProOtvVergi { get; set; }

    public double? ProOtvtutari { get; set; }

    public byte? ProOtvVergisizFl { get; set; }

    public string? ProPaketKod { get; set; }

    public Guid? ProRezUid { get; set; }

    public byte? ProHarekettipi { get; set; }

    public Guid? ProYetkiliUid { get; set; }

    public string? ProKapatmanedenkod { get; set; }

    public DateTime? ProGecerlilikTarihi { get; set; }

    public byte? ProOnodemeEvrakTip { get; set; }

    public string? ProOnodemeEvrakSeri { get; set; }

    public int? ProOnodemeEvrakSira { get; set; }

    public double? ProRezervasyonMiktari { get; set; }

    public double? ProRezervedenTeslimEdilen { get; set; }

    public string? ProHareketGrupKodu1 { get; set; }

    public string? ProHareketGrupKodu2 { get; set; }

    public string? ProHareketGrupKodu3 { get; set; }

    public double? ProOlcu1 { get; set; }

    public double? ProOlcu2 { get; set; }

    public double? ProOlcu3 { get; set; }

    public double? ProOlcu4 { get; set; }

    public double? ProOlcu5 { get; set; }

    public byte? ProFormulMiktarNo { get; set; }

    public double? ProFormulMiktar { get; set; }

    public byte? ProSatisFiyatDovizCinsi { get; set; }

    public double? ProSatisFiyatDovizKuru { get; set; }

    public string? ProEticaretKanalKodu { get; set; }
}
