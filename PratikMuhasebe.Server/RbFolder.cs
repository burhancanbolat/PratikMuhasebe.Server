using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class RbFolder
{
    public string FolderName { get; set; } = null!;

    public int ParentId { get; set; }

    public int FolderId { get; set; }
}
