using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ProgramLoglari
{
    public Guid LogGuid { get; set; }

    public short LogDbcno { get; set; }

    public int? LogSpecRecno { get; set; }

    public bool? LogIptal { get; set; }

    public short? LogFileid { get; set; }

    public bool? LogHidden { get; set; }

    public bool? LogKilitli { get; set; }

    public bool? LogDegisti { get; set; }

    public int? LogChecksum { get; set; }

    public short? LogCreateUser { get; set; }

    public DateTime LogCreateDate { get; set; }

    public short? LogLastupUser { get; set; }

    public DateTime? LogLastupDate { get; set; }

    public string? LogSpecial1 { get; set; }

    public string? LogSpecial2 { get; set; }

    public string? LogSpecial3 { get; set; }

    public byte? LogType { get; set; }

    public int? LogFirmano { get; set; }

    public int? LogSubeno { get; set; }

    public DateTime? LogTarihi { get; set; }

    public int? LogUser { get; set; }

    public short? LogPrgno { get; set; }

    public int? LogMenuno { get; set; }

    public string? LogAciklama { get; set; }
}
