using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PuanHediyeCekiHareketleri
{
    public Guid PhcGuid { get; set; }

    public short PhcDbcno { get; set; }

    public int? PhcSpecRecNo { get; set; }

    public bool? PhcIptal { get; set; }

    public short? PhcFileid { get; set; }

    public bool? PhcHidden { get; set; }

    public bool? PhcKilitli { get; set; }

    public bool? PhcDegisti { get; set; }

    public int? PhcChecksum { get; set; }

    public short? PhcCreateUser { get; set; }

    public DateTime PhcCreateDate { get; set; }

    public short? PhcLastupUser { get; set; }

    public DateTime? PhcLastupDate { get; set; }

    public string? PhcSpecial1 { get; set; }

    public string? PhcSpecial2 { get; set; }

    public string? PhcSpecial3 { get; set; }

    public int? PhcFirmano { get; set; }

    public int? PhcSubeno { get; set; }

    public byte? PhcEvrTip { get; set; }

    public string? PhcEvraknoSeri { get; set; }

    public int? PhcEvraknoSira { get; set; }

    public int? PhcSatirNo { get; set; }

    public byte? PhcPuanhcekTipi { get; set; }

    public string? PhcPuanhcekKodu { get; set; }

    public string? PhcHcekSeriNo { get; set; }

    public string? PhcCariKodu { get; set; }

    public DateTime? PhcTarih { get; set; }

    public int? PhcDepoNo { get; set; }

    public byte? PhcHareketTipi { get; set; }

    public DateTime? PhcIlkKullanimTarih { get; set; }

    public DateTime? PhcSonKullanimTarih { get; set; }

    public double? PhcMiktari { get; set; }

    public double? PhcTutari { get; set; }

    public short? PhcKaynakTablo { get; set; }

    public byte? PhcKaynakEvraktip { get; set; }

    public string? PhcKaynakEvraknoSeri { get; set; }

    public int? PhcKaynakEvraknoSira { get; set; }

    public int? PhcKaynakEvrakSatirno { get; set; }

    public string? PhcKaynakPromosyon { get; set; }

    public string? PhcBelgeNo { get; set; }

    public DateTime? PhcBelgeTarih { get; set; }

    public string? PhcPlasiyer { get; set; }

    public string? PhcAciklama { get; set; }

    public string? PhcProvizyonId { get; set; }
}
