using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariHesapAdresleri
{
    public Guid AdrGuid { get; set; }

    public short AdrDbcno { get; set; }

    public int? AdrSpecRecno { get; set; }

    public bool? AdrIptal { get; set; }

    public short? AdrFileid { get; set; }

    public bool? AdrHidden { get; set; }

    public bool? AdrKilitli { get; set; }

    public bool? AdrDegisti { get; set; }

    public int? AdrChecksum { get; set; }

    public short? AdrCreateUser { get; set; }

    public DateTime AdrCreateDate { get; set; }

    public short? AdrLastupUser { get; set; }

    public DateTime? AdrLastupDate { get; set; }

    public string? AdrSpecial1 { get; set; }

    public string? AdrSpecial2 { get; set; }

    public string? AdrSpecial3 { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }

    public string? AdrCariKod { get; set; }

    public int? AdrAdresNo { get; set; }

    public bool? AdrAprintFl { get; set; }

    public string? AdrCadde { get; set; }

    public string? AdrMahalle { get; set; }

    public string? AdrSokak { get; set; }

    public string? AdrSemt { get; set; }

    public string? AdrAptNo { get; set; }

    public string? AdrDaireNo { get; set; }

    public string? AdrPostaKodu { get; set; }

    public string? AdrIlce { get; set; }

    public string? AdrIl { get; set; }

    public string? AdrUlke { get; set; }

    public string? AdrAdresKodu { get; set; }

    public string? AdrTelUlkeKodu { get; set; }

    public string? AdrTelBolgeKodu { get; set; }

    public string? AdrTelNo1 { get; set; }

    public string? AdrTelNo2 { get; set; }

    public string? AdrTelFaxno { get; set; }

    public string? AdrTelModem { get; set; }

    public string? AdrYonKodu { get; set; }

    public short? AdrUzaklikKodu { get; set; }

    public string? AdrTemsilciKodu { get; set; }

    public string? AdrOzelNot { get; set; }

    public byte? AdrZiyaretperyodu { get; set; }

    public double? AdrZiyaretgunu { get; set; }

    public double? AdrGpsEnlem { get; set; }

    public double? AdrGpsBoylam { get; set; }

    public byte? AdrZiyarethaftasi { get; set; }

    public bool? AdrZiygunu21 { get; set; }

    public bool? AdrZiygunu22 { get; set; }

    public bool? AdrZiygunu23 { get; set; }

    public bool? AdrZiygunu24 { get; set; }

    public bool? AdrZiygunu25 { get; set; }

    public bool? AdrZiygunu26 { get; set; }

    public bool? AdrZiygunu27 { get; set; }

    public string? AdrEfaturaAlias { get; set; }

    public string? AdrEirsaliyeAlias { get; set; }
}
