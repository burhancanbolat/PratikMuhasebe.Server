using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class FirmaMaliyilIsletmeTanimlari
{
    public Guid FmitGuid { get; set; }

    public short FmitDbcno { get; set; }

    public int? FmitSpecRecno { get; set; }

    public bool? FmitIptal { get; set; }

    public short? FmitFileid { get; set; }

    public bool? FmitHidden { get; set; }

    public bool? FmitKilitli { get; set; }

    public bool? FmitDegisti { get; set; }

    public int? FmitChecksum { get; set; }

    public short? FmitCreateUser { get; set; }

    public DateTime FmitCreateDate { get; set; }

    public short? FmitLastupUser { get; set; }

    public DateTime? FmitLastupDate { get; set; }

    public string? FmitSpecial1 { get; set; }

    public string? FmitSpecial2 { get; set; }

    public string? FmitSpecial3 { get; set; }

    public int? FmitFirmasirano { get; set; }

    public int? FmitMaliyil { get; set; }

    public double? FmitIsletmeDevirVergi { get; set; }

    public double? FmitIsletmeDevirAtikVergi { get; set; }

    public bool? FmitIsletmeAtikKdvDokulmesin { get; set; }

    public double? FmitIsletmeAsgarikarhaddi { get; set; }

    public string? FmitAmortismanDemirbas { get; set; }

    public string? FmitAmortismanMakine { get; set; }

    public string? FmitBrutUcretImalat { get; set; }

    public string? FmitIsverenSgkImalat { get; set; }

    public string? FmitIsverenIssImalat { get; set; }

    public string? FmitBrutUcretPazarlama { get; set; }

    public string? FmitIsverenSgkPazarlama { get; set; }

    public string? FmitIsverenIssPazarlama { get; set; }

    public string? FmitBrutUcretGenel { get; set; }

    public string? FmitIsverenSgkGenel { get; set; }

    public string? FmitIsverenIssGenel { get; set; }

    public string? FmitIsverenHisTesvik { get; set; }

    public string? FmitDemirbasSatisKar { get; set; }

    public string? FmitDemirbasSatisZarar { get; set; }

    public string? FmitDemirbasSatisVergi { get; set; }

    public string? FmitStokAlis0 { get; set; }

    public string? FmitStokAlis1 { get; set; }

    public string? FmitStokAlis2 { get; set; }

    public string? FmitStokAlis3 { get; set; }

    public string? FmitStokAlis4 { get; set; }

    public string? FmitStokAlis5 { get; set; }

    public string? FmitStokAlis6 { get; set; }

    public string? FmitStokAlis7 { get; set; }

    public string? FmitStokAlis8 { get; set; }

    public string? FmitStokAlis9 { get; set; }

    public string? FmitStokAlis10 { get; set; }

    public string? FmitStokSatis0 { get; set; }

    public string? FmitStokSatis1 { get; set; }

    public string? FmitStokSatis2 { get; set; }

    public string? FmitStokSatis3 { get; set; }

    public string? FmitStokSatis4 { get; set; }

    public string? FmitStokSatis5 { get; set; }

    public string? FmitStokSatis6 { get; set; }

    public string? FmitStokSatis7 { get; set; }

    public string? FmitStokSatis8 { get; set; }

    public string? FmitStokSatis9 { get; set; }

    public string? FmitStokSatis10 { get; set; }

    public string? FmitMasrafAlis0 { get; set; }

    public string? FmitMasrafAlis1 { get; set; }

    public string? FmitMasrafAlis2 { get; set; }

    public string? FmitMasrafAlis3 { get; set; }

    public string? FmitMasrafAlis4 { get; set; }

    public string? FmitMasrafAlis5 { get; set; }

    public string? FmitMasrafAlis6 { get; set; }

    public string? FmitMasrafAlis7 { get; set; }

    public string? FmitMasrafAlis8 { get; set; }

    public string? FmitMasrafAlis9 { get; set; }

    public string? FmitMasrafAlis10 { get; set; }

    public string? FmitHizmetSatis0 { get; set; }

    public string? FmitHizmetSatis1 { get; set; }

    public string? FmitHizmetSatis2 { get; set; }

    public string? FmitHizmetSatis3 { get; set; }

    public string? FmitHizmetSatis4 { get; set; }

    public string? FmitHizmetSatis5 { get; set; }

    public string? FmitHizmetSatis6 { get; set; }

    public string? FmitHizmetSatis7 { get; set; }

    public string? FmitHizmetSatis8 { get; set; }

    public string? FmitHizmetSatis9 { get; set; }

    public string? FmitHizmetSatis10 { get; set; }

    public string? FmitSmmAlis0 { get; set; }

    public string? FmitSmmAlis1 { get; set; }

    public string? FmitSmmAlis2 { get; set; }

    public string? FmitSmmAlis3 { get; set; }

    public string? FmitSmmAlis4 { get; set; }

    public string? FmitSmmAlis5 { get; set; }

    public string? FmitSmmAlis6 { get; set; }

    public string? FmitSmmAlis7 { get; set; }

    public string? FmitSmmAlis8 { get; set; }

    public string? FmitSmmAlis9 { get; set; }

    public string? FmitSmmAlis10 { get; set; }

    public string? FmitSmmSatis0 { get; set; }

    public string? FmitSmmSatis1 { get; set; }

    public string? FmitSmmSatis2 { get; set; }

    public string? FmitSmmSatis3 { get; set; }

    public string? FmitSmmSatis4 { get; set; }

    public string? FmitSmmSatis5 { get; set; }

    public string? FmitSmmSatis6 { get; set; }

    public string? FmitSmmSatis7 { get; set; }

    public string? FmitSmmSatis8 { get; set; }

    public string? FmitSmmSatis9 { get; set; }

    public string? FmitSmmSatis10 { get; set; }

    public string? FmitGiderMakbuzu0 { get; set; }

    public string? FmitGiderMakbuzu1 { get; set; }

    public string? FmitGiderMakbuzu2 { get; set; }

    public string? FmitGiderMakbuzu3 { get; set; }

    public string? FmitGiderMakbuzu4 { get; set; }

    public string? FmitGiderMakbuzu5 { get; set; }

    public string? FmitGiderMakbuzu6 { get; set; }

    public string? FmitGiderMakbuzu7 { get; set; }

    public string? FmitGiderMakbuzu8 { get; set; }

    public string? FmitGiderMakbuzu9 { get; set; }

    public string? FmitGiderMakbuzu10 { get; set; }

    public string? FmitAmortismanKkeg { get; set; }

    public string? FmitBinekotoKiraKkeg { get; set; }

    public string? FmitBinekotoKiraKdvKkeg { get; set; }

    public string? FmitBinekotoGiderKkeg { get; set; }

    public string? FmitBinekotoGiderKdvKkeg { get; set; }
}
