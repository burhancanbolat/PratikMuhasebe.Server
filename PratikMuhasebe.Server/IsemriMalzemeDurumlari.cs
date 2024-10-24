using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsemriMalzemeDurumlari
{
    public Guid IshGuid { get; set; }

    public short IshDbcno { get; set; }

    public int? IshSpecRecNo { get; set; }

    public bool? IshIptal { get; set; }

    public short? IshFileid { get; set; }

    public bool? IshHidden { get; set; }

    public bool? IshKilitli { get; set; }

    public bool? IshDegisti { get; set; }

    public int? IshChecksum { get; set; }

    public short? IshCreateUser { get; set; }

    public DateTime IshCreateDate { get; set; }

    public short? IshLastupUser { get; set; }

    public DateTime? IshLastupDate { get; set; }

    public string? IshOzelkod1 { get; set; }

    public string? IshOzelkod2 { get; set; }

    public string? IshOzelkod3 { get; set; }

    public byte? IshStokHizmGider { get; set; }

    public string? IshStokhizmGidKod { get; set; }

    public string? IshIsemri { get; set; }

    public string? IshFasoncu { get; set; }

    public double? IshSevkMiktar { get; set; }

    public double? IshSevkDeger0 { get; set; }

    public double? IshSevkDeger1 { get; set; }

    public double? IshSevkDeger2 { get; set; }

    public double? IshIadeMiktar { get; set; }

    public double? IshIadeDeger0 { get; set; }

    public double? IshIadeDeger1 { get; set; }

    public double? IshIadeDeger2 { get; set; }

    public double? IshTuketMiktar { get; set; }

    public double? IshTuketDeger0 { get; set; }

    public double? IshTuketDeger1 { get; set; }

    public double? IshTuketDeger2 { get; set; }

    public double? IshUretMiktar { get; set; }

    public double? IshUretDeger0 { get; set; }

    public double? IshUretDeger1 { get; set; }

    public double? IshUretDeger2 { get; set; }

    public double? IshUretiadeMiktar { get; set; }

    public double? IshUretiadeDeg0 { get; set; }

    public double? IshUretiadeDeg1 { get; set; }

    public double? IshUretiadeDeg2 { get; set; }

    public double? IshPlanSevkmiktar { get; set; }

    public double? IshPlanuretim { get; set; }

    public double? IshGenelUretimMaliyetiAna { get; set; }

    public double? IshGenelUretimMaliyetiAlt { get; set; }

    public double? IshGenelUretimMaliyetiOrj { get; set; }

    public double? IshDirektIscilikMaliyetiAna { get; set; }

    public double? IshDirektIscilikMaliyetiAlt { get; set; }

    public double? IshDirektIscilikMaliyetiOrj { get; set; }
}
