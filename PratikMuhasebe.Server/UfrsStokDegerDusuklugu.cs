using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UfrsStokDegerDusuklugu
{
    public Guid UsddGuid { get; set; }

    public short UsddDbcno { get; set; }

    public int? UsddSpecRecno { get; set; }

    public bool? UsddIptal { get; set; }

    public short? UsddFileid { get; set; }

    public bool? UsddHidden { get; set; }

    public bool? UsddKilitli { get; set; }

    public bool? UsddDegisti { get; set; }

    public int? UsddChecksum { get; set; }

    public short? UsddCreateUser { get; set; }

    public DateTime UsddCreateDate { get; set; }

    public short? UsddLastupUser { get; set; }

    public DateTime? UsddLastupDate { get; set; }

    public string? UsddSpecial1 { get; set; }

    public string? UsddSpecial2 { get; set; }

    public string? UsddSpecial3 { get; set; }

    public DateTime? UsddTarih { get; set; }

    public int? UsddSatirno { get; set; }

    public string? UsddStokkodu { get; set; }

    public int? UsddDepono { get; set; }

    public double? UsddEnvantermiktar { get; set; }

    public double? UsddEnvanterdeger { get; set; }

    public double? UsddPiyasadegeri { get; set; }

    public double? UsddDegerfarki { get; set; }

    public byte? UsddStokdcinsi { get; set; }

    public double? UsddStokdkur { get; set; }

    public byte? UsddHardcinsi { get; set; }

    public double? UsddHardkur { get; set; }

    public double? UsddAltdkur { get; set; }
}
