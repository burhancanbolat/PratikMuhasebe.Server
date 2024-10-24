using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KargoTanimlari
{
    public Guid KrgGuid { get; set; }

    public short KrgDbcno { get; set; }

    public int? KrgSpecRecno { get; set; }

    public bool? KrgIptal { get; set; }

    public short? KrgFileid { get; set; }

    public bool? KrgHidden { get; set; }

    public bool? KrgKilitli { get; set; }

    public bool? KrgDegisti { get; set; }

    public int? KrgCheckSum { get; set; }

    public short? KrgCreateUser { get; set; }

    public DateTime KrgCreateDate { get; set; }

    public short? KrgLastupUser { get; set; }

    public DateTime? KrgLastupDate { get; set; }

    public string? KrgSpecial1 { get; set; }

    public string? KrgSpecial2 { get; set; }

    public string? KrgSpecial3 { get; set; }

    public string? KrgKodu { get; set; }

    public string? KrgAdi { get; set; }

    public byte? KrgTipi { get; set; }

    public string? KrgYetkili { get; set; }

    public string? KrgTel { get; set; }

    public string? KrgFax { get; set; }

    public string? KrgEmail { get; set; }
}
