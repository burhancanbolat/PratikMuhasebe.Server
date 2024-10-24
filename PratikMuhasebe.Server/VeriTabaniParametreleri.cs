using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class VeriTabaniParametreleri
{
    public int ParamRecno { get; set; }

    public short ParamId { get; set; }

    public short ParamItem { get; set; }

    public int? ParamSize { get; set; }

    public byte[]? ParamBuf { get; set; }
}
