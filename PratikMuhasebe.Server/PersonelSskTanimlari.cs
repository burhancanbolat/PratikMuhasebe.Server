using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSskTanimlari
{
    public Guid SskGuid { get; set; }

    public short SskDbcno { get; set; }

    public int? SskSpecRecno { get; set; }

    public bool? SskIptal { get; set; }

    public short? SskFileid { get; set; }

    public bool? SskHidden { get; set; }

    public bool? SskKilitli { get; set; }

    public bool? SskDegisti { get; set; }

    public int? SskChecksum { get; set; }

    public short? SskCreateUser { get; set; }

    public DateTime SskCreateDate { get; set; }

    public short? SskLastupUser { get; set; }

    public DateTime? SskLastupDate { get; set; }

    public string? SskSpecial1 { get; set; }

    public string? SskSpecial2 { get; set; }

    public string? SskSpecial3 { get; set; }

    public int? SskSiraNo { get; set; }

    public string? SskIsmi { get; set; }

    public byte? SskTehlikeDerecesi { get; set; }

    public double? SskKazaYuzdesi { get; set; }

    public string? SskSubekodu { get; set; }

    public string? SskBolCalDosNo { get; set; }

    public string? SskCadde { get; set; }

    public string? SskMahalle { get; set; }

    public string? SskSokak { get; set; }

    public string? SskAdrSemt { get; set; }

    public string? SskAptNo { get; set; }

    public string? SskDaireNo { get; set; }

    public string? SskPostaKodu { get; set; }

    public string? SskIlce { get; set; }

    public string? SskIl { get; set; }

    public string? SskUlke { get; set; }

    public string? SskAdresKodu { get; set; }

    public byte? SskIysinifi { get; set; }

    public string? SskIykapino { get; set; }

    public string? SskMaasbankakodu { get; set; }

    public string? SskSsknoMahiyet { get; set; }

    public string? SskSsknoIskolu { get; set; }

    public string? SskSsknoSubeKodu { get; set; }

    public string? SskSsknoTehlikeKodu { get; set; }

    public string? SskSsknoSiraNo { get; set; }

    public string? SskSsknoIlKodu { get; set; }

    public string? SskSsknoIlce { get; set; }

    public string? SskSsknoKontrolNo { get; set; }

    public string? SskAraciKodu { get; set; }

    public string? SskBolgeMudurlukNo { get; set; }

    public Guid? SskIskurUid { get; set; }

    public string? SskSemt { get; set; }

    public double? SskNSskYuzde { get; set; }

    public double? SskESskYuzde { get; set; }

    public double? SskCSskYuzde { get; set; }

    public double? SskYSskYuzde { get; set; }

    public double? SskAnaSig { get; set; }

    public double? SskNHastSig { get; set; }

    public double? SskCHastSig { get; set; }

    public double? SskYasOlSig { get; set; }

    public double? SskSgdpOrani { get; set; }

    public string? SskCalismaKodu { get; set; }

    public string? SskFirmaUnvani { get; set; }

    public string? SskFirmaUnvani2 { get; set; }

    public string? SskEbildirgeUsername { get; set; }

    public string? SskEbildirgeIsyerikod { get; set; }

    public string? SskEbildirgePassword { get; set; }

    public string? SskEbildirgeIsyerisifre { get; set; }

    public double? SskYasolumItibarihizmet { get; set; }

    public byte? SskIsverentipi { get; set; }

    public double? SskGenelSaglikSigortasi { get; set; }

    public double? SskMalullukMuafiyet { get; set; }

    public byte? Ssk5225belgeTuru { get; set; }

    public DateTime? Ssk5225belgeTarihi { get; set; }

    public string? Ssk5225belgeSayisi { get; set; }

    public DateTime? SskGvk80belgeTarih { get; set; }

    public string? SskGvk80belgeNo { get; set; }

    public byte? SskIskolukodu { get; set; }

    public byte? SskIskolukoduNew { get; set; }

    public bool? SskPasifFl { get; set; }

    public DateTime? SskAcilisTarihi { get; set; }

    public DateTime? SskKapanisTarihi { get; set; }

    public string? SskMuhtasarisyeriAdi { get; set; }

    public byte? SskMuhtasarisyeriTuru { get; set; }

    public string? SskMuhtasarisyeriKodu { get; set; }

    public byte? SskMuhtasarisyeriMulkiyet { get; set; }

    public string? SskTicaretSicilNo { get; set; }

    public string? SskTicaretSicilMudurlugu { get; set; }

    public string? SskNaceKodu { get; set; }

    public int? SskFirmaNo { get; set; }

    public int? SskSubeNo { get; set; }

    public double? SskGeciciMadde17GunlukDestek { get; set; }

    public bool? SskMuhsgkDegerlendirilmesinFl { get; set; }

    public int? SskKbsTesiskodu { get; set; }

    public double? SskDulkeIscipayiUstdilimi { get; set; }

    public double? SskDulkeIscipayiUstorani { get; set; }

    public double? SskIssizlikSigortasiPersonelPayi { get; set; }

    public double? SskIssizlikSigortasiIsverenPayi { get; set; }

    public short? SskTeknokentBolge { get; set; }

    public string? SskVergiDaire { get; set; }
}
