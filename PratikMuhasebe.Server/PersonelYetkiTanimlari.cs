using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelYetkiTanimlari
{
    public Guid YtGuid { get; set; }

    public short YtDbcno { get; set; }

    public int? YtSpecRecno { get; set; }

    public bool? YtIptal { get; set; }

    public short? YtFileid { get; set; }

    public bool? YtHidden { get; set; }

    public bool? YtKilitli { get; set; }

    public bool? YtDegisti { get; set; }

    public int? YtChecksum { get; set; }

    public short? YtCreateUser { get; set; }

    public DateTime YtCreateDate { get; set; }

    public short? YtLastupUser { get; set; }

    public DateTime? YtLastupDate { get; set; }

    public string? YtSpecial1 { get; set; }

    public string? YtSpecial2 { get; set; }

    public string? YtSpecial3 { get; set; }

    public string? YtKod { get; set; }

    public string? YtAciklama { get; set; }
}
