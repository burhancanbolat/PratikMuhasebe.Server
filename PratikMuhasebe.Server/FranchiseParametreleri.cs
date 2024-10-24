using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FranchiseParametreleri
{
    public string? FrparGelenVeriDizini { get; set; }

    public string? FrparGidenVeriDizini { get; set; }

    public string? FrparLogDizini { get; set; }

    public string? FrparAnaSaglayiciCarisi { get; set; }

    public string? FrparWebServisUser { get; set; }

    public string? FrparWebServisPass { get; set; }

    public string? FrparSiparisWebServisUrl { get; set; }

    public string? FrparSatinalmatalepWebServisUrl { get; set; }

    public string? FrparAktarimUserNo { get; set; }

    public int? FrparDepoNoPrefix { get; set; }

    public string? FrparFiyDegdenMuafReyonlar { get; set; }

    public string? FrparLogGonderilecekMailler { get; set; }

    public string? FrparIadetalepWebServisUrl { get; set; }

    public string? FrparLokalVeriDizini { get; set; }
}
