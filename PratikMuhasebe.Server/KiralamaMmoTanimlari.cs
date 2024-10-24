using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KiralamaMmoTanimlari
{
    public Guid KmmoGuid { get; set; }

    public short KmmoDbcno { get; set; }

    public int? KmmoSpecRecno { get; set; }

    public bool? KmmoIptal { get; set; }

    public short? KmmoFileid { get; set; }

    public bool? KmmoHidden { get; set; }

    public bool? KmmoKilitli { get; set; }

    public bool? KmmoDegisti { get; set; }

    public int? KmmoChecksum { get; set; }

    public short? KmmoCreateUser { get; set; }

    public DateTime KmmoCreateDate { get; set; }

    public short? KmmoLastupUser { get; set; }

    public DateTime? KmmoLastupDate { get; set; }

    public string? KmmoSpecial1 { get; set; }

    public string? KmmoSpecial2 { get; set; }

    public string? KmmoSpecial3 { get; set; }

    public byte? KmmoRaporTipi { get; set; }

    public string? KmmoRaporKodu { get; set; }

    public DateTime? KmmoKontrolTarihi { get; set; }

    public DateTime? KmmoRapTarihi { get; set; }

    public string? KmmoRapNo { get; set; }

    public DateTime? KmmoGecerlilikTarihi { get; set; }

    public string? KmmoStokKodu { get; set; }

    public string? KmmoCihazSeri { get; set; }

    public string? KmmoCarikodu { get; set; }

    public string? KmmoFaturaSeri { get; set; }

    public int? KmmoFaturaSira { get; set; }

    public DateTime? KmmoFaturaTarihi { get; set; }

    public double? KmmoTutar { get; set; }

    public string? KmmoAciklama { get; set; }
}
