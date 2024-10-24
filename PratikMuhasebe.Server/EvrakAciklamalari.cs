using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EvrakAciklamalari
{
    public Guid EgkGuid { get; set; }

    public short EgkDbcno { get; set; }

    public int? EgkSpecRecno { get; set; }

    public bool? EgkIptal { get; set; }

    public short? EgkFileid { get; set; }

    public bool? EgkHidden { get; set; }

    public bool? EgkKilitli { get; set; }

    public bool? EgkDegisti { get; set; }

    public int? EgkChecksum { get; set; }

    public short? EgkCreateUser { get; set; }

    public DateTime EgkCreateDate { get; set; }

    public short? EgkLastupUser { get; set; }

    public DateTime? EgkLastupDate { get; set; }

    public string? EgkSpecial1 { get; set; }

    public string? EgkSpecial2 { get; set; }

    public string? EgkSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public short? EgkDosyano { get; set; }

    public byte? EgkHareketTip { get; set; }

    public byte? EgkEvrTip { get; set; }

    public string? EgkEvrSeri { get; set; }

    public int? EgkEvrSira { get; set; }

    public string? EgkEvrUstkod { get; set; }

    public short? EgkEvrDoksayisi { get; set; }

    public string? EgkEvracik1 { get; set; }

    public string? EgkEvracik2 { get; set; }

    public string? EgkEvracik3 { get; set; }

    public string? EgkEvracik4 { get; set; }

    public string? EgkEvracik5 { get; set; }

    public string? EgkEvracik6 { get; set; }

    public string? EgkEvracik7 { get; set; }

    public string? EgkEvracik8 { get; set; }

    public string? EgkEvracik9 { get; set; }

    public string? EgkEvracik10 { get; set; }

    public double? EgkSipgenkarorani { get; set; }

    public string? EgkKargokodu { get; set; }

    public string? EgkKargono { get; set; }

    public DateTime? EgkTesaltarihi { get; set; }

    public string? EgkTesalkisi { get; set; }

    public short? EgkPrevwiewsayisi { get; set; }

    public short? EgkEmailsayisi { get; set; }

    public bool? EgkEvrakopnoVerildiFl { get; set; }
}
