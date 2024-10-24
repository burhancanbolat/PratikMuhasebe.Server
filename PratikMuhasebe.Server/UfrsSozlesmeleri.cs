using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UfrsSozlesmeleri
{
    public Guid UsozGuid { get; set; }

    public short UsozDbcno { get; set; }

    public int? UsozSpecRecno { get; set; }

    public bool? UsozIptal { get; set; }

    public short? UsozFileid { get; set; }

    public bool? UsozHidden { get; set; }

    public bool? UsozKilitli { get; set; }

    public bool? UsozDegisti { get; set; }

    public int? UsozChecksum { get; set; }

    public short? UsozCreateUser { get; set; }

    public DateTime UsozCreateDate { get; set; }

    public short? UsozLastupUser { get; set; }

    public DateTime? UsozLastupDate { get; set; }

    public string? UsozSpecial1 { get; set; }

    public string? UsozSpecial2 { get; set; }

    public string? UsozSpecial3 { get; set; }

    public byte? UsozSiptip { get; set; }

    public byte? UsozSipcins { get; set; }

    public string? UsozSipevrakseri { get; set; }

    public int? UsozSipevraksira { get; set; }

    public string? UsozAciklama { get; set; }

    public DateTime? UsozSiptarih { get; set; }

    public string? UsozSipcarikodu { get; set; }

    public byte? UsozSipcarigrupno { get; set; }

    public double? UsozFaizorani { get; set; }

    public int? UsozOdemeplani { get; set; }

    public double? UsozToplamtutar { get; set; }

    public byte? UsozDovizcinsi { get; set; }

    public byte? UsozSozlesmetipi { get; set; }

    public byte? UsozMulkiyetnereden { get; set; }

    public byte? UsozVadenereden { get; set; }

    public DateTime? UsozMulkiyettarihi { get; set; }
}
