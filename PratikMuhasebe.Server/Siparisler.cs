using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Siparisler
{
    public Guid SipGuid { get; set; }

    public short SipDbcno { get; set; }

    public int? SipSpecRecno { get; set; }

    public bool? SipIptal { get; set; }

    public short? SipFileid { get; set; }

    public bool? SipHidden { get; set; }

    public bool? SipKilitli { get; set; }

    public bool? SipDegisti { get; set; }

    public int? SipChecksum { get; set; }

    public short? SipCreateUser { get; set; }

    public DateTime SipCreateDate { get; set; }

    public short? SipLastupUser { get; set; }

    public DateTime? SipLastupDate { get; set; }

    public string? SipSpecial1 { get; set; }

    public string? SipSpecial2 { get; set; }

    public string? SipSpecial3 { get; set; }

    public int? SipFirmano { get; set; }

    public int? SipSubeno { get; set; }

    public DateTime? SipTarih { get; set; }

    public DateTime? SipTeslimTarih { get; set; }

    public byte? SipTip { get; set; }

    public byte? SipCins { get; set; }

    public string? SipEvraknoSeri { get; set; }

    public int? SipEvraknoSira { get; set; }

    public int? SipSatirno { get; set; }

    public string? SipBelgeno { get; set; }

    public DateTime? SipBelgeTarih { get; set; }

    public string? SipSaticiKod { get; set; }

    public string? SipMusteriKod { get; set; }

    public string? SipStokKod { get; set; }

    public double? SipBFiyat { get; set; }

    public double? SipMiktar { get; set; }

    public byte? SipBirimPntr { get; set; }

    public double? SipTeslimMiktar { get; set; }

    public double? SipTutar { get; set; }

    public double? SipIskonto1 { get; set; }

    public double? SipIskonto2 { get; set; }

    public double? SipIskonto3 { get; set; }

    public double? SipIskonto4 { get; set; }

    public double? SipIskonto5 { get; set; }

    public double? SipIskonto6 { get; set; }

    public double? SipMasraf1 { get; set; }

    public double? SipMasraf2 { get; set; }

    public double? SipMasraf3 { get; set; }

    public double? SipMasraf4 { get; set; }

    public byte? SipVergiPntr { get; set; }

    public double? SipVergi { get; set; }

    public byte? SipMasvergiPntr { get; set; }

    public double? SipMasvergi { get; set; }

    public int? SipOpno { get; set; }

    public string? SipAciklama { get; set; }

    public string? SipAciklama2 { get; set; }

    public int? SipDepono { get; set; }

    public short? SipOnaylayanKulNo { get; set; }

    public bool? SipVergisizFl { get; set; }

    public bool? SipKapatFl { get; set; }

    public bool? SipPromosyonFl { get; set; }

    public string? SipCariSormerk { get; set; }

    public string? SipStokSormerk { get; set; }

    public byte? SipCariGrupno { get; set; }

    public byte? SipDovizCinsi { get; set; }

    public double? SipDovizKuru { get; set; }

    public double? SipAltDovizKuru { get; set; }

    public int? SipAdresno { get; set; }

    public string? SipTeslimturu { get; set; }

    public bool? SipCagrilabilirFl { get; set; }

    public Guid? SipProsipUid { get; set; }

    public byte? SipIskonto11 { get; set; }

    public byte? SipIskonto21 { get; set; }

    public byte? SipIskonto31 { get; set; }

    public byte? SipIskonto41 { get; set; }

    public byte? SipIskonto51 { get; set; }

    public byte? SipIskonto61 { get; set; }

    public byte? SipMasraf11 { get; set; }

    public byte? SipMasraf21 { get; set; }

    public byte? SipMasraf31 { get; set; }

    public byte? SipMasraf41 { get; set; }

    public bool? SipIsk1 { get; set; }

    public bool? SipIsk2 { get; set; }

    public bool? SipIsk3 { get; set; }

    public bool? SipIsk4 { get; set; }

    public bool? SipIsk5 { get; set; }

    public bool? SipIsk6 { get; set; }

    public bool? SipMas1 { get; set; }

    public bool? SipMas2 { get; set; }

    public bool? SipMas3 { get; set; }

    public bool? SipMas4 { get; set; }

    public string? SipExpImpKodu { get; set; }

    public double? SipKarOrani { get; set; }

    public byte? SipDurumu { get; set; }

    public Guid? SipStalUid { get; set; }

    public double? SipPlanlananmiktar { get; set; }

    public Guid? SipTeklifUid { get; set; }

    public string? SipPartiKodu { get; set; }

    public int? SipLotNo { get; set; }

    public string? SipProjekodu { get; set; }

    public int? SipFiyatListeNo { get; set; }

    public byte? SipOtvPntr { get; set; }

    public double? SipOtvVergi { get; set; }

    public double? SipOtvtutari { get; set; }

    public byte? SipOtvVergisizFl { get; set; }

    public string? SipPaketKod { get; set; }

    public Guid? SipRezUid { get; set; }

    public byte? SipHarekettipi { get; set; }

    public Guid? SipYetkiliUid { get; set; }

    public string? SipKapatmanedenkod { get; set; }

    public DateTime? SipGecerlilikTarihi { get; set; }

    public byte? SipOnodemeEvrakTip { get; set; }

    public string? SipOnodemeEvrakSeri { get; set; }

    public int? SipOnodemeEvrakSira { get; set; }

    public double? SipRezervasyonMiktari { get; set; }

    public double? SipRezervedenTeslimEdilen { get; set; }

    public string? SipHareketGrupKodu1 { get; set; }

    public string? SipHareketGrupKodu2 { get; set; }

    public string? SipHareketGrupKodu3 { get; set; }

    public double? SipOlcu1 { get; set; }

    public double? SipOlcu2 { get; set; }

    public double? SipOlcu3 { get; set; }

    public double? SipOlcu4 { get; set; }

    public double? SipOlcu5 { get; set; }

    public byte? SipFormulMiktarNo { get; set; }

    public double? SipFormulMiktar { get; set; }

    public byte? SipSatisFiyatDovizCinsi { get; set; }

    public double? SipSatisFiyatDovizKuru { get; set; }

    public string? SipEticaretKanalKodu { get; set; }
}
