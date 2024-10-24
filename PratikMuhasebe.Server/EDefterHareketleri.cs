using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EDefterHareketleri
{
    public Guid EdefterGuid { get; set; }

    public short EdefterDbcno { get; set; }

    public int? EdefterSpecRecNo { get; set; }

    public bool? EdefterIptal { get; set; }

    public short? EdefterFileid { get; set; }

    public bool? EdefterHidden { get; set; }

    public bool? EdefterKilitli { get; set; }

    public bool? EdefterDegisti { get; set; }

    public int? EdefterChecksum { get; set; }

    public short? EdefterCreateUser { get; set; }

    public DateTime EdefterCreateDate { get; set; }

    public short? EdefterLastupUser { get; set; }

    public DateTime? EdefterLastupDate { get; set; }

    public string? EdefterSpecial1 { get; set; }

    public string? EdefterSpecial2 { get; set; }

    public string? EdefterSpecial3 { get; set; }

    public int? EdefterFirmano { get; set; }

    public int? EdefterMaliyil { get; set; }

    public int? EdefterMalidonem { get; set; }

    public int? EdefterDonemsirano { get; set; }

    public int? EdefterMaliyilsirano { get; set; }

    public byte? EdefterDosyalamaperiyodu { get; set; }

    public byte? EdefterAktifgrup { get; set; }

    public string? EdefterAciklama { get; set; }

    public bool? EdefterZamandamgasifl { get; set; }

    public DateTime? EdefterIlktarih { get; set; }

    public DateTime? EdefterSontarih { get; set; }

    public int? EdefterIlkyevmiye { get; set; }

    public int? EdefterSonyevmiye { get; set; }

    public double? EdefterDosyaboyutu { get; set; }

    public bool? EdefterOlusturuldu { get; set; }

    public bool? EdefterOnayliberatalindi { get; set; }

    public byte? EdefterOlusturulsun { get; set; }

    public int? EdefterIlkmuteselsilno { get; set; }

    public int? EdefterSonmuteselsilno { get; set; }

    public string? EdefterSubeAdi { get; set; }

    public int? EdefterSubeNo { get; set; }

    public byte? EdefterDovizTipi { get; set; }

    public string? EdefterGibYevDurumKod { get; set; }

    public string? EdefterGibYevDurumAciklama { get; set; }

    public string? EdefterGibKebDurumKod { get; set; }

    public string? EdefterGibKebDurumAciklama { get; set; }

    public bool? EdefterMyeYevYuklendi { get; set; }

    public bool? EdefterMyeKebYuklendi { get; set; }

    public bool? EdefterMyeYevBeratYuklendi { get; set; }

    public bool? EdefterMyeKebBeratYuklendi { get; set; }

    public bool? EdefterMyeYevGibBeratYuklendi { get; set; }

    public bool? EdefterMyeKebGibBeratYuklendi { get; set; }

    public double? EdefterBorcToplam { get; set; }

    public double? EdefterAlacakToplam { get; set; }

    public string? EdefterYevmiyeHash { get; set; }

    public string? EdefterYevmiyeZipHash { get; set; }

    public string? EdefterYevmiyeBeratHash { get; set; }

    public string? EdefterYevmiyeBeratZipHash { get; set; }

    public string? EdefterKebirHash { get; set; }

    public string? EdefterKebirZipHash { get; set; }

    public string? EdefterKebirBeratHash { get; set; }

    public string? EdefterKebirBeratZipHash { get; set; }

    public byte? EdefterMaliyilBaslangicAyi { get; set; }

    public bool? EdefterMaliyilTakvimBitisyili { get; set; }

    public byte? EdefterMaliyilBaslangicGunu { get; set; }

    public Guid? EdefterYevmiyeBeratUid { get; set; }

    public Guid? EdefterKebirBeratUid { get; set; }

    public string? EdefterGibRapDurumKod { get; set; }

    public string? EdefterGibRapDurumAciklama { get; set; }

    public bool? EdefterMyeRaporBeratYuklendi { get; set; }

    public string? EdefterRaporBeratHash { get; set; }

    public string? EdefterRaporBeratZipHash { get; set; }

    public Guid? EdefterRaporBeratId { get; set; }

    public bool? EdefterGibbildYevYuklendi { get; set; }

    public bool? EdefterGibbildKebYuklendi { get; set; }

    public bool? EdefterGibbildYevBeratYuklendi { get; set; }

    public bool? EdefterGibbildKebBeratYuklendi { get; set; }

    public bool? EdefterGibbildYevGibBeratYuklendi { get; set; }

    public bool? EdefterGibbildKebGibBeratYuklendi { get; set; }

    public bool? EdefterGibbildRaporBeratYuklendi { get; set; }
}
