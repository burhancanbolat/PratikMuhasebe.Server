using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeTextDatum
{
    public int TableId { get; set; }

    public Guid RecordUid { get; set; }

    public string? Data { get; set; }
}
