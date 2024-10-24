using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class VergiTahakkuklari
{
    public Guid FhGuid { get; set; }

    public short FhDbcno { get; set; }

    public int? FhSpecRecno { get; set; }

    public bool? FhIptal { get; set; }

    public short? FhFileid { get; set; }

    public bool? FhHidden { get; set; }

    public bool? FhKilitli { get; set; }

    public bool? FhDegisti { get; set; }

    public int? FhChecksum { get; set; }

    public short? FhCreateUser { get; set; }

    public DateTime FhCreateDate { get; set; }

    public short? FhLastupUser { get; set; }

    public DateTime? FhLastupDate { get; set; }

    public string? FhSpecial1 { get; set; }

    public string? FhSpecial2 { get; set; }

    public string? FhSpecial3 { get; set; }

    public int? FhFirmano { get; set; }

    public DateTime? FhTarih { get; set; }

    public short? FhIslem { get; set; }

    public short? FhDonem { get; set; }

    public double? FhTutar { get; set; }

    public byte? FhTip { get; set; }

    public string? FhEvrnoSeri { get; set; }

    public int? FhEvrnoSira { get; set; }

    public byte? FhSekli { get; set; }

    public string? FhAciklama { get; set; }

    public string? FhYeri { get; set; }

    public double? FhMatrah { get; set; }

    public double? FhMahsup { get; set; }

    public int? FhSatirNo { get; set; }

    public DateTime? FhVade { get; set; }

    public string? FhOdemeNo { get; set; }

    public string? FhTahhakkukNo { get; set; }

    public string? FhDbkodu { get; set; }
}
