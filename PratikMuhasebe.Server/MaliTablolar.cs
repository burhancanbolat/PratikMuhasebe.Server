using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MaliTablolar
{
    public Guid MtGuid { get; set; }

    public short MtDbcno { get; set; }

    public int? MtSpecRecno { get; set; }

    public bool? MtIptal { get; set; }

    public short? MtFileid { get; set; }

    public bool? MtHidden { get; set; }

    public bool? MtKilitli { get; set; }

    public bool? MtDegisti { get; set; }

    public int? MtCheckSum { get; set; }

    public short? MtCreateUser { get; set; }

    public DateTime MtCreateDate { get; set; }

    public short? MtLastupUser { get; set; }

    public DateTime? MtLastupDate { get; set; }

    public string? MtSpecial1 { get; set; }

    public string? MtSpecial2 { get; set; }

    public string? MtSpecial3 { get; set; }

    public byte? MtTablo { get; set; }

    public int? MtSirano { get; set; }

    public string? MtDilAciklamasiT { get; set; }

    public string? MtDilAciklamasiE { get; set; }

    public string? MtDilAciklamasiG { get; set; }

    public string? MtDilAciklamasiA { get; set; }

    public string? MtDilAciklamasiR { get; set; }

    public string? MtDilAciklamasiB { get; set; }

    public string? MtDilAciklamasiP { get; set; }

    public int? MtTipi { get; set; }

    public string? MtHesapVeyaFormul { get; set; }

    public double? MtGiris { get; set; }

    public double? MtEskiDonem { get; set; }

    public int? MtSeviye { get; set; }

    public string? MtRaporAdi { get; set; }
}
