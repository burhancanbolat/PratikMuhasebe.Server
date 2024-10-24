using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CariPersonelTanimlari
{
    public Guid CariPerGuid { get; set; }

    public short CariPerDbcno { get; set; }

    public int? CariPerSpecRecno { get; set; }

    public bool? CariPerIptal { get; set; }

    public short? CariPerFileid { get; set; }

    public bool? CariPerHidden { get; set; }

    public bool? CariPerKilitli { get; set; }

    public bool? CariPerDegisti { get; set; }

    public int? CariPerChecksum { get; set; }

    public short? CariPerCreateUser { get; set; }

    public DateTime CariPerCreateDate { get; set; }

    public short? CariPerLastupUser { get; set; }

    public DateTime? CariPerLastupDate { get; set; }

    public string? CariPerSpecial1 { get; set; }

    public string? CariPerSpecial2 { get; set; }

    public string? CariPerSpecial3 { get; set; }

    public string? CariPerKod { get; set; }

    public string? CariPerAdi { get; set; }

    public string? CariPerSoyadi { get; set; }

    public byte? CariPerTip { get; set; }

    public byte? CariPerDovizCinsi { get; set; }

    public string? CariPerMuhkod0 { get; set; }

    public string? CariPerMuhkod1 { get; set; }

    public string? CariPerMuhkod2 { get; set; }

    public string? CariPerMuhkod3 { get; set; }

    public string? CariPerMuhkod4 { get; set; }

    public string? CariPerBankaTcmbKod { get; set; }

    public string? CariPerBankaTcmbSubekod { get; set; }

    public string? CariPerBankaTcmbIlkod { get; set; }

    public string? CariPerBankaHesapno { get; set; }

    public string? CariPerBankaSwiftkodu { get; set; }

    public double? CariPerPrimAdet { get; set; }

    public double? CariPerPrimYuzde { get; set; }

    public double? CariPerPrimCarpani { get; set; }

    public double? CariPerBasmprimcirotav1 { get; set; }

    public double? CariPerBasmprimyuz1 { get; set; }

    public double? CariPerBasmprimcirotav2 { get; set; }

    public double? CariPerBasmprimyuz2 { get; set; }

    public double? CariPerBasmprimcirotav3 { get; set; }

    public double? CariPerBasmprimyuz3 { get; set; }

    public double? CariPerBasmprimcirotav4 { get; set; }

    public double? CariPerBasmprimyuz4 { get; set; }

    public double? CariPerBasmprimcirotav5 { get; set; }

    public double? CariPerBasmprimyuz5 { get; set; }

    public string? CariPerKasiyerkodu { get; set; }

    public string? CariPerKasiyersifresi { get; set; }

    public string? CariPerKasiyerAmiri { get; set; }

    public int? CariPerUserno { get; set; }

    public int? CariPerDepono { get; set; }

    public string? CariPerCepno { get; set; }

    public string? CariPerMail { get; set; }

    public string? CariTakvimKodu { get; set; }

    public string? CariPerKasiyerfirmaid { get; set; }

    public string? CariPerKepAdresi { get; set; }

    public string? CariPerTcKimlikNo { get; set; }
}
