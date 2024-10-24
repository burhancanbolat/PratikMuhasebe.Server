using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OnayliEvraklar
{
    public Guid OeGuid { get; set; }

    public short OeDbcno { get; set; }

    public int? OeSpecRecno { get; set; }

    public bool? OeIptal { get; set; }

    public short? OeFileid { get; set; }

    public bool? OeHidden { get; set; }

    public bool? OeKilitli { get; set; }

    public bool? OeDegisti { get; set; }

    public int? OeChecksum { get; set; }

    public short? OeCreateUser { get; set; }

    public DateTime OeCreateDate { get; set; }

    public short? OeLastupUser { get; set; }

    public DateTime? OeLastupDate { get; set; }

    public string? OeSpecial1 { get; set; }

    public string? OeSpecial2 { get; set; }

    public string? OeSpecial3 { get; set; }

    public short? OeTabloNo { get; set; }

    public int? OeFirmaNo { get; set; }

    public byte? OeEvrakTip { get; set; }

    public byte? OeCinsTip { get; set; }

    public string? OeEvrakSeri { get; set; }

    public int? OeEvrakSira { get; set; }

    public string? OeEvrakKodu { get; set; }

    public int? OeOnaylayan1 { get; set; }

    public DateTime? OeOnaylamaTarihi1 { get; set; }

    public string? OeOnayAciklamasi11 { get; set; }

    public string? OeOnayAciklamasi21 { get; set; }

    public double? OeKullaniciLimiti1 { get; set; }

    public byte? OeKullaniciYetkiTipi1 { get; set; }

    public double? OeEvrakYekun1 { get; set; }

    public int? OeOnaylayan2 { get; set; }

    public DateTime? OeOnaylamaTarihi2 { get; set; }

    public string? OeOnayAciklamasi12 { get; set; }

    public string? OeOnayAciklamasi22 { get; set; }

    public double? OeKullaniciLimiti2 { get; set; }

    public byte? OeKullaniciYetkiTipi2 { get; set; }

    public double? OeEvrakYekun2 { get; set; }

    public int? OeOnaylayan3 { get; set; }

    public DateTime? OeOnaylamaTarihi3 { get; set; }

    public string? OeOnayAciklamasi13 { get; set; }

    public string? OeOnayAciklamasi23 { get; set; }

    public double? OeKullaniciLimiti3 { get; set; }

    public byte? OeKullaniciYetkiTipi3 { get; set; }

    public double? OeEvrakYekun3 { get; set; }

    public int? OeOnaylayan4 { get; set; }

    public DateTime? OeOnaylamaTarihi4 { get; set; }

    public string? OeOnayAciklamasi14 { get; set; }

    public string? OeOnayAciklamasi24 { get; set; }

    public double? OeKullaniciLimiti4 { get; set; }

    public byte? OeKullaniciYetkiTipi4 { get; set; }

    public double? OeEvrakYekun4 { get; set; }

    public int? OeOnaylayan5 { get; set; }

    public DateTime? OeOnaylamaTarihi5 { get; set; }

    public string? OeOnayAciklamasi15 { get; set; }

    public string? OeOnayAciklamasi25 { get; set; }

    public double? OeKullaniciLimiti5 { get; set; }

    public byte? OeKullaniciYetkiTipi5 { get; set; }

    public double? OeEvrakYekun5 { get; set; }

    public bool? OeOnayTamamlandiFl { get; set; }

    public Guid? OeKaynakUid { get; set; }
}
