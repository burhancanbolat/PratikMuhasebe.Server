using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ServisHareketleri
{
    public Guid SrvhGuid { get; set; }

    public short SrvhDbcno { get; set; }

    public int? SrvhSpecRecno { get; set; }

    public bool? SrvhIptal { get; set; }

    public short? SrvhFileid { get; set; }

    public bool? SrvhHidden { get; set; }

    public bool? SrvhKilitli { get; set; }

    public bool? SrvhDegisti { get; set; }

    public int? SrvhCheckSum { get; set; }

    public short? SrvhCreateUser { get; set; }

    public DateTime SrvhCreateDate { get; set; }

    public short? SrvhLastupUser { get; set; }

    public DateTime? SrvhLastupDate { get; set; }

    public string? SrvhSpecial1 { get; set; }

    public string? SrvhSpecial2 { get; set; }

    public string? SrvhSpecial3 { get; set; }

    public int? SrvhFirmano { get; set; }

    public int? SrvhSubeno { get; set; }

    public string? SrvhEvraknoSeri { get; set; }

    public int? SrvhEvraknoSira { get; set; }

    public string? SrvhBelgeno { get; set; }

    public DateTime? SrvhBelgeTarih { get; set; }

    public Guid? SrvhIsemriUid { get; set; }

    public string? SrvhReferansNo { get; set; }

    public DateTime? SrvhTarih { get; set; }

    public Guid? SrvhYetkiliUid { get; set; }

    public int? SrvhCalismaSaati { get; set; }

    public string? SrvhYapilanIslemler1 { get; set; }

    public string? SrvhYapilanIslemler2 { get; set; }

    public string? SrvhYapilanIslemler3 { get; set; }

    public DateTime? SrvhBaslamaSaati { get; set; }

    public DateTime? SrvhBitisSaati { get; set; }

    public string? SrvhAracPlaka { get; set; }

    public double? SrvhToplamYol { get; set; }

    public int? SrvhSatirno { get; set; }

    public byte? SrvhHareketTipi { get; set; }

    public string? SrvhStokHizmetKodu { get; set; }

    public string? SrvhAciklama { get; set; }

    public double? SrvhMiktari { get; set; }

    public byte? SrvhFaturaGarantiTipi { get; set; }

    public byte? SrvhDurumu { get; set; }

    public int? SrvhDepoNo { get; set; }

    public string? SrvhSormerk { get; set; }

    public string? SrvhProjekodu { get; set; }

    public byte? SrvhDovizCinsi { get; set; }

    public byte? SrvhSipTip { get; set; }

    public Guid? SrvhSipUid { get; set; }

    public byte? SrvhChzMakTipi { get; set; }

    public byte? SrvhArizaTespitiYapanTipi { get; set; }

    public string? SrvhArizaTespitiYapanEkip { get; set; }

    public byte? SrvhIseAtananTipi { get; set; }

    public string? SrvhIseAtananEkip { get; set; }

    public byte? SrvhIsiYapanTipi { get; set; }

    public string? SrvhIsiYapanEkip { get; set; }

    public double? SrvhCihazSayacDegeri { get; set; }

    public string? SrvhArizaKodu1 { get; set; }

    public string? SrvhArizaKodu2 { get; set; }

    public string? SrvhArizaKodu3 { get; set; }

    public string? SrvhArizaKodu4 { get; set; }

    public string? SrvhArizaKodu5 { get; set; }

    public string? SrvhArizaKodu6 { get; set; }

    public string? SrvhArizaKodu7 { get; set; }

    public string? SrvhArizaKodu8 { get; set; }

    public string? SrvhArizaKodu9 { get; set; }

    public string? SrvhArizaKodu10 { get; set; }
}
