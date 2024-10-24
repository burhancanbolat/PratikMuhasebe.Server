using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MyePlanPin
{
    public int PpTableId { get; set; }

    public Guid PpRecordUid { get; set; }

    public int PpOrder { get; set; }

    public int? PpPointx { get; set; }

    public int? PpPointy { get; set; }

    public int? PpColor { get; set; }

    public Guid PpConRecordUid { get; set; }
}
