using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokDepoDetaylari
{
    public Guid SdpGuid { get; set; }

    public short SdpDbcno { get; set; }

    public int? SdpSpecRecno { get; set; }

    public bool? SdpIptal { get; set; }

    public short? SdpFileid { get; set; }

    public bool? SdpHidden { get; set; }

    public bool? SdpKilitli { get; set; }

    public bool? SdpDegisti { get; set; }

    public int? SdpChecksum { get; set; }

    public short? SdpCreateUser { get; set; }

    public DateTime SdpCreateDate { get; set; }

    public short? SdpLastupUser { get; set; }

    public DateTime? SdpLastupDate { get; set; }

    public string? SdpSpecial1 { get; set; }

    public string? SdpSpecial2 { get; set; }

    public string? SdpSpecial3 { get; set; }

    public string? SdpDepoKod { get; set; }

    public int? SdpDepoNo { get; set; }

    public double? SdpKarOrani { get; set; }

    public double? SdpMinStok { get; set; }

    public double? SdpSipStok { get; set; }

    public double? SdpMaxStok { get; set; }

    public byte? SdpVerSipbirimpntr { get; set; }

    public byte? SdpAlSipbirimpntr { get; set; }

    public short? SdpSipsure { get; set; }

    public string? SdpYerkodu { get; set; }

    public byte? SdpSatisdursun { get; set; }

    public byte? SdpSipdursun { get; set; }

    public byte? SdpMalkabuldursun { get; set; }

    public bool? SdpMalKabulGun1 { get; set; }

    public bool? SdpMalKabulGun2 { get; set; }

    public bool? SdpMalKabulGun3 { get; set; }

    public bool? SdpMalKabulGun4 { get; set; }

    public bool? SdpMalKabulGun5 { get; set; }

    public bool? SdpMalKabulGun6 { get; set; }

    public bool? SdpMalKabulGun7 { get; set; }

    public bool? SdpSiparisGun1 { get; set; }

    public bool? SdpSiparisGun2 { get; set; }

    public bool? SdpSiparisGun3 { get; set; }

    public bool? SdpSiparisGun4 { get; set; }

    public bool? SdpSiparisGun5 { get; set; }

    public bool? SdpSiparisGun6 { get; set; }

    public bool? SdpSiparisGun7 { get; set; }

    public bool? SdpIskontoYapilamaz { get; set; }

    public bool? SdpTasfiyedeFl { get; set; }

    public bool? SdpPasifFl { get; set; }

    public string? SdpSatCariKod { get; set; }

    public double? SdpKasaIskontoOrani { get; set; }

    public double? SdpKasaIskontoTutari { get; set; }

    public bool? SdpEksiyedusebilirFl { get; set; }

    public string? SdpUrunSorumlusuKodu { get; set; }

    public bool? SdpKasadaTaksitlenebilirFl { get; set; }

    public byte? SdpSiparisyeri { get; set; }

    public string? SdpMuhkodArtikeli { get; set; }

    public string? SdpPozisyonbayrakKodu { get; set; }

    public short? SdpMinStokBelirlemeGun { get; set; }

    public short? SdpSipStokBelirlemeGun { get; set; }

    public short? SdpMaxStokBelirlemeGun { get; set; }

    public bool? SdpSevBelOprDegerlendimeFl { get; set; }
}
