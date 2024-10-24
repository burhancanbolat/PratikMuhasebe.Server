using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Demirbaslar
{
    public Guid DemGuid { get; set; }

    public short DemDbcno { get; set; }

    public int? DemSpecRecno { get; set; }

    public bool? DemIptal { get; set; }

    public short? DemFileid { get; set; }

    public bool? DemHidden { get; set; }

    public bool? DemKilitli { get; set; }

    public bool? DemDegisti { get; set; }

    public int? DemChecksum { get; set; }

    public short? DemCreateUser { get; set; }

    public DateTime DemCreateDate { get; set; }

    public short? DemLastupUser { get; set; }

    public DateTime? DemLastupDate { get; set; }

    public string? DemSpecial1 { get; set; }

    public string? DemSpecial2 { get; set; }

    public string? DemSpecial3 { get; set; }

    public string? DemKod { get; set; }

    public int? DemFirmano { get; set; }

    public int? DemSubeno { get; set; }

    public string? DemIsim { get; set; }

    public string? DemAciklama { get; set; }

    public byte? DemDovizCinsi { get; set; }

    public byte? DemVergi { get; set; }

    public double? DemAmortoran { get; set; }

    public byte? DemAmortip { get; set; }

    public string? DemBirim { get; set; }

    public DateTime? DemFaturaTarihi { get; set; }

    public string? DemFaturaSeri { get; set; }

    public int? DemFaturaSira { get; set; }

    public double? DemTutar { get; set; }

    public double? DemTutarAlternatif { get; set; }

    public double? DemTutarOrjinal { get; set; }

    public double? DemMiktar { get; set; }

    public string? DemDagankodu { get; set; }

    public string? DemSozlesmekodu { get; set; }

    public string? DemMuhKodu { get; set; }

    public string? DemBirikAmortMuh { get; set; }

    public string? DemYdfMuhKod { get; set; }

    public string? DemAmorgiderMuhkod { get; set; }

    public string? DemMaliyetArtisMu { get; set; }

    public string? DemSatisKarMuhkod { get; set; }

    public string? DemSatisZararMuhk { get; set; }

    public string? DemYeniFonMuhkodu { get; set; }

    public string? DemSermEkgmStsKazM { get; set; }

    public string? DemAmorgidkarMuhkod { get; set; }

    public string? DemYatirimtesMuhkod { get; set; }

    public string? DemMuhKoduKkeg { get; set; }

    public string? DemKkegMuhKodu { get; set; }

    public string? DemAmortMasrafKodu { get; set; }

    public string? DemAmortMasrafKoduKkeg { get; set; }

    public string? DemYenilemeFonuMasrafKodu { get; set; }

    public string? DemIslDemirbasKodu { get; set; }

    public bool? DemMakinatesisFl { get; set; }

    public bool? DemEmlakFl { get; set; }

    public bool? DemIzdusumFl { get; set; }

    public bool? DemYeniDegyoFl { get; set; }

    public bool? DemKistasFl { get; set; }

    public bool? DemTesfikFl { get; set; }

    public double? DemAtikizdegerDusu { get; set; }

    public string? DemZimmetyeri { get; set; }

    public string? DemZimmetcaripers { get; set; }

    public string? DemGrupkodu { get; set; }

    public string? DemSrmmMrkKodu { get; set; }

    public byte? DemEnfTabii { get; set; }

    public string? DemMuhgrupKodu { get; set; }

    public string? DemMkodArtik { get; set; }

    public string? DemFaydaliOmurKodu { get; set; }

    public string? DemProjeKodu { get; set; }

    public string? DemAltfaydaliOmurKodu { get; set; }

    public double? DemAlternatifAmortoran { get; set; }

    public double? DemUfrstutar { get; set; }

    public double? DemUfrstutarAlternatif { get; set; }

    public double? DemUfrstutarOrjinal { get; set; }

    public byte? DemUfrsamortip { get; set; }

    public string? DemUfrsOmurKodu { get; set; }

    public double? DemUfrsamortoran { get; set; }

    public bool? DemUfrskistasFl { get; set; }

    public string? DemUfrsfarkMuhKodu { get; set; }

    public string? DemBirikAmortUfrsfarkKodu { get; set; }

    public string? DemYdfUfrsfarkKodu { get; set; }

    public string? DemAmorgiderUfrsfarkKodu { get; set; }

    public string? DemMaliyetArtisUfrsfarkKodu { get; set; }

    public string? DemSatisKarUfrsfarkKodu { get; set; }

    public string? DemSatisZararUfrsfarkKodu { get; set; }

    public string? DemYeniFonUfrsfarkKodu { get; set; }

    public string? DemSermEkgmStsKazUfrsfarkKodu { get; set; }

    public string? DemAmorgidkarUfrsfarkKodu { get; set; }

    public string? DemYatirimtesUfrsfarkKodu { get; set; }

    public string? DemUfrsfarkMuhKoduKkeg { get; set; }

    public string? DemKkegUfrsfarkKodu { get; set; }

    public double? DemOtvTutar { get; set; }

    public bool? DemOtvMaliyeteEklensinFl { get; set; }

    public bool? DemKdvMaliyeteEklensinFl { get; set; }

    public string? DemGtipNo { get; set; }

    public string? DemAmortismanGiderTuru { get; set; }

    public string? DemDefterBeyanId { get; set; }

    public string? DemDefterBeyanDevirFisiId { get; set; }

    public double? DemItfaBedeliAna { get; set; }

    public double? DemItfaBedeliAlt { get; set; }

    public double? DemItfaBedeliOrj { get; set; }

    public double? DemKkegBedelAna { get; set; }

    public double? DemKkegBedelAlt { get; set; }

    public double? DemKkegBedelOrj { get; set; }

    public byte? DemBinekOtoSinifi { get; set; }

    public string? DemIslDemirbasKoduKkeg { get; set; }

    public string? DemAracplaka { get; set; }

    public bool? DemSatisKariYenilemeFonunaFl { get; set; }

    public double? DemYenilemeFonuBedeliAna { get; set; }

    public double? DemYenilemeFonuBedeliAlt { get; set; }

    public double? DemYenilemeFonuBedeliOrj { get; set; }

    public double? DemYenilemeFonuBedeliAnaUfrs { get; set; }

    public double? DemYenilemeFonuBedeliAltUfrs { get; set; }

    public double? DemYenilemeFonuBedeliOrjUfrs { get; set; }

    public byte? DemVuk530DuzeltmesineTabii { get; set; }

    public byte? DemNitelik { get; set; }

    public DateTime? DemVuk530DuzeltmeTarihi { get; set; }
}
