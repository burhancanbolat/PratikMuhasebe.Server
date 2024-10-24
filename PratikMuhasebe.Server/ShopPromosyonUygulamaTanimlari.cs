using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ShopPromosyonUygulamaTanimlari
{
    public Guid PruGuid { get; set; }

    public short PruDbcno { get; set; }

    public int? PruSpecRecno { get; set; }

    public bool? PruIptal { get; set; }

    public short? PruFileid { get; set; }

    public bool? PruHidden { get; set; }

    public bool? PruKilitli { get; set; }

    public bool? PruDegisti { get; set; }

    public int? PruCheckSum { get; set; }

    public short? PruCreateUser { get; set; }

    public DateTime PruCreateDate { get; set; }

    public short? PruLastupUser { get; set; }

    public DateTime? PruLastupDate { get; set; }

    public string? PruSpecial1 { get; set; }

    public string? PruSpecial2 { get; set; }

    public string? PruSpecial3 { get; set; }

    public string? PruPromosyon { get; set; }

    public string? PruKod { get; set; }

    public string? PruAciklama { get; set; }

    public int? PruUygulamaKodu { get; set; }

    public string? PruUrunler { get; set; }

    public bool? PruXxxdblAktif { get; set; }

    public string? PruMiktar { get; set; }

    public string? PruDeger { get; set; }

    public double? PruMiktarDbl { get; set; }

    public double? PruDegerDbl { get; set; }

    public byte? PruOzelDurum { get; set; }

    public byte? PruOzellikler { get; set; }

    public byte? PruIskontoDagitimSekli { get; set; }

    public byte? PruIskontoIndex { get; set; }

    public byte? PruYuvarlamaTipi { get; set; }

    public double? PruYuvarlamaMiktar { get; set; }

    public string? PruEksikseMesaj { get; set; }

    public string? PruKasaMesaji { get; set; }

    public string? PruEkbilgi { get; set; }
}
