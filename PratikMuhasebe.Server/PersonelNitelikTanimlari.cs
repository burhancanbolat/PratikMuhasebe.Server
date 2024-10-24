using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelNitelikTanimlari
{
    public Guid NtGuid { get; set; }

    public short NtDbcno { get; set; }

    public int? NtSpecRecno { get; set; }

    public bool? NtIptal { get; set; }

    public short? NtFileid { get; set; }

    public bool? NtHidden { get; set; }

    public bool? NtKilitli { get; set; }

    public bool? NtDegisti { get; set; }

    public int? NtChecksum { get; set; }

    public short? NtCreateUser { get; set; }

    public DateTime NtCreateDate { get; set; }

    public short? NtLastupUser { get; set; }

    public DateTime? NtLastupDate { get; set; }

    public string? NtSpecial1 { get; set; }

    public string? NtSpecial2 { get; set; }

    public string? NtSpecial3 { get; set; }

    public string? NtKod { get; set; }

    public string? NtAciklama { get; set; }

    public byte? NtTipi { get; set; }

    public byte? NtAktif { get; set; }

    public double? NtMaxpuan { get; set; }

    public double? NtToplamdakipayi { get; set; }

    public string? NtSozelpuanlar { get; set; }
}
