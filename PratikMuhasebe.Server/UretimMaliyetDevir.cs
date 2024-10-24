using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimMaliyetDevir
{
    public Guid UmdGuid { get; set; }

    public short UmdDbcno { get; set; }

    public int? UmdSpecRecno { get; set; }

    public bool? UmdIptal { get; set; }

    public short? UmdFileid { get; set; }

    public bool? UmdHidden { get; set; }

    public bool? UmdKilitli { get; set; }

    public bool? UmdDegisti { get; set; }

    public int? UmdChecksum { get; set; }

    public short? UmdCreateUser { get; set; }

    public DateTime UmdCreateDate { get; set; }

    public short? UmdLastupUser { get; set; }

    public DateTime? UmdLastupDate { get; set; }

    public string? UmdSpecial1 { get; set; }

    public string? UmdSpecial2 { get; set; }

    public string? UmdSpecial3 { get; set; }

    public string? UmdIsemrikodu { get; set; }

    public double? UmdSevkedilenMalzeme { get; set; }

    public double? UmdUruneYansiyanMalzeme { get; set; }

    public double? UmdUruneYansiyanDirektIscilik { get; set; }

    public double? UmdGerceklesenGenelUretim { get; set; }

    public double? UmdUruneYansiyanGenelUretim { get; set; }
}
