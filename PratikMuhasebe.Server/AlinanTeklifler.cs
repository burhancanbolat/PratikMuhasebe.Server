using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AlinanTeklifler
{
    public Guid AltklGuid { get; set; }

    public short AltklDbcno { get; set; }

    public int? AltklSpecRecno { get; set; }

    public bool? AltklIptal { get; set; }

    public short? AltklFileid { get; set; }

    public bool? AltklHidden { get; set; }

    public bool? AltklKilitli { get; set; }

    public bool? AltklDegisti { get; set; }

    public int? AltklChecksum { get; set; }

    public short? AltklCreateUser { get; set; }

    public DateTime AltklCreateDate { get; set; }

    public short? AltklLastupUser { get; set; }

    public DateTime? AltklLastupDate { get; set; }

    public string? AltklSpecial1 { get; set; }

    public string? AltklSpecial2 { get; set; }

    public string? AltklSpecial3 { get; set; }

    public int? AltklFirmano { get; set; }

    public int? AltklSubeno { get; set; }

    public string? AltklTeklifKodu { get; set; }

    public int? AltklSiraNo { get; set; }

    public int? AltklSatirno { get; set; }

    public DateTime? AltklTarihi { get; set; }

    public string? AltklBelgeNo { get; set; }

    public DateTime? AltklBelgeTarih { get; set; }

    public string? AltklCariKodu { get; set; }

    public int? AltklCariAdresNo { get; set; }

    public Guid? AltklCariYetkiliUid { get; set; }

    public DateTime? AltklTeslimatTarihi { get; set; }

    public int? AltklOdemePlani { get; set; }

    public string? AltklTeslimTuru { get; set; }

    public string? AltklProjeKodu { get; set; }

    public string? AltklSrmmrkKodu { get; set; }

    public string? AltklSorumluKodu { get; set; }

    public byte? AltklHareketTipi { get; set; }

    public string? AltklHareketKodu { get; set; }

    public double? AltklMiktar { get; set; }

    public double? AltklBirimFiyati { get; set; }

    public double? AltklTutar { get; set; }

    public byte? AltklDovizCins { get; set; }

    public double? AltklDovizKur { get; set; }

    public double? AltklAltDovizKur { get; set; }

    public double? AltklIskonto1 { get; set; }

    public double? AltklIskonto2 { get; set; }

    public double? AltklIskonto3 { get; set; }

    public double? AltklIskonto4 { get; set; }

    public double? AltklIskonto5 { get; set; }

    public double? AltklIskonto6 { get; set; }

    public double? AltklMasraf1 { get; set; }

    public double? AltklMasraf2 { get; set; }

    public double? AltklMasraf3 { get; set; }

    public double? AltklMasraf4 { get; set; }

    public byte? AltklVergiPntr { get; set; }

    public double? AltklVergi { get; set; }

    public byte? AltklMasrafVergiPnt { get; set; }

    public double? AltklMasrafVergi { get; set; }

    public byte? AltklIskMas1 { get; set; }

    public byte? AltklIskMas2 { get; set; }

    public byte? AltklIskMas3 { get; set; }

    public byte? AltklIskMas4 { get; set; }

    public byte? AltklIskMas5 { get; set; }

    public byte? AltklIskMas6 { get; set; }

    public byte? AltklIskMas7 { get; set; }

    public byte? AltklIskMas8 { get; set; }

    public byte? AltklIskMas9 { get; set; }

    public byte? AltklIskMas10 { get; set; }

    public bool? AltklSatIskmas1 { get; set; }

    public bool? AltklSatIskmas2 { get; set; }

    public bool? AltklSatIskmas3 { get; set; }

    public bool? AltklSatIskmas4 { get; set; }

    public bool? AltklSatIskmas5 { get; set; }

    public bool? AltklSatIskmas6 { get; set; }

    public bool? AltklSatIskmas7 { get; set; }

    public bool? AltklSatIskmas8 { get; set; }

    public bool? AltklSatIskmas9 { get; set; }

    public bool? AltklSatIskmas10 { get; set; }

    public bool? AltklVergisizFl { get; set; }

    public int? AltklFiyatListeNo { get; set; }

    public string? AltklPaketKod { get; set; }

    public int? AltklTeslimdepo { get; set; }

    public string? AltklAciklama { get; set; }

    public short? AltklOnaylayanKullanici { get; set; }

    public byte? AltklDurumu { get; set; }

    public Guid? AltklSatalTalepUid { get; set; }

    public Guid? AltklSiparisUid { get; set; }

    public Guid? AltklProsiparisUid { get; set; }

    public byte? AltklBirimPntr { get; set; }

    public byte? AltklCariTipi { get; set; }
}
