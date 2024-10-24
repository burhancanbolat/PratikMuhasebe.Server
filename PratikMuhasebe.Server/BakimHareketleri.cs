using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BakimHareketleri
{
    public Guid BkmGuid { get; set; }

    public short BkmDbcno { get; set; }

    public int? BkmSpecRecNo { get; set; }

    public bool? BkmIptal { get; set; }

    public short? BkmFileid { get; set; }

    public bool? BkmHidden { get; set; }

    public bool? BkmKilitli { get; set; }

    public bool? BkmDegisti { get; set; }

    public int? BkmChecksum { get; set; }

    public short? BkmCreateUser { get; set; }

    public DateTime BkmCreateDate { get; set; }

    public short? BkmLastupUser { get; set; }

    public DateTime? BkmLastupDate { get; set; }

    public string? BkmSpecial1 { get; set; }

    public string? BkmSpecial2 { get; set; }

    public string? BkmSpecial3 { get; set; }

    public int? BkmFirmano { get; set; }

    public int? BkmSubeno { get; set; }

    public DateTime? BkmTarihi { get; set; }

    public string? BkmEvraknoSeri { get; set; }

    public int? BkmEvraknoSira { get; set; }

    public int? BkmSatirno { get; set; }

    public string? BkmBelgeno { get; set; }

    public DateTime? BkmBelgeTarihi { get; set; }

    public string? BkmTuketiciKodu { get; set; }

    public string? BkmCihazSerino { get; set; }

    public string? BkmFisStokKodu { get; set; }

    public DateTime? BkmTeslimAlinmaTarihi { get; set; }

    public DateTime? BkmTeslimEdilmeTarihi { get; set; }

    public byte? BkmTeslimEdilmeSekli { get; set; }

    public string? BkmArizaKodu1 { get; set; }

    public string? BkmArizaKodu2 { get; set; }

    public string? BkmArizaKodu3 { get; set; }

    public string? BkmArizaKodu4 { get; set; }

    public string? BkmArizaKodu5 { get; set; }

    public string? BkmArizaKodu6 { get; set; }

    public string? BkmArizaKodu7 { get; set; }

    public string? BkmArizaKodu8 { get; set; }

    public string? BkmArizaKodu9 { get; set; }

    public string? BkmArizaKodu10 { get; set; }

    public string? BkmEkipKodu { get; set; }

    public int? BkmDepono { get; set; }

    public string? BkmAciklama { get; set; }

    public byte? BkmHareketTipi { get; set; }

    public string? BkmStokHizmetKodu { get; set; }

    public double? BkmMiktari { get; set; }

    public double? BkmBirimFiyati { get; set; }

    public double? BkmTutari { get; set; }

    public double? BkmIskonto1 { get; set; }

    public double? BkmIskonto2 { get; set; }

    public double? BkmIskonto3 { get; set; }

    public double? BkmIskonto4 { get; set; }

    public double? BkmIskonto5 { get; set; }

    public double? BkmIskonto6 { get; set; }

    public double? BkmMasraf1 { get; set; }

    public double? BkmMasraf2 { get; set; }

    public double? BkmMasraf3 { get; set; }

    public double? BkmMasraf4 { get; set; }

    public byte? BkmVergiPntr { get; set; }

    public double? BkmVergi { get; set; }

    public byte? BkmMasrafVergiPnt { get; set; }

    public double? BkmMasrafVergi { get; set; }

    public byte? BkmIskMas1 { get; set; }

    public byte? BkmIskMas2 { get; set; }

    public byte? BkmIskMas3 { get; set; }

    public byte? BkmIskMas4 { get; set; }

    public byte? BkmIskMas5 { get; set; }

    public byte? BkmIskMas6 { get; set; }

    public byte? BkmIskMas7 { get; set; }

    public byte? BkmIskMas8 { get; set; }

    public byte? BkmIskMas9 { get; set; }

    public byte? BkmIskMas10 { get; set; }

    public bool? BkmSatIskMas1 { get; set; }

    public bool? BkmSatIskMas2 { get; set; }

    public bool? BkmSatIskMas3 { get; set; }

    public bool? BkmSatIskMas4 { get; set; }

    public bool? BkmSatIskMas5 { get; set; }

    public bool? BkmSatIskMas6 { get; set; }

    public bool? BkmSatIskMas7 { get; set; }

    public bool? BkmSatIskMas8 { get; set; }

    public bool? BkmSatIskMas9 { get; set; }

    public bool? BkmSatIskMas10 { get; set; }

    public byte? BkmDovizCins { get; set; }

    public double? BkmDovizKur { get; set; }

    public double? BkmAltDovizKur { get; set; }

    public bool? BkmVergisizFl { get; set; }

    public string? BkmSatirAciklama { get; set; }

    public bool? BkmFaturalandiFl { get; set; }

    public string? BkmZiyaretKodu { get; set; }

    public DateTime? BkmZiyAcTar { get; set; }

    public DateTime? BkmZiyCikZmn { get; set; }

    public DateTime? BkmZiyBasZmn { get; set; }

    public DateTime? BkmZiySonZmn { get; set; }

    public DateTime? BkmZiyDonZmn { get; set; }

    public Guid? BkmKabulUid { get; set; }

    public Guid? BkmIsemriUid { get; set; }

    public DateTime? BkmCihazdurumbastarihi1 { get; set; }

    public DateTime? BkmCihazdurumbittarihi1 { get; set; }

    public string? BkmCihazdurumkodu1 { get; set; }

    public string? BkmCihazserviselemanikodu1 { get; set; }

    public DateTime? BkmCihazdurumbastarihi2 { get; set; }

    public DateTime? BkmCihazdurumbittarihi2 { get; set; }

    public string? BkmCihazdurumkodu2 { get; set; }

    public string? BkmCihazserviselemanikodu2 { get; set; }

    public DateTime? BkmCihazdurumbastarihi3 { get; set; }

    public DateTime? BkmCihazdurumbittarihi3 { get; set; }

    public string? BkmCihazdurumkodu3 { get; set; }

    public string? BkmCihazserviselemanikodu3 { get; set; }

    public DateTime? BkmCihazdurumbastarihi4 { get; set; }

    public DateTime? BkmCihazdurumbittarihi4 { get; set; }

    public string? BkmCihazdurumkodu4 { get; set; }

    public string? BkmCihazserviselemanikodu4 { get; set; }

    public DateTime? BkmCihazdurumbastarihi5 { get; set; }

    public DateTime? BkmCihazdurumbittarihi5 { get; set; }

    public string? BkmCihazdurumkodu5 { get; set; }

    public string? BkmCihazserviselemanikodu5 { get; set; }

    public DateTime? BkmCihazdurumbastarihi6 { get; set; }

    public DateTime? BkmCihazdurumbittarihi6 { get; set; }

    public string? BkmCihazdurumkodu6 { get; set; }

    public string? BkmCihazserviselemanikodu6 { get; set; }

    public DateTime? BkmCihazdurumbastarihi7 { get; set; }

    public DateTime? BkmCihazdurumbittarihi7 { get; set; }

    public string? BkmCihazdurumkodu7 { get; set; }

    public string? BkmCihazserviselemanikodu7 { get; set; }

    public DateTime? BkmCihazdurumbastarihi8 { get; set; }

    public DateTime? BkmCihazdurumbittarihi8 { get; set; }

    public string? BkmCihazdurumkodu8 { get; set; }

    public string? BkmCihazserviselemanikodu8 { get; set; }

    public DateTime? BkmCihazdurumbastarihi9 { get; set; }

    public DateTime? BkmCihazdurumbittarihi9 { get; set; }

    public string? BkmCihazdurumkodu9 { get; set; }

    public string? BkmCihazserviselemanikodu9 { get; set; }

    public DateTime? BkmCihazdurumbastarihi10 { get; set; }

    public DateTime? BkmCihazdurumbittarihi10 { get; set; }

    public string? BkmCihazdurumkodu10 { get; set; }

    public string? BkmCihazserviselemanikodu10 { get; set; }

    public int? BkmFiyatListeNo { get; set; }

    public string? BkmPartiKodu { get; set; }

    public int? BkmLotNo { get; set; }

    public byte? BkmServisTuru { get; set; }

    public string? BkmPrjKodu { get; set; }

    public string? BkmSrmKodu { get; set; }

    public int? BkmAdresNo { get; set; }

    public byte? BkmOtvPntr { get; set; }

    public double? BkmOtvVergi { get; set; }

    public double? BkmOtvtutari { get; set; }

    public bool? BkmOtvvergisizFl { get; set; }
}
