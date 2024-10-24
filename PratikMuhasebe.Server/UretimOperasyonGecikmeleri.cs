using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimOperasyonGecikmeleri
{
    public Guid OpgGuid { get; set; }

    public short OpgDbcno { get; set; }

    public int? OpgSpecRecno { get; set; }

    public bool? OpgIptal { get; set; }

    public short? OpgFileid { get; set; }

    public bool? OpgHidden { get; set; }

    public bool? OpgKilitli { get; set; }

    public bool? OpgDegisti { get; set; }

    public int? OpgCheckSum { get; set; }

    public short? OpgCreateUser { get; set; }

    public DateTime OpgCreateDate { get; set; }

    public short? OpgLastupUser { get; set; }

    public DateTime? OpgLastupDate { get; set; }

    public string? OpgSpecial1 { get; set; }

    public string? OpgSpecial2 { get; set; }

    public string? OpgSpecial3 { get; set; }

    public Guid? OpgOpTamamUid { get; set; }

    public string? OpgGecikmeKodu { get; set; }

    public DateTime? OpgGecikmeBoslukBaslangici { get; set; }

    public DateTime? OpgGecikmeBoslukSonu { get; set; }

    public int? OpgGecikmeSuresi { get; set; }

    public string? OpgAciklama { get; set; }
}
