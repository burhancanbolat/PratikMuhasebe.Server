using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelGirilenSinavlar
{
    public Guid AsnGuid { get; set; }

    public short AsnDbcno { get; set; }

    public int? AsnSpecRecno { get; set; }

    public bool? AsnIptal { get; set; }

    public short? AsnFileid { get; set; }

    public bool? AsnHidden { get; set; }

    public bool? AsnKilitli { get; set; }

    public bool? AsnDegisti { get; set; }

    public int? AsnChecksum { get; set; }

    public short? AsnCreateUser { get; set; }

    public DateTime AsnCreateDate { get; set; }

    public short? AsnLastupUser { get; set; }

    public DateTime? AsnLastupDate { get; set; }

    public string? AsnSpecial1 { get; set; }

    public string? AsnSpecial2 { get; set; }

    public string? AsnSpecial3 { get; set; }

    public DateTime? AsnTarih { get; set; }

    public byte? AsnKapsam { get; set; }

    public string? AsnPerKodu { get; set; }

    public string? AsnSinavKodu { get; set; }

    public double? AsnPuan { get; set; }

    public string? AsnAciklama { get; set; }

    public string? AsnSinavYeri { get; set; }

    public byte? AsnSinaviYapanTipi { get; set; }

    public string? AsnSinaviYapan { get; set; }
}
