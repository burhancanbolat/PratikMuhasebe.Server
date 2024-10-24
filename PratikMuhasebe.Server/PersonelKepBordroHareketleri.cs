using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKepBordroHareketleri
{
    public Guid PerkepGuid { get; set; }

    public short PerkepDbcno { get; set; }

    public int? PerkepSpecRecno { get; set; }

    public bool? PerkepIptal { get; set; }

    public short? PerkepFileid { get; set; }

    public bool? PerkepHidden { get; set; }

    public bool? PerkepKilitli { get; set; }

    public bool? PerkepDegisti { get; set; }

    public int? PerkepChecksum { get; set; }

    public short? PerkepCreateUser { get; set; }

    public DateTime? PerkepCreateDate { get; set; }

    public short? PerkepLastupUser { get; set; }

    public DateTime? PerkepLastupDate { get; set; }

    public string? PerkepSpecial1 { get; set; }

    public string? PerkepSpecial2 { get; set; }

    public string? PerkepSpecial3 { get; set; }

    public string? PerkepPerKod { get; set; }

    public int? PerkepMaliYil { get; set; }

    public short? PerkepTahAy { get; set; }

    public short? PerkepTahNo { get; set; }

    public byte? PerkepDurumKod { get; set; }

    public string? PerkepAciklama { get; set; }

    public int? PerkepKepDurumKod { get; set; }

    public string? PerkepKepDurumAciklama { get; set; }
}
