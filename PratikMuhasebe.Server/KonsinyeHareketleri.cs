using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KonsinyeHareketleri
{
    public Guid KonGuid { get; set; }

    public short KonDbcno { get; set; }

    public int? KonSpecRecno { get; set; }

    public bool? KonIptal { get; set; }

    public short? KonFileid { get; set; }

    public bool? KonHidden { get; set; }

    public bool? KonKilitli { get; set; }

    public bool? KonDegisti { get; set; }

    public int? KonChecksum { get; set; }

    public short? KonCreateUser { get; set; }

    public DateTime KonCreateDate { get; set; }

    public short? KonLastupUser { get; set; }

    public DateTime? KonLastupDate { get; set; }

    public string? KonSpecial1 { get; set; }

    public string? KonSpecial2 { get; set; }

    public string? KonSpecial3 { get; set; }

    public int? KonFirmano { get; set; }

    public int? KonSubeno { get; set; }

    public DateTime? KonTarih { get; set; }

    public byte? KonTip { get; set; }

    public byte? KonNormalIade { get; set; }

    public string? KonEvraknoSeri { get; set; }

    public int? KonEvraknoSira { get; set; }

    public int? KonSatirno { get; set; }

    public string? KonBelgeNo { get; set; }

    public DateTime? KonBelgeTarih { get; set; }

    public string? KonStokKod { get; set; }

    public string? KonCariKod { get; set; }

    public string? KonSaticiKod { get; set; }

    public double? KonMiktar { get; set; }

    public double? KonFaturalanan { get; set; }

    public string? KonAciklama { get; set; }

    public int? KonGirisDepoNo { get; set; }

    public int? KonCikisDepoNo { get; set; }

    public DateTime? KonMalkabulTarih { get; set; }

    public Guid? KonSipUid { get; set; }

    public double? KonIslemgoren { get; set; }

    public Guid? KonKarkonUid { get; set; }

    public double? KonNetagirlik { get; set; }

    public double? KonBrutagirlik { get; set; }

    public double? KonRehinmiktari { get; set; }

    public double? KonRehinfiyati { get; set; }

    public double? KonMiktar2 { get; set; }

    public double? KonIslemgoren2 { get; set; }

    public double? KonSandikmiktari { get; set; }

    public double? KonSandikfiyati { get; set; }

    public short? KonSevkAdresno { get; set; }

    public string? KonCariSrmMerkez { get; set; }

    public string? KonStokSrmMerkez { get; set; }

    public string? KonsPartiKodu { get; set; }

    public int? KonsLotNo { get; set; }

    public string? KonsProjekodu { get; set; }

    public byte? KonsHarDovizCinsi { get; set; }

    public double? KonsHarDovizKuru { get; set; }

    public double? KonsAltDovizKuru { get; set; }

    public byte? KonsStokDovizCinsi { get; set; }

    public double? KonsStokDovizKuru { get; set; }

    public int? KonsOdemeOp { get; set; }

    public byte? KonsBirimPntr { get; set; }

    public double? KonsTutar { get; set; }

    public byte? KonsIskMas1 { get; set; }

    public byte? KonsIskMas2 { get; set; }

    public byte? KonsIskMas3 { get; set; }

    public byte? KonsIskMas4 { get; set; }

    public byte? KonsIskMas5 { get; set; }

    public byte? KonsIskMas6 { get; set; }

    public byte? KonsIskMas7 { get; set; }

    public byte? KonsIskMas8 { get; set; }

    public byte? KonsIskMas9 { get; set; }

    public byte? KonsIskMas10 { get; set; }

    public bool? KonsSatIskmas1 { get; set; }

    public bool? KonsSatIskmas2 { get; set; }

    public bool? KonsSatIskmas3 { get; set; }

    public bool? KonsSatIskmas4 { get; set; }

    public bool? KonsSatIskmas5 { get; set; }

    public bool? KonsSatIskmas6 { get; set; }

    public bool? KonsSatIskmas7 { get; set; }

    public bool? KonsSatIskmas8 { get; set; }

    public bool? KonsSatIskmas9 { get; set; }

    public bool? KonsSatIskmas10 { get; set; }

    public double? KonsIskonto1 { get; set; }

    public double? KonsIskonto2 { get; set; }

    public double? KonsIskonto3 { get; set; }

    public double? KonsIskonto4 { get; set; }

    public double? KonsIskonto5 { get; set; }

    public double? KonsIskonto6 { get; set; }

    public double? KonsMasraf1 { get; set; }

    public double? KonsMasraf2 { get; set; }

    public double? KonsMasraf3 { get; set; }

    public double? KonsMasraf4 { get; set; }

    public byte? KonsVergiPntr { get; set; }

    public double? KonsVergi { get; set; }

    public byte? KonsMasrafVergiPntr { get; set; }

    public double? KonsMasrafVergi { get; set; }

    public bool? KonsVergisizFl { get; set; }

    public byte? KonsOtvPntr { get; set; }

    public double? KonsOtvVergi { get; set; }

    public double? KonsOtvtutari { get; set; }

    public bool? KonsOtvvergisizFl { get; set; }

    public byte? KonsOivPntr { get; set; }

    public double? KonsOivVergi { get; set; }

    public bool? KonsOivvergisizFl { get; set; }

    public int? KonsFiyatListeNo { get; set; }

    public byte? KonCins { get; set; }

    public byte? KonEvraktip { get; set; }

    public string? KonGiderKodu { get; set; }

    public double? KonsOivtutari { get; set; }

    public Guid? KonIrsUid { get; set; }

    public Guid? KonYetkiliUid { get; set; }

    public int? KonNakliyedeposu { get; set; }

    public byte? KonNakliyedurumu { get; set; }

    public string? KonKunyeNo { get; set; }

    public byte? KonEirsSenaryo { get; set; }

    public byte? KonEirsTipi { get; set; }

    public DateTime? KonTeslimTarihi { get; set; }

    public bool? KonMatbuFl { get; set; }
}
