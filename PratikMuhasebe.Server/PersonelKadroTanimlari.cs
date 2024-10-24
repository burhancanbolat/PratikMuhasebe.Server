using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroTanimlari
{
    public Guid KdrGuid { get; set; }

    public short KdrDbcno { get; set; }

    public int? KdrSpecRecno { get; set; }

    public bool? KdrIptal { get; set; }

    public short? KdrFileid { get; set; }

    public bool? KdrHidden { get; set; }

    public bool? KdrKilitli { get; set; }

    public bool? KdrDegisti { get; set; }

    public int? KdrChecksum { get; set; }

    public short? KdrCreateUser { get; set; }

    public DateTime KdrCreateDate { get; set; }

    public short? KdrLastupUser { get; set; }

    public DateTime? KdrLastupDate { get; set; }

    public string? KdrSpecial1 { get; set; }

    public string? KdrSpecial2 { get; set; }

    public string? KdrSpecial3 { get; set; }

    public string? KdrKod { get; set; }

    public string? KdrAciklama { get; set; }

    public string? KdrRutbe { get; set; }

    public int? KdrKadrosayisi { get; set; }

    public string? KdrBagliIdariAmir { get; set; }

    public string? KdrBagliTeknikAmir { get; set; }

    public byte? KdrMinimumEgitim { get; set; }

    public string? KdrHedefKadro1 { get; set; }

    public string? KdrHedefKadro2 { get; set; }

    public string? KdrHedefKadro3 { get; set; }

    public string? KdrGorevTanimi { get; set; }

    public string? KdrSorumlulukTanimi { get; set; }

    public bool? KdrSemadaGosterme { get; set; }

    public double? KdrMinUcret { get; set; }

    public double? KdrMaxUcret { get; set; }

    public byte? KdrUcretDcinsi { get; set; }

    public string? KdrUnvanKodu { get; set; }

    public string? KdrGorevKodu { get; set; }

    public string? KdrRaporlamaYapKadroKodu { get; set; }

    public string? KdrVekaletKadroKodu { get; set; }
}
