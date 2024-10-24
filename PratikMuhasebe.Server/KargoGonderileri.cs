using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KargoGonderileri
{
    public Guid KargoGuid { get; set; }

    public short KargoDbcno { get; set; }

    public int? KargoSpecRecNo { get; set; }

    public bool? KargoIptal { get; set; }

    public short? KargoFileid { get; set; }

    public bool? KargoHidden { get; set; }

    public bool? KargoKilitli { get; set; }

    public bool? KargoDegisti { get; set; }

    public int? KargoChecksum { get; set; }

    public short? KargoCreateUser { get; set; }

    public DateTime KargoCreateDate { get; set; }

    public short? KargoLastupUser { get; set; }

    public DateTime? KargoLastupDate { get; set; }

    public string? KargoSpecial1 { get; set; }

    public string? KargoSpecial2 { get; set; }

    public string? KargoSpecial3 { get; set; }

    public byte? KargoSirkettipi { get; set; }

    public DateTime? KargoGonderitarihi { get; set; }

    public string? KargoAlicikodu { get; set; }

    public int? KargoAliciadresno { get; set; }

    public int? KargoVarisdepono { get; set; }

    public int? KargoEvraktabloid { get; set; }

    public byte? KargoEvraktipi { get; set; }

    public byte? KargoEvrakcinsi { get; set; }

    public string? KargoEvraknoseri { get; set; }

    public int? KargoEvraknosira { get; set; }

    public string? KargoEvrakbelgeno { get; set; }

    public Guid? KargoEvrakuid { get; set; }

    public double? KargoKargoadedi { get; set; }

    public double? KargoEvrakbedeli { get; set; }

    public byte? KargoEvrtahsilattipi { get; set; }

    public string? KargoOzelalan { get; set; }

    public byte? KargoGonderiakibeti { get; set; }

    public byte? KargoGonderitipi { get; set; }

    public byte? KargoGonderiyikimodeyecek { get; set; }

    public Guid? KargoMastergonderino { get; set; }
}
