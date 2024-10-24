using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapHareketleri
{
    public Guid ChaGuid { get; set; }

    public short ChaDbcno { get; set; }

    public int? ChaSpecRecNo { get; set; }

    public bool? ChaIptal { get; set; }

    public short? ChaFileid { get; set; }

    public bool? ChaHidden { get; set; }

    public bool? ChaKilitli { get; set; }

    public bool? ChaDegisti { get; set; }

    public int? ChaCheckSum { get; set; }

    public short? ChaCreateUser { get; set; }

    public DateTime ChaCreateDate { get; set; }

    public short? ChaLastupUser { get; set; }

    public DateTime? ChaLastupDate { get; set; }

    public string? ChaSpecial1 { get; set; }

    public string? ChaSpecial2 { get; set; }

    public string? ChaSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public int? ChaFirmano { get; set; }

    public int? ChaSubeno { get; set; }

    public byte? ChaEvrakTip { get; set; }

    public string? ChaEvraknoSeri { get; set; }

    public int? ChaEvraknoSira { get; set; }

    public int? ChaSatirNo { get; set; }

    public DateTime? ChaTarihi { get; set; }

    public byte? ChaTip { get; set; }

    public byte? ChaCinsi { get; set; }

    public byte? ChaNormalIade { get; set; }

    public byte? ChaTpoz { get; set; }

    public byte? ChaTicaretTuru { get; set; }

    public string? ChaBelgeNo { get; set; }

    public DateTime? ChaBelgeTarih { get; set; }

    public string? ChaAciklama { get; set; }

    public string? ChaSaticiKodu { get; set; }

    public string? ChaEximkodu { get; set; }

    public string? ChaProjekodu { get; set; }

    public string? ChaYatTesKodu { get; set; }

    public byte? ChaCariCins { get; set; }

    public string? ChaKod { get; set; }

    public string? ChaCiroCariKodu { get; set; }

    public byte? ChaDCins { get; set; }

    public double? ChaDKur { get; set; }

    public double? ChaAltdKur { get; set; }

    public byte? ChaGrupno { get; set; }

    public string? ChaSrmrkkodu { get; set; }

    public byte? ChaKasaHizmet { get; set; }

    public string? ChaKasaHizkod { get; set; }

    public byte? ChaKarsidcinsi { get; set; }

    public double? ChaKarsidKur { get; set; }

    public byte? ChaKarsidgrupno { get; set; }

    public string? ChaKarsisrmrkkodu { get; set; }

    public double? ChaMiktari { get; set; }

    public double? ChaMeblag { get; set; }

    public double? ChaAratoplam { get; set; }

    public int? ChaVade { get; set; }

    public double? ChaVadeFarkiYuz { get; set; }

    public double? ChaFtIskonto1 { get; set; }

    public double? ChaFtIskonto2 { get; set; }

    public double? ChaFtIskonto3 { get; set; }

    public double? ChaFtIskonto4 { get; set; }

    public double? ChaFtIskonto5 { get; set; }

    public double? ChaFtIskonto6 { get; set; }

    public double? ChaFtMasraf1 { get; set; }

    public double? ChaFtMasraf2 { get; set; }

    public double? ChaFtMasraf3 { get; set; }

    public double? ChaFtMasraf4 { get; set; }

    public byte? ChaIskMas1 { get; set; }

    public byte? ChaIskMas2 { get; set; }

    public byte? ChaIskMas3 { get; set; }

    public byte? ChaIskMas4 { get; set; }

    public byte? ChaIskMas5 { get; set; }

    public byte? ChaIskMas6 { get; set; }

    public byte? ChaIskMas7 { get; set; }

    public byte? ChaIskMas8 { get; set; }

    public byte? ChaIskMas9 { get; set; }

    public byte? ChaIskMas10 { get; set; }

    public bool? ChaSatIskmas1 { get; set; }

    public bool? ChaSatIskmas2 { get; set; }

    public bool? ChaSatIskmas3 { get; set; }

    public bool? ChaSatIskmas4 { get; set; }

    public bool? ChaSatIskmas5 { get; set; }

    public bool? ChaSatIskmas6 { get; set; }

    public bool? ChaSatIskmas7 { get; set; }

    public bool? ChaSatIskmas8 { get; set; }

    public bool? ChaSatIskmas9 { get; set; }

    public bool? ChaSatIskmas10 { get; set; }

    public double? ChaYuvarlama { get; set; }

    public byte? ChaStFonPntr { get; set; }

    public double? ChaStopaj { get; set; }

    public double? ChaSavsandesfonu { get; set; }

    public double? ChaAvansmakDamgapul { get; set; }

    public byte? ChaVergipntr { get; set; }

    public double? ChaVergi1 { get; set; }

    public double? ChaVergi2 { get; set; }

    public double? ChaVergi3 { get; set; }

    public double? ChaVergi4 { get; set; }

    public double? ChaVergi5 { get; set; }

    public double? ChaVergi6 { get; set; }

    public double? ChaVergi7 { get; set; }

    public double? ChaVergi8 { get; set; }

    public double? ChaVergi9 { get; set; }

    public double? ChaVergi10 { get; set; }

    public bool? ChaVergisizFl { get; set; }

    public double? ChaOtvtutari { get; set; }

    public bool? ChaOtvvergisizFl { get; set; }

    public byte? ChaOivPntr { get; set; }

    public double? ChaOivtutari { get; set; }

    public double? ChaOivVergi { get; set; }

    public bool? ChaOivergisizFl { get; set; }

    public DateTime? ChaFisTarih { get; set; }

    public int? ChaFisSirano { get; set; }

    public string? ChaTrefno { get; set; }

    public byte? ChaSntckPoz { get; set; }

    public DateTime? ChaReftarihi { get; set; }

    public byte? ChaIstisnakodu { get; set; }

    public byte? ChaPosHareketi { get; set; }

    public byte? ChaMeblagAnaDovizIcinGecersizFl { get; set; }

    public byte? ChaMeblagAltDovizIcinGecersizFl { get; set; }

    public byte? ChaMeblagOrjDovizIcinGecersizFl { get; set; }

    public Guid? ChaSipUid { get; set; }

    public Guid? ChaKiraharUid { get; set; }

    public DateTime? ChaVardiyaTarihi { get; set; }

    public byte? ChaVardiyaNo { get; set; }

    public byte? ChaVardiyaEvrakTi { get; set; }

    public byte? ChaEbelgeTuru { get; set; }

    public double? ChaTevkifatToplam { get; set; }

    public double? ChaIlaveEdilecekKdv1 { get; set; }

    public double? ChaIlaveEdilecekKdv2 { get; set; }

    public double? ChaIlaveEdilecekKdv3 { get; set; }

    public double? ChaIlaveEdilecekKdv4 { get; set; }

    public double? ChaIlaveEdilecekKdv5 { get; set; }

    public double? ChaIlaveEdilecekKdv6 { get; set; }

    public double? ChaIlaveEdilecekKdv7 { get; set; }

    public double? ChaIlaveEdilecekKdv8 { get; set; }

    public double? ChaIlaveEdilecekKdv9 { get; set; }

    public double? ChaIlaveEdilecekKdv10 { get; set; }

    public byte? ChaEIslemTuru { get; set; }

    public byte? ChaFaturaBelgeTuru { get; set; }

    public string? ChaDigerBelgeAdi { get; set; }

    public string? ChaUuid { get; set; }

    public int? ChaAdresNo { get; set; }

    public double? ChaVergifonToplam { get; set; }

    public DateTime? ChaIlkBelgeTarihi { get; set; }

    public double? ChaIlkBelgeDovizKuru { get; set; }

    public string? ChaHareketGrupKodu1 { get; set; }

    public string? ChaHareketGrupKodu2 { get; set; }

    public string? ChaHareketGrupKodu3 { get; set; }

    public string? ChaEbelgenoSeri { get; set; }

    public int? ChaEbelgenoSira { get; set; }

    public string? ChaHubid { get; set; }

    public string? ChaHubglbid { get; set; }

    public string? ChaDisyazilimid { get; set; }

    public byte? ChaDisyazilimTip { get; set; }

    public byte? ChaBsbaEBelgeMi { get; set; }

    public string? ChaEticaretKanalKodu { get; set; }

    public short? ChaHizliSatisKasaNo { get; set; }

    public byte? ChaEbelgeIslemturu { get; set; }
}
