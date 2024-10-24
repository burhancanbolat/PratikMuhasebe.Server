using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokFiyatDegisiklikleri
{
    public Guid FidGuid { get; set; }

    public short FidDbcno { get; set; }

    public int? FidSpecRecNo { get; set; }

    public bool? FidIptal { get; set; }

    public short? FidFileid { get; set; }

    public bool? FidHidden { get; set; }

    public bool? FidKilitli { get; set; }

    public bool? FidDegisti { get; set; }

    public int? FidChecksum { get; set; }

    public short? FidCreateUser { get; set; }

    public DateTime FidCreateDate { get; set; }

    public short? FidLastupUser { get; set; }

    public DateTime? FidLastupDate { get; set; }

    public string? FidSpecial1 { get; set; }

    public string? FidSpecial2 { get; set; }

    public string? FidSpecial3 { get; set; }

    public int? FidEvrakSatirNo { get; set; }

    public string? FidEvrakSeriNo { get; set; }

    public int? FidEvrakSiraNo { get; set; }

    public DateTime? FidEvrakTarih { get; set; }

    public string? FidBelgeNo { get; set; }

    public DateTime? FidBelgeTarih { get; set; }

    public string? FidStokKod { get; set; }

    public DateTime? FidTarih { get; set; }

    public byte? FidSaat { get; set; }

    public byte? FidFiyatDegNeden { get; set; }

    public int? FidFiyatNo { get; set; }

    public double? FidEskifiyTutar { get; set; }

    public byte? FidEskifiyDoviz { get; set; }

    public string? FidEskifiyIskonto { get; set; }

    public int? FidEskifiyOpno { get; set; }

    public double? FidYenifiyTutar { get; set; }

    public byte? FidYenifiyDoviz { get; set; }

    public string? FidYenifiyIskonto { get; set; }

    public int? FidYenifiyOpno { get; set; }

    public byte? FidYapildiFl { get; set; }

    public double? FidEskiKarorani { get; set; }

    public double? FidYeniKarorani { get; set; }

    public int? FidDepoNo { get; set; }

    public Guid? FidProfUid { get; set; }

    public byte? FidBirimPntr { get; set; }
}
