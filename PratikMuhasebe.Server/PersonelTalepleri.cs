using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelTalepleri
{
    public Guid TlpGuid { get; set; }

    public short TlpDbcno { get; set; }

    public int? TlpSpecRecno { get; set; }

    public bool? TlpIptal { get; set; }

    public short? TlpFileid { get; set; }

    public bool? TlpHidden { get; set; }

    public bool? TlpKilitli { get; set; }

    public bool? TlpDegisti { get; set; }

    public int? TlpChecksum { get; set; }

    public short? TlpCreateUser { get; set; }

    public DateTime TlpCreateDate { get; set; }

    public short? TlpLastupUser { get; set; }

    public DateTime? TlpLastupDate { get; set; }

    public string? TlpSpecial1 { get; set; }

    public string? TlpSpecial2 { get; set; }

    public string? TlpSpecial3 { get; set; }

    public string? TlpKodu { get; set; }

    public string? TlpAdi { get; set; }

    public DateTime? TlpTarih { get; set; }

    public DateTime? TlpBitistarih { get; set; }

    public string? TlpGrvKodu { get; set; }

    public string? TlpDptKodu { get; set; }

    public string? TlpEdenPerKodu { get; set; }

    public short? TlpAdet { get; set; }

    public byte? TlpDurum { get; set; }

    public string? TlpAciklama1 { get; set; }

    public string? TlpAciklama2 { get; set; }

    public string? TlpAciklama3 { get; set; }

    public string? TlpAciklama4 { get; set; }

    public string? TlpAciklama5 { get; set; }

    public string? TlpKadroKodu { get; set; }

    public byte? TlpNedeni { get; set; }

    public byte? TlpCinsiyet { get; set; }

    public byte? TlpMedeniHal { get; set; }

    public int? TlpMinyas { get; set; }

    public int? TlpMaxyas { get; set; }

    public byte? TlpAskerlik { get; set; }

    public byte? TlpEhliyet { get; set; }

    public int? TlpTecrube { get; set; }

    public byte? TlpDilTipi { get; set; }

    public byte? TlpDilSeviye { get; set; }

    public byte? TlpDilKonusma { get; set; }

    public byte? TlpOzurderecesi { get; set; }

    public byte? TlpOzurgrubu { get; set; }
}
