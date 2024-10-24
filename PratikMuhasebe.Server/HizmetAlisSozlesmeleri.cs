using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizmetAlisSozlesmeleri
{
    public Guid HasGuid { get; set; }

    public short HasDbcno { get; set; }

    public int? HasSpecRecNo { get; set; }

    public bool? HasIptal { get; set; }

    public short? HasFileid { get; set; }

    public bool? HasHidden { get; set; }

    public bool? HasKilitli { get; set; }

    public bool? HasDegisti { get; set; }

    public int? HasChecksum { get; set; }

    public short? HasCreateUser { get; set; }

    public DateTime HasCreateDate { get; set; }

    public short? HasLastupUser { get; set; }

    public DateTime? HasLastupDate { get; set; }

    public string? HasSpecial1 { get; set; }

    public string? HasSpecial2 { get; set; }

    public string? HasSpecial3 { get; set; }

    public int? HasFirmano { get; set; }

    public int? HasSubeno { get; set; }

    public DateTime? HasEvraktarihi { get; set; }

    public string? HasEvrakseri { get; set; }

    public int? HasEvraksira { get; set; }

    public int? HasEvraksatir { get; set; }

    public string? HasCarikodu { get; set; }

    public string? HasCarisrmmrk { get; set; }

    public DateTime? HasTarihi { get; set; }

    public string? HasMasrafkodu { get; set; }

    public string? HasAciklama { get; set; }

    public double? HasFiyati { get; set; }

    public int? HasOpno { get; set; }

    public string? HasKesfatseri { get; set; }

    public int? HasKesfatsira { get; set; }

    public string? HasSrmmrkkodu { get; set; }

    public string? HasProjekodu { get; set; }

    public byte? HasVergipntr { get; set; }

    public short? HasOnaylayanKulNo { get; set; }

    public bool? HasCagrilabilirFl { get; set; }

    public string? HasCarisozlesmekodu { get; set; }

    public byte? HasCarisozlesmeakttipi { get; set; }

    public byte? HasGrupno { get; set; }

    public byte? HasDovizCins { get; set; }

    public double? HasDovizKur { get; set; }

    public double? HasAltDovizKur { get; set; }

    public string? HasSaticikodu { get; set; }

    public string? HasBelgeno { get; set; }

    public DateTime? HasBelgeTarih { get; set; }
}
