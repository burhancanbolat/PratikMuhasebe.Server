using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MuhasebeFisleri
{
    public Guid FisGuid { get; set; }

    public short FisDbcno { get; set; }

    public int? FisSpecRecno { get; set; }

    public bool? FisIptal { get; set; }

    public short? FisFileid { get; set; }

    public bool? FisHidden { get; set; }

    public bool? FisKilitli { get; set; }

    public bool? FisDegisti { get; set; }

    public int? FisChecksum { get; set; }

    public short? FisCreateUser { get; set; }

    public DateTime FisCreateDate { get; set; }

    public short? FisLastupUser { get; set; }

    public DateTime? FisLastupDate { get; set; }

    public string? FisSpecial1 { get; set; }

    public string? FisSpecial2 { get; set; }

    public string? FisSpecial3 { get; set; }

    public int? FisFirmano { get; set; }

    public int? FisSubeno { get; set; }

    public int? FisMaliyil { get; set; }

    public DateTime? FisTarih { get; set; }

    public int? FisSiraNo { get; set; }

    public byte? FisTur { get; set; }

    public string? FisHesapKod { get; set; }

    public int? FisSatirNo { get; set; }

    public string? FisAciklama1 { get; set; }

    public double? FisMeblag0 { get; set; }

    public double? FisMeblag1 { get; set; }

    public double? FisMeblag2 { get; set; }

    public double? FisMeblag3 { get; set; }

    public double? FisMeblag4 { get; set; }

    public double? FisMeblag5 { get; set; }

    public double? FisMeblag6 { get; set; }

    public string? FisSorumlulukKodu { get; set; }

    public byte? FisTicariTip { get; set; }

    public Guid? FisTicariUid { get; set; }

    public bool? FisKurfarkifl { get; set; }

    public byte? FisTicariEvraktip { get; set; }

    public string? FisTicEvrakSeri { get; set; }

    public int? FisTicEvrakSira { get; set; }

    public string? FisTicBelgeno { get; set; }

    public DateTime? FisTicBelgetarihi { get; set; }

    public int? FisYevmiyeNo { get; set; }

    public short? FisKatagori { get; set; }

    public short? FisEvrakDbcno { get; set; }

    public byte? FisFmahsupTipi { get; set; }

    public string? FisFozelmahkod { get; set; }

    public string? FisGrupkodu { get; set; }

    public byte? FisAktifPasif { get; set; }

    public string? FisProjeKodu { get; set; }

    public string? FisHareketGrupKodu1 { get; set; }

    public string? FisHareketGrupKodu2 { get; set; }

    public string? FisHareketGrupKodu3 { get; set; }

    public string? FisTicariHubid { get; set; }

    public string? FisTicariHubglbid { get; set; }

    public string? FisTicariDisyazilimid { get; set; }

    public byte? FisTicariDisyazilimTip { get; set; }
}
