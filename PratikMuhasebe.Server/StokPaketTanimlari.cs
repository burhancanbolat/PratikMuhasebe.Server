using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokPaketTanimlari
{
    public Guid PakGuid { get; set; }

    public short PakDbcno { get; set; }

    public int? PakSpecRecno { get; set; }

    public bool? PakIptal { get; set; }

    public short? PakFileid { get; set; }

    public bool? PakHidden { get; set; }

    public bool? PakKilitli { get; set; }

    public bool? PakDegisti { get; set; }

    public int? PakChecksum { get; set; }

    public short? PakCreateUser { get; set; }

    public DateTime PakCreateDate { get; set; }

    public short? PakLastupUser { get; set; }

    public DateTime? PakLastupDate { get; set; }

    public string? PakSpecial1 { get; set; }

    public string? PakSpecial2 { get; set; }

    public string? PakSpecial3 { get; set; }

    public string? PakKod { get; set; }

    public string? PakStokkod { get; set; }

    public double? PakMiktar { get; set; }

    public string? PakAciklama { get; set; }

    public int? PakSatirno { get; set; }

    public double? PakFiyat { get; set; }

    public byte? PakVergidahilfl { get; set; }

    public byte? PakMasterTip { get; set; }

    public byte? PakDetayTip { get; set; }

    public byte? PakDovizCins { get; set; }

    public byte? PakVeVeya { get; set; }

    public string? PakIsmi { get; set; }
}
