using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class VergiFonTanimlari
{
    public Guid VfGuid { get; set; }

    public short VfDbcno { get; set; }

    public int? VfSpecRecno { get; set; }

    public bool? VfIptal { get; set; }

    public short? VfFileid { get; set; }

    public bool? VfHidden { get; set; }

    public bool? VfKilitli { get; set; }

    public bool? VfDegisti { get; set; }

    public int? VfChecksum { get; set; }

    public short? VfCreateUser { get; set; }

    public DateTime VfCreateDate { get; set; }

    public short? VfLastupUser { get; set; }

    public DateTime? VfLastupDate { get; set; }

    public string? VfSpecial1 { get; set; }

    public string? VfSpecial2 { get; set; }

    public string? VfSpecial3 { get; set; }

    public int? VfFirmaNo { get; set; }

    public short? VfSiraNo { get; set; }

    public string? VfKodu { get; set; }

    public string? VfUzunAdi { get; set; }

    public string? VfKisaAdi { get; set; }

    public double? VfOrani { get; set; }

    public double? VfSabitTutar { get; set; }

    public string? VfGirisMasrafKodu { get; set; }

    public string? VfGirisMuhKodu { get; set; }

    public string? VfCikisMuhKodu { get; set; }

    public bool? VfKdvli { get; set; }

    public byte? VfBsbayadahil { get; set; }
}
