using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SayimSonuclari
{
    public Guid SymGuid { get; set; }

    public short SymDbcno { get; set; }

    public int? SymSpecRecno { get; set; }

    public bool? SymIptal { get; set; }

    public short? SymFileid { get; set; }

    public bool? SymHidden { get; set; }

    public bool? SymKilitli { get; set; }

    public bool? SymDegisti { get; set; }

    public int? SymChecksum { get; set; }

    public short? SymCreateUser { get; set; }

    public DateTime SymCreateDate { get; set; }

    public short? SymLastupUser { get; set; }

    public DateTime? SymLastupDate { get; set; }

    public string? SymSpecial1 { get; set; }

    public string? SymSpecial2 { get; set; }

    public string? SymSpecial3 { get; set; }

    public DateTime? SymTarihi { get; set; }

    public int? SymDepono { get; set; }

    public int? SymEvrakno { get; set; }

    public int? SymSatirno { get; set; }

    public string? SymStokkodu { get; set; }

    public string? SymReyonkodu { get; set; }

    public string? SymKoridorkodu { get; set; }

    public string? SymRafkodu { get; set; }

    public double? SymMiktar1 { get; set; }

    public double? SymMiktar2 { get; set; }

    public double? SymMiktar3 { get; set; }

    public double? SymMiktar4 { get; set; }

    public double? SymMiktar5 { get; set; }

    public byte? SymBirimPntr { get; set; }

    public string? SymBarkod { get; set; }

    public int? SymRenkno { get; set; }

    public int? SymBedenno { get; set; }

    public string? SymPartiKodu { get; set; }

    public int? SymLotNo { get; set; }

    public string? SymSerino { get; set; }
}
