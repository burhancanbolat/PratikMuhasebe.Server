using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Urunler
{
    public Guid UruGuid { get; set; }

    public short UruDbcno { get; set; }

    public int? UruSpecRecno { get; set; }

    public bool? UruIptal { get; set; }

    public short? UruFileid { get; set; }

    public bool? UruHidden { get; set; }

    public bool? UruKilitli { get; set; }

    public bool? UruDegisti { get; set; }

    public int? UruChecksum { get; set; }

    public short? UruCreateUser { get; set; }

    public DateTime UruCreateDate { get; set; }

    public short? UruLastupUser { get; set; }

    public DateTime? UruLastupDate { get; set; }

    public string? UruSpecial1 { get; set; }

    public string? UruSpecial2 { get; set; }

    public string? UruSpecial3 { get; set; }

    public string? UruStokKod { get; set; }

    public double? UruGider1 { get; set; }

    public double? UruGider2 { get; set; }

    public double? UruGider3 { get; set; }

    public double? UruGider4 { get; set; }

    public double? UruGider5 { get; set; }

    public byte? UruTip { get; set; }

    public double? UruMaxFireYuz { get; set; }

    public double? UruMinFireYuz { get; set; }

    public double? UruFasonmaliyet { get; set; }

    public double? UruPartimiktari { get; set; }

    public string? UruIsemriId { get; set; }

    public double? UruUretimortakcarpani { get; set; }

    public byte? UruUretimsekli { get; set; }

    public string? UruFormdosyaadi { get; set; }

    public string? UruExcdosyaadi { get; set; }

    public int? UruOngorulendepo { get; set; }

    public double? UruGider6 { get; set; }

    public double? UruGider7 { get; set; }

    public double? UruGider8 { get; set; }

    public double? UruGider9 { get; set; }

    public double? UruGider10 { get; set; }

    public byte? UruOzelTipi { get; set; }

    public double? UruSabitmlytAnauruncarpan { get; set; }

    public string? UruMasterrecete { get; set; }

    public string? UruSorumlulukMerkezi { get; set; }

    public string? UruVarsayilanismerkezi { get; set; }

    public string? UruMuhgrupKodu { get; set; }

    public string? UruMasterkalipKodu { get; set; }

    public string? UruReceteIsmi1 { get; set; }

    public string? UruReceteIsmi2 { get; set; }

    public string? UruReceteIsmi3 { get; set; }

    public string? UruReceteIsmi4 { get; set; }

    public string? UruReceteIsmi5 { get; set; }

    public string? UruVarsayilanReceteTanimKodu { get; set; }

    public byte? UruVarsayilanReceteCins { get; set; }
}
