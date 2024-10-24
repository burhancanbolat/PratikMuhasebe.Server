using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmkapiTanimlari
{
    public Guid KapiGuid { get; set; }

    public short KapiDbcno { get; set; }

    public int? KapiSpecRecno { get; set; }

    public bool? KapiIptal { get; set; }

    public short? KapiFileid { get; set; }

    public bool? KapiHidden { get; set; }

    public bool? KapiKilitli { get; set; }

    public bool? KapiDegisti { get; set; }

    public int? KapiChecksum { get; set; }

    public short? KapiCreateUser { get; set; }

    public DateTime KapiCreateDate { get; set; }

    public short? KapiLastupUser { get; set; }

    public DateTime? KapiLastupDate { get; set; }

    public string? KapiSpecial1 { get; set; }

    public string? KapiSpecial2 { get; set; }

    public string? KapiSpecial3 { get; set; }

    public string? KapiSitekod { get; set; }

    public string? KapiBlokkod { get; set; }

    public string? KapiKatkod { get; set; }

    public string? KapiKod { get; set; }

    public string? KapiIsmi { get; set; }

    public byte? KapiTuru { get; set; }
}
