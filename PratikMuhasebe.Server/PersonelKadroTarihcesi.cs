using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroTarihcesi
{
    public Guid KtGuid { get; set; }

    public short KtDbcno { get; set; }

    public int? KtSpecRecno { get; set; }

    public bool? KtIptal { get; set; }

    public short? KtFileid { get; set; }

    public bool? KtHidden { get; set; }

    public bool? KtKilitli { get; set; }

    public bool? KtDegisti { get; set; }

    public int? KtChecksum { get; set; }

    public short? KtCreateUser { get; set; }

    public DateTime KtCreateDate { get; set; }

    public short? KtLastupUser { get; set; }

    public DateTime? KtLastupDate { get; set; }

    public string? KtSpecial1 { get; set; }

    public string? KtSpecial2 { get; set; }

    public string? KtSpecial3 { get; set; }

    public string? KtKadrokodu { get; set; }

    public int? KtSirano { get; set; }

    public string? KtPersonelkodu { get; set; }

    public DateTime? KtAtamatarihi { get; set; }

    public DateTime? KtAyrilmatarihi { get; set; }

    public string? KtAyrilmasebebi { get; set; }
}
