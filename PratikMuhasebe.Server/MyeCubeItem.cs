using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeCubeItem
{
    public int CiId { get; set; }

    public int? CiCubeid { get; set; }

    public int? CiFieldid { get; set; }

    public string? CiFieldalias { get; set; }

    public string? CiFielduseralias { get; set; }

    public string? CiDescription { get; set; }

    public bool? CiIsmeasure { get; set; }

    public bool? CiIsvisible { get; set; }

    public string? CiDisplayformat { get; set; }
}
