using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class NakitAkisTablosu
{
    public Guid NakakGuid { get; set; }

    public short NakakDbcno { get; set; }

    public int? NakakSpecRecno { get; set; }

    public bool? NakakIptal { get; set; }

    public short? NakakFileid { get; set; }

    public bool? NakakHidden { get; set; }

    public bool? NakakKilitli { get; set; }

    public bool? NakakDegisti { get; set; }

    public int? NakakCheckSum { get; set; }

    public short? NakakCreateUser { get; set; }

    public DateTime NakakCreateDate { get; set; }

    public short? NakakLastupUser { get; set; }

    public DateTime? NakakLastupDate { get; set; }

    public string? NakakSpecial1 { get; set; }

    public string? NakakSpecial2 { get; set; }

    public string? NakakSpecial3 { get; set; }

    public string? NakakNaveritabani { get; set; }

    public int? NakakNafirmano { get; set; }

    public DateTime? NakakNavade { get; set; }

    public byte? NakakNatip { get; set; }

    public string? NakakNaref { get; set; }

    public string? NakakNaaciklama { get; set; }

    public double? NakakNatutar { get; set; }

    public double? NakakNaAltDovTutar { get; set; }

    public double? NakakNaOrjDovTutar { get; set; }

    public byte? NakakNacaricins { get; set; }

    public string? NakakNakod { get; set; }

    public string? NakakNaisim { get; set; }

    public byte? NakakNaOrjDovCinsi { get; set; }

    public string? NakakProje { get; set; }

    public string? NakakSrmmrk { get; set; }
}
