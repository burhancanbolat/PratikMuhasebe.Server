using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IstasyonVardiyaCalisanlari
{
    public Guid VcGuid { get; set; }

    public short VcDbcno { get; set; }

    public int? VcSpecRecno { get; set; }

    public bool? VcIptal { get; set; }

    public short? VcFileid { get; set; }

    public bool? VcHidden { get; set; }

    public bool? VcKilitli { get; set; }

    public bool? VcDegisti { get; set; }

    public int? VcChecksum { get; set; }

    public short? VcCreateUser { get; set; }

    public DateTime VcCreateDate { get; set; }

    public short? VcLastupUser { get; set; }

    public DateTime? VcLastupDate { get; set; }

    public string? VcSpecial1 { get; set; }

    public string? VcSpecial2 { get; set; }

    public string? VcSpecial3 { get; set; }

    public int? VcFirmano { get; set; }

    public int? VcSubeno { get; set; }

    public byte? VcVardiyahesaptip { get; set; }

    public DateTime? VcTarihi { get; set; }

    public byte? VcNumarasi { get; set; }

    public string? VcPersKodu { get; set; }

    public byte? VcAcikKapali { get; set; }

    public string? VcOrtakPers1 { get; set; }

    public string? VcOrtakPers2 { get; set; }

    public string? VcOrtakPers3 { get; set; }

    public string? VcOrtakPers4 { get; set; }

    public string? VcOrtakPers5 { get; set; }

    public string? VcOrtakPers6 { get; set; }

    public string? VcOrtakPers7 { get; set; }

    public string? VcOrtakPers8 { get; set; }

    public string? VcOrtakPers9 { get; set; }

    public string? VcOrtakPers10 { get; set; }
}
