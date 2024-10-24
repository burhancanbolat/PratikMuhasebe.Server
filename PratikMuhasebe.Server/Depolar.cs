using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Depolar
{
    public Guid DepGuid { get; set; }

    public short DepDbcno { get; set; }

    public int? DepSpecRecno { get; set; }

    public bool? DepIptal { get; set; }

    public short? DepFileid { get; set; }

    public bool? DepHidden { get; set; }

    public bool? DepKilitli { get; set; }

    public bool? DepDegisti { get; set; }

    public int? DepChecksum { get; set; }

    public short? DepCreateUser { get; set; }

    public DateTime DepCreateDate { get; set; }

    public short? DepLastupUser { get; set; }

    public DateTime? DepLastupDate { get; set; }

    public string? DepSpecial1 { get; set; }

    public string? DepSpecial2 { get; set; }

    public string? DepSpecial3 { get; set; }

    public int? DepFirmano { get; set; }

    public int? DepSubeno { get; set; }

    public int? DepNo { get; set; }

    public string? DepAdi { get; set; }

    public string? DepGrupKodu { get; set; }

    public byte? DepTipi { get; set; }

    public byte? DepDepoSevkOtoFiyat { get; set; }

    public byte? DepHareketTipi { get; set; }

    public string? DepMuhKodu { get; set; }

    public string? DepSorMerKodu { get; set; }

    public string? DepProjeKodu { get; set; }

    public int? DepDepoSevkUygFiyat { get; set; }

    public DateTime? DepKilitTarihi { get; set; }

    public string? DepCadde { get; set; }

    public string? DepMahalle { get; set; }

    public string? DepSokak { get; set; }

    public string? DepSemt { get; set; }

    public string? DepAptNo { get; set; }

    public string? DepDaireNo { get; set; }

    public string? DepPostaKodu { get; set; }

    public string? DepIlce { get; set; }

    public string? DepIl { get; set; }

    public string? DepUlke { get; set; }

    public string? DepAdresKodu { get; set; }

    public double? DepGpsEnlem { get; set; }

    public double? DepGpsBoylam { get; set; }

    public double? DepAlani { get; set; }

    public double? DepRafhacmi { get; set; }

    public string? DepYetkiliEmail { get; set; }

    public double? DepSatisAlani { get; set; }

    public double? DepSergiAlani { get; set; }

    public double? DepOtoparkAlani { get; set; }

    public int? DepOtoparkKapasite { get; set; }

    public int? DepKasaSayisi { get; set; }

    public double? DepKamyonKasaHacmi { get; set; }

    public double? DepKamyonIstiabHaddi { get; set; }

    public string? DepDizinAdi { get; set; }

    public string? DepTelUlkeKodu { get; set; }

    public string? DepTelBolgeKodu { get; set; }

    public string? DepTelNo1 { get; set; }

    public string? DepTelNo2 { get; set; }

    public string? DepTelFaxno { get; set; }

    public string? DepTelModem { get; set; }

    public bool? DepEnvanterHariciFl { get; set; }

    public byte? DepDetayTakibi { get; set; }

    public string? DepBarkodYaziciYolu { get; set; }

    public string? DepFasonSorMerKodu { get; set; }

    public byte? DepEksiyeDusurenStkHar { get; set; }

    public byte? DepBagliOrtakliklaraSatisUygFiyat { get; set; }

    public string? DepBolgeKodu { get; set; }

    public byte? DepNakliyefisiSatisFiyatTipi { get; set; }

    public bool? DepGidisteEirsaliyeFl { get; set; }

    public bool? DepGelisteEirsaliyeFl { get; set; }

    public bool? DepFytdegfisKullanilmazFl { get; set; }

    public byte? DepSeribagDetayTakibi { get; set; }
}
