using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SatisSartlari
{
    public Guid SatGuid { get; set; }

    public short SatDbcno { get; set; }

    public int? SatSpecRecno { get; set; }

    public bool? SatIptal { get; set; }

    public short? SatFileid { get; set; }

    public bool? SatHidden { get; set; }

    public bool? SatKilitli { get; set; }

    public bool? SatDegisti { get; set; }

    public int? SatChecksum { get; set; }

    public short? SatCreateUser { get; set; }

    public DateTime SatCreateDate { get; set; }

    public short? SatLastupUser { get; set; }

    public DateTime? SatLastupDate { get; set; }

    public string? SatSpecial1 { get; set; }

    public string? SatSpecial2 { get; set; }

    public string? SatSpecial3 { get; set; }

    public string? SatStokKod { get; set; }

    public string? SatCariKod { get; set; }

    public string? SatEvraknoSeri { get; set; }

    public int? SatEvraknoSira { get; set; }

    public DateTime? SatEvrakTarih { get; set; }

    public int? SatSatirno { get; set; }

    public string? SatBelgeno { get; set; }

    public DateTime? SatBelgeTarih { get; set; }

    public double? SatAsgariMiktar { get; set; }

    public short? SatTeslimatSure { get; set; }

    public DateTime? SatBaslaTarih { get; set; }

    public DateTime? SatBitisTarih { get; set; }

    public double? SatBrutFiyat { get; set; }

    public string? SatDetIskAcik1 { get; set; }

    public byte? SatDetIskUyg1 { get; set; }

    public byte? SatDetIskDurum1 { get; set; }

    public byte? SatDetIskVergi1 { get; set; }

    public double? SatDetIskKriter1 { get; set; }

    public double? SatDetIskYuzde1 { get; set; }

    public double? SatDetIskMiktar1 { get; set; }

    public string? SatDetIskAcik2 { get; set; }

    public byte? SatDetIskUyg2 { get; set; }

    public byte? SatDetIskDurum2 { get; set; }

    public byte? SatDetIskVergi2 { get; set; }

    public double? SatDetIskKriter2 { get; set; }

    public double? SatDetIskYuzde2 { get; set; }

    public double? SatDetIskMiktar2 { get; set; }

    public string? SatDetIskAcik3 { get; set; }

    public byte? SatDetIskUyg3 { get; set; }

    public byte? SatDetIskDurum3 { get; set; }

    public byte? SatDetIskVergi3 { get; set; }

    public double? SatDetIskKriter3 { get; set; }

    public double? SatDetIskYuzde3 { get; set; }

    public double? SatDetIskMiktar3 { get; set; }

    public string? SatDetIskAcik4 { get; set; }

    public byte? SatDetIskUyg4 { get; set; }

    public byte? SatDetIskDurum4 { get; set; }

    public byte? SatDetIskVergi4 { get; set; }

    public double? SatDetIskKriter4 { get; set; }

    public double? SatDetIskYuzde4 { get; set; }

    public double? SatDetIskMiktar4 { get; set; }

    public string? SatDetIskAcik5 { get; set; }

    public byte? SatDetIskUyg5 { get; set; }

    public byte? SatDetIskDurum5 { get; set; }

    public byte? SatDetIskVergi5 { get; set; }

    public double? SatDetIskKriter5 { get; set; }

    public double? SatDetIskYuzde5 { get; set; }

    public double? SatDetIskMiktar5 { get; set; }

    public string? SatDetIskAcik6 { get; set; }

    public byte? SatDetIskUyg6 { get; set; }

    public byte? SatDetIskDurum6 { get; set; }

    public byte? SatDetIskVergi6 { get; set; }

    public double? SatDetIskKriter6 { get; set; }

    public double? SatDetIskYuzde6 { get; set; }

    public double? SatDetIskMiktar6 { get; set; }

    public string? SatDetMasAcik1 { get; set; }

    public byte? SatDetMasUyg1 { get; set; }

    public byte? SatDetMasDurum1 { get; set; }

    public byte? SasDetMasVergi1 { get; set; }

    public double? SatDetMasKriter1 { get; set; }

    public double? SatDetMasYuzde1 { get; set; }

    public double? SatDetMasMiktar1 { get; set; }

    public string? SatDetMasAcik2 { get; set; }

    public byte? SatDetMasUyg2 { get; set; }

    public byte? SatDetMasDurum2 { get; set; }

    public byte? SasDetMasVergi2 { get; set; }

    public double? SatDetMasKriter2 { get; set; }

    public double? SatDetMasYuzde2 { get; set; }

    public double? SatDetMasMiktar2 { get; set; }

    public string? SatDetMasAcik3 { get; set; }

    public byte? SatDetMasUyg3 { get; set; }

    public byte? SatDetMasDurum3 { get; set; }

    public byte? SasDetMasVergi3 { get; set; }

    public double? SatDetMasKriter3 { get; set; }

    public double? SatDetMasYuzde3 { get; set; }

    public double? SatDetMasMiktar3 { get; set; }

    public string? SatDetMasAcik4 { get; set; }

    public byte? SatDetMasUyg4 { get; set; }

    public byte? SatDetMasDurum4 { get; set; }

    public byte? SasDetMasVergi4 { get; set; }

    public double? SatDetMasKriter4 { get; set; }

    public double? SatDetMasYuzde4 { get; set; }

    public double? SatDetMasMiktar4 { get; set; }

    public int? SatOdemePlan { get; set; }

    public byte? SatDovizCinsi { get; set; }

    public int? SatDepoNo { get; set; }

    public int? SatFiyatListeNo { get; set; }

    public byte? SatMiktarTip { get; set; }

    public double? SatMiktar { get; set; }

    public string? SatProjeKodu { get; set; }

    public string? SatSrmmrkKodu { get; set; }
}
