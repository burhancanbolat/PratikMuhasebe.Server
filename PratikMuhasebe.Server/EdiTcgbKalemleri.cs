using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EdiTcgbKalemleri
{
    public Guid EstGuid { get; set; }

    public short EstDbcno { get; set; }

    public int? EstSpecRecno { get; set; }

    public bool? EstIptal { get; set; }

    public short? EstFileid { get; set; }

    public bool? EstHidden { get; set; }

    public bool? EstKilitli { get; set; }

    public bool? EstDegisti { get; set; }

    public int? EstChecksum { get; set; }

    public short? EstCreateUser { get; set; }

    public DateTime EstCreateDate { get; set; }

    public short? EstLastupUser { get; set; }

    public DateTime? EstLastupDate { get; set; }

    public string? EstSpecial1 { get; set; }

    public string? EstSpecial2 { get; set; }

    public string? EstSpecial3 { get; set; }

    public Guid? EstHarUid { get; set; }

    public string? EstKalemkodu { get; set; }

    public string? EstOlcukod { get; set; }

    public string? EstKapcinsi { get; set; }

    public string? EstKapnumarasi { get; set; }

    public double? EstKapadedi { get; set; }

    public string? EstKapmarkasi { get; set; }

    public int? EstOdemeadresi { get; set; }

    public string? EstImalatci { get; set; }

    public string? EstMuafiyetkod1 { get; set; }

    public string? EstMuafiyetref1 { get; set; }

    public string? EstMuafiyetaciklama1 { get; set; }

    public string? EstMuafiyetkod2 { get; set; }

    public string? EstMuafiyetref2 { get; set; }

    public string? EstMuafiyetaciklama2 { get; set; }

    public string? EstMuafiyetkod3 { get; set; }

    public string? EstMuafiyetref3 { get; set; }

    public string? EstMuafiyetaciklama3 { get; set; }

    public short? EstEkbelkod1 { get; set; }

    public string? EstEkbelreferansno1 { get; set; }

    public string? EstEkbelaciklama1 { get; set; }

    public short? EstEkbelkod2 { get; set; }

    public string? EstEkbelreferansno2 { get; set; }

    public string? EstEkbelaciklama2 { get; set; }

    public short? EstEkbelkod3 { get; set; }

    public string? EstEkbelreferansno3 { get; set; }

    public string? EstEkbelaciklama3 { get; set; }

    public short? EstEkbelkod4 { get; set; }

    public string? EstEkbelreferansno4 { get; set; }

    public string? EstEkbelaciklama4 { get; set; }

    public short? EstEkbelkod5 { get; set; }

    public string? EstEkbelreferansno5 { get; set; }

    public string? EstEkbelaciklama5 { get; set; }

    public bool? EstDogrulama1 { get; set; }

    public bool? EstDogrulama2 { get; set; }

    public bool? EstDogrulama3 { get; set; }

    public bool? EstDogrulama4 { get; set; }

    public bool? EstDogrulama5 { get; set; }

    public bool? EstDogrulama6 { get; set; }

    public bool? EstDogrulama7 { get; set; }

    public bool? EstDogrulama8 { get; set; }

    public string? EstKotakodu { get; set; }

    public string? EstEkkod { get; set; }

    public double? EstIstatislikkiymet { get; set; }

    public short? EstEbirlikambalajkod { get; set; }

    public string? EstEbirlikIplikkodu { get; set; }

    public bool? EstBedelsiz { get; set; }

    public string? EstBeyannameno { get; set; }

    public DateTime? EstBeyannametarihi { get; set; }

    public string? EstBeyannameSirano { get; set; }

    public byte? EstHarekettipi { get; set; }
}
