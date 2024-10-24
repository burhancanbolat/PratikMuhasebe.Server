using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FranchiseVeriTabanlari
{
    public int FrcFranchiseNo { get; set; }

    public string? FrcSunucu { get; set; }

    public string? FrcVeriTabani { get; set; }

    public int? FrcDepoNo { get; set; }

    public bool? FrcAktifFl { get; set; }

    public string? FrcGelenVeriDizini { get; set; }

    public string? FrcGidenVeriDizini { get; set; }

    public string? FrcPosVeriDizini { get; set; }
}
