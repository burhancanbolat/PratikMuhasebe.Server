using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BankaOnlineHareketler
{
    public Guid BohGuid { get; set; }

    public short BohDbcno { get; set; }

    public int? BohSpecRecno { get; set; }

    public bool? BohIptal { get; set; }

    public short? BohFileid { get; set; }

    public bool? BohHidden { get; set; }

    public bool? BohKilitli { get; set; }

    public bool? BohDegisti { get; set; }

    public int? BohChecksum { get; set; }

    public short? BohCreateUser { get; set; }

    public DateTime BohCreateDate { get; set; }

    public short? BohLastupUser { get; set; }

    public DateTime? BohLastupDate { get; set; }

    public string? BohSpecial1 { get; set; }

    public string? BohSpecial2 { get; set; }

    public string? BohSpecial3 { get; set; }

    public string BohBanKod { get; set; } = null!;

    public long BohId { get; set; }

    public DateTime BohTxDate { get; set; }

    public string? BohTxBranch { get; set; }

    public string? BohTxRegistrationId { get; set; }

    public string? BohTxNumber { get; set; }

    public string? BohTxTypeCode { get; set; }

    public string BohDebitCredit { get; set; } = null!;

    public double BohAmount { get; set; }

    public double BohBalance { get; set; }

    public string? BohDescription1 { get; set; }

    public string? BohDescription2 { get; set; }

    public string? BohOtherAcctIban { get; set; }

    public int? BohOtherAcctBankCode { get; set; }

    public int? BohOtherAcctBranchCode { get; set; }

    public string? BohOtherAcctTaxNumber { get; set; }

    public DateTime? BohCreatedAt { get; set; }

    public DateTime? BohUpdatedAt { get; set; }

    public string? BohUniqueKey { get; set; }

    public string? BohSyncStatus { get; set; }

    public bool? BohAutoMatched { get; set; }

    public long BohBankAccountId { get; set; }

    public bool? BohAktarimDurumu { get; set; }

    public byte? BohAktarimTipi { get; set; }

    public Guid? BohAktarimUid { get; set; }

    public bool? BohEkspressAktarimDurumu { get; set; }

    public Guid? BohEkspressAktarimUid { get; set; }

    public DateTime? BohEkspressAktarimTarih { get; set; }

    public byte? BohEslestirKarsiCariCins { get; set; }

    public string BohEslestirKarsiCariKodu { get; set; } = null!;

    public byte? BohEslestirKarsiCariGrup { get; set; }

    public string BohEslestirKapaliFaturaCariKodu { get; set; } = null!;

    public string BohEslestirSrmMrkKodu { get; set; } = null!;

    public string BohEslestirProjeKodu { get; set; } = null!;

    public string BohEslestirSorumluKodu { get; set; } = null!;

    public string? BohRawData { get; set; }
}
