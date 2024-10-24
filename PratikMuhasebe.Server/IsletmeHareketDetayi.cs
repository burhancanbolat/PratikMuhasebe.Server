using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsletmeHareketDetayi
{
    public Guid DtfisGuid { get; set; }

    public short DtfisDbcno { get; set; }

    public int? DtfisSpecRecno { get; set; }

    public bool? DtfisIptal { get; set; }

    public short? DtfisFileid { get; set; }

    public bool? DtfisHidden { get; set; }

    public bool? DtfisKilitli { get; set; }

    public bool? DtfisDegisti { get; set; }

    public int? DtfisChecksum { get; set; }

    public short? DtfisCreateUser { get; set; }

    public DateTime DtfisCreateDate { get; set; }

    public short? DtfisLastupUser { get; set; }

    public DateTime? DtfisLastupDate { get; set; }

    public string? DtfisSpecial1 { get; set; }

    public string? DtfisSpecial2 { get; set; }

    public string? DtfisSpecial3 { get; set; }

    public Guid? DtfisHarUid { get; set; }

    public int? DtfisSatirno { get; set; }

    public string? DtfisStokIsmi { get; set; }

    public string? DtfisAciklama { get; set; }

    public double? DtfisMiktar { get; set; }

    public double? DtfisTutar { get; set; }
}
