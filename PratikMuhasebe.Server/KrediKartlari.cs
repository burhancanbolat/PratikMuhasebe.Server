using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KrediKartlari
{
    public Guid KkaGuid { get; set; }

    public short KkaDbcno { get; set; }

    public int? KkaSpecRecno { get; set; }

    public bool? KkaIptal { get; set; }

    public short? KkaFileid { get; set; }

    public bool? KkaHidden { get; set; }

    public bool? KkaKilitli { get; set; }

    public bool? KkaDegisti { get; set; }

    public int? KkaChecksum { get; set; }

    public short? KkaCreateUser { get; set; }

    public DateTime KkaCreateDate { get; set; }

    public short? KkaLastupUser { get; set; }

    public DateTime? KkaLastupDate { get; set; }

    public string? KkaSpecial1 { get; set; }

    public string? KkaSpecial2 { get; set; }

    public string? KkaSpecial3 { get; set; }

    public Guid? KkaYetkiliUid { get; set; }

    public string? KkaNo { get; set; }

    public string? KkaCvcNo { get; set; }

    public string? KkaSonay { get; set; }

    public string? KkaSonyil { get; set; }

    public byte? KkaTipi { get; set; }

    public string? KkaIsim { get; set; }

    public string? KkaBankaKodu { get; set; }
}
