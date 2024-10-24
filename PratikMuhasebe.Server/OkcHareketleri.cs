using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OkcHareketleri
{
    public Guid OkcGuid { get; set; }

    public short OkcDbcno { get; set; }

    public int? OkcSpecRecno { get; set; }

    public bool? OkcIptal { get; set; }

    public short? OkcFileid { get; set; }

    public bool? OkcHidden { get; set; }

    public bool? OkcKilitli { get; set; }

    public bool? OkcDegisti { get; set; }

    public int? OkcCheckSum { get; set; }

    public short? OkcCreateUser { get; set; }

    public DateTime OkcCreateDate { get; set; }

    public short? OkcLastupUser { get; set; }

    public DateTime? OkcLastupDate { get; set; }

    public string? OkcSpecial1 { get; set; }

    public string? OkcSpecial2 { get; set; }

    public string? OkcSpecial3 { get; set; }

    public int? OkcFisNo { get; set; }

    public byte? OkcFisTipi { get; set; }

    public DateTime? OkcFisTarihi { get; set; }

    public int? OkcZraporNo { get; set; }

    public DateTime? OkcFisIrsaliyeTarihi { get; set; }

    public string? OkcSeriNo { get; set; }

    public string? OkcUuid { get; set; }
}
