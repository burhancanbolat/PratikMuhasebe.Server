using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeRaporParam
{
    public int RapparMenuid { get; set; }

    public short RapparCreateuser { get; set; }

    public string RapparName { get; set; } = null!;

    public Guid RapparGuid { get; set; }

    public int? RapparSize { get; set; }

    public byte[]? RapparBuf { get; set; }
}
