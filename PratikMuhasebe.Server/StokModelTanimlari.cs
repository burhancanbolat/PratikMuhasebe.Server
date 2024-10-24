using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokModelTanimlari
{
    public Guid MdlGuid { get; set; }

    public short MdlDbcno { get; set; }

    public int? MdlSpecRecno { get; set; }

    public bool? MdlIptal { get; set; }

    public short? MdlFileid { get; set; }

    public bool? MdlHidden { get; set; }

    public bool? MdlKilitli { get; set; }

    public bool? MdlDegisti { get; set; }

    public int? MdlCheckSum { get; set; }

    public short? MdlCreateUser { get; set; }

    public DateTime MdlCreateDate { get; set; }

    public short? MdlLastupUser { get; set; }

    public DateTime? MdlLastupDate { get; set; }

    public string? MdlSpecial1 { get; set; }

    public string? MdlSpecial2 { get; set; }

    public string? MdlSpecial3 { get; set; }

    public string? MdlKodu { get; set; }

    public string? MdlIsmi { get; set; }
}
