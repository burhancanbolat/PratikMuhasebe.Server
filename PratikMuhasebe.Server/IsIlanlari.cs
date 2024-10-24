using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsIlanlari
{
    public Guid IlnGuid { get; set; }

    public short IlnDbcno { get; set; }

    public int? IlnSpecRecno { get; set; }

    public bool? IlnIptal { get; set; }

    public short? IlnFileid { get; set; }

    public bool? IlnHidden { get; set; }

    public bool? IlnKilitli { get; set; }

    public bool? IlnDegisti { get; set; }

    public int? IlnChecksum { get; set; }

    public short? IlnCreateUser { get; set; }

    public DateTime IlnCreateDate { get; set; }

    public short? IlnLastupUser { get; set; }

    public DateTime? IlnLastupDate { get; set; }

    public string? IlnSpecial1 { get; set; }

    public string? IlnSpecial2 { get; set; }

    public string? IlnSpecial3 { get; set; }

    public string? IlnKodu { get; set; }

    public string? IlnAciklama { get; set; }

    public short? IlnTecrube { get; set; }

    public byte? IlnCinsiyet { get; set; }

    public double? IlnNetUcret { get; set; }

    public byte? IlnDovizCinsi { get; set; }

    public DateTime? IlnIlkTarih { get; set; }

    public DateTime? IlnSonTarih { get; set; }

    public short? IlnKisiSayisi { get; set; }
}
