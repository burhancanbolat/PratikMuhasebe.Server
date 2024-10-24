using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EvrakBelgeResimleri
{
    public int EiKey { get; set; }

    public short? EiDosyano { get; set; }

    public byte? EiHareketTip { get; set; }

    public byte? EiEvrTip { get; set; }

    public string? EiEvrSeri { get; set; }

    public int? EiEvrSira { get; set; }

    public string? EiEvrUstkod { get; set; }

    public byte? EiClassid { get; set; }

    public byte[]? EiImage { get; set; }

    public string? EiAciklama { get; set; }
}
