using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UfrsStokHareketDegerleri
{
    public Guid UshdGuid { get; set; }

    public short UshdDbcno { get; set; }

    public int? UshdSpecRecno { get; set; }

    public bool? UshdIptal { get; set; }

    public short? UshdFileid { get; set; }

    public bool? UshdHidden { get; set; }

    public bool? UshdKilitli { get; set; }

    public bool? UshdDegisti { get; set; }

    public int? UshdChecksum { get; set; }

    public short? UshdCreateUser { get; set; }

    public DateTime UshdCreateDate { get; set; }

    public short? UshdLastupUser { get; set; }

    public DateTime? UshdLastupDate { get; set; }

    public string? UshdSpecial1 { get; set; }

    public string? UshdSpecial2 { get; set; }

    public string? UshdSpecial3 { get; set; }

    public Guid? UshdBagliharUid { get; set; }

    public double? UshdTutar { get; set; }

    public double? UshdIskonto1 { get; set; }

    public double? UshdIskonto2 { get; set; }

    public double? UshdIskonto3 { get; set; }

    public double? UshdIskonto4 { get; set; }

    public double? UshdIskonto5 { get; set; }

    public double? UshdIskonto6 { get; set; }

    public double? UshdMasraf1 { get; set; }

    public double? UshdMasraf2 { get; set; }

    public double? UshdMasraf3 { get; set; }

    public double? UshdMasraf4 { get; set; }

    public double? UshdMaliyetAna { get; set; }

    public double? UshdMaliyetAlternatif { get; set; }

    public double? UshdMaliyetOrjinal { get; set; }

    public double? UshdUrunilkmaddedegeri { get; set; }

    public double? UshdMamulyarimamuldegeri { get; set; }

    public double? UshdDirektIscilik1 { get; set; }

    public double? UshdDirektIscilik2 { get; set; }

    public double? UshdDirektIscilik3 { get; set; }

    public double? UshdDirektIscilik4 { get; set; }

    public double? UshdDirektIscilik5 { get; set; }

    public double? UshdGenelUretim1 { get; set; }

    public double? UshdGenelUretim2 { get; set; }

    public double? UshdGenelUretim3 { get; set; }

    public double? UshdGenelUretim4 { get; set; }

    public double? UshdGenelUretim5 { get; set; }

    public double? UshdDegerfarki { get; set; }

    public Guid? UshdFatUid { get; set; }

    public byte? UshdEvraktip { get; set; }

    public string? UshdEvraknoSeri { get; set; }

    public int? UshdEvraknoSira { get; set; }
}
