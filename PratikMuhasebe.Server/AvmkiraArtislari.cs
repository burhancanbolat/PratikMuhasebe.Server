using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmkiraArtislari
{
    public Guid AvmKaGuid { get; set; }

    public short AvmKaDbcno { get; set; }

    public int? AvmKaSpecRecno { get; set; }

    public bool? AvmKaIptal { get; set; }

    public short? AvmKaFileid { get; set; }

    public bool? AvmKaHidden { get; set; }

    public bool? AvmKaKilitli { get; set; }

    public bool? AvmKaDegisti { get; set; }

    public int? AvmKaChecksum { get; set; }

    public short? AvmKaCreateUser { get; set; }

    public DateTime AvmKaCreateDate { get; set; }

    public short? AvmKaLastupUser { get; set; }

    public DateTime? AvmKaLastupDate { get; set; }

    public string? AvmKaSpecial1 { get; set; }

    public string? AvmKaSpecial2 { get; set; }

    public string? AvmKaSpecial3 { get; set; }

    public string? AvmKaKodu { get; set; }

    public string? AvmKaIsmi { get; set; }

    public string? AvmKaAciklama { get; set; }

    public double? AvmKaOrani { get; set; }
}
