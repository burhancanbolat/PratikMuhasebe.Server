using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BakimSarfiyatlari
{
    public Guid BsrfGuid { get; set; }

    public short BsrfDbcno { get; set; }

    public int? BsrfSpecRecNo { get; set; }

    public bool? BsrfIptal { get; set; }

    public short? BsrfFileid { get; set; }

    public bool? BsrfHidden { get; set; }

    public bool? BsrfKilitli { get; set; }

    public bool? BsrfDegisti { get; set; }

    public int? BsrfChecksum { get; set; }

    public short? BsrfCreateUser { get; set; }

    public DateTime BsrfCreateDate { get; set; }

    public short? BsrfLastupUser { get; set; }

    public DateTime? BsrfLastupDate { get; set; }

    public string? BsrfSpecial1 { get; set; }

    public string? BsrfSpecial2 { get; set; }

    public string? BsrfSpecial3 { get; set; }

    public int? BsrfFirmano { get; set; }

    public int? BsrfSubeno { get; set; }

    public DateTime? BsrfEvraktarihi { get; set; }

    public string? BsrfEvrakseri { get; set; }

    public int? BsrfEvraksira { get; set; }

    public int? BsrfEvraksatir { get; set; }

    public string? BsrfBelgeno { get; set; }

    public DateTime? BsrfBelgeTarih { get; set; }

    public string? BsrfIsemri { get; set; }

    public string? BsrfStokKodu { get; set; }

    public double? BsrfMiktar { get; set; }

    public byte? BsrfBirimPntr { get; set; }

    public string? BsrfAciklama { get; set; }

    public string? BsrfProje { get; set; }

    public string? BsrfSrmmrkkodu { get; set; }
}
