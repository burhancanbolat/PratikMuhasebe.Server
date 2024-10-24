using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ZiyaretHareketleri
{
    public Guid ZyrtGuid { get; set; }

    public short ZyrtDbcno { get; set; }

    public int? ZyrtSpecRecNo { get; set; }

    public bool? ZyrtIptal { get; set; }

    public short? ZyrtFileid { get; set; }

    public bool? ZyrtHidden { get; set; }

    public bool? ZyrtKilitli { get; set; }

    public bool? ZyrtDegisti { get; set; }

    public int? ZyrtChecksum { get; set; }

    public short? ZyrtCreateUser { get; set; }

    public DateTime ZyrtCreateDate { get; set; }

    public short? ZyrtLastupUser { get; set; }

    public DateTime? ZyrtLastupDate { get; set; }

    public string? ZyrtSpecial1 { get; set; }

    public string? ZyrtSpecial2 { get; set; }

    public string? ZyrtSpecial3 { get; set; }

    public int? ZyrtFirmano { get; set; }

    public int? ZyrtSubeno { get; set; }

    public DateTime? ZyrtBasZamani { get; set; }

    public DateTime? ZyrtBitZamani { get; set; }

    public string? ZyrtCariKodu { get; set; }

    public string? ZyrtPersonelKodu { get; set; }

    public bool? ZyrtTamamlandiFl { get; set; }

    public int? ZyrtAdresNo { get; set; }

    public string? ZyrtYetkiliIsmi { get; set; }

    public string? ZyrtAciklama { get; set; }

    public string? ZyrtKodu { get; set; }

    public string? ZyrtSorMrkKodu { get; set; }

    public string? ZyrtProjeKodu { get; set; }

    public string? ZyrtBkmEvrakSeri { get; set; }

    public int? ZyrtBkmEvrakSira { get; set; }
}
