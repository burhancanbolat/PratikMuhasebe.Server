using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IstasyonSayacHareketDetaylari
{
    public Guid ShdtGuid { get; set; }

    public short ShdtDbcno { get; set; }

    public int? ShdtSpecRecno { get; set; }

    public bool? ShdtIptal { get; set; }

    public short? ShdtFileid { get; set; }

    public bool? ShdtHidden { get; set; }

    public bool? ShdtKilitli { get; set; }

    public bool? ShdtDegisti { get; set; }

    public int? ShdtChecksum { get; set; }

    public short? ShdtCreateUser { get; set; }

    public DateTime ShdtCreateDate { get; set; }

    public short? ShdtLastupUser { get; set; }

    public DateTime? ShdtLastupDate { get; set; }

    public string? ShdtSpecial1 { get; set; }

    public string? ShdtSpecial2 { get; set; }

    public string? ShdtSpecial3 { get; set; }

    public int? ShdtFirmaNo { get; set; }

    public int? ShdtSubeNo { get; set; }

    public string? ShdtSayackodu { get; set; }

    public int? ShdtDepoNo { get; set; }

    public string? ShdtStokkodu { get; set; }

    public DateTime? ShdtVardiyatarihi { get; set; }

    public byte? ShdtVardiyano { get; set; }

    public string? ShdtFilokodu { get; set; }

    public string? ShdtCarikodu { get; set; }

    public string? ShdtTagnumarasi { get; set; }

    public string? ShdtPlakaVeyaPersonel { get; set; }

    public double? ShdtMotorsaati { get; set; }

    public double? ShdtKilometre { get; set; }

    public byte? ShdtSatistipi { get; set; }

    public DateTime? ShdtSatistarihi { get; set; }

    public int? ShdtSatissirano { get; set; }

    public byte? ShdtYakittipi { get; set; }

    public double? ShdtBirimfiyat { get; set; }

    public double? ShdtMiktar { get; set; }

    public double? ShdtTutar { get; set; }

    public byte? ShdtPompano { get; set; }

    public byte? ShdtTabancano { get; set; }

    public byte? ShdtOdemeturu { get; set; }

    public string? ShdtAracplaka { get; set; }

    public int? ShdtFisno { get; set; }

    public double? ShdtOdeme { get; set; }

    public double? ShdtIndirim { get; set; }

    public double? ShdtHediyepuan { get; set; }

    public double? ShdtHediyetutar { get; set; }

    public string? ShdtHediyekartno { get; set; }

    public byte? ShdtHediyekartturu { get; set; }

    public double? ShdtNetbirimfiyat { get; set; }

    public Guid? ShdtSthUid { get; set; }
}
