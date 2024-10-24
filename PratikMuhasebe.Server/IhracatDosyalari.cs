using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IhracatDosyalari
{
    public Guid IhrGuid { get; set; }

    public short IhrDbcno { get; set; }

    public int? IhrSpecRecNo { get; set; }

    public bool? IhrIptal { get; set; }

    public short? IhrFileid { get; set; }

    public bool? IhrHidden { get; set; }

    public bool? IhrKilitli { get; set; }

    public bool? IhrDegisti { get; set; }

    public int? IhrChecksum { get; set; }

    public short? IhrCreateUser { get; set; }

    public DateTime IhrCreateDate { get; set; }

    public short? IhrLastupUser { get; set; }

    public DateTime? IhrLastupDate { get; set; }

    public string? IhrSpecial1 { get; set; }

    public string? IhrSpecial2 { get; set; }

    public string? IhrSpecial3 { get; set; }

    public int? IhrFirmano { get; set; }

    public int? IhrSubeno { get; set; }

    public string? IhrKodu { get; set; }

    public string? IhrIsmi { get; set; }

    public string? IhrSatici { get; set; }

    public byte? IhrUlkeTipi { get; set; }

    public string? IhrUlkeKodu { get; set; }

    public string? IhrGumrukKodu { get; set; }

    public byte? IhrTeslimSekli { get; set; }

    public byte? IhrOdemeSekli { get; set; }

    public byte? IhrCarigrupno { get; set; }

    public byte? IhrDovizCinsi { get; set; }

    public string? IhrAraciBanka { get; set; }

    public DateTime? IhrGcbTarihi { get; set; }

    public string? IhrGcbNo { get; set; }

    public byte? IhrTasima { get; set; }

    public string? IhrVasitaNo { get; set; }

    public string? IhrNakliyeci { get; set; }

    public string? IhrGumrukMusaviri { get; set; }

    public DateTime? IhrIntacTarihi { get; set; }

    public byte? IhrCikisUlkeTipi { get; set; }

    public string? IhrCikisUlkekodu { get; set; }

    public byte? IhrMenseUlkeTipi { get; set; }

    public string? IhrMenseUlkekodu { get; set; }

    public string? IhrAraciCariKodu { get; set; }

    public string? IhrAkreditif { get; set; }

    public byte? IhrGcbEtgb { get; set; }
}
