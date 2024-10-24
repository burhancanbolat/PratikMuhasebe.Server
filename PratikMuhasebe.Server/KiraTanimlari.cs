using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiraTanimlari
{
    public Guid KrGuid { get; set; }

    public short KrDbcno { get; set; }

    public int? KrSpecRecno { get; set; }

    public bool? KrIptal { get; set; }

    public short? KrFileid { get; set; }

    public bool? KrHidden { get; set; }

    public bool? KrKilitli { get; set; }

    public bool? KrDegisti { get; set; }

    public int? KrChecksum { get; set; }

    public short? KrCreateUser { get; set; }

    public DateTime KrCreateDate { get; set; }

    public short? KrLastupUser { get; set; }

    public DateTime? KrLastupDate { get; set; }

    public string? KrSpecial1 { get; set; }

    public string? KrSpecial2 { get; set; }

    public string? KrSpecial3 { get; set; }

    public int? KrFirmaNo { get; set; }

    public int? KrSubeNo { get; set; }

    public int? KrKiraNo { get; set; }

    public string? KrMuhtasarGrupKodu { get; set; }

    public string? KrUnvan { get; set; }

    public string? KrHesapKodu { get; set; }

    public double? KrTutar { get; set; }

    public byte? KrIsltip { get; set; }

    public string? KrOzelMahKodu { get; set; }

    public string? KrVergiKimlikNo { get; set; }

    public string? KrCadde { get; set; }

    public string? KrMahalle { get; set; }

    public string? KrSokak { get; set; }

    public string? KrSemt { get; set; }

    public string? KrAptNo { get; set; }

    public string? KrDaireNo { get; set; }

    public string? KrPostaKodu { get; set; }

    public string? KrIlce { get; set; }

    public string? KrIl { get; set; }

    public string? KrUlke { get; set; }

    public string? KrAdresNo { get; set; }

    public string? KrVergiDairesiKodu { get; set; }

    public double? KrVergiOrani { get; set; }

    public string? KrTckimlikNo { get; set; }

    public DateTime? KrBaslangictarihi { get; set; }

    public DateTime? KrBitistarihi { get; set; }
}
