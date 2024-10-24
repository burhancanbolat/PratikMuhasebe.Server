using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SiparislerOzet
{
    public int SoRecno { get; set; }

    public int? SoFirmano { get; set; }

    public int? SoSubeno { get; set; }

    public byte? SoTipi { get; set; }

    public string? SoKodu { get; set; }

    public string? SoSrmMerkezi { get; set; }

    public string? SoProjeKodu { get; set; }

    public int? SoDepo { get; set; }

    public int? SoMaliYil { get; set; }

    public byte? SoDonem { get; set; }

    public byte? SoHareketCins { get; set; }

    public double? SoTalepMiktar { get; set; }

    public double? SoTalepKarsilanan { get; set; }

    public double? SoTalepKapanan { get; set; }

    public double? SoTeminMiktar { get; set; }

    public double? SoTeminKarsilanan { get; set; }

    public double? SoTeminKapanan { get; set; }
}
