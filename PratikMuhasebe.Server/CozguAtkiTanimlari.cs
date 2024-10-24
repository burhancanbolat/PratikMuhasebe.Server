using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CozguAtkiTanimlari
{
    public Guid CaGuid { get; set; }

    public short CaDbcno { get; set; }

    public int? CaSpecRecno { get; set; }

    public bool? CaIptal { get; set; }

    public short? CaFileid { get; set; }

    public bool? CaHidden { get; set; }

    public bool? CaKilitli { get; set; }

    public bool? CaDegisti { get; set; }

    public int? CaChecksum { get; set; }

    public short? CaCreateUser { get; set; }

    public DateTime CaCreateDate { get; set; }

    public short? CaLastupUser { get; set; }

    public DateTime? CaLastupDate { get; set; }

    public string? CaSpecial1 { get; set; }

    public string? CaSpecial2 { get; set; }

    public string? CaSpecial3 { get; set; }

    public byte? CaCozguAtki { get; set; }

    public string? CaStokKodu { get; set; }

    public byte? CaRaporIplik { get; set; }

    public int? CaId { get; set; }

    public int? CaParentId { get; set; }

    public string? CaAdi { get; set; }

    public int? CaTekrarTelSayisi { get; set; }

    public byte? CaRaporTipi { get; set; }

    public double? CaRaporBoyu { get; set; }
}
