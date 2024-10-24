using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelProjeTanimlari
{
    public Guid PprGuid { get; set; }

    public short PprDbcno { get; set; }

    public int? PprSpecRecno { get; set; }

    public bool? PprIptal { get; set; }

    public short? PprFileid { get; set; }

    public bool? PprHidden { get; set; }

    public bool? PprKilitli { get; set; }

    public bool? PprDegisti { get; set; }

    public int? PprChecksum { get; set; }

    public short? PprCreateUser { get; set; }

    public DateTime PprCreateDate { get; set; }

    public short? PprLastupUser { get; set; }

    public DateTime? PprLastupDate { get; set; }

    public string? PprSpecial1 { get; set; }

    public string? PprSpecial2 { get; set; }

    public string? PprSpecial3 { get; set; }

    public string? PprKodu { get; set; }

    public string? PprAdi { get; set; }

    public DateTime? PprBasTar { get; set; }

    public DateTime? PprBitTar { get; set; }
}
