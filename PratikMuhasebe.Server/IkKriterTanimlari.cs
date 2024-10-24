using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IkKriterTanimlari
{
    public Guid IkkGuid { get; set; }

    public short IkkDbcno { get; set; }

    public int? IkkSpecRecno { get; set; }

    public bool? IkkIptal { get; set; }

    public short? IkkFileid { get; set; }

    public bool? IkkHidden { get; set; }

    public bool? IkkKilitli { get; set; }

    public bool? IkkDegisti { get; set; }

    public int? IkkChecksum { get; set; }

    public short? IkkCreateUser { get; set; }

    public DateTime IkkCreateDate { get; set; }

    public short? IkkLastupUser { get; set; }

    public DateTime? IkkLastupDate { get; set; }

    public string? IkkSpecial1 { get; set; }

    public string? IkkSpecial2 { get; set; }

    public string? IkkSpecial3 { get; set; }

    public int? IkkFirmano { get; set; }

    public int? IkkSubeno { get; set; }

    public byte? IkkTipi { get; set; }

    public string? IkkKodu { get; set; }

    public string? IkkAdi { get; set; }

    public string? IkkUzunadi { get; set; }

    public string? IkkAciklama1 { get; set; }

    public string? IkkAciklama2 { get; set; }

    public string? IkkAciklama3 { get; set; }

    public double? IkkMaxpuan { get; set; }

    public double? IkkAgirlikOrt { get; set; }
}
