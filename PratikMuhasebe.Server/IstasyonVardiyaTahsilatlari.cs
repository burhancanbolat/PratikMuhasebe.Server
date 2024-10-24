using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IstasyonVardiyaTahsilatlari
{
    public Guid VnGuid { get; set; }

    public short VnDbcno { get; set; }

    public int? VnSpecRecno { get; set; }

    public bool? VnIptal { get; set; }

    public short? VnFileid { get; set; }

    public bool? VnHidden { get; set; }

    public bool? VnKilitli { get; set; }

    public bool? VnDegisti { get; set; }

    public int? VnChecksum { get; set; }

    public short? VnCreateUser { get; set; }

    public DateTime VnCreateDate { get; set; }

    public short? VnLastupUser { get; set; }

    public DateTime? VnLastupDate { get; set; }

    public string? VnSpecial1 { get; set; }

    public string? VnSpecial2 { get; set; }

    public string? VnSpecial3 { get; set; }

    public int? VnFirmano { get; set; }

    public int? VnSubeno { get; set; }

    public byte? VnVardiyahesaptip { get; set; }

    public DateTime? VnTarihi { get; set; }

    public byte? VnNumarasi { get; set; }

    public string? VnPersKodu { get; set; }

    public int? VnSiraNo { get; set; }

    public string? VnKasaBankaKodu { get; set; }

    public byte? VnTahsilatSekli { get; set; }

    public double? VnTutar { get; set; }

    public double? VnMusteriKomisyon { get; set; }

    public DateTime? VnVadeTarihi { get; set; }
}
