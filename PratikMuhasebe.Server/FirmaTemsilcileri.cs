using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FirmaTemsilcileri
{
    public Guid TmsGuid { get; set; }

    public short TmsDbcno { get; set; }

    public int? TmsSpecRecno { get; set; }

    public bool? TmsIptal { get; set; }

    public short? TmsFileid { get; set; }

    public bool? TmsHidden { get; set; }

    public bool? TmsKilitli { get; set; }

    public bool? TmsDegisti { get; set; }

    public int? TmsChecksum { get; set; }

    public short? TmsCreateUser { get; set; }

    public DateTime TmsCreateDate { get; set; }

    public short? TmsLastupUser { get; set; }

    public DateTime? TmsLastupDate { get; set; }

    public string? TmsReserved1 { get; set; }

    public string? TmsReserved2 { get; set; }

    public string? TmsReserved3 { get; set; }

    public int? TmsBagFirmaNo { get; set; }

    public string? TmsKodu { get; set; }

    public string? TmsAdi { get; set; }

    public string? TmsSoyadi { get; set; }

    public byte? TmsSifat { get; set; }

    public string? TmsVdaire { get; set; }

    public string? TmsVkimlikNo { get; set; }

    public double? TmsHisse { get; set; }

    public string? TmsTicOdaSicilNo { get; set; }

    public string? TmsTcKimlikNo { get; set; }

    public string? TmsBabaadi { get; set; }

    public string? TmsAnneadi { get; set; }

    public string? TmsDogyeri { get; set; }

    public DateTime? TmsDogtarihi { get; set; }

    public byte? TmsMedenihal { get; set; }

    public string? TmsUyruk { get; set; }

    public string? TmsEmail { get; set; }

    public string? TmsMobTelUlKod1 { get; set; }

    public string? TmsMobTelKod1 { get; set; }

    public string? TmsMobTelNo1 { get; set; }

    public string? TmsMobTelUlKod2 { get; set; }

    public string? TmsMobTelKod2 { get; set; }

    public string? TmsMobTelNo2 { get; set; }

    public string? TmsIsTelUlKod { get; set; }

    public string? TmsIsTelKod { get; set; }

    public string? TmsIsTelNo1 { get; set; }

    public string? TmsIsTelNo2 { get; set; }

    public string? TmsIsFaxNo { get; set; }

    public string? TmsIsModemNo { get; set; }

    public string? TmsIsCadde { get; set; }

    public string? TmsIsMahalle { get; set; }

    public string? TmsIsSokak { get; set; }

    public string? TmsIsSemt { get; set; }

    public string? TmsIsAptNo { get; set; }

    public string? TmsIsDaireNo { get; set; }

    public string? TmsIsPostaKodu { get; set; }

    public string? TmsIsIlce { get; set; }

    public string? TmsIsIl { get; set; }

    public string? TmsIsUlke { get; set; }

    public string? TmsIsAdresKodu { get; set; }

    public string? TmsIkmTelUlKod { get; set; }

    public string? TmsIkmTelKod { get; set; }

    public string? TmsIkmTelNo { get; set; }

    public string? TmsIkmCadde { get; set; }

    public string? TmsIkmMahalle { get; set; }

    public string? TmsIkmSokak { get; set; }

    public string? TmsIkmSemt { get; set; }

    public string? TmsIkmAptNo { get; set; }

    public string? TmsIkmDaireNo { get; set; }

    public string? TmsIkmPostaKodu { get; set; }

    public string? TmsIkmIlce { get; set; }

    public string? TmsIkmIl { get; set; }

    public string? TmsIkmUlke { get; set; }

    public string? TmsIkmAdresKodu { get; set; }

    public string? TmsNufCiltno { get; set; }

    public string? TmsNufSayfano { get; set; }

    public string? TmsNufKutukno { get; set; }

    public string? TmsNufIl { get; set; }

    public string? TmsTnbSifre { get; set; }

    public DateTime? TmsSozlesmeTarihi { get; set; }

    public string? TmsSozlesmeNo { get; set; }

    public string? TmsSozlesmeAciklama { get; set; }

    public bool? TmsTnbKullanFl { get; set; }

    public byte? TmsTnbKimlikTipi { get; set; }

    public string? TmsTurmobKey { get; set; }
}
