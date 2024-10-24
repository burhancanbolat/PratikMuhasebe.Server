using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ZimmetHareketleri
{
    public Guid ZmhGuid { get; set; }

    public short ZmhDbcno { get; set; }

    public int? ZmhSpecRecno { get; set; }

    public bool? ZmhIptal { get; set; }

    public short? ZmhFileid { get; set; }

    public bool? ZmhHidden { get; set; }

    public bool? ZmhKilitli { get; set; }

    public bool? ZmhDegisti { get; set; }

    public int? ZmhChecksum { get; set; }

    public short? ZmhCreateUser { get; set; }

    public DateTime ZmhCreateDate { get; set; }

    public short? ZmhLastupUser { get; set; }

    public DateTime? ZmhLastupDate { get; set; }

    public string? ZmhSpecial1 { get; set; }

    public string? ZmhSpecial2 { get; set; }

    public string? ZmhSpecial3 { get; set; }

    public int? ZmhFirmano { get; set; }

    public int? ZmhSubeno { get; set; }

    public DateTime? ZmhTarihi { get; set; }

    public string? ZmhEvraknoSeri { get; set; }

    public int? ZmhEvraknoSira { get; set; }

    public int? ZmhSatirno { get; set; }

    public string? ZmhBelgeno { get; set; }

    public DateTime? ZmhBelgeTarihi { get; set; }

    public string? ZmhDemirbasKodu { get; set; }

    public string? ZmhZimmetAlanPerKodu { get; set; }

    public string? ZmhZimmetVerenPerKodu { get; set; }

    public string? ZmhCikisZimmetYeri { get; set; }

    public string? ZmhGirisZimmetYeri { get; set; }

    public double? ZmhMiktar { get; set; }

    public DateTime? ZmhZimmettenDusmeTarihi { get; set; }

    public byte? ZmhDurumu { get; set; }

    public string? ZmhAciklama { get; set; }

    public string? ZmhSatirAciklama { get; set; }

    public string? ZmhSorumlulukMerkezi { get; set; }

    public string? ZmhProjeKodu { get; set; }
}
