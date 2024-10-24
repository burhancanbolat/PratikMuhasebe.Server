using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Projeler
{
    public Guid ProGuid { get; set; }

    public short ProDbcno { get; set; }

    public int? ProSpecRecno { get; set; }

    public bool? ProIptal { get; set; }

    public short? ProFileid { get; set; }

    public bool? ProHidden { get; set; }

    public bool? ProKilitli { get; set; }

    public bool? ProDegisti { get; set; }

    public int? ProChecksum { get; set; }

    public short? ProCreateUser { get; set; }

    public DateTime ProCreateDate { get; set; }

    public short? ProLastupUser { get; set; }

    public DateTime? ProLastupDate { get; set; }

    public string? ProSpecial1 { get; set; }

    public string? ProSpecial2 { get; set; }

    public string? ProSpecial3 { get; set; }

    public string? ProKodu { get; set; }

    public string? ProAdi { get; set; }

    public string? ProMusterikodu { get; set; }

    public string? ProSormerkodu { get; set; }

    public string? ProBolgekodu { get; set; }

    public string? ProSektorkodu { get; set; }

    public string? ProGrupkodu { get; set; }

    public string? ProMuhKodArtikeli { get; set; }

    public byte? ProDurumu { get; set; }

    public string? ProAciklama { get; set; }

    public string? ProAnaProjekodu { get; set; }

    public int? ProPlanlananSure { get; set; }

    public DateTime? ProPlanlananBastarih { get; set; }

    public DateTime? ProPlanlananBittarih { get; set; }

    public DateTime? ProGerceklesenBastarih { get; set; }

    public DateTime? ProGerceklesenBittarih { get; set; }

    public string? ProBaslangicGecikmesebep { get; set; }

    public string? ProBitisGecikmesebep { get; set; }

    public double? ProPerformansOrani { get; set; }

    public byte? ProTeminatSekli { get; set; }

    public byte? ProTeminatDovizCinsi { get; set; }

    public double? ProTeminat { get; set; }

    public byte? ProIsavansiSekli { get; set; }

    public byte? ProIsavansiDovizCinsi { get; set; }

    public double? ProIsavansi { get; set; }
}
