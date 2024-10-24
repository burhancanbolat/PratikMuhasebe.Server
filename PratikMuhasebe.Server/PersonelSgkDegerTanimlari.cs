using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelSgkDegerTanimlari
{
    public Guid PsgkGuid { get; set; }

    public short PsgkDbcno { get; set; }

    public int? PsgkSpecRecno { get; set; }

    public bool? PsgkIptal { get; set; }

    public short? PsgkFileid { get; set; }

    public bool? PsgkHidden { get; set; }

    public bool? PsgkKilitli { get; set; }

    public bool? PsgkDegisti { get; set; }

    public int? PsgkChecksum { get; set; }

    public short? PsgkCreateUser { get; set; }

    public DateTime PsgkCreateDate { get; set; }

    public short? PsgkLastupUser { get; set; }

    public DateTime? PsgkLastupDate { get; set; }

    public string? PsgkSpecial1 { get; set; }

    public string? PsgkSpecial2 { get; set; }

    public string? PsgkSpecial3 { get; set; }

    public string? PsgkKodu { get; set; }

    public string? PsgkAdi { get; set; }

    public byte? PsgkTehlikeDerecesi { get; set; }

    public double? PsgkKazaYuzdesi { get; set; }

    public double? PsgkSskYuzde { get; set; }

    public double? PsgkAnaSig { get; set; }

    public double? PsgkHastSig { get; set; }

    public double? PsgkYasOlSig { get; set; }

    public double? PsgkSgdpOrani { get; set; }

    public double? PsgkGenelSaglikSig { get; set; }

    public double? PsgkMalullukMuafiyet { get; set; }

    public double? PsgkGeciciMadde17GunlukDestek { get; set; }

    public double? PsgkIssizlikSigortasiPerPayi { get; set; }

    public double? PsgkIssizlikSigortasiIsverenPayi { get; set; }

    public double? PsgkYasolumItibarihizmet { get; set; }
}
