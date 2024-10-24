using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OdemeEmriAcilislari
{
    public Guid ScaGuid { get; set; }

    public short ScaDbcno { get; set; }

    public int? ScaSpecRecNo { get; set; }

    public bool? ScaIptal { get; set; }

    public short? ScaFileid { get; set; }

    public bool? ScaHidden { get; set; }

    public bool? ScaKilitli { get; set; }

    public bool? ScaDegisti { get; set; }

    public int? ScaCheckSum { get; set; }

    public short? ScaCreateUser { get; set; }

    public DateTime ScaCreateDate { get; set; }

    public short? ScaLastupUser { get; set; }

    public DateTime? ScaLastupDate { get; set; }

    public string? ScaSpecial1 { get; set; }

    public string? ScaSpecial2 { get; set; }

    public string? ScaSpecial3 { get; set; }

    public int? ScaFirmano { get; set; }

    public int? ScaSubeno { get; set; }

    public byte? ScaEvrakTip { get; set; }

    public string? ScaEvraknoSeri { get; set; }

    public int? ScaEvraknoSira { get; set; }

    public int? ScaSatirNo { get; set; }

    public DateTime? ScaTarihi { get; set; }

    public byte? ScaTip { get; set; }

    public byte? ScaCinsi { get; set; }

    public byte? ScaNormalIade { get; set; }

    public byte? ScaTpoz { get; set; }

    public byte? ScaDisticaretTuru { get; set; }

    public string? ScaBelgeNo { get; set; }

    public DateTime? ScaBelgeTarih { get; set; }

    public string? ScaAciklama { get; set; }

    public string? ScaSaticiKodu { get; set; }

    public string? ScaEximkodu { get; set; }

    public string? ScaProjekodu { get; set; }

    public string? ScaYatTesKodu { get; set; }

    public byte? ScaCariCins { get; set; }

    public string? ScaKod { get; set; }

    public string? ScaCiroCariKodu { get; set; }

    public byte? ScaDCins { get; set; }

    public double? ScaDKur { get; set; }

    public double? ScaAltdKur { get; set; }

    public byte? ScaGrupno { get; set; }

    public string? ScaSrmrkkodu { get; set; }

    public byte? ScaKasaHizmet { get; set; }

    public string? ScaKasaHizkod { get; set; }

    public byte? ScaKarsidcinsi { get; set; }

    public double? ScaKarsidKur { get; set; }

    public byte? ScaKarsidgrupno { get; set; }

    public string? ScaKarsisrmrkkodu { get; set; }

    public double? ScaMiktari { get; set; }

    public double? ScaMeblag { get; set; }

    public double? ScaAratoplam { get; set; }

    public int? ScaVade { get; set; }

    public double? ScaVadeFarkiYuz { get; set; }

    public double? ScaFtIskonto1 { get; set; }

    public double? ScaFtIskonto2 { get; set; }

    public double? ScaFtIskonto3 { get; set; }

    public double? ScaFtIskonto4 { get; set; }

    public double? ScaFtIskonto5 { get; set; }

    public double? ScaFtIskonto6 { get; set; }

    public double? ScaFtMasraf1 { get; set; }

    public double? ScaFtMasraf2 { get; set; }

    public double? ScaFtMasraf3 { get; set; }

    public double? ScaFtMasraf4 { get; set; }

    public byte? ScaIskMas1 { get; set; }

    public byte? ScaIskMas2 { get; set; }

    public byte? ScaIskMas3 { get; set; }

    public byte? ScaIskMas4 { get; set; }

    public byte? ScaIskMas5 { get; set; }

    public byte? ScaIskMas6 { get; set; }

    public byte? ScaIskMas7 { get; set; }

    public byte? ScaIskMas8 { get; set; }

    public byte? ScaIskMas9 { get; set; }

    public byte? ScaIskMas10 { get; set; }

    public bool? ScaSatIskmas1 { get; set; }

    public bool? ScaSatIskmas2 { get; set; }

    public bool? ScaSatIskmas3 { get; set; }

    public bool? ScaSatIskmas4 { get; set; }

    public bool? ScaSatIskmas5 { get; set; }

    public bool? ScaSatIskmas6 { get; set; }

    public bool? ScaSatIskmas7 { get; set; }

    public bool? ScaSatIskmas8 { get; set; }

    public bool? ScaSatIskmas9 { get; set; }

    public bool? ScaSatIskmas10 { get; set; }

    public double? ScaYuvarlama { get; set; }

    public byte? ScaStFonPntr { get; set; }

    public double? ScaStopaj { get; set; }

    public double? ScaSavsandesfonu { get; set; }

    public double? ScaAvansmakDamgapul { get; set; }

    public byte? ScaVergipntr { get; set; }

    public double? ScaVergi1 { get; set; }

    public double? ScaVergi2 { get; set; }

    public double? ScaVergi3 { get; set; }

    public double? ScaVergi4 { get; set; }

    public double? ScaVergi5 { get; set; }

    public double? ScaVergi6 { get; set; }

    public double? ScaVergi7 { get; set; }

    public double? ScaVergi8 { get; set; }

    public double? ScaVergi9 { get; set; }

    public double? ScaVergi10 { get; set; }

    public bool? ScaVergisizFl { get; set; }

    public double? ScaOtvtutari { get; set; }

    public bool? ScaOtvvergisizFl { get; set; }

    public byte? ScaOivPntr { get; set; }

    public double? ScaOivtutari { get; set; }

    public double? ScaOivVergi { get; set; }

    public bool? ScaOivergisizFl { get; set; }

    public DateTime? ScaFisTarih { get; set; }

    public int? ScaFisSirano { get; set; }

    public string? ScaTrefno { get; set; }

    public byte? ScaSntckPoz { get; set; }

    public DateTime? ScaReftarihi { get; set; }

    public byte? ScaIstisnakodu { get; set; }

    public byte? ScaPosHareketi { get; set; }

    public byte? ScaMeblagAnaDovizIcinGecersizFl { get; set; }

    public byte? ScaMeblagAltDovizIcinGecersizFl { get; set; }

    public byte? ScaMeblagOrjDovizIcinGecersizFl { get; set; }

    public Guid? ScaSipUid { get; set; }

    public Guid? ChaKiraharUid { get; set; }

    public DateTime? ScaVardiyaTarihi { get; set; }

    public byte? ScaVardiyaNo { get; set; }

    public byte? ScaVardiyaEvrakTi { get; set; }

    public byte? ScaEbelgeCinsi { get; set; }

    public double? ScaTevkifatToplam { get; set; }

    public double? ScaIlaveEdilecekKdv1 { get; set; }

    public double? ScaIlaveEdilecekKdv2 { get; set; }

    public double? ScaIlaveEdilecekKdv3 { get; set; }

    public double? ScaIlaveEdilecekKdv4 { get; set; }

    public double? ScaIlaveEdilecekKdv5 { get; set; }

    public double? ScaIlaveEdilecekKdv6 { get; set; }

    public double? ScaIlaveEdilecekKdv7 { get; set; }

    public double? ScaIlaveEdilecekKdv8 { get; set; }

    public double? ScaIlaveEdilecekKdv9 { get; set; }

    public double? ScaIlaveEdilecekKdv10 { get; set; }

    public byte? ScaEIslemTuru { get; set; }

    public byte? ScaFaturaBelgeTuru { get; set; }

    public string? ScaDigerBelgeAdi { get; set; }

    public string? ScaUuid { get; set; }

    public int? ScaAdresNo { get; set; }

    public double? ScaVergifonToplam { get; set; }

    public DateTime? ScaIlkBelgeTarihi { get; set; }

    public double? ScaIlkBelgeDovizKuru { get; set; }

    public string? ScaHareketGrupKodu1 { get; set; }

    public string? ScaHareketGrupKodu2 { get; set; }

    public string? ScaHareketGrupKodu3 { get; set; }

    public string? ScaEbelgenoSeri { get; set; }

    public int? ScaEbelgenoSira { get; set; }

    public string? ScaHubid { get; set; }

    public string? ScaHubglbid { get; set; }

    public string? ScaDisyazilimid { get; set; }

    public byte? ScaDisyazilimTip { get; set; }

    public byte? ScaBsbaEBelgeMi { get; set; }

    public string? ScaEticaretKanalKodu { get; set; }

    public short? ScaHizliSatisKasaNo { get; set; }

    public byte? ScaEbelgeIslemturu { get; set; }
}
