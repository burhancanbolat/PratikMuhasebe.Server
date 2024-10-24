using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimPlanMatrisiDetay
{
    public Guid UpmdGuid { get; set; }

    public short UpmdDbcno { get; set; }

    public int? UpmdSpecRecno { get; set; }

    public bool? UpmdIptal { get; set; }

    public short? UpmdFileid { get; set; }

    public bool? UpmdHidden { get; set; }

    public bool? UpmdKilitli { get; set; }

    public bool? UpmdDegisti { get; set; }

    public int? UpmdChecksum { get; set; }

    public short? UpmdCreateUser { get; set; }

    public DateTime UpmdCreateDate { get; set; }

    public short? UpmdLastupUser { get; set; }

    public DateTime? UpmdLastupDate { get; set; }

    public string? UpmdSpecial1 { get; set; }

    public string? UpmdSpecial2 { get; set; }

    public string? UpmdSpecial3 { get; set; }

    public string? UpmdMatriskodu { get; set; }

    public string? UpmdStokkodu { get; set; }

    public byte? UpmdDonemno { get; set; }

    public double? UpmdMiktar { get; set; }
}
