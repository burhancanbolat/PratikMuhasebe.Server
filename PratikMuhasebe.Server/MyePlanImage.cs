using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyePlanImage
{
    public int PiTableId { get; set; }

    public Guid PiRecordUid { get; set; }

    public byte[]? PiImage { get; set; }

    public int? PiLeftmargin { get; set; }

    public int? PiTopmargin { get; set; }

    public int? PiZoom { get; set; }
}
