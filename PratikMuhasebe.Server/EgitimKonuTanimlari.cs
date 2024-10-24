using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EgitimKonuTanimlari
{
    public Guid EkonuGuid { get; set; }

    public short EkonuDbcno { get; set; }

    public int? EkonuSpecRecno { get; set; }

    public bool? EkonuIptal { get; set; }

    public short? EkonuFileid { get; set; }

    public bool? EkonuHidden { get; set; }

    public bool? EkonuKilitli { get; set; }

    public bool? EkonuDegisti { get; set; }

    public int? EkonuChecksum { get; set; }

    public short? EkonuCreateUser { get; set; }

    public DateTime EkonuCreateDate { get; set; }

    public short? EkonuLastupUser { get; set; }

    public DateTime? EkonuLastupDate { get; set; }

    public string? EkonuSpecial1 { get; set; }

    public string? EkonuSpecial2 { get; set; }

    public string? EkonuSpecial3 { get; set; }

    public string? EkonuKodu { get; set; }

    public string? EkonuAdi { get; set; }

    public byte? EkonuTip { get; set; }

    public string? Eaciklama1 { get; set; }

    public string? Eaciklama2 { get; set; }

    public string? Eaciklama3 { get; set; }
}
