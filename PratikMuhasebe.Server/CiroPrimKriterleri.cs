using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CiroPrimKriterleri
{
    public Guid CprkGuid { get; set; }

    public string? CprkBaglicarikod { get; set; }

    public int? CprkNumarasi { get; set; }

    public string? CprkStokSorgu { get; set; }

    public string? CprkDepoSorgu { get; set; }
}
