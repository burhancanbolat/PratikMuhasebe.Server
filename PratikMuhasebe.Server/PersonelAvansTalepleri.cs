using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelAvansTalepleri
{
    public Guid PatGuid { get; set; }

    public short PatDbcno { get; set; }

    public int? PatSpecRecno { get; set; }

    public bool? PatIptal { get; set; }

    public short? PatFileid { get; set; }

    public bool? PatHidden { get; set; }

    public bool? PatKilitli { get; set; }

    public bool? PatDegisti { get; set; }

    public int? PatChecksum { get; set; }

    public short? PatCreateUser { get; set; }

    public DateTime PatCreateDate { get; set; }

    public short? PatLastupUser { get; set; }

    public DateTime? PatLastupDate { get; set; }

    public string? PatSpecial1 { get; set; }

    public string? PatSpecial2 { get; set; }

    public string? PatSpecial3 { get; set; }

    public string? PatPersonelkod { get; set; }

    public int? PatMaliyil { get; set; }

    public int? PatSatirno { get; set; }

    public byte? PatAvansayi { get; set; }

    public double? PatAvanstutari { get; set; }

    public string? PatAciklamasi { get; set; }

    public byte? PatDurum { get; set; }

    public byte? PatCariharEvraktip { get; set; }

    public string? PatCariharEvrakseri { get; set; }

    public int? PatCariharEvraksira { get; set; }
}
