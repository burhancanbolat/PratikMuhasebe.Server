using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DiibTanimlari
{
    public Guid DiGuid { get; set; }

    public short DiDbcno { get; set; }

    public int? DiSpecRecNo { get; set; }

    public bool? DiIptal { get; set; }

    public short? DiFileid { get; set; }

    public bool? DiHidden { get; set; }

    public bool? DiKilitli { get; set; }

    public bool? DiDegisti { get; set; }

    public int? DiChecksum { get; set; }

    public short? DiCreateUser { get; set; }

    public DateTime DiCreateDate { get; set; }

    public short? DiLastupUser { get; set; }

    public DateTime? DiLastupDate { get; set; }

    public string? DiSpecial1 { get; set; }

    public string? DiSpecial2 { get; set; }

    public string? DiSpecial3 { get; set; }

    public string? DiNosu { get; set; }

    public DateTime? DiTarih { get; set; }

    public byte? DiTipi { get; set; }

    public DateTime? DiBitisTarihi { get; set; }
}
