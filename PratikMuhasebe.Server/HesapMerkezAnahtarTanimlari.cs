using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HesapMerkezAnahtarTanimlari
{
    public Guid HmaGuid { get; set; }

    public short HmaDbcno { get; set; }

    public int? HmaSpecRecno { get; set; }

    public bool? HmaIptal { get; set; }

    public short? HmaFileid { get; set; }

    public bool? HmaHidden { get; set; }

    public bool? HmaKilitli { get; set; }

    public bool? HmaDegisti { get; set; }

    public int? HmaCheckSum { get; set; }

    public short? HmaCreateUser { get; set; }

    public DateTime HmaCreateDate { get; set; }

    public short? HmaLastupUser { get; set; }

    public DateTime? HmaLastupDate { get; set; }

    public string? HmaSpecial1 { get; set; }

    public string? HmaSpecial2 { get; set; }

    public string? HmaSpecial3 { get; set; }

    public string? HmaHesapKodu { get; set; }

    public string? HmaSorMerkKodu { get; set; }

    public string? HmaDagAnahKodu { get; set; }

    public byte? HmaMaliyetDagitimSekli { get; set; }
}
