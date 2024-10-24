using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeTableFilter
{
    public int UserId { get; set; }

    public int TableId { get; set; }

    public string? FilterStr { get; set; }

    public byte[]? FilterStream { get; set; }
}
