using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ButceMaster
{
    public Guid BmGuid { get; set; }

    public short BmDbcno { get; set; }

    public int? BmSpecRecno { get; set; }

    public bool? BmIptal { get; set; }

    public short? BmFileid { get; set; }

    public bool? BmHidden { get; set; }

    public bool? BmKilitli { get; set; }

    public bool? BmDegisti { get; set; }

    public int? BmChecksum { get; set; }

    public short? BmCreateUser { get; set; }

    public DateTime BmCreateDate { get; set; }

    public short? BmLastupUser { get; set; }

    public DateTime? BmLastupDate { get; set; }

    public string? BmSpecial1 { get; set; }

    public string? BmSpecial2 { get; set; }

    public string? BmSpecial3 { get; set; }

    public string BmButcekodu { get; set; } = null!;

    public string? BmButceadi { get; set; }

    public int? BmFirmano { get; set; }

    public byte? BmButcetipi { get; set; }

    public byte? BmStokDetayi { get; set; }

    public byte? BmHizmetDetayi { get; set; }

    public byte? BmMasrafDetayi { get; set; }

    public byte? BmCariDetayi { get; set; }

    public byte? BmSorumluDetayi { get; set; }

    public byte? BmDepoDetayi { get; set; }

    public byte? BmSormrkDetayi { get; set; }

    public byte? BmProjeDetayi { get; set; }

    public byte? BmDonemTipi { get; set; }

    public byte? BmDegerDetayi1 { get; set; }

    public byte? BmDegerDetayi2 { get; set; }

    public byte? BmDegerDetayi3 { get; set; }

    public byte? BmDegerDetayi4 { get; set; }

    public byte? BmDegerDetayi5 { get; set; }

    public byte? BmMaxTanimliDonem { get; set; }

    public string? BmDonem1Adi { get; set; }

    public string? BmDonem2Adi { get; set; }

    public string? BmDonem3Adi { get; set; }

    public string? BmDonem4Adi { get; set; }

    public string? BmDonem5Adi { get; set; }

    public string? BmDonem6Adi { get; set; }

    public string? BmDonem7Adi { get; set; }

    public string? BmDonem8Adi { get; set; }

    public string? BmDonem9Adi { get; set; }

    public string? BmDonem10Adi { get; set; }

    public string? BmDonem11Adi { get; set; }

    public string? BmDonem12Adi { get; set; }

    public string? BmDonem13Adi { get; set; }

    public string? BmDonem14Adi { get; set; }

    public string? BmDonem15Adi { get; set; }

    public string? BmDonem16Adi { get; set; }

    public DateTime? BmDonem1Bas { get; set; }

    public DateTime? BmDonem1Bit { get; set; }

    public DateTime? BmDonem2Bas { get; set; }

    public DateTime? BmDonem2Bit { get; set; }

    public DateTime? BmDonem3Bas { get; set; }

    public DateTime? BmDonem3Bit { get; set; }

    public DateTime? BmDonem4Bas { get; set; }

    public DateTime? BmDonem4Bit { get; set; }

    public DateTime? BmDonem5Bas { get; set; }

    public DateTime? BmDonem5Bit { get; set; }

    public DateTime? BmDonem6Bas { get; set; }

    public DateTime? BmDonem6Bit { get; set; }

    public DateTime? BmDonem7Bas { get; set; }

    public DateTime? BmDonem7Bit { get; set; }

    public DateTime? BmDonem8Bas { get; set; }

    public DateTime? BmDonem8Bit { get; set; }

    public DateTime? BmDonem9Bas { get; set; }

    public DateTime? BmDonem9Bit { get; set; }

    public DateTime? BmDonem10Bas { get; set; }

    public DateTime? BmDonem10Bit { get; set; }

    public DateTime? BmDonem11Bas { get; set; }

    public DateTime? BmDonem11Bit { get; set; }

    public DateTime? BmDonem12Bas { get; set; }

    public DateTime? BmDonem12Bit { get; set; }

    public DateTime? BmDonem13Bas { get; set; }

    public DateTime? BmDonem13Bit { get; set; }

    public DateTime? BmDonem14Bas { get; set; }

    public DateTime? BmDonem14Bit { get; set; }

    public DateTime? BmDonem15Bas { get; set; }

    public DateTime? BmDonem15Bit { get; set; }

    public DateTime? BmDonem16Bas { get; set; }

    public DateTime? BmDonem16Bit { get; set; }

    public string? BmStokDetayStr { get; set; }

    public string? BmHizmetDetayStr { get; set; }

    public string? BmMasrafDetayStr { get; set; }

    public string? BmCariDetayStr { get; set; }

    public string? BmSorumluDetayStr { get; set; }

    public string? BmDepoDetayStr { get; set; }

    public string? BmSormrkDetayStr { get; set; }

    public string? BmProjeDetayStr { get; set; }

    public string? BmDonemDetayStr { get; set; }
}
