using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapHareketleriOzet
{
    public int ChoRecno { get; set; }

    public int? ChoFirmano { get; set; }

    public int? ChoSubeno { get; set; }

    public byte? ChoCinsi { get; set; }

    public string? ChoCariKodu { get; set; }

    public string? ChoProjeKodu { get; set; }

    public string? ChoSrmMerkezi { get; set; }

    public byte? ChoGrupNo { get; set; }

    public int? ChoMaliYil { get; set; }

    public byte? ChoDonem { get; set; }

    public byte? ChoHareketCins { get; set; }

    public double? ChoAnaBorc { get; set; }

    public double? ChoAnaAlacak { get; set; }

    public double? ChoAltBorc { get; set; }

    public double? ChoAltAlacak { get; set; }

    public double? ChoOrjBorc { get; set; }

    public double? ChoOrjAlacak { get; set; }
}
