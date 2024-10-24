using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ZraporuHareketleri
{
    public Guid ZharGuid { get; set; }

    public short ZharDbcno { get; set; }

    public int? ZharSpecRecno { get; set; }

    public bool? ZharIptal { get; set; }

    public short? ZharFileid { get; set; }

    public bool? ZharHidden { get; set; }

    public bool? ZharKilitli { get; set; }

    public bool? ZharDegisti { get; set; }

    public int? ZharChecksum { get; set; }

    public short? ZharCreateUser { get; set; }

    public DateTime ZharCreateDate { get; set; }

    public short? ZharLastupUser { get; set; }

    public DateTime? ZharLastupDate { get; set; }

    public string? ZharSpecial1 { get; set; }

    public string? ZharSpecial2 { get; set; }

    public string? ZharSpecial3 { get; set; }

    public DateTime? ZharTarih { get; set; }

    public string? ZharKasaSicilNo { get; set; }

    public byte? ZharKayitTipi { get; set; }

    public int? ZharZraporNo { get; set; }

    public double? ZharOkcFisTutar { get; set; }

    public double? ZharOkcFaturaTutar { get; set; }

    public double? ZharOkcSmmTutar { get; set; }

    public double? ZharOkcMustahsilTutar { get; set; }

    public double? ZharOkcGybiletTutar { get; set; }

    public double? ZharOkcGpusulaTutar { get; set; }

    public double? ZharOtvTutar { get; set; }

    public double? ZharKdvTutar1 { get; set; }

    public double? ZharKdvTutar2 { get; set; }

    public double? ZharKdvTutar3 { get; set; }

    public double? ZharKdvTutar4 { get; set; }

    public double? ZharKdvTutar5 { get; set; }

    public double? ZharKdvTutar6 { get; set; }

    public double? ZharKdvTutar7 { get; set; }

    public double? ZharKdvTutar8 { get; set; }

    public double? ZharKdvTutar9 { get; set; }

    public double? ZharKdvTutar10 { get; set; }

    public double? ZharNakitOdeme { get; set; }

    public double? ZharBkkartOdeme { get; set; }

    public double? ZharYemekkcOdeme { get; set; }

    public double? ZharDigerOdeme { get; set; }

    public int? ZharFaturabfisAdet { get; set; }

    public double? ZharFaturabfisTutar { get; set; }

    public int? ZharYemekkcbfisAdet { get; set; }

    public double? ZharYemekkcbfisTutar { get; set; }

    public int? ZharAvansbfisAdet { get; set; }

    public double? ZharAvansbfisTutar { get; set; }

    public int? ZharFaturatahsilatbfisAdet { get; set; }

    public double? ZharFaturatahsilatbfisTutar { get; set; }

    public int? ZharOtoparkbfisAdet { get; set; }

    public double? ZharOtoparkbfisTutar { get; set; }

    public int? ZharCarihesapbfisAdet { get; set; }

    public double? ZharCarihesapbfisTutar { get; set; }

    public int? ZharDigerbfisAdet { get; set; }

    public double? ZharDigerbfisTutar { get; set; }

    public string? ZharUuid { get; set; }
}
