using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TabloTriggerParametre
{
    public Guid Tdpguid { get; set; }

    public int? TdptabloId { get; set; }

    public int? TdptabloSatirNo { get; set; }

    public bool? TdptetikNew { get; set; }

    public bool? TdptetikRef { get; set; }

    public bool? TdptetikDel { get; set; }

    public string? Tdpwhere { get; set; }

    public string? TdponDeger { get; set; }

    public string? Tdptrigger { get; set; }

    public string? TdpuserIds { get; set; }

    public string? TdpuyariMsj { get; set; }

    public bool? TdppasifFl { get; set; }
}
