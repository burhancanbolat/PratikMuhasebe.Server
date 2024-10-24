using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class RbItem
{
    public int FolderId { get; set; }

    public string ItemName { get; set; } = null!;

    public int ItemType { get; set; }

    public DateTime Modified { get; set; }

    public int ItemId { get; set; }

    public int? ItemSize { get; set; }

    public DateTime? Deleted { get; set; }

    public byte[]? Template { get; set; }
}
