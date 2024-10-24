using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MultikodTanimlari
{
    public Guid McodGuid { get; set; }

    public short McodDbcno { get; set; }

    public int? McodSpecRecNo { get; set; }

    public bool? McodIptal { get; set; }

    public short? McodFileid { get; set; }

    public bool? McodHidden { get; set; }

    public bool? McodKilitli { get; set; }

    public bool? McodDegisti { get; set; }

    public int? McodCheckSum { get; set; }

    public short? McodCreateUser { get; set; }

    public DateTime McodCreateDate { get; set; }

    public short? McodLastupUser { get; set; }

    public DateTime? McodLastupDate { get; set; }

    public string? McodSpecial1 { get; set; }

    public string? McodSpecial2 { get; set; }

    public string? McodSpecial3 { get; set; }

    public string? McodCarikodu { get; set; }

    public string? McodStokkod { get; set; }

    public string? McodCaristokKod { get; set; }

    public string? McodCaristokIsmi { get; set; }

    public byte? McodTipi { get; set; }

    public bool? McodHerseferindeeslestirFl { get; set; }

    public byte? McodBirim1Pntr { get; set; }

    public string? McodCaribirim1Ad { get; set; }

    public double? McodBirim1Katsayi { get; set; }

    public byte? McodBirim2Pntr { get; set; }

    public string? McodCaribirim2Ad { get; set; }

    public double? McodBirim2Katsayi { get; set; }

    public byte? McodBirim3Pntr { get; set; }

    public string? McodCaribirim3Ad { get; set; }

    public double? McodBirim3Katsayi { get; set; }

    public byte? McodBirim4Pntr { get; set; }

    public string? McodCaribirim4Ad { get; set; }

    public double? McodBirim4Katsayi { get; set; }
}
