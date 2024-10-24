using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ButcelenenNakitAki
{
    public Guid BnaGuid { get; set; }

    public short BnaDbcno { get; set; }

    public int? BnaSpecRecno { get; set; }

    public bool? BnaIptal { get; set; }

    public short? BnaFileid { get; set; }

    public bool? BnaHidden { get; set; }

    public bool? BnaKilitli { get; set; }

    public bool? BnaDegisti { get; set; }

    public int? BnaChecksum { get; set; }

    public short? BnaCreateUser { get; set; }

    public DateTime BnaCreateDate { get; set; }

    public short? BnaLastupUser { get; set; }

    public DateTime? BnaLastupDate { get; set; }

    public string? BnaSpecial1 { get; set; }

    public string? BnaSpecial2 { get; set; }

    public string? BnaSpecial3 { get; set; }

    public int? BnaFirmano { get; set; }

    public byte? BnaGirisCikis { get; set; }

    public DateTime? BnaVade { get; set; }

    public string? BnaAciklama { get; set; }

    public double? BnaTutar { get; set; }

    public byte? BnaDovizcinsi { get; set; }

    public bool? BnaTamamlandi { get; set; }

    public string? BnaProje { get; set; }

    public string? BnaSrmmrk { get; set; }
}
