using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelAlinanEgitimler
{
    public Guid AegGuid { get; set; }

    public short AegDbcno { get; set; }

    public int? AegSpecRecno { get; set; }

    public bool? AegIptal { get; set; }

    public short? AegFileid { get; set; }

    public bool? AegHidden { get; set; }

    public bool? AegKilitli { get; set; }

    public bool? AegDegisti { get; set; }

    public int? AegChecksum { get; set; }

    public short? AegCreateUser { get; set; }

    public DateTime AegCreateDate { get; set; }

    public short? AegLastupUser { get; set; }

    public DateTime? AegLastupDate { get; set; }

    public string? AegSpecial1 { get; set; }

    public string? AegSpecial2 { get; set; }

    public string? AegSpecial3 { get; set; }

    public int? AegFirmano { get; set; }

    public int? AegSubeno { get; set; }

    public DateTime? AegTarih { get; set; }

    public string? AegEvraknoSeri { get; set; }

    public int? AegEvraknoSira { get; set; }

    public string? AegEgitimKodu { get; set; }

    public int? AegSatirno { get; set; }

    public byte? AegDurumu { get; set; }

    public DateTime? AegBastar { get; set; }

    public DateTime? AegBitistar { get; set; }

    public double? AegButce { get; set; }

    public string? AegPerKodu { get; set; }

    public double? AegSinavPuan { get; set; }

    public double? AegOnayPuan1 { get; set; }

    public double? AegOnayPuan2 { get; set; }

    public double? AegOnayPuan3 { get; set; }

    public string? AegAciklama1 { get; set; }

    public string? AegAciklama2 { get; set; }

    public string? AegAciklama3 { get; set; }

    public Guid? AegBagliTalepUid { get; set; }

    public string? AegEgitimGrupKodu { get; set; }

    public string? AegEgitimAltGrupKodu { get; set; }
}
