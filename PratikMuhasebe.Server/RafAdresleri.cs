using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class RafAdresleri
{
    public Guid RaGuid { get; set; }

    public short RaDbcno { get; set; }

    public int? RaSpecRecno { get; set; }

    public bool? RaIptal { get; set; }

    public short? RaFileid { get; set; }

    public bool? RaHidden { get; set; }

    public bool? RaKilitli { get; set; }

    public bool? RaDegisti { get; set; }

    public int? RaChecksum { get; set; }

    public short? RaCreateUser { get; set; }

    public DateTime RaCreateDate { get; set; }

    public short? RaLastupUser { get; set; }

    public DateTime? RaLastupDate { get; set; }

    public string? RaSpecial1 { get; set; }

    public string? RaSpecial2 { get; set; }

    public string? RaSpecial3 { get; set; }

    public string? RaKod { get; set; }

    public byte? RaCins { get; set; }

    public int? RaDepo { get; set; }

    public string? RaKoridor { get; set; }

    public byte? RaYon { get; set; }

    public string? RaBlok { get; set; }

    public string? RaKat { get; set; }

    public short? RaEn { get; set; }

    public short? RaBoy { get; set; }

    public short? RaYukseklik { get; set; }

    public int? RaHacim { get; set; }

    public int? RaKapasite { get; set; }

    public byte? RaBolumsayisi { get; set; }
}
