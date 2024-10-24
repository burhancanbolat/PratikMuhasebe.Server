using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BankaOnlineEntegrasyon
{
    public Guid BoeGuid { get; set; }

    public short BoeDbcno { get; set; }

    public int? BoeSpecRecno { get; set; }

    public bool? BoeIptal { get; set; }

    public short? BoeFileid { get; set; }

    public bool? BoeHidden { get; set; }

    public bool? BoeKilitli { get; set; }

    public bool? BoeDegisti { get; set; }

    public int? BoeChecksum { get; set; }

    public short? BoeCreateUser { get; set; }

    public DateTime BoeCreateDate { get; set; }

    public short? BoeLastupUser { get; set; }

    public DateTime? BoeLastupDate { get; set; }

    public string? BoeSpecial1 { get; set; }

    public string? BoeSpecial2 { get; set; }

    public string? BoeSpecial3 { get; set; }

    public string BoeTcmbKodu { get; set; } = null!;

    public string? BoePId { get; set; }

    public long? BoePCompanyPrstId { get; set; }

    public string? BoePBankName { get; set; }

    public DateTime? BoePCreatedAt { get; set; }

    public DateTime? BoePUpdatedAt { get; set; }

    public DateTime? BoePSyncedAt { get; set; }

    public string? BoePStatus { get; set; }

    public string? BoePCredentialsId { get; set; }

    public string? BoePCredentialsUsername { get; set; }

    public string? BoePCredentialsPasword { get; set; }

    public string? BoePCredentialsFirmCode { get; set; }

    public string? BoePCredentialsFirmName { get; set; }

    public string? BoePCredentialsFirmKey { get; set; }

    public string? BoePCredentialsEndpoint { get; set; }

    public string? BoePCredentialsCorporationCode { get; set; }

    public string? BoePCredentialsCustomerNo { get; set; }
}
