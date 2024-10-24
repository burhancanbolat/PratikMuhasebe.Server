using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ServisIsemirleri
{
    public Guid SisGuid { get; set; }

    public short SisDbcno { get; set; }

    public int? SisSpecRecno { get; set; }

    public bool? SisIptal { get; set; }

    public short? SisFileid { get; set; }

    public bool? SisHidden { get; set; }

    public bool? SisKilitli { get; set; }

    public bool? SisDegisti { get; set; }

    public int? SisCheckSum { get; set; }

    public short? SisCreateUser { get; set; }

    public DateTime SisCreateDate { get; set; }

    public short? SisLastupUser { get; set; }

    public DateTime? SisLastupDate { get; set; }

    public string? SisSpecial1 { get; set; }

    public string? SisSpecial2 { get; set; }

    public string? SisSpecial3 { get; set; }

    public int? SisFirmano { get; set; }

    public int? SisSubeno { get; set; }

    public string? SisKodu { get; set; }

    public string? SisAdi { get; set; }

    public DateTime? SisTarih { get; set; }

    public string? SisTuketiciKodu { get; set; }

    public string? SisCihazSerino { get; set; }

    public string? SisStokKodu { get; set; }

    public DateTime? SisServisTarihi { get; set; }

    public DateTime? SisServisBitisTarihi { get; set; }

    public string? SisYetkili { get; set; }

    public byte? SisServisYeri { get; set; }

    public byte? SisServisTuru { get; set; }

    public byte? SisIstekGelisSekli { get; set; }

    public DateTime? SisIsemriKapanisTarihi { get; set; }

    public byte? SisArizaTespitiYapanTipi { get; set; }

    public string? SisArizaTespitiYapanEkip { get; set; }

    public byte? SisIseAtananTipi { get; set; }

    public string? SisIseAtananEkip { get; set; }

    public byte? SisIsiYapanTipi { get; set; }

    public string? SisIsiYapanEkip { get; set; }

    public byte? SisIsemriDurumu { get; set; }

    public string? SisBakimKabulEvrakSeri { get; set; }

    public int? SisBakimKabulEvrakSira { get; set; }

    public DateTime? SisIncelemedeTarihi { get; set; }

    public DateTime? SisOnayBekliyorTarihi { get; set; }

    public DateTime? SisOnaylandiTarihi { get; set; }

    public DateTime? SisServiseAlindiTarihi { get; set; }

    public DateTime? SisTamamlandiTarihi { get; set; }

    public DateTime? SisKapatildiTarihi { get; set; }

    public DateTime? SisIptalEdildiTarihi { get; set; }

    public string? SisIncelemedeAciklama { get; set; }

    public string? SisOnayBekliyorAciklama { get; set; }

    public string? SisOnaylandiAciklama { get; set; }

    public string? SisServiseAlindiAciklama { get; set; }

    public string? SisTamamlandiAciklama { get; set; }

    public string? SisKapatildiAciklama { get; set; }

    public string? SisIptalEdildiAciklama { get; set; }

    public string? SisIsemriIptalNedeni { get; set; }

    public string? SisAciklama1 { get; set; }

    public string? SisAciklama2 { get; set; }

    public string? SisAciklama3 { get; set; }

    public string? SisArizaKodu1 { get; set; }

    public string? SisArizaKodu2 { get; set; }

    public string? SisArizaKodu3 { get; set; }

    public string? SisArizaKodu4 { get; set; }

    public string? SisArizaKodu5 { get; set; }

    public string? SisArizaKodu6 { get; set; }

    public string? SisArizaKodu7 { get; set; }

    public string? SisArizaKodu8 { get; set; }

    public string? SisArizaKodu9 { get; set; }

    public string? SisArizaKodu10 { get; set; }

    public int? SisKiralamadanDusulecekSure { get; set; }

    public int? SisKiralamadanDusulenSure { get; set; }

    public byte? SisServisIslemTuru { get; set; }

    public byte? SisKaynakEvrakTipi { get; set; }

    public Guid? SisKtlpUid { get; set; }

    public int? SisAdresNo { get; set; }
}
