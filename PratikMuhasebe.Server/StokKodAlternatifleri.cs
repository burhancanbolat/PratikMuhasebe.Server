using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokKodAlternatifleri
{
    public Guid SakGuid { get; set; }

    public short SakDbcno { get; set; }

    public int? SakSpecRecno { get; set; }

    public bool? SakIptal { get; set; }

    public short? SakFileid { get; set; }

    public bool? SakHidden { get; set; }

    public bool? SakKilitli { get; set; }

    public bool? SakDegisti { get; set; }

    public int? SakChecksum { get; set; }

    public short? SakCreateUser { get; set; }

    public DateTime SakCreateDate { get; set; }

    public short? SakLastupUser { get; set; }

    public DateTime? SakLastupDate { get; set; }

    public string? SakSpecial1 { get; set; }

    public string? SakSpecial2 { get; set; }

    public string? SakSpecial3 { get; set; }

    public short? SakAltgrupno { get; set; }

    public short? SakAltalanno { get; set; }

    public string? SakAltkodu { get; set; }

    public string? SakAltaciklama { get; set; }
}
