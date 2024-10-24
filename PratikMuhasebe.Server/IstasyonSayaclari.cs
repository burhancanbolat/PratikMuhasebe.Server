using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IstasyonSayaclari
{
    public Guid SGuid { get; set; }

    public short SDbcno { get; set; }

    public int? SSpecRecno { get; set; }

    public bool? SIptal { get; set; }

    public short? SFileid { get; set; }

    public bool? SHidden { get; set; }

    public bool? SKilitli { get; set; }

    public bool? SDegisti { get; set; }

    public int? SChecksum { get; set; }

    public short? SCreateUser { get; set; }

    public DateTime SCreateDate { get; set; }

    public short? SLastupUser { get; set; }

    public DateTime? SLastupDate { get; set; }

    public string? SSpecial1 { get; set; }

    public string? SSpecial2 { get; set; }

    public string? SSpecial3 { get; set; }

    public string? SKod { get; set; }

    public string? SIsmi { get; set; }

    public int? SFirmaNo { get; set; }

    public int? SSubeNo { get; set; }

    public byte? SHareketTipi { get; set; }

    public string? SStokkodu { get; set; }

    public string? SAdakodu { get; set; }

    public string? SAciklama { get; set; }

    public int? SDepono { get; set; }

    public double? SAcilis { get; set; }

    public string? SSubeSayackodu { get; set; }
}
