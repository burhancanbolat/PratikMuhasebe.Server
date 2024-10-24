using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelGorevTanimlari
{
    public Guid PgkGuid { get; set; }

    public short PgkDbcno { get; set; }

    public int? PgkSpecRecno { get; set; }

    public bool? PgkIptal { get; set; }

    public short? PgkFileid { get; set; }

    public bool? PgkHidden { get; set; }

    public bool? PgkKilitli { get; set; }

    public bool? PgkDegisti { get; set; }

    public int? PgkChecksum { get; set; }

    public short? PgkCreateUser { get; set; }

    public DateTime PgkCreateDate { get; set; }

    public short? PgkLastupUser { get; set; }

    public DateTime? PgkLastupDate { get; set; }

    public string? PgkSpecial1 { get; set; }

    public string? PgkSpecial2 { get; set; }

    public string? PgkSpecial3 { get; set; }

    public string? PgkGorevKodu { get; set; }

    public string? PgkGorevAdi { get; set; }
}
