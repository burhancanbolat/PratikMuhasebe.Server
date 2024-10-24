using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KisaMesajSablonlari
{
    public Guid SblGuid { get; set; }

    public short SblDbcno { get; set; }

    public int? SblSpecRecno { get; set; }

    public bool? SblIptal { get; set; }

    public short? SblFileid { get; set; }

    public bool? SblHidden { get; set; }

    public bool? SblKilitli { get; set; }

    public bool? SblDegisti { get; set; }

    public int? SblChecksum { get; set; }

    public short? SblCreateUser { get; set; }

    public DateTime SblCreateDate { get; set; }

    public short? SblLastupUser { get; set; }

    public DateTime? SblLastupDate { get; set; }

    public string? SblSpecial1 { get; set; }

    public string? SblSpecial2 { get; set; }

    public string? SblSpecial3 { get; set; }

    public string? SblKodu { get; set; }

    public string? SblAdi { get; set; }

    public string? SblMetni { get; set; }

    public byte? SblFunctipi1 { get; set; }

    public byte? SblFunctipi2 { get; set; }

    public byte? SblFunctipi3 { get; set; }

    public byte? SblFunctipi4 { get; set; }

    public byte? SblFunctipi5 { get; set; }

    public byte? SblFunctipi6 { get; set; }

    public byte? SblFunctipi7 { get; set; }

    public byte? SblFunctipi8 { get; set; }

    public byte? SblFunctipi9 { get; set; }

    public byte? SblFunctipi10 { get; set; }
}
