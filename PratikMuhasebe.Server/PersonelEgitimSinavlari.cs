using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelEgitimSinavlari
{
    public Guid PesGuid { get; set; }

    public short PesDbcno { get; set; }

    public int? PesSpecRecno { get; set; }

    public bool? PesIptal { get; set; }

    public short? PesFileid { get; set; }

    public bool? PesHidden { get; set; }

    public bool? PesKilitli { get; set; }

    public bool? PesDegisti { get; set; }

    public int? PesChecksum { get; set; }

    public short? PesCreateUser { get; set; }

    public DateTime PesCreateDate { get; set; }

    public short? PesLastupUser { get; set; }

    public DateTime? PesLastupDate { get; set; }

    public string? PesSpecial1 { get; set; }

    public string? PesSpecial2 { get; set; }

    public string? PesSpecial3 { get; set; }

    public byte? PesTipi { get; set; }

    public string? PesKodu { get; set; }

    public string? PesSinavkodu { get; set; }

    public int? PesSirano { get; set; }

    public double? PesPuan { get; set; }
}
