using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokCariKampanyaTanimlari
{
    public Guid KampanyaGuid { get; set; }

    public short KampanyaDbcno { get; set; }

    public int? KampanyaSpecRecno { get; set; }

    public bool? KampanyaIptal { get; set; }

    public short? KampanyaFileid { get; set; }

    public bool? KampanyaHidden { get; set; }

    public bool? KampanyaKilitli { get; set; }

    public bool? KampanyaDegisti { get; set; }

    public int? KampanyaChecksum { get; set; }

    public short? KampanyaCreateUser { get; set; }

    public DateTime KampanyaCreateDate { get; set; }

    public short? KampanyaLastupUser { get; set; }

    public DateTime? KampanyaLastupDate { get; set; }

    public string? KampanyaSpecial1 { get; set; }

    public string? KampanyaSpecial2 { get; set; }

    public string? KampanyaSpecial3 { get; set; }

    public string? KampanyaStokKod { get; set; }

    public string? KampanyaCariKod { get; set; }

    public string? KampanyaAciklama { get; set; }

    public int? KampanyaIlaveVade { get; set; }

    public double? KampanyaIlaveIskonto { get; set; }

    public byte? KampanyaIskontoNo { get; set; }
}
