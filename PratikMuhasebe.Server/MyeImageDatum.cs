using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeImageDatum
{
    public int TableId { get; set; }

    public Guid RecordUid { get; set; }

    public int ImageId { get; set; }

    public byte[]? Data { get; set; }
}
