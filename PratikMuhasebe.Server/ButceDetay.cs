using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ButceDetay
{
    public Guid BdGuid { get; set; }

    public short BdDbcno { get; set; }

    public int? BdSpecRecno { get; set; }

    public bool? BdIptal { get; set; }

    public short? BdFileid { get; set; }

    public bool? BdHidden { get; set; }

    public bool? BdKilitli { get; set; }

    public bool? BdDegisti { get; set; }

    public int? BdChecksum { get; set; }

    public short? BdCreateUser { get; set; }

    public DateTime BdCreateDate { get; set; }

    public short? BdLastupUser { get; set; }

    public DateTime? BdLastupDate { get; set; }

    public string? BdSpecial1 { get; set; }

    public string? BdSpecial2 { get; set; }

    public string? BdSpecial3 { get; set; }

    public string BdButcekodu { get; set; } = null!;

    public byte? BdStokHizmet { get; set; }

    public string? BdShDetayKodu { get; set; }

    public string? BdMasrafDetayKodu { get; set; }

    public string? BdCariDetayKodu { get; set; }

    public string? BdSorumluDetayKodu { get; set; }

    public string? BdDepoDetayKodu { get; set; }

    public string? BdSormrkDetayKodu { get; set; }

    public string? BdProjeDetayKodu { get; set; }

    public string? BdDonem { get; set; }

    public double? BdDegerHedef1 { get; set; }

    public double? BdDegerDurum1 { get; set; }

    public double? BdDegerHedef2 { get; set; }

    public double? BdDegerDurum2 { get; set; }

    public double? BdDegerHedef3 { get; set; }

    public double? BdDegerDurum3 { get; set; }

    public double? BdDegerHedef4 { get; set; }

    public double? BdDegerDurum4 { get; set; }

    public double? BdDegerHedef5 { get; set; }

    public double? BdDegerDurum5 { get; set; }

    public double? BdSiparisDurum1 { get; set; }

    public double? BdSiparisDurum2 { get; set; }

    public double? BdSiparisDurum3 { get; set; }

    public double? BdSiparisDurum4 { get; set; }

    public double? BdSiparisDurum5 { get; set; }
}
