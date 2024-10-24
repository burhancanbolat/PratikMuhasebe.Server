using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyeAttachedFile
{
    public int TableId { get; set; }

    public Guid RecordUid { get; set; }

    public int AttachmentNo { get; set; }

    public string? FileName { get; set; }
}
