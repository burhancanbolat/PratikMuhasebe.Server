using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BankaOnlineAktarimKosul
{
    public Guid BoakGuid { get; set; }

    public short BoakDbcno { get; set; }

    public int? BoakSpecRecno { get; set; }

    public bool? BoakIptal { get; set; }

    public short? BoakFileid { get; set; }

    public bool? BoakHidden { get; set; }

    public bool? BoakKilitli { get; set; }

    public bool? BoakDegisti { get; set; }

    public int? BoakChecksum { get; set; }

    public short? BoakCreateUser { get; set; }

    public DateTime BoakCreateDate { get; set; }

    public short? BoakLastupUser { get; set; }

    public DateTime? BoakLastupDate { get; set; }

    public string? BoakSpecial1 { get; set; }

    public string? BoakSpecial2 { get; set; }

    public string? BoakSpecial3 { get; set; }

    public string? BoakBankTcmbKodu { get; set; }

    public string? BoakBankKod { get; set; }

    public string? BoakIslemKodu { get; set; }

    public string? BoakIslemAciklama { get; set; }

    public byte? BoakKarsiVknTipi { get; set; }

    public byte? BoakKarsiIbanTipi { get; set; }

    public byte? BoakKarsiSubeTipi { get; set; }

    public byte? BoakKarsiHesapnoTipi { get; set; }

    public byte? BoakKarsiTutarTipi { get; set; }

    public int? BoakOncelik { get; set; }

    public string? BoakSablonKod { get; set; }
}
