using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MakinaHareketleri
{
    public Guid MkhGuid { get; set; }

    public short MkhDbcno { get; set; }

    public int? MkhSpecRecno { get; set; }

    public bool? MkhIptal { get; set; }

    public short? MkhFileid { get; set; }

    public bool? MkhHidden { get; set; }

    public bool? MkhKilitli { get; set; }

    public bool? MkhDegisti { get; set; }

    public int? MkhChecksum { get; set; }

    public short? MkhCreateUser { get; set; }

    public DateTime MkhCreateDate { get; set; }

    public short? MkhLastupUser { get; set; }

    public DateTime? MkhLastupDate { get; set; }

    public string? MkhSpecial1 { get; set; }

    public string? MkhSpecial2 { get; set; }

    public string? MkhSpecial3 { get; set; }

    public string? MkhEvrnoSeri { get; set; }

    public int? MkhEvrnoSira { get; set; }

    public int? MkhSatirNo { get; set; }

    public string? MkhMakKodu { get; set; }

    public string? MkhMakSrnKodu { get; set; }

    public DateTime? MkhDurmaZaman { get; set; }

    public DateTime? MkhKalkmaZaman { get; set; }

    public string? MkhAciklama { get; set; }

    public string? MkhYetkiliop { get; set; }

    public string? MkhBakimelm { get; set; }
}
