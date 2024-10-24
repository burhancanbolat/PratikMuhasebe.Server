using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UfrsCariHareketDegerleri
{
    public Guid UchdGuid { get; set; }

    public short UchdDbcno { get; set; }

    public int? UchdSpecRecno { get; set; }

    public bool? UchdIptal { get; set; }

    public short? UchdFileid { get; set; }

    public bool? UchdHidden { get; set; }

    public bool? UchdKilitli { get; set; }

    public bool? UchdDegisti { get; set; }

    public int? UchdChecksum { get; set; }

    public short? UchdCreateUser { get; set; }

    public DateTime UchdCreateDate { get; set; }

    public short? UchdLastupUser { get; set; }

    public DateTime? UchdLastupDate { get; set; }

    public string? UchdSpecial1 { get; set; }

    public string? UchdSpecial2 { get; set; }

    public string? UchdSpecial3 { get; set; }

    public Guid? UchdBagliharUid { get; set; }

    public double? UchdAratoplam { get; set; }

    public double? UchdMeblag { get; set; }

    public double? UchdIskonto1 { get; set; }

    public double? UchdIskonto2 { get; set; }

    public double? UchdIskonto3 { get; set; }

    public double? UchdIskonto4 { get; set; }

    public double? UchdIskonto5 { get; set; }

    public double? UchdIskonto6 { get; set; }

    public double? UchdMasraf1 { get; set; }

    public double? UchdMasraf2 { get; set; }

    public double? UchdMasraf3 { get; set; }

    public double? UchdMasraf4 { get; set; }

    public double? UchdDegerfarki { get; set; }

    public bool? UchdEntegreOlmasinFl { get; set; }
}
