using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Firmalar
{
    public Guid FirGuid { get; set; }

    public short FirDbcno { get; set; }

    public int? FirSpecRecno { get; set; }

    public bool? FirIptal { get; set; }

    public short? FirFileid { get; set; }

    public bool? FirHidden { get; set; }

    public bool? FirKilitli { get; set; }

    public bool? FirDegisti { get; set; }

    public int? FirChecksum { get; set; }

    public short? FirCreateUser { get; set; }

    public DateTime FirCreateDate { get; set; }

    public short? FirLastupUser { get; set; }

    public DateTime? FirLastupDate { get; set; }

    public string? FirSpecial1 { get; set; }

    public string? FirSpecial2 { get; set; }

    public string? FirSpecial3 { get; set; }

    public int? FirSirano { get; set; }

    public string? FirUnvan { get; set; }

    public string? FirUnvan2 { get; set; }

    public string? FirTckimlik { get; set; }

    public string? FirYazisma { get; set; }

    public string? FirBordro { get; set; }

    public string? FirFhesapNo { get; set; }

    public string? FirFvergiDaire { get; set; }

    public string? FirFvergiNo { get; set; }

    public string? FirFbolgeNo { get; set; }

    public bool? FirMuhtasar { get; set; }

    public bool? FirIsci { get; set; }

    public DateTime? FirBasTar { get; set; }

    public string? FirIstigal { get; set; }

    public bool? FirDefter { get; set; }

    public string? FirTicSicilNo { get; set; }

    public bool? FirIslIzn1 { get; set; }

    public bool? FirIslIzn2 { get; set; }

    public bool? FirIslIzn3 { get; set; }

    public bool? FirIslIzn4 { get; set; }

    public bool? FirIslIzn5 { get; set; }

    public bool? FirIslIzn6 { get; set; }

    public bool? FirIslIzn7 { get; set; }

    public bool? FirIslIzn8 { get; set; }

    public bool? FirIslIzn9 { get; set; }

    public bool? FirIslIzn10 { get; set; }

    public bool? FirIslIzn11 { get; set; }

    public bool? FirIslIzn12 { get; set; }

    public bool? FirIslIzn13 { get; set; }

    public bool? FirIslIzn14 { get; set; }

    public bool? FirIslIzn15 { get; set; }

    public byte? FirSmmEntegrasyon { get; set; }

    public byte? FirMaliMusFirmasi { get; set; }

    public string? FirIsoNo { get; set; }

    public string? FirMaasBankaKod { get; set; }

    public DateTime? FirBaslangicTarihi { get; set; }

    public bool? FirOtvdenMuaf { get; set; }

    public double? FirKrediriskyuzde1 { get; set; }

    public byte? FirKrediriskneolacak1 { get; set; }

    public byte? FirKredirisklimityuzde1hesap { get; set; }

    public double? FirKredirisklimityuzde1 { get; set; }

    public byte? FirKredirisklimittipi1 { get; set; }

    public double? FirKrediriskyuzde2 { get; set; }

    public byte? FirKrediriskneolacak2 { get; set; }

    public byte? FirKredirisklimityuzde2hesap { get; set; }

    public double? FirKredirisklimityuzde2 { get; set; }

    public byte? FirKredirisklimittipi2 { get; set; }

    public double? FirKrediriskyuzde3 { get; set; }

    public byte? FirKrediriskneolacak3 { get; set; }

    public byte? FirKredirisklimityuzde3hesap { get; set; }

    public double? FirKredirisklimityuzde3 { get; set; }

    public byte? FirKredirisklimittipi3 { get; set; }

    public double? FirKrediriskyuzde4 { get; set; }

    public byte? FirKrediriskneolacak4 { get; set; }

    public byte? FirKredirisklimityuzde4hesap { get; set; }

    public double? FirKredirisklimityuzde4 { get; set; }

    public byte? FirKredirisklimittipi4 { get; set; }

    public double? FirKrediriskyuzde5 { get; set; }

    public byte? FirKrediriskneolacak5 { get; set; }

    public byte? FirKredirisklimityuzde5hesap { get; set; }

    public double? FirKredirisklimityuzde5 { get; set; }

    public byte? FirKredirisklimittipi5 { get; set; }

    public double? FirKrediriskyuzde6 { get; set; }

    public byte? FirKrediriskneolacak6 { get; set; }

    public byte? FirKredirisklimityuzde6hesap { get; set; }

    public double? FirKredirisklimityuzde6 { get; set; }

    public byte? FirKredirisklimittipi6 { get; set; }

    public double? FirKrediriskyuzde7 { get; set; }

    public byte? FirKrediriskneolacak7 { get; set; }

    public byte? FirKredirisklimityuzde7hesap { get; set; }

    public double? FirKredirisklimityuzde7 { get; set; }

    public byte? FirKredirisklimittipi7 { get; set; }

    public double? FirKrediriskyuzde8 { get; set; }

    public byte? FirKrediriskneolacak8 { get; set; }

    public byte? FirKredirisklimityuzde8hesap { get; set; }

    public double? FirKredirisklimityuzde8 { get; set; }

    public byte? FirKredirisklimittipi8 { get; set; }

    public double? FirKrediriskyuzde9 { get; set; }

    public byte? FirKrediriskneolacak9 { get; set; }

    public byte? FirKredirisklimityuzde9hesap { get; set; }

    public double? FirKredirisklimityuzde9 { get; set; }

    public byte? FirKredirisklimittipi9 { get; set; }

    public double? FirKrediriskyuzde10 { get; set; }

    public byte? FirKrediriskneolacak10 { get; set; }

    public byte? FirKredirisklimityuzde10hesap { get; set; }

    public double? FirKredirisklimityuzde10 { get; set; }

    public byte? FirKredirisklimittipi10 { get; set; }

    public string? FirDefKasakodu { get; set; }

    public byte? FirIsletmetipi { get; set; }

    public string? FirIsletmefaliyetturu { get; set; }

    public bool? FirKdvucaylik { get; set; }

    public string? FirEanKodu { get; set; }

    public byte? FirMukellefiyet { get; set; }

    public string? FirKanKabEdGiderKodu { get; set; }

    public string? FirWebSayfasi { get; set; }

    public string? FirWebKullaniciAdi { get; set; }

    public string? FirWebKullaniciSifresi { get; set; }

    public string? FirWebMusteriNo { get; set; }

    public bool? FirOivdenMuaf { get; set; }

    public string? FirMaassistemikodu { get; set; }

    public string? FirGenelEmail { get; set; }

    public string? FirNaceKodu { get; set; }

    public string? FirMaliMuhurSifre { get; set; }

    public int? FirZamanDamgasiKullanici { get; set; }

    public string? FirZamanDamgasiSifre { get; set; }

    public string? FirEdefterSubeAdi { get; set; }

    public int? FirEdefterSubeNo { get; set; }

    public DateTime? FirEdefterBaslangic { get; set; }

    public int? FirEdefterMaxBoyut { get; set; }

    public byte? FirEdefterDovizTipi { get; set; }

    public byte? FirEdefterAktifGrup { get; set; }

    public string? FirTuikIsyerikayitno { get; set; }

    public DateTime? FirEfaturaBaslangic { get; set; }

    public DateTime? FirEarsivBaslangic { get; set; }

    public string? FirKepAdresi { get; set; }

    public string? FirTicaretSicilMudurlugu { get; set; }

    public string? FirEdefterSmmKodu { get; set; }

    public string? FirEdefterYmmKodu { get; set; }

    public string? FirEdefterNaceKodu { get; set; }

    public DateTime? FirTasfiyeTarihi { get; set; }

    public string? FirMuhasebeYetkilisi { get; set; }

    public string? FirEdefterYetkilisi { get; set; }

    public byte? FirMaliMuhurTipi { get; set; }

    public string? FirMaliMuhurSurucusu { get; set; }

    public bool? FirEdefterSubeDefteriMi { get; set; }

    public string? FirMikroWebServisKodu { get; set; }

    public string? FirUyelikHopiFirmaKodu { get; set; }

    public string? FirUyelikHopiKullanici { get; set; }

    public string? FirUyelikHopiSifre { get; set; }

    public bool? FirTasfiyeHaliFirmasiMi { get; set; }

    public string? FirSmtpHost { get; set; }

    public int? FirSmtpPort { get; set; }

    public bool? FirSmtpEnableSsl { get; set; }

    public string? FirSmtpUsername { get; set; }

    public string? FirSmtpSifre { get; set; }

    public byte? FirBaslangicTarihiTipi { get; set; }

    public byte? FirBitisTarihiTipi { get; set; }

    public byte? FirVergiDetayTipi { get; set; }

    public string? FirSmmdefterBeyanApiKey { get; set; }

    public string? FirSmmdefterBeyanApiSecret { get; set; }

    public byte? FirDefterBeyanTipi { get; set; }

    public bool? FirUtssisteminekayitlimi { get; set; }

    public string? FirUtskurumno { get; set; }

    public string? FirTescilNoktasi { get; set; }

    public DateTime? FirDefBeyAmorDefBaslangic { get; set; }

    public DateTime? FirDefBeyStokDefBaslangic { get; set; }

    public byte? FirEbasvuruTakipSayfaNo { get; set; }

    public bool? FirPosetucaylik { get; set; }

    public byte? FirEdefterSaklamaSorguDurumu { get; set; }

    public bool? FirIkportalEntegrasyonFl { get; set; }

    public string? FirIkuser { get; set; }

    public string? FirIkpassword { get; set; }

    public bool? FirTurizmucaylik { get; set; }

    public bool? FirEdefterucaylik { get; set; }

    public int? FirIdmId { get; set; }

    public bool? FirMuhsgk1003bFl { get; set; }

    public DateTime? FirEMustahsilBaslangic { get; set; }

    public DateTime? FirESmmmBaslangic { get; set; }

    public DateTime? FirEirsaliyeBaslangic { get; set; }

    public int? FirParasutFirmaid { get; set; }

    public string? FirParasutUsername { get; set; }

    public string? FirParasutPassword { get; set; }

    public DateTime? FirSinyalTarihi { get; set; }

    public string? FirTakepUsername { get; set; }

    public string? FirTakepPassword { get; set; }

    public string? FirEarsivportalKullaniciadi { get; set; }

    public string? FirEarsivportalSifre { get; set; }

    public byte? FirDefterbeyanVersiyon { get; set; }

    public bool? FirEdefterOtomatikGibyedekFl { get; set; }

    public string? FirEdefterOtomatikGibklasor { get; set; }
}
