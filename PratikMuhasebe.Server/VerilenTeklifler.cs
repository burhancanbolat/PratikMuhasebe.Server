using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class VerilenTeklifler
{
    public Guid TklGuid { get; set; }

    public short TklDbcno { get; set; }

    public int? TklSpecRecno { get; set; }

    public bool? TklIptal { get; set; }

    public short? TklFileid { get; set; }

    public bool? TklHidden { get; set; }

    public bool? TklKilitli { get; set; }

    public bool? TklDegisti { get; set; }

    public int? TklChecksum { get; set; }

    public short? TklCreateUser { get; set; }

    public DateTime TklCreateDate { get; set; }

    public short? TklLastupUser { get; set; }

    public DateTime? TklLastupDate { get; set; }

    public string? TklSpecial1 { get; set; }

    public string? TklSpecial2 { get; set; }

    public string? TklSpecial3 { get; set; }

    public int? TklFirmano { get; set; }

    public int? TklSubeno { get; set; }

    public string? TklStokKod { get; set; }

    public string? TklCariKod { get; set; }

    public string? TklEvraknoSeri { get; set; }

    public int? TklEvraknoSira { get; set; }

    public DateTime? TklEvrakTarihi { get; set; }

    public int? TklSatirno { get; set; }

    public string? TklBelgeNo { get; set; }

    public DateTime? TklBelgeTarih { get; set; }

    public double? TklAsgariMiktar { get; set; }

    public short? TklTeslimatSuresi { get; set; }

    public DateTime? TklBaslangicTarihi { get; set; }

    public DateTime? TklGecerlilikSures { get; set; }

    public double? TklBrutFiyat { get; set; }

    public int? TklOdemePlani { get; set; }

    public double? TklAlisfiyati { get; set; }

    public double? TklKarorani { get; set; }

    public double? TklMiktar { get; set; }

    public string? TklAciklama { get; set; }

    public byte? TklDovizCins { get; set; }

    public double? TklDovizKur { get; set; }

    public double? TklAltDovizKur { get; set; }

    public double? TklIskonto1 { get; set; }

    public double? TklIskonto2 { get; set; }

    public double? TklIskonto3 { get; set; }

    public double? TklIskonto4 { get; set; }

    public double? TklIskonto5 { get; set; }

    public double? TklIskonto6 { get; set; }

    public double? TklMasraf1 { get; set; }

    public double? TklMasraf2 { get; set; }

    public double? TklMasraf3 { get; set; }

    public double? TklMasraf4 { get; set; }

    public byte? TklVergiPntr { get; set; }

    public double? TklVergi { get; set; }

    public byte? TklMasrafVergiPnt { get; set; }

    public double? TklMasrafVergi { get; set; }

    public byte? TklIskMas1 { get; set; }

    public byte? TklIskMas2 { get; set; }

    public byte? TklIskMas3 { get; set; }

    public byte? TklIskMas4 { get; set; }

    public byte? TklIskMas5 { get; set; }

    public byte? TklIskMas6 { get; set; }

    public byte? TklIskMas7 { get; set; }

    public byte? TklIskMas8 { get; set; }

    public byte? TklIskMas9 { get; set; }

    public byte? TklIskMas10 { get; set; }

    public bool? TklSatIskmas1 { get; set; }

    public bool? TklSatIskmas2 { get; set; }

    public bool? TklSatIskmas3 { get; set; }

    public bool? TklSatIskmas4 { get; set; }

    public bool? TklSatIskmas5 { get; set; }

    public bool? TklSatIskmas6 { get; set; }

    public bool? TklSatIskmas7 { get; set; }

    public bool? TklSatIskmas8 { get; set; }

    public bool? TklSatIskmas9 { get; set; }

    public bool? TklSatIskmas10 { get; set; }

    public bool? TklVergisizFl { get; set; }

    public bool? TklKapatFl { get; set; }

    public string? TklTeslimturu { get; set; }

    public string? TklProjeKodu { get; set; }

    public string? TklSorumluKod { get; set; }

    public int? TklAdresNo { get; set; }

    public Guid? TklYetkiliUid { get; set; }

    public byte? TklDurumu { get; set; }

    public string? TklTedarikEdilecekCari { get; set; }

    public int? TklFiyatListeNo { get; set; }

    public double? TklBirimfiyati { get; set; }

    public string? TklPaketKod { get; set; }

    public double? TklTeslimMiktar { get; set; }

    public short? TklOnaylayanKulNo { get; set; }

    public bool? TklCagrilabilirFl { get; set; }

    public byte? TklHarekettipi { get; set; }

    public string? TklCariSormerk { get; set; }

    public string? TklStokSormerk { get; set; }

    public string? TklKapatmanedenkod { get; set; }

    public string? TklServisisemrikodu { get; set; }

    public byte? TklBirimPntr { get; set; }

    public byte? TklCariTipi { get; set; }

    public string? TklHareketGrupKodu1 { get; set; }

    public string? TklHareketGrupKodu2 { get; set; }

    public string? TklHareketGrupKodu3 { get; set; }

    public double? TklOlcu1 { get; set; }

    public double? TklOlcu2 { get; set; }

    public double? TklOlcu3 { get; set; }

    public double? TklOlcu4 { get; set; }

    public double? TklOlcu5 { get; set; }

    public byte? TklFormulMiktarNo { get; set; }

    public double? TklFormulMiktar { get; set; }
}
