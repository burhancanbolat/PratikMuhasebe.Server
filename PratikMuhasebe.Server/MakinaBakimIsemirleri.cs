using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MakinaBakimIsemirleri
{
    public Guid MakisemGuid { get; set; }

    public short MakisemDbcno { get; set; }

    public int? MakisemSpecRecno { get; set; }

    public bool? MakisemIptal { get; set; }

    public short? MakisemFileid { get; set; }

    public bool? MakisemHidden { get; set; }

    public bool? MakisemKilitli { get; set; }

    public bool? MakisemDegisti { get; set; }

    public int? MakisemChecksum { get; set; }

    public short? MakisemCreateUser { get; set; }

    public DateTime MakisemCreateDate { get; set; }

    public short? MakisemLastupUser { get; set; }

    public DateTime? MakisemLastupDate { get; set; }

    public string? MakisemSpecial1 { get; set; }

    public string? MakisemSpecial2 { get; set; }

    public string? MakisemSpecial3 { get; set; }

    public string? MakisemKod { get; set; }

    public string? MakisemIsim { get; set; }

    public string? MakisemAciklama { get; set; }

    public string? MakisemMakinaKod { get; set; }

    public string? MakisemSorunKod { get; set; }

    public string? MakisemAcanPer { get; set; }

    public DateTime? MakisemBasZaman { get; set; }

    public string? MakisemKapatanPer { get; set; }

    public DateTime? MakisemBitZaman { get; set; }

    public byte? MakisemDurumu { get; set; }

    public string? MakisemAciklama1 { get; set; }

    public string? MakisemAciklama2 { get; set; }

    public string? MakisemAciklama3 { get; set; }
}
