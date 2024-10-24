using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelKadroEgitimleri
{
    public Guid KeGuid { get; set; }

    public short KeDbcno { get; set; }

    public int? KeSpecRecno { get; set; }

    public bool? KeIptal { get; set; }

    public short? KeFileid { get; set; }

    public bool? KeHidden { get; set; }

    public bool? KeKilitli { get; set; }

    public bool? KeDegisti { get; set; }

    public int? KeChecksum { get; set; }

    public short? KeCreateUser { get; set; }

    public DateTime KeCreateDate { get; set; }

    public short? KeLastupUser { get; set; }

    public DateTime? KeLastupDate { get; set; }

    public string? KeSpecial1 { get; set; }

    public string? KeSpecial2 { get; set; }

    public string? KeSpecial3 { get; set; }

    public string? KeKadrokod { get; set; }

    public int? KeKadrosirano { get; set; }

    public int? KeSatirno { get; set; }

    public byte? KeTipi { get; set; }

    public string? KeEgitimkod { get; set; }

    public DateTime? KeGecerliliktarihi { get; set; }

    public int? KeTamamlamaSuresi { get; set; }
}
