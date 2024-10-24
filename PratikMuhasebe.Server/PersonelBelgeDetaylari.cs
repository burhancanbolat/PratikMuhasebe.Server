using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelBelgeDetaylari
{
    public Guid BdtGuid { get; set; }

    public short BdtDbcno { get; set; }

    public int? BdtSpecRecno { get; set; }

    public bool? BdtIptal { get; set; }

    public short? BdtFileid { get; set; }

    public bool? BdtHidden { get; set; }

    public bool? BdtKilitli { get; set; }

    public bool? BdtDegisti { get; set; }

    public int? BdtChecksum { get; set; }

    public short? BdtCreateUser { get; set; }

    public DateTime BdtCreateDate { get; set; }

    public short? BdtLastupUser { get; set; }

    public DateTime? BdtLastupDate { get; set; }

    public string? BdtSpecial1 { get; set; }

    public string? BdtSpecial2 { get; set; }

    public string? BdtSpecial3 { get; set; }

    public string? BdtPersKod { get; set; }

    public string? BdtBelgeKod { get; set; }

    public string? BdtBelgeNo { get; set; }

    public string? BdtBelgeYeri { get; set; }

    public string? BdtUlkeKodu { get; set; }

    public DateTime? BdtBelgeBaslangic { get; set; }

    public DateTime? BdtBelgeBitis { get; set; }

    public byte? BdtPozisyon { get; set; }

    public string? BdtSorumlu { get; set; }

    public DateTime? BdtPozisyonDegisimTarihi { get; set; }

    public string? BdtPozisyonAciklama { get; set; }
}
