using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FirmaNaceTanimlari
{
    public Guid FncGuid { get; set; }

    public short FncDbcno { get; set; }

    public int? FncSpecRecNo { get; set; }

    public bool? FncIptal { get; set; }

    public short? FncFileid { get; set; }

    public bool? FncHidden { get; set; }

    public bool? FncKilitli { get; set; }

    public bool? FncDegisti { get; set; }

    public int? FncChecksum { get; set; }

    public short? FncCreateUser { get; set; }

    public DateTime FncCreateDate { get; set; }

    public short? FncLastupUser { get; set; }

    public DateTime? FncLastupDate { get; set; }

    public string? FncSpecial1 { get; set; }

    public string? FncSpecial2 { get; set; }

    public string? FncSpecial3 { get; set; }

    public int? FncFirmano { get; set; }

    public short? FncSirano { get; set; }

    public string? FncNaceKodu { get; set; }

    public string? FncMuhHesapKod1 { get; set; }

    public string? FncMuhHesapKod2 { get; set; }

    public string? FncMuhHesapKod3 { get; set; }

    public string? FncMuhHesapKod4 { get; set; }

    public string? FncMuhHesapKod5 { get; set; }

    public string? FncMuhHesapKod6 { get; set; }

    public string? FncMuhHesapKod7 { get; set; }

    public string? FncMuhHesapKod8 { get; set; }

    public string? FncMuhHesapKod9 { get; set; }

    public string? FncMuhHesapKod10 { get; set; }

    public string? FncGiderMuhHesapKod1 { get; set; }

    public string? FncGiderMuhHesapKod2 { get; set; }

    public string? FncGiderMuhHesapKod3 { get; set; }

    public string? FncGiderMuhHesapKod4 { get; set; }

    public string? FncGiderMuhHesapKod5 { get; set; }

    public string? FncGiderMuhHesapKod6 { get; set; }

    public string? FncGiderMuhHesapKod7 { get; set; }

    public string? FncGiderMuhHesapKod8 { get; set; }

    public string? FncGiderMuhHesapKod9 { get; set; }

    public string? FncGiderMuhHesapKod10 { get; set; }

    public bool? FncHasilatEsasliFl { get; set; }
}
