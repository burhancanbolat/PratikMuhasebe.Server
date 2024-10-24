using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelIsBasvurulari
{
    public Guid BasGuid { get; set; }

    public short BasDbcno { get; set; }

    public int? BasSpecRecno { get; set; }

    public bool? BasIptal { get; set; }

    public short? BasFileid { get; set; }

    public bool? BasHidden { get; set; }

    public bool? BasKilitli { get; set; }

    public bool? BasDegisti { get; set; }

    public int? BasChecksum { get; set; }

    public short? BasCreateUser { get; set; }

    public DateTime BasCreateDate { get; set; }

    public short? BasLastupUser { get; set; }

    public DateTime? BasLastupDate { get; set; }

    public string? BasSpecial1 { get; set; }

    public string? BasSpecial2 { get; set; }

    public string? BasSpecial3 { get; set; }

    public string? BasKodu { get; set; }

    public string? BasAdi { get; set; }

    public string? BasSoyadi { get; set; }

    public DateTime? BasTarih { get; set; }

    public byte? BasCinsiyet { get; set; }

    public byte? BasMedeniHal { get; set; }

    public DateTime? BasDogumTarih { get; set; }

    public string? BasDogumYer { get; set; }

    public byte? BasTahsilTipi { get; set; }

    public byte? BasAskerlik { get; set; }

    public byte? BasTecil { get; set; }

    public byte? BasEhliyet { get; set; }

    public string? BasHobi { get; set; }

    public string? BasEkbilgi { get; set; }

    public string? BasUlasCadde { get; set; }

    public string? BasUlasMahalle { get; set; }

    public string? BasUlasSokak { get; set; }

    public string? BasUlasSemt { get; set; }

    public string? BasUlasAptNo { get; set; }

    public string? BasUlasDaireNo { get; set; }

    public string? BasUlasPostaKod { get; set; }

    public string? BasUlasIlce { get; set; }

    public string? BasUlasIl { get; set; }

    public string? BasUlasUlke { get; set; }

    public string? BasUlasAdresKodu { get; set; }

    public string? BasUlasTel1UlkeKod { get; set; }

    public string? BasUlasTel1BolgeKod { get; set; }

    public string? BasUlasTel1No { get; set; }

    public string? BasUlasTel2UlkeKod { get; set; }

    public string? BasUlasTel2BolgeKod { get; set; }

    public string? BasUlasTel2No { get; set; }

    public string? BasUlasFaxUlkeKod { get; set; }

    public string? BasUlasFaxBolgeKod { get; set; }

    public string? BasUlasFaxNo { get; set; }

    public string? BasUlasMail { get; set; }

    public byte? BasOkul1Tipi { get; set; }

    public string? BasOkul1Kodu { get; set; }

    public string? BasOkul1Adi { get; set; }

    public string? BasOkul1BolumKodu { get; set; }

    public string? BasOkul1Bolumu { get; set; }

    public short? BasOkul1Mezyil { get; set; }

    public double? BasOkul1Derece { get; set; }

    public byte? BasOkul2Tipi { get; set; }

    public string? BasOkul2Kodu { get; set; }

    public string? BasOkul2Adi { get; set; }

    public string? BasOkul2BolumKodu { get; set; }

    public string? BasOkul2Bolumu { get; set; }

    public short? BasOkul2Mezyil { get; set; }

    public double? BasOkul2Derece { get; set; }

    public byte? BasOkul3Tipi { get; set; }

    public string? BasOkul3Kodu { get; set; }

    public string? BasOkul3Adi { get; set; }

    public string? BasOkul3BolumKodu { get; set; }

    public string? BasOkul3Bolumu { get; set; }

    public short? BasOkul3Mezyil { get; set; }

    public double? BasOkul3Derece { get; set; }

    public byte? BasOkul4Tipi { get; set; }

    public string? BasOkul4Kodu { get; set; }

    public string? BasOkul4Adi { get; set; }

    public string? BasOkul4BolumKodu { get; set; }

    public string? BasOkul4Bolumu { get; set; }

    public short? BasOkul4Mezyil { get; set; }

    public double? BasOkul4Derece { get; set; }

    public byte? BasOkul5Tipi { get; set; }

    public string? BasOkul5Kodu { get; set; }

    public string? BasOkul5Adi { get; set; }

    public string? BasOkul5BolumKodu { get; set; }

    public string? BasOkul5Bolumu { get; set; }

    public short? BasOkul5Mezyil { get; set; }

    public double? BasOkul5Derece { get; set; }

    public byte? BasOkul6Tipi { get; set; }

    public string? BasOkul6Kodu { get; set; }

    public string? BasOkul6Adi { get; set; }

    public string? BasOkul6BolumKodu { get; set; }

    public string? BasOkul6Bolumu { get; set; }

    public short? BasOkul6Mezyil { get; set; }

    public double? BasOkul6Derece { get; set; }

    public byte? BasDil1Tipi { get; set; }

    public byte? BasDil1Seviye { get; set; }

    public byte? BasDil1Konusma { get; set; }

    public byte? BasDil2Tipi { get; set; }

    public byte? BasDil2Seviye { get; set; }

    public byte? BasDil2Konusma { get; set; }

    public byte? BasDil3Tipi { get; set; }

    public byte? BasDil3Seviye { get; set; }

    public byte? BasDil3Konusma { get; set; }

    public byte? BasDil4Tipi { get; set; }

    public byte? BasDil4Seviye { get; set; }

    public byte? BasDil4Konusma { get; set; }

    public byte? BasDil5Tipi { get; set; }

    public byte? BasDil5Seviye { get; set; }

    public byte? BasDil5Konusma { get; set; }

    public string? BasKurs1Konusu { get; set; }

    public string? BasKurs1Kurumu { get; set; }

    public short? BasKurs1Yil { get; set; }

    public string? BasKurs1Aciklama { get; set; }

    public string? BasKurs1EgitimKodu { get; set; }

    public bool? BasKurs1SertifikaFl { get; set; }

    public string? BasKurs2Konusu { get; set; }

    public string? BasKurs2Kurumu { get; set; }

    public short? BasKurs2Yil { get; set; }

    public string? BasKurs2Aciklama { get; set; }

    public string? BasKurs2EgitimKodu { get; set; }

    public bool? BasKurs2SertifikaFl { get; set; }

    public string? BasKurs3Konusu { get; set; }

    public string? BasKurs3Kurumu { get; set; }

    public short? BasKurs3Yil { get; set; }

    public string? BasKurs3Aciklama { get; set; }

    public string? BasKurs3EgitimKodu { get; set; }

    public bool? BasKurs3SertifikaFl { get; set; }

    public string? BasKurs4Konusu { get; set; }

    public string? BasKurs4Kurumu { get; set; }

    public short? BasKurs4Yil { get; set; }

    public string? BasKurs4Aciklama { get; set; }

    public string? BasKurs4EgitimKodu { get; set; }

    public bool? BasKurs4SertifikaFl { get; set; }

    public string? BasKurs5Konusu { get; set; }

    public string? BasKurs5Kurumu { get; set; }

    public short? BasKurs5Yil { get; set; }

    public string? BasKurs5Aciklama { get; set; }

    public string? BasKurs5EgitimKodu { get; set; }

    public bool? BasKurs5SertifikaFl { get; set; }

    public string? BasSirk1Adi { get; set; }

    public string? BasSirk1Gorevi { get; set; }

    public DateTime? BasSirk1Girisyil { get; set; }

    public DateTime? BasSirk1Cikisyil { get; set; }

    public string? BasSirk1Cikissebebi { get; set; }

    public double? BasSirk1Ucret { get; set; }

    public byte? BasSirk1Cikissebepsecimli { get; set; }

    public string? BasSirk2Adi { get; set; }

    public string? BasSirk2Gorevi { get; set; }

    public DateTime? BasSirk2Girisyil { get; set; }

    public DateTime? BasSirk2Cikisyil { get; set; }

    public string? BasSirk2Cikissebebi { get; set; }

    public double? BasSirk2Ucret { get; set; }

    public byte? BasSirk2Cikissebepsecimli { get; set; }

    public string? BasSirk3Adi { get; set; }

    public string? BasSirk3Gorevi { get; set; }

    public DateTime? BasSirk3Girisyil { get; set; }

    public DateTime? BasSirk3Cikisyil { get; set; }

    public string? BasSirk3Cikissebebi { get; set; }

    public double? BasSirk3Ucret { get; set; }

    public byte? BasSirk3Cikissebepsecimli { get; set; }

    public string? BasSirk4Adi { get; set; }

    public string? BasSirk4Gorevi { get; set; }

    public DateTime? BasSirk4Girisyil { get; set; }

    public DateTime? BasSirk4Cikisyil { get; set; }

    public string? BasSirk4Cikissebebi { get; set; }

    public double? BasSirk4Ucret { get; set; }

    public byte? BasSirk4Cikissebepsecimli { get; set; }

    public string? BasSirk5Adi { get; set; }

    public string? BasSirk5Gorevi { get; set; }

    public DateTime? BasSirk5Girisyil { get; set; }

    public DateTime? BasSirk5Cikisyil { get; set; }

    public string? BasSirk5Cikissebebi { get; set; }

    public double? BasSirk5Ucret { get; set; }

    public byte? BasSirk5Cikissebepsecimli { get; set; }

    public string? BasRefr1Adi { get; set; }

    public string? BasRefr1Meslek { get; set; }

    public string? BasRefr1Iletisim { get; set; }

    public string? BasRefr2Adi { get; set; }

    public string? BasRefr2Meslek { get; set; }

    public string? BasRefr2Iletisim { get; set; }

    public string? BasRefr3Adi { get; set; }

    public string? BasRefr3Meslek { get; set; }

    public string? BasRefr3Iletisim { get; set; }

    public string? BasRefr4Adi { get; set; }

    public string? BasRefr4Meslek { get; set; }

    public string? BasRefr4Iletisim { get; set; }

    public string? BasRefr5Adi { get; set; }

    public string? BasRefr5Meslek { get; set; }

    public string? BasRefr5Iletisim { get; set; }

    public string? BasRefr6Adi { get; set; }

    public string? BasRefr6Meslek { get; set; }

    public string? BasRefr6Iletisim { get; set; }

    public string? BasRefr7Adi { get; set; }

    public string? BasRefr7Meslek { get; set; }

    public string? BasRefr7Iletisim { get; set; }

    public string? BasRefr8Adi { get; set; }

    public string? BasRefr8Meslek { get; set; }

    public string? BasRefr8Iletisim { get; set; }

    public string? BasRefr9Adi { get; set; }

    public string? BasRefr9Meslek { get; set; }

    public string? BasRefr9Iletisim { get; set; }

    public string? BasRefr10Adi { get; set; }

    public string? BasRefr10Meslek { get; set; }

    public string? BasRefr10Iletisim { get; set; }

    public string? BasBvis1Depkodu { get; set; }

    public string? BasBvis1Gorkodu { get; set; }

    public string? BasBvis1Aciklama { get; set; }

    public string? BasBvis1Kadrokodu { get; set; }

    public string? BasBvis1Isilankodu { get; set; }

    public string? BasBvis2Depkodu { get; set; }

    public string? BasBvis2Gorkodu { get; set; }

    public string? BasBvis2Aciklama { get; set; }

    public string? BasBvis2Kadrokodu { get; set; }

    public string? BasBvis2Isilankodu { get; set; }

    public string? BasBvis3Depkodu { get; set; }

    public string? BasBvis3Gorkodu { get; set; }

    public string? BasBvis3Aciklama { get; set; }

    public string? BasBvis3Kadrokodu { get; set; }

    public string? BasBvis3Isilankodu { get; set; }

    public string? BasBvis4Depkodu { get; set; }

    public string? BasBvis4Gorkodu { get; set; }

    public string? BasBvis4Aciklama { get; set; }

    public string? BasBvis4Kadrokodu { get; set; }

    public string? BasBvis4Isilankodu { get; set; }

    public double? BasUcretTalep { get; set; }

    public byte? BasUcretTalepDoviz { get; set; }

    public byte? BasUcretTalepTip { get; set; }

    public byte? BasUcretTalepBrutnet { get; set; }

    public double? BasUcretOneri { get; set; }

    public byte? BasUcretOneriDoviz { get; set; }

    public byte? BasUcretOneriTip { get; set; }

    public byte? BasUcretOneriBrutnet { get; set; }

    public byte? BasDurum { get; set; }

    public string? BasIskurno { get; set; }

    public bool? BasOzurlu { get; set; }

    public byte? BasOzurderecesi { get; set; }

    public byte? BasOzurgrubu { get; set; }

    public byte? BasSigortagrubu { get; set; }

    public byte? BasKapsam { get; set; }

    public string? BasPerskodu { get; set; }

    public string? BasTckimlikno { get; set; }

    public string? BasNitelik1Kodu { get; set; }

    public string? BasNitelik2Kodu { get; set; }

    public string? BasNitelik3Kodu { get; set; }

    public string? BasNitelik4Kodu { get; set; }

    public string? BasNitelik5Kodu { get; set; }

    public string? BasNitelik6Kodu { get; set; }

    public string? BasNitelik7Kodu { get; set; }

    public string? BasNitelik8Kodu { get; set; }

    public string? BasNitelik9Kodu { get; set; }

    public string? BasNitelik10Kodu { get; set; }

    public Guid? BasTalepUid { get; set; }

    public string? BasKabulIsilankodu { get; set; }

    public bool? BasSigaraFl { get; set; }
}
