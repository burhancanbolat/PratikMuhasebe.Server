using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiralamaHareketleri
{
    public Guid KharGuid { get; set; }

    public short KharDbcno { get; set; }

    public int? KharSpecRecNo { get; set; }

    public bool? KharIptal { get; set; }

    public short? KharFileid { get; set; }

    public bool? KharHidden { get; set; }

    public bool? KharKilitli { get; set; }

    public bool? KharDegisti { get; set; }

    public int? KharChecksum { get; set; }

    public short? KharCreateUser { get; set; }

    public DateTime KharCreateDate { get; set; }

    public short? KharLastupUser { get; set; }

    public DateTime? KharLastupDate { get; set; }

    public string? KharSpecial1 { get; set; }

    public string? KharSpecial2 { get; set; }

    public string? KharSpecial3 { get; set; }

    public int? KharFirmano { get; set; }

    public int? KharSubeno { get; set; }

    public string? KharKodu { get; set; }

    public DateTime? KharTarihi { get; set; }

    public string? KharCariKodu { get; set; }

    public byte? KharDovizCinsi { get; set; }

    public byte? KharFatDovizCinsi { get; set; }

    public string? KharAciklama { get; set; }

    public string? KharAciklama2 { get; set; }

    public int? KharFatAdresNo { get; set; }

    public int? KharSevkAdresNo { get; set; }

    public int? KharDepono { get; set; }

    public string? KharTemsilciKodu { get; set; }

    public Guid? KharYetkiliUid { get; set; }

    public string? KharSrmMerkeziKodu { get; set; }

    public string? KharProjeKodu { get; set; }

    public string? KharKullanimAlaniKodu { get; set; }

    public string? KharYapilanIsKodu { get; set; }

    public int? KharOpno { get; set; }

    public DateTime? KharBaslangicTarihi { get; set; }

    public byte? KharFaturaPeryodu { get; set; }

    public short? KharFaturaGunu { get; set; }

    public byte? KharKiralamaCinsi { get; set; }

    public string? KharSonFaturanoSeri { get; set; }

    public int? KharSonFaturanoSira { get; set; }

    public int? KharSatirno { get; set; }

    public byte? KharHareketTipi { get; set; }

    public string? KharHareketKodu { get; set; }

    public string? KharSeriNo { get; set; }

    public int? KharKiralamaSuresi { get; set; }

    public double? KharIskTutari { get; set; }

    public double? KharTutar { get; set; }

    public string? KharSatirAciklama { get; set; }

    public byte? KharDurumu { get; set; }

    public int? KharRevizeSure { get; set; }

    public double? KharRevizeTutar { get; set; }

    public DateTime? KharBitisTarihi { get; set; }

    public DateTime? KharTahminiDonusTarihi { get; set; }

    public DateTime? KharFaturalananSonTarih { get; set; }

    public string? KharHizmetFaturanoSeri { get; set; }

    public int? KharHizmetFaturanoSira { get; set; }

    public Guid? KharKtkfUid { get; set; }
}
