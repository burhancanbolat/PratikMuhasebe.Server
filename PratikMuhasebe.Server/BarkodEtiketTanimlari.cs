using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BarkodEtiketTanimlari
{
    public Guid BepGuid { get; set; }

    public short BepDbcno { get; set; }

    public int? BepSpecRecNo { get; set; }

    public bool? BepIptal { get; set; }

    public short? BepFileid { get; set; }

    public bool? BepHidden { get; set; }

    public bool? BepKilitli { get; set; }

    public bool? BepDegisti { get; set; }

    public int? BepChecksum { get; set; }

    public short? BepCreateUser { get; set; }

    public DateTime BepCreateDate { get; set; }

    public short? BepLastupUser { get; set; }

    public DateTime? BepLastupDate { get; set; }

    public string? BepSpecial1 { get; set; }

    public string? BepSpecial2 { get; set; }

    public string? BepSpecial3 { get; set; }

    public int? BepNo { get; set; }

    public string? BepAciklama { get; set; }

    public byte? BepEtiketYolAdi { get; set; }

    public short? BepBasimAdedi { get; set; }

    public string? BepDisProgram { get; set; }

    public string? BepDisProgramParam { get; set; }

    public string? BepEan13DosyaAdi { get; set; }

    public string? BepEan8DosyaAdi { get; set; }

    public string? BepAsciiDosyaAdi { get; set; }

    public string? BepUpcaDosyaAdi { get; set; }

    public string? BepUpceDosyaAdi { get; set; }

    public string? BepCode39DosyaAdi { get; set; }

    public bool? BepKarakterCevirFl { get; set; }

    public byte? BepBasimBeklemeSuresi { get; set; }

    public bool? BepYtlcevirFl { get; set; }

    public string? BepDosyaAdi { get; set; }

    public string? BepEan13TrDosyaAdi { get; set; }

    public string? BepEan8TrDosyaAdi { get; set; }

    public string? BepAsciiTrDosyaAdi { get; set; }

    public string? BepUpcaTrDosyaAdi { get; set; }

    public string? BepUpceTrDosyaAdi { get; set; }

    public string? BepCode39TrDosyaAdi { get; set; }
}
