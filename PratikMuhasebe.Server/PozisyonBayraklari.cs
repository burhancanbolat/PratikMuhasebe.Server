using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PozisyonBayraklari
{
    public Guid PbGuid { get; set; }

    public short PbDbcno { get; set; }

    public int? PbSpecRecno { get; set; }

    public bool? PbIptal { get; set; }

    public short? PbFileid { get; set; }

    public bool? PbHidden { get; set; }

    public bool? PbKilitli { get; set; }

    public bool? PbDegisti { get; set; }

    public int? PbChecksum { get; set; }

    public short? PbCreateUser { get; set; }

    public DateTime PbCreateDate { get; set; }

    public short? PbLastupUser { get; set; }

    public DateTime? PbLastupDate { get; set; }

    public string? PbSpecial1 { get; set; }

    public string? PbSpecial2 { get; set; }

    public string? PbSpecial3 { get; set; }

    public string? PbKod { get; set; }

    public string? PbIsmi { get; set; }

    public byte? PbDetayTakip { get; set; }

    public byte? PbSatisDursun { get; set; }

    public byte? PbSiparisDursun { get; set; }

    public byte? PbMalkabulDursun { get; set; }

    public bool? PbMalkabulGun1 { get; set; }

    public bool? PbMalkabulGun2 { get; set; }

    public bool? PbMalkabulGun3 { get; set; }

    public bool? PbMalkabulGun4 { get; set; }

    public bool? PbMalkabulGun5 { get; set; }

    public bool? PbMalkabulGun6 { get; set; }

    public bool? PbMalkabulGun7 { get; set; }

    public bool? PbSiparisGun1 { get; set; }

    public bool? PbSiparisGun2 { get; set; }

    public bool? PbSiparisGun3 { get; set; }

    public bool? PbSiparisGun4 { get; set; }

    public bool? PbSiparisGun5 { get; set; }

    public bool? PbSiparisGun6 { get; set; }

    public bool? PbSiparisGun7 { get; set; }

    public string? PbYerKod { get; set; }

    public bool? PbPasifFl { get; set; }

    public byte? PbEtiketBas { get; set; }

    public byte? PbElkEtkTipi { get; set; }

    public byte? PbRafEtiketli { get; set; }

    public short? PbRafOmru { get; set; }
}
