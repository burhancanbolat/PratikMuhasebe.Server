using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class TeklifTanimlari
{
    public Guid TeklifGuid { get; set; }

    public short TeklifDbcno { get; set; }

    public int? TeklifSpecRecno { get; set; }

    public bool? TeklifIptal { get; set; }

    public short? TeklifFileid { get; set; }

    public bool? TeklifHidden { get; set; }

    public bool? TeklifKilitli { get; set; }

    public bool? TeklifDegisti { get; set; }

    public int? TeklifChecksum { get; set; }

    public short? TeklifCreateUser { get; set; }

    public DateTime TeklifCreateDate { get; set; }

    public short? TeklifLastupUser { get; set; }

    public DateTime? TeklifLastupDate { get; set; }

    public string? TeklifSpecial1 { get; set; }

    public string? TeklifSpecial2 { get; set; }

    public string? TeklifSpecial3 { get; set; }

    public string? TeklifKodu { get; set; }

    public string? TeklifIsmi { get; set; }

    public string? TeklifAciklama { get; set; }

    public string? TeklifProje { get; set; }

    public string? TeklifSrmmrk { get; set; }

    public string? TeklifSorumlu { get; set; }

    public DateTime? TeklifBaslangictarihi { get; set; }

    public DateTime? TeklifGecerliliksuresi { get; set; }

    public DateTime? TeklifIstenenteslimtarihi { get; set; }
}
