using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeKartDizayn
{
    public int KartId { get; set; }

    public string Language { get; set; } = null!;

    public int UserNo { get; set; }

    public byte KartNo { get; set; }

    public string? Data { get; set; }
}
