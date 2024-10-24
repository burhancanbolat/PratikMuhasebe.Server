using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokKategorileri
{
    public Guid KtgGuid { get; set; }

    public short KtgDbcno { get; set; }

    public int? KtgSpecRecno { get; set; }

    public bool? KtgIptal { get; set; }

    public short? KtgFileid { get; set; }

    public bool? KtgHidden { get; set; }

    public bool? KtgKilitli { get; set; }

    public bool? KtgDegisti { get; set; }

    public int? KtgChecksum { get; set; }

    public short? KtgCreateUser { get; set; }

    public DateTime KtgCreateDate { get; set; }

    public short? KtgLastupUser { get; set; }

    public DateTime? KtgLastupDate { get; set; }

    public string? KtgSpecial1 { get; set; }

    public string? KtgSpecial2 { get; set; }

    public string? KtgSpecial3 { get; set; }

    public string? KtgKod { get; set; }

    public string? KtgIsim { get; set; }

    public string? KtgAciklama { get; set; }
}
