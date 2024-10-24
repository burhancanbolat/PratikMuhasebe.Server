using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroLimitleri
{
    public Guid PklGuid { get; set; }

    public short PklDbcno { get; set; }

    public int? PklSpecRecno { get; set; }

    public bool? PklIptal { get; set; }

    public short? PklFileid { get; set; }

    public bool? PklHidden { get; set; }

    public bool? PklKilitli { get; set; }

    public bool? PklDegisti { get; set; }

    public int? PklChecksum { get; set; }

    public short? PklCreateUser { get; set; }

    public DateTime PklCreateDate { get; set; }

    public short? PklLastupUser { get; set; }

    public DateTime? PklLastupDate { get; set; }

    public string? PklSpecial1 { get; set; }

    public string? PklSpecial2 { get; set; }

    public string? PklSpecial3 { get; set; }

    public byte? PklTipi { get; set; }

    public string? PklKadroKodu { get; set; }

    public int? PklKadroNo { get; set; }

    public byte? PklCinsi { get; set; }

    public string? PklKodu { get; set; }

    public byte? PklPeriyod { get; set; }

    public double? PklLimit { get; set; }
}
