using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OperasyonMaliyetDetaylari
{
    public Guid MknGuid { get; set; }

    public short MknDbcno { get; set; }

    public int? MknSpecRecno { get; set; }

    public bool? MknIptal { get; set; }

    public short? MknFileid { get; set; }

    public bool? MknHidden { get; set; }

    public bool? MknKilitli { get; set; }

    public bool? MknDegisti { get; set; }

    public int? MknChecksum { get; set; }

    public short? MknCreateUser { get; set; }

    public DateTime MknCreateDate { get; set; }

    public short? MknLastupUser { get; set; }

    public DateTime? MknLastupDate { get; set; }

    public string? MknSpecial1 { get; set; }

    public string? MknSpecial2 { get; set; }

    public string? MknSpecial3 { get; set; }

    public string? MknHesapKodu { get; set; }

    public string? MknSrmMerkezi { get; set; }

    public byte? MknDagitimSekli { get; set; }

    public double? MknDagitilanAnahtar { get; set; }

    public double? MknDagitilanMaliyetAna { get; set; }

    public double? MknDagitilanMaliyetAlt { get; set; }

    public double? MknDagitilanMaliyetOrj { get; set; }

    public Guid? MknOptamamUid { get; set; }

    public byte? MknMasrafNereye { get; set; }
}
