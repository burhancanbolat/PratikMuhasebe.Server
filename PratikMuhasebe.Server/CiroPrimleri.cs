using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CiroPrimleri
{
    public Guid CprGuid { get; set; }

    public short CprDbcno { get; set; }

    public int? CprSpecRecno { get; set; }

    public bool? CprIptal { get; set; }

    public short? CprFileid { get; set; }

    public bool? CprHidden { get; set; }

    public bool? CprKilitli { get; set; }

    public bool? CprDegisti { get; set; }

    public int? CprChecksum { get; set; }

    public short? CprCreateUser { get; set; }

    public DateTime CprCreateDate { get; set; }

    public short? CprLastupUser { get; set; }

    public DateTime? CprLastupDate { get; set; }

    public string? CprSpecial1 { get; set; }

    public string? CprSpecial2 { get; set; }

    public string? CprSpecial3 { get; set; }

    public int? CprFirmano { get; set; }

    public int? CprSubeno { get; set; }

    public string? CprBaglicarikod { get; set; }

    public int? CprNumarasi { get; set; }

    public string? CprCarisozlesmekodu { get; set; }

    public int? CprSatirno { get; set; }

    public DateTime? CprTarihi { get; set; }

    public string? CprAciklama { get; set; }

    public byte? CprUygulamasekli { get; set; }

    public byte? CprIadelergozardi { get; set; }

    public byte? CprHesapsekli { get; set; }

    public byte? CprStokindex { get; set; }

    public string? CprStokbaglantikodu { get; set; }

    public byte? CprStokindex2 { get; set; }

    public string? CprStokbaglantikodu2 { get; set; }

    public byte? CprStokindex3 { get; set; }

    public string? CprStokbaglantikodu3 { get; set; }

    public byte? CprStokindex4 { get; set; }

    public string? CprStokbaglantikodu4 { get; set; }

    public byte? CprStokindex5 { get; set; }

    public string? CprStokbaglantikodu5 { get; set; }

    public string? CprSrmmrkkodu { get; set; }

    public string? CprStoksrmmrkkodu { get; set; }

    public string? CprHizmetkodu { get; set; }

    public DateTime? CprBaslangictarihi { get; set; }

    public DateTime? CprBitistarihi { get; set; }

    public double? CprPrimeesasdeger1 { get; set; }

    public double? CprPrimeesasdeger2 { get; set; }

    public double? CprPrimeesasdeger3 { get; set; }

    public double? CprPrimeesasdeger4 { get; set; }

    public double? CprPrimeesasdeger5 { get; set; }

    public double? CprPrimorani1 { get; set; }

    public double? CprPrimorani2 { get; set; }

    public double? CprPrimorani3 { get; set; }

    public double? CprPrimorani4 { get; set; }

    public double? CprPrimorani5 { get; set; }

    public string? CprFaturaseri { get; set; }

    public int? CprFaturasira { get; set; }

    public byte? CprPrimisrmmrkleredagit { get; set; }

    public int? CprOdemeplani { get; set; }

    public bool? CprAltcaridegerlendir { get; set; }

    public bool? CprFiyatfarkidegerlendirme { get; set; }

    public byte? CprCiroprimfaturatipi { get; set; }

    public byte? CprMiktarsaltavancarpantipi { get; set; }

    public byte? CprPrimeesastavantipi { get; set; }

    public bool? CprPrimevergidahil { get; set; }

    public int? CprDepono { get; set; }

    public bool? CprPrimvergidetayli { get; set; }

    public bool? CprHesapfaturatarihinden { get; set; }

    public byte? CprDepobaglantitip1 { get; set; }

    public int? CprDepobaglantino1 { get; set; }

    public string? CprDepobaglantikodu1 { get; set; }

    public byte? CprDepobaglantitip2 { get; set; }

    public int? CprDepobaglantino2 { get; set; }

    public string? CprDepobaglantikodu2 { get; set; }

    public byte? CprDepobaglantitip3 { get; set; }

    public int? CprDepobaglantino3 { get; set; }

    public string? CprDepobaglantikodu3 { get; set; }

    public bool? CprIrsaliyedegerlendir { get; set; }

    public string? CprFaturalanacakcarikod { get; set; }
}
