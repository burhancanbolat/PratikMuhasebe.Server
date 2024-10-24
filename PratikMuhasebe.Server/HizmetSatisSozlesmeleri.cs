using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizmetSatisSozlesmeleri
{
    public Guid HssGuid { get; set; }

    public short HssDbcno { get; set; }

    public int? HssSpecRecNo { get; set; }

    public bool? HssIptal { get; set; }

    public short? HssFileid { get; set; }

    public bool? HssHidden { get; set; }

    public bool? HssKilitli { get; set; }

    public bool? HssDegisti { get; set; }

    public int? HssChecksum { get; set; }

    public short? HssCreateUser { get; set; }

    public DateTime HssCreateDate { get; set; }

    public short? HssLastupUser { get; set; }

    public DateTime? HssLastupDate { get; set; }

    public string? HssSpecial1 { get; set; }

    public string? HssSpecial2 { get; set; }

    public string? HssSpecial3 { get; set; }

    public int? HssFirmano { get; set; }

    public int? HssSubeno { get; set; }

    public DateTime? HssEvraktarihi { get; set; }

    public string? HssEvrakseri { get; set; }

    public int? HssEvraksira { get; set; }

    public int? HssEvraksatir { get; set; }

    public string? HssCarikodu { get; set; }

    public string? HssCarisrmmrk { get; set; }

    public DateTime? HssTarihi { get; set; }

    public string? HssHizmetkodu { get; set; }

    public string? HssAciklama { get; set; }

    public double? HssFiyati { get; set; }

    public int? HssOpno { get; set; }

    public string? HssKesfatseri { get; set; }

    public int? HssKesfatsira { get; set; }

    public string? HssSrmmrkkodu { get; set; }

    public string? HssProjekodu { get; set; }

    public double? HssMiktari { get; set; }

    public short? HssOnaylayanKulNo { get; set; }

    public bool? HssCagrilabilirFl { get; set; }

    public string? HssCarisozlesmekodu { get; set; }

    public byte? HssCarisozlesmeakttipi { get; set; }

    public byte? HssGrupno { get; set; }

    public byte? HssDovizCins { get; set; }

    public double? HssDovizKur { get; set; }

    public double? HssAltDovizKur { get; set; }

    public Guid? HssChasgirUid { get; set; }

    public bool? HssGuncellendiFl { get; set; }

    public double? HssGuncOncekifiyati { get; set; }

    public double? HssGuncOncekiEndeks { get; set; }

    public string? HssSaticikodu { get; set; }

    public string? HssBelgeno { get; set; }

    public DateTime? HssBelgeTarih { get; set; }
}
