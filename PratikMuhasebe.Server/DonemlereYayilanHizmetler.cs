using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class DonemlereYayilanHizmetler
{
    public Guid DyhGuid { get; set; }

    public short DyhDbcno { get; set; }

    public int? DyhSpecRecNo { get; set; }

    public bool? DyhIptal { get; set; }

    public short? DyhFileid { get; set; }

    public bool? DyhHidden { get; set; }

    public bool? DyhKilitli { get; set; }

    public bool? DyhDegisti { get; set; }

    public int? DyhChecksum { get; set; }

    public short? DyhCreateUser { get; set; }

    public DateTime DyhCreateDate { get; set; }

    public short? DyhLastupUser { get; set; }

    public DateTime? DyhLastupDate { get; set; }

    public string? DyhSpecial1 { get; set; }

    public string? DyhSpecial2 { get; set; }

    public string? DyhSpecial3 { get; set; }

    public string? DyhKodu { get; set; }

    public string? DyhIsmi { get; set; }

    public string? DyhAciklama { get; set; }

    public byte? DyhTipi { get; set; }

    public int? DyhFirmano { get; set; }

    public int? DyhSubeno { get; set; }

    public string? DyhTipkod { get; set; }

    public string? DyhSinifkod { get; set; }

    public string? DyhGrupkod { get; set; }

    public string? DyhCarikodu { get; set; }

    public string? DyhBelgeno { get; set; }

    public DateTime? DyhBaslangictarihi { get; set; }

    public DateTime? DyhBitistarihi { get; set; }

    public byte? DyhDovizcinsi { get; set; }

    public double? DyhTutari { get; set; }

    public byte? DyhKdvpntr { get; set; }

    public byte? DyhStopajfonpntr { get; set; }

    public string? DyhMuhkod1 { get; set; }

    public string? DyhMuhkod2 { get; set; }

    public string? DyhHizmetmasrafkodu { get; set; }

    public string? DyhDagitimanahtarkodu { get; set; }

    public double? DyhUfrsTutari { get; set; }

    public string? DyhUfrsFarkMuhkod1 { get; set; }

    public string? DyhUfrsFarkMuhkod2 { get; set; }

    public string? DyhProjekodu { get; set; }

    public string? DyhSrmmrkkodu { get; set; }

    public byte? DyhHesaplamatipi { get; set; }

    public string? DyhBirim { get; set; }
}
