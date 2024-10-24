using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EFaturaDetaylari
{
    public Guid EfdGuid { get; set; }

    public short EfdDbcno { get; set; }

    public int? EfdSpecRecno { get; set; }

    public bool? EfdIptal { get; set; }

    public short? EfdFileid { get; set; }

    public bool? EfdHidden { get; set; }

    public bool? EfdKilitli { get; set; }

    public bool? EfdDegisti { get; set; }

    public int? EfdChecksum { get; set; }

    public short? EfdCreateUser { get; set; }

    public DateTime EfdCreateDate { get; set; }

    public short? EfdLastupUser { get; set; }

    public DateTime? EfdLastupDate { get; set; }

    public string? EfdSpecial1 { get; set; }

    public string? EfdSpecial2 { get; set; }

    public string? EfdSpecial3 { get; set; }

    public int? EfdFirmano { get; set; }

    public byte? EfdTipi { get; set; }

    public string? EfdGibSeri { get; set; }

    public int? EfdGibSira { get; set; }

    public string? EfdUuid { get; set; }

    public Guid? EfdFatUid { get; set; }

    public byte? EfdPozisyon { get; set; }

    public string? EfdMVkn { get; set; }

    public string? EfdToken { get; set; }
}
