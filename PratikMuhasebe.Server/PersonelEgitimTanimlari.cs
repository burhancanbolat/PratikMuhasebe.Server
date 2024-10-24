using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelEgitimTanimlari
{
    public Guid EgtGuid { get; set; }

    public short EgtDbcno { get; set; }

    public int? EgtSpecRecno { get; set; }

    public bool? EgtIptal { get; set; }

    public short? EgtFileid { get; set; }

    public bool? EgtHidden { get; set; }

    public bool? EgtKilitli { get; set; }

    public bool? EgtDegisti { get; set; }

    public int? EgtChecksum { get; set; }

    public short? EgtCreateUser { get; set; }

    public DateTime EgtCreateDate { get; set; }

    public short? EgtLastupUser { get; set; }

    public DateTime? EgtLastupDate { get; set; }

    public string? EgtSpecial1 { get; set; }

    public string? EgtSpecial2 { get; set; }

    public string? EgtSpecial3 { get; set; }

    public string? EgtKodu { get; set; }

    public string? EgtAdi { get; set; }

    public byte? EgtTipi { get; set; }

    public double? EgtPuan { get; set; }

    public int? EgtSuresi { get; set; }

    public byte? EgtPeryodu { get; set; }

    public double? EgtPeryotgunu { get; set; }

    public byte? EgtPerhaftasi { get; set; }

    public bool? EgtPergunu21 { get; set; }

    public bool? EgtPergunu22 { get; set; }

    public bool? EgtPergunu23 { get; set; }

    public bool? EgtPergunu24 { get; set; }

    public bool? EgtPergunu25 { get; set; }

    public bool? EgtPergunu26 { get; set; }

    public bool? EgtPergunu27 { get; set; }

    public DateTime? EgtBastar { get; set; }

    public DateTime? EgtBitistar { get; set; }

    public double? EgtPlanButce { get; set; }

    public byte? EgtDovizCinsi { get; set; }

    public double? EgtDovizKuru { get; set; }

    public string? EgtEgitimYerKodu { get; set; }

    public string? EgtKonuKodu { get; set; }

    public string? EgtAmacKodu { get; set; }

    public string? EgtAciklama1 { get; set; }

    public string? EgtAciklama2 { get; set; }

    public string? EgtAciklama3 { get; set; }

    public int? EgtMaxKatilimci { get; set; }

    public bool? EgtSertifikaFl { get; set; }
}
