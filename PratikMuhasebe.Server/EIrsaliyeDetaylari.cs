using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EIrsaliyeDetaylari
{
    public Guid EirGuid { get; set; }

    public short EirDbcno { get; set; }

    public int? EirSpecRecno { get; set; }

    public bool? EirIptal { get; set; }

    public short? EirFileid { get; set; }

    public bool? EirHidden { get; set; }

    public bool? EirKilitli { get; set; }

    public bool? EirDegisti { get; set; }

    public int? EirChecksum { get; set; }

    public short? EirCreateUser { get; set; }

    public DateTime? EirCreateDate { get; set; }

    public short? EirLastupUser { get; set; }

    public DateTime? EirLastupDate { get; set; }

    public string? EirSpecial1 { get; set; }

    public string? EirSpecial2 { get; set; }

    public string? EirSpecial3 { get; set; }

    public int? EirFirmaNo { get; set; }

    public byte? EirEvrakTip { get; set; }

    public byte? EirTipi { get; set; }

    public string? EirEvraknoSeri { get; set; }

    public int? EirEvraknoSira { get; set; }

    public string? EirGibSeri { get; set; }

    public int? EirGibSira { get; set; }

    public byte? EirPozisyon { get; set; }

    public string? EirUuid { get; set; }

    public string? EirMVkn { get; set; }

    public string? EirTasiyiciFirmaKodu { get; set; }

    public Guid? EirSoforUid { get; set; }

    public Guid? EirSofor2Uid { get; set; }

    public string? EirTasiyiciAracPlaka { get; set; }

    public string? EirTasiyiciDorsePlaka1 { get; set; }

    public string? EirTasiyiciDorsePlaka2 { get; set; }

    public byte? EirStokKonsinye { get; set; }

    public string? EirToptanciFirmaKodu { get; set; }

    public string? EirBayiFirmaKodu { get; set; }

    public string? EirSoforAdi { get; set; }

    public string? EirSoforSoyadi { get; set; }

    public string? EirSofor2Adi { get; set; }

    public string? EirSofor2Soyadi { get; set; }

    public string? EirMatbuBelgeno { get; set; }

    public DateTime? EirMatbuTarih { get; set; }

    public string? EirSoforTckn { get; set; }

    public string? EirSofor2Tckn { get; set; }

    public byte? EirEirsOlrkGonderilsin { get; set; }

    public string? EirKargoNo { get; set; }

    public string? EirAsamaNo { get; set; }

    public string? EirTasimaYontemi { get; set; }

    public string? EirAracTipi { get; set; }

    public string? EirGuzergahKodu { get; set; }

    public string? EirDetayBilgi { get; set; }

    public DateTime? EirBaslamaZamani { get; set; }

    public DateTime? EirBitisZamani { get; set; }

    public byte? EirNormalIade { get; set; }

    public byte? EirTip { get; set; }

    public bool? EirGonderildiFl { get; set; }

    public short? EirGonderenKulNo { get; set; }

    public DateTime? EirGonderimTarihi { get; set; }
}
