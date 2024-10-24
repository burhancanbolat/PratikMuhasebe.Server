using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SonKullanicilar
{
    public Guid TukGuid { get; set; }

    public short TukDbcno { get; set; }

    public int? TukSpecRecNo { get; set; }

    public bool? TukIptal { get; set; }

    public short? TukFileid { get; set; }

    public bool? TukHidden { get; set; }

    public bool? TukKilitli { get; set; }

    public bool? TukDegisti { get; set; }

    public int? TukChecksum { get; set; }

    public short? TukCreateUser { get; set; }

    public DateTime TukCreateDate { get; set; }

    public short? TukLastupUser { get; set; }

    public DateTime? TukLastupDate { get; set; }

    public string? TukSpecial1 { get; set; }

    public string? TukSpecial2 { get; set; }

    public string? TukSpecial3 { get; set; }

    public string? TukKodu { get; set; }

    public string? TukIsmi { get; set; }

    public string? TukAdr1Cadde { get; set; }

    public string? TukAdr1Mahalle { get; set; }

    public string? TukAdr1Sokak { get; set; }

    public string? TukAdr1Semt { get; set; }

    public string? TukAdr1AptNo { get; set; }

    public string? TukAdr1DaireNo { get; set; }

    public string? TukAdr1Postakodu { get; set; }

    public string? TukAdr1Ilce { get; set; }

    public string? TukAdr1Il { get; set; }

    public string? TukAdr1Ulke { get; set; }

    public string? TukAdr1AdresKodu { get; set; }

    public string? TukAdr2Cadde { get; set; }

    public string? TukAdr2Mahalle { get; set; }

    public string? TukAdr2Sokak { get; set; }

    public string? TukAdr2Semt { get; set; }

    public string? TukAdr2AptNo { get; set; }

    public string? TukAdr2DaireNo { get; set; }

    public string? TukAdr2Postakodu { get; set; }

    public string? TukAdr2Ilce { get; set; }

    public string? TukAdr2Il { get; set; }

    public string? TukAdr2Ulke { get; set; }

    public string? TukAdr2AdresKodu { get; set; }

    public string? TukTel1Ulkekod { get; set; }

    public string? TukTel1Bolgekod { get; set; }

    public string? TukTel1TelNo1 { get; set; }

    public string? TukTel1TelNo2 { get; set; }

    public string? TukTel1FaxNo { get; set; }

    public string? TukTel1ModemNo { get; set; }

    public string? TukTel2Ulkekod { get; set; }

    public string? TukTel2Bolgekod { get; set; }

    public string? TukTel2TelNo1 { get; set; }

    public string? TukTel2TelNo2 { get; set; }

    public string? TukTel2FaxNo { get; set; }

    public string? TukTel2ModemNo { get; set; }

    public string? TukYetkili1 { get; set; }

    public string? TukYetkili2 { get; set; }

    public string? TukCeptel1 { get; set; }

    public string? TukCeptel2 { get; set; }

    public string? TukEmail1 { get; set; }

    public string? TukEmail2 { get; set; }

    public string? TukGrpKodu { get; set; }

    public string? TukMuhKodu { get; set; }

    public bool? TukKilitliFlg { get; set; }

    public string? TukCariKodu { get; set; }

    public string? TukSektorKodu { get; set; }

    public string? TukBolgeKodu { get; set; }
}
