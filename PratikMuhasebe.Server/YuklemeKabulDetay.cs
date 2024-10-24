using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class YuklemeKabulDetay
{
    public Guid YkdGuid { get; set; }

    public short YkdDbcno { get; set; }

    public int? YkdSpecRecno { get; set; }

    public bool? YkdIptal { get; set; }

    public short? YkdFileid { get; set; }

    public bool? YkdHidden { get; set; }

    public bool? YkdKilitli { get; set; }

    public bool? YkdDegisti { get; set; }

    public int? YkdChecksum { get; set; }

    public short? YkdCreateUser { get; set; }

    public DateTime YkdCreateDate { get; set; }

    public short? YkdLastupUser { get; set; }

    public DateTime? YkdLastupDate { get; set; }

    public string? YkdSpecial1 { get; set; }

    public string? YkdSpecial2 { get; set; }

    public string? YkdSpecial3 { get; set; }

    public byte? YkdTipi { get; set; }

    public string? YkdYuklemeKabulKodu { get; set; }

    public Guid? YkdSiparisUid { get; set; }

    public double? YkdMiktar { get; set; }

    public string? YkdPartiKodu { get; set; }

    public int? YkdLotNo { get; set; }

    public string? YkdAciklama { get; set; }

    public int? YkdOnaylayanKullanici { get; set; }

    public byte? YkdDurumu { get; set; }

    public int? YkdDepono { get; set; }

    public double? YkdTeslimMiktar { get; set; }

    public int? YkdSirano { get; set; }
}
