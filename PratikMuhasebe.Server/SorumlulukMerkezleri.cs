using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SorumlulukMerkezleri
{
    public Guid SomGuid { get; set; }

    public short SomDbcno { get; set; }

    public int? SomSpecRecno { get; set; }

    public bool? SomIptal { get; set; }

    public short? SomFileid { get; set; }

    public bool? SomHidden { get; set; }

    public bool? SomKilitli { get; set; }

    public bool? SomDegisti { get; set; }

    public int? SomChecksum { get; set; }

    public short? SomCreateUser { get; set; }

    public DateTime SomCreateDate { get; set; }

    public short? SomLastupUser { get; set; }

    public DateTime? SomLastupDate { get; set; }

    public string? SomSpecial1 { get; set; }

    public string? SomSpecial2 { get; set; }

    public string? SomSpecial3 { get; set; }


    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public string? SomKod { get; set; }

    public string? SomIsim { get; set; }

    public bool? SomDogrudanUrtSrmMrk { get; set; }

    public byte? SomMasrafNereyeYuklenecek { get; set; }

    public string? SomDagAnahKodu { get; set; }

    public string? SomMuhArtikeli { get; set; }

    public byte? SomMaliyetDagitimSekli { get; set; }

    public byte? SomMaliyetDagitimKaynak { get; set; }

    public byte? SomTipi { get; set; }

    public int? SomSatisFiyatListeNo { get; set; }
}
