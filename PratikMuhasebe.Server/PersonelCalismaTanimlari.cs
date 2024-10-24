using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelCalismaTanimlari
{
    public Guid PcGuid { get; set; }

    public short PcDbcno { get; set; }

    public int? PcSpecRecno { get; set; }

    public bool? PcIptal { get; set; }

    public short? PcFileid { get; set; }

    public bool? PcHidden { get; set; }

    public bool? PcKilitli { get; set; }

    public bool? PcDegisti { get; set; }

    public int? PcChecksum { get; set; }

    public short? PcCreateUser { get; set; }

    public DateTime PcCreateDate { get; set; }

    public short? PcLastupUser { get; set; }

    public DateTime? PcLastupDate { get; set; }

    public string? PcSpecial1 { get; set; }

    public string? PcSpecial2 { get; set; }

    public string? PcSpecial3 { get; set; }

    public string? PcKodu { get; set; }

    public string? PcIsmi { get; set; }

    public byte? PcDovizCinsi { get; set; }

    public double? PcGunCalisSaat { get; set; }

    public bool? PcIkrAylari1 { get; set; }

    public bool? PcIkrAylari2 { get; set; }

    public bool? PcIkrAylari3 { get; set; }

    public bool? PcIkrAylari4 { get; set; }

    public bool? PcIkrAylari5 { get; set; }

    public bool? PcIkrAylari6 { get; set; }

    public bool? PcIkrAylari7 { get; set; }

    public bool? PcIkrAylari8 { get; set; }

    public bool? PcIkrAylari9 { get; set; }

    public bool? PcIkrAylari10 { get; set; }

    public bool? PcIkrAylari11 { get; set; }

    public bool? PcIkrAylari12 { get; set; }

    public bool? PcYakAylari1 { get; set; }

    public bool? PcYakAylari2 { get; set; }

    public bool? PcYakAylari3 { get; set; }

    public bool? PcYakAylari4 { get; set; }

    public bool? PcYakAylari5 { get; set; }

    public bool? PcYakAylari6 { get; set; }

    public bool? PcYakAylari7 { get; set; }

    public bool? PcYakAylari8 { get; set; }

    public bool? PcYakAylari9 { get; set; }

    public bool? PcYakAylari10 { get; set; }

    public bool? PcYakAylari11 { get; set; }

    public bool? PcYakAylari12 { get; set; }

    public bool? PcBayAylari1 { get; set; }

    public bool? PcBayAylari2 { get; set; }

    public bool? PcBayAylari3 { get; set; }

    public bool? PcBayAylari4 { get; set; }

    public bool? PcBayAylari5 { get; set; }

    public bool? PcBayAylari6 { get; set; }

    public bool? PcBayAylari7 { get; set; }

    public bool? PcBayAylari8 { get; set; }

    public bool? PcBayAylari9 { get; set; }

    public bool? PcBayAylari10 { get; set; }

    public bool? PcBayAylari11 { get; set; }

    public bool? PcBayAylari12 { get; set; }

    public double? PcIkrYuzde { get; set; }

    public byte? PcIkrHesapSekli { get; set; }

    public bool? PcIkrKesAt { get; set; }

    public short? PcOngIzinGunu0 { get; set; }

    public short? PcOngIzinGunu1 { get; set; }

    public short? PcOngIzinGunu2 { get; set; }

    public short? PcOngIzinGunu3 { get; set; }

    public short? PcOngIzinGunu4 { get; set; }

    public double? PcAvMaasOran { get; set; }

    public byte? PcAvHesapSekli { get; set; }

    public short? PcSinyorityAltSinirGunu1 { get; set; }

    public short? PcSinyorityUstSinirGunu1 { get; set; }

    public double? PcSinyorityOran1 { get; set; }

    public short? PcSinyorityAltSinirGunu2 { get; set; }

    public short? PcSinyorityUstSinirGunu2 { get; set; }

    public double? PcSinyorityOran2 { get; set; }

    public short? PcSinyorityAltSinirGunu3 { get; set; }

    public short? PcSinyorityUstSinirGunu3 { get; set; }

    public double? PcSinyorityOran3 { get; set; }

    public short? PcSinyorityAltSinirGunu4 { get; set; }

    public short? PcSinyorityUstSinirGunu4 { get; set; }

    public double? PcSinyorityOran4 { get; set; }

    public short? PcSinyorityAltSinirGunu5 { get; set; }

    public short? PcSinyorityUstSinirGunu5 { get; set; }

    public double? PcSinyorityOran5 { get; set; }

    public short? PcIzinParaHakedisGun { get; set; }

    public double? PcIzinParaOrani { get; set; }

    public short? PcIzinParaKacGunSonraOdeme { get; set; }

    public bool? PcCocukEgitimYardimiBir { get; set; }

    public bool? PcIkramiyeKazancHesabi30gun { get; set; }

    public string? PcVardiyaTakvim { get; set; }

    public short? PcOngYillikIzinGunu { get; set; }

    public short? PcOngUcretliIzinGunu { get; set; }

    public short? PcOngHastalikIzinGunu { get; set; }

    public short? PcOngAskerlikIzinGunu { get; set; }

    public short? PcOngZorunlulukIzinGunu { get; set; }

    public short? PcOngDevamsizlikIzinGunu { get; set; }

    public short? PcOngAravermeIzinGunu { get; set; }

    public short? PcOngDigerIzinGunu { get; set; }

    public short? PcOngUcretsizIzinGunu { get; set; }

    public short? PcOngSuaIzinGunu { get; set; }

    public short? PcOngEvlilikIzinGunu { get; set; }

    public short? PcOngDogumIzinGunu { get; set; }

    public short? PcOngBabalikIzinGunu { get; set; }

    public short? PcOngSutIzinGunu { get; set; }

    public short? PcOngOlumIzinGunu { get; set; }

    public short? PcOngIsAramaIzinGunu { get; set; }

    public bool? PcDksPuantajaAktarilmasin { get; set; }

    public byte? PcDksPuantajHesaplamaSekli { get; set; }

    public byte? PcDksToplamIseEkKazancNo { get; set; }

    public double? PcYarimIsGunuCalismaSaati { get; set; }

    public double? PcHastalikOran0 { get; set; }

    public double? PcHastalikOran1 { get; set; }

    public double? PcHastalikOran2 { get; set; }

    public double? PcHastalikOran3 { get; set; }

    public byte? PcIzinHesaplamaSekli { get; set; }

    public byte? PcHastalikHesaplamaSekli { get; set; }

    public double? PcIkramiyeAyindaTaksitArtisOrani { get; set; }

    public double? PcDamgaVergisiOrani { get; set; }

    public byte? PcKazancHesabi { get; set; }

    public byte? PcEkkazancHesabi { get; set; }

    public byte? PcSosyalYardimHesabi { get; set; }

    public byte? PcAktarimdaEksikGunIzin { get; set; }

    public byte? PcAktarimdaEksikGunIzinTip { get; set; }

    public bool? PcTatilgunuPazar { get; set; }

    public bool? PcTatilgunuPazartesi { get; set; }

    public bool? PcTatilgunuSali { get; set; }

    public bool? PcTatilgunuCarsamba { get; set; }

    public bool? PcTatilgunuPersembe { get; set; }

    public bool? PcTatilgunuCuma { get; set; }

    public bool? PcTatilgunuCumartesi { get; set; }
}
