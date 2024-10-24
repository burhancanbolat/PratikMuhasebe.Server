using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ProformaFiyatDegisiklikleri
{
    public Guid PrfdGuid { get; set; }

    public short PrfdDbcno { get; set; }

    public int? PrfdSpecRecNo { get; set; }

    public bool? PrfdIptal { get; set; }

    public short? PrfdFileid { get; set; }

    public bool? PrfdHidden { get; set; }

    public bool? PrfdKilitli { get; set; }

    public bool? PrfdDegisti { get; set; }

    public int? PrfdChecksum { get; set; }

    public short? PrfdCreateUser { get; set; }

    public DateTime PrfdCreateDate { get; set; }

    public short? PrfdLastupUser { get; set; }

    public DateTime? PrfdLastupDate { get; set; }

    public string? PrfdSpecial1 { get; set; }

    public string? PrfdSpecial2 { get; set; }

    public string? PrfdSpecial3 { get; set; }

    public int? PrfdEvrakSatirNo { get; set; }

    public string? PrfdEvrakSeriNo { get; set; }

    public int? PrfdEvrakSiraNo { get; set; }

    public DateTime? PrfdEvrakTarih { get; set; }

    public string? PrfdBelgeNo { get; set; }

    public DateTime? PrfdBelgeTarih { get; set; }

    public string? PrfdStokKod { get; set; }

    public DateTime? PrfdTarih { get; set; }

    public byte? PrfdSaat { get; set; }

    public byte? PrfdFiyatDegNeden { get; set; }

    public int? PrfdFiyatNo { get; set; }

    public double? PrfdEskifiyTutar { get; set; }

    public byte? PrfdEskifiyDoviz { get; set; }

    public string? PrfdEskifiyIskonto { get; set; }

    public int? PrfdEskifiyOpno { get; set; }

    public double? PrfdYenifiyTutar { get; set; }

    public byte? PrfdYenifiyDoviz { get; set; }

    public string? PrfdYenifiyIskonto { get; set; }

    public int? PrfdYenifiyOpno { get; set; }

    public double? PrfdEskiKarorani { get; set; }

    public double? PrfdYeniKarorani { get; set; }

    public int? PrfdDepoNo { get; set; }

    public byte? PrfdOnaylayanKulNo { get; set; }

    public bool? PrfdCagrilabilirFl { get; set; }

    public bool? PrfdKapatFl { get; set; }

    public double? PrfdOncekifiyTutar { get; set; }

    public byte? PrfdOncekifiyDoviz { get; set; }

    public string? PrfdOncekifiyIskonto { get; set; }

    public int? PrfdOncekifiyOpno { get; set; }

    public string? PrfdKapatmanedenkod { get; set; }

    public byte? PrfdBirimPntr { get; set; }
}
