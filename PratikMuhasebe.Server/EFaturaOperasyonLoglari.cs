using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EFaturaOperasyonLoglari
{
    public Guid EfolGuid { get; set; }

    public short EfolDbcno { get; set; }

    public int? EfolSpecRecno { get; set; }

    public bool? EfolIptal { get; set; }

    public short? EfolFileid { get; set; }

    public bool? EfolHidden { get; set; }

    public bool? EfolKilitli { get; set; }

    public bool? EfolDegisti { get; set; }

    public int? EfolChecksum { get; set; }

    public short? EfolCreateUser { get; set; }

    public DateTime EfolCreateDate { get; set; }

    public short? EfolLastupUser { get; set; }

    public DateTime? EfolLastupDate { get; set; }

    public string? EfolSpecial1 { get; set; }

    public string? EfolSpecial2 { get; set; }

    public string? EfolSpecial3 { get; set; }

    public int? EfolFirmano { get; set; }

    public byte? EfolTipi { get; set; }

    public string? EfolGibFatno { get; set; }

    public string? EfolMusVkn { get; set; }

    public string? EfolUuid { get; set; }

    public short? EfolLogKodu { get; set; }

    public string? EfolLogAciklama { get; set; }

    public DateTime? EfolIlktarih { get; set; }

    public DateTime? EfolSontarih { get; set; }

    public string? EfolIslemId { get; set; }

    public string? EfolEvraknoSeri { get; set; }

    public int? EfolEvraknoSira { get; set; }

    public string? EfolMusUnvan { get; set; }

    public string? EfolBagliirsGibno { get; set; }
}
