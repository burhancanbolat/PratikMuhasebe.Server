using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PromosyonHareketleri
{
    public Guid PrhGuid { get; set; }

    public short PrhDbcno { get; set; }

    public int? PrhSpecRecNo { get; set; }

    public bool? PrhIptal { get; set; }

    public short? PrhFileid { get; set; }

    public bool? PrhHidden { get; set; }

    public bool? PrhKilitli { get; set; }

    public bool? PrhDegisti { get; set; }

    public int? PrhChecksum { get; set; }

    public short? PrhCreateUser { get; set; }

    public DateTime PrhCreateDate { get; set; }

    public short? PrhLastupUser { get; set; }

    public DateTime? PrhLastupDate { get; set; }

    public string? PrhSpecial1 { get; set; }

    public string? PrhSpecial2 { get; set; }

    public string? PrhSpecial3 { get; set; }

    public int? PrhFirmano { get; set; }

    public int? PrhSubeno { get; set; }

    public string? PrhPromoKodu { get; set; }

    public byte? PrhEvrakKaynak { get; set; }

    public byte? PrhSthEvraktip { get; set; }

    public byte? PrhEvrakCins { get; set; }

    public string? PrhSthEvraknoSeri { get; set; }

    public int? PrhSthEvraknoSira { get; set; }

    public int? PrhSthSatirno { get; set; }

    public byte? PrhUrunCinsi { get; set; }

    public string? PrhStokKodu { get; set; }

    public string? PrhCariKodu { get; set; }

    public DateTime? PrhTarih { get; set; }

    public string? PrhPlasiyerKodu { get; set; }

    public double? PrhMiktar { get; set; }

    public double? PrhTutar { get; set; }

    public double? PrhYansiyanPromoTutari { get; set; }

    public short? PrhPromosyonTipi { get; set; }

    public short? PrhUygulamaTipi { get; set; }
}
