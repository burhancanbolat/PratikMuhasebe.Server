using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiralamaSevkHareketleri
{
    public Guid KsvkGuid { get; set; }

    public short KsvkDbcno { get; set; }

    public int? KsvkSpecRecNo { get; set; }

    public bool? KsvkIptal { get; set; }

    public short? KsvkFileid { get; set; }

    public bool? KsvkHidden { get; set; }

    public bool? KsvkKilitli { get; set; }

    public bool? KsvkDegisti { get; set; }

    public int? KsvkChecksum { get; set; }

    public short? KsvkCreateUser { get; set; }

    public DateTime KsvkCreateDate { get; set; }

    public short? KsvkLastupUser { get; set; }

    public DateTime? KsvkLastupDate { get; set; }

    public string? KsvkSpecial1 { get; set; }

    public string? KsvkSpecial2 { get; set; }

    public string? KsvkSpecial3 { get; set; }

    public int? KsvkFirmano { get; set; }

    public int? KsvkSubeno { get; set; }

    public DateTime? KsvkTarihi { get; set; }

    public string? KsvkEvraknoSeri { get; set; }

    public int? KsvkEvraknoSira { get; set; }

    public int? KsvkSatirno { get; set; }

    public string? KsvkBelgeno { get; set; }

    public DateTime? KsvkBelgeTarihi { get; set; }

    public string? KsvkCariKodu { get; set; }

    public int? KsvkAdresNo { get; set; }

    public string? KsvkKirakodu { get; set; }

    public byte? KsvkGirisCikis { get; set; }

    public int? KsvkDepono { get; set; }

    public string? KsvkNakliyeCariKodu { get; set; }

    public string? KsvkHareketKodu { get; set; }

    public string? KsvkSeriNo { get; set; }

    public DateTime? KsvkSevktarihi { get; set; }

    public string? KsvkSatirAciklama { get; set; }

    public Guid? KsvkKharUid { get; set; }

    public int? KsvkKmsayac { get; set; }

    public Guid? KsvkSisUid { get; set; }

    public byte? KsvkEirsSenaryo { get; set; }

    public byte? KsvkEirsTipi { get; set; }

    public DateTime? KsvkTeslimTarihi { get; set; }

    public bool? KsvkMatbuFl { get; set; }
}
