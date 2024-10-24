using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ShopPromosyonKontrol
{
    public Guid SpkGuid { get; set; }

    public short SpkDbcno { get; set; }

    public int? SpkSpecRecno { get; set; }

    public bool? SpkIptal { get; set; }

    public short? SpkFileid { get; set; }

    public bool? SpkHidden { get; set; }

    public bool? SpkKilitli { get; set; }

    public bool? SpkDegisti { get; set; }

    public int? SpkCheckSum { get; set; }

    public short? SpkCreateUser { get; set; }

    public DateTime SpkCreateDate { get; set; }

    public short? SpkLastupUser { get; set; }

    public DateTime? SpkLastupDate { get; set; }

    public string? SpkSpecial1 { get; set; }

    public string? SpkSpecial2 { get; set; }

    public string? SpkSpecial3 { get; set; }

    public int? SpkTestid { get; set; }

    public byte? SpkDatatip { get; set; }

    public string? SpkOrnekKodu { get; set; }

    public string? SpkPromosyonKodu { get; set; }

    public int? SpkSatirno { get; set; }

    public string? SpkStokKod { get; set; }

    public string? SpkStokBarkod { get; set; }

    public int? SpkStokRenkId { get; set; }

    public int? SpkStokBedenId { get; set; }

    public byte? SpkCariCinsi { get; set; }

    public string? SpkCariKodu { get; set; }

    public byte? SpkCariGrupNo { get; set; }

    public double? SpkMiktar { get; set; }

    public double? SpkTutar { get; set; }

    public double? SpkIskontoSatir { get; set; }

    public double? SpkIskontoGenel { get; set; }

    public double? SpkMasrafSatir { get; set; }

    public double? SpkMasrafGenel { get; set; }

    public double? SpkVergi { get; set; }

    public double? SpkMasrafVergi { get; set; }

    public double? SpkOtvVergi { get; set; }

    public double? SpkOtvtutari { get; set; }

    public double? SpkOivVergi { get; set; }

    public double? SpkOivtutari { get; set; }

    public int? SpkOdemeTipi { get; set; }

    public int? SpkTaksitTipi { get; set; }

    public string? SpkPuanKodu { get; set; }

    public double? SpkOdemeToplam { get; set; }

    public bool? SpkPromoOk { get; set; }
}
