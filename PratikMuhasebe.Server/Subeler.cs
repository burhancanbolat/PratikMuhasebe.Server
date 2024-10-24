using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class Subeler
{
    public Guid SubeGuid { get; set; }

    public short SubeDbcno { get; set; }

    public int? SubeSpecRecno { get; set; }

    public bool? SubeIptal { get; set; }

    public short? SubeFileid { get; set; }

    public bool? SubeHidden { get; set; }

    public bool? SubeKilitli { get; set; }

    public bool? SubeDegisti { get; set; }

    public int? SubeChecksum { get; set; }

    public short? SubeCreateUser { get; set; }

    public DateTime SubeCreateDate { get; set; }

    public short? SubeLastupUser { get; set; }

    public DateTime? SubeLastupDate { get; set; }

    public string? SubeSpecial1 { get; set; }

    public string? SubeSpecial2 { get; set; }

    public string? SubeSpecial3 { get; set; }

    public int? SubeBagFirma { get; set; }

    public int? SubeNo { get; set; }

    public string? SubeAdi { get; set; }

    public string? SubeKodu { get; set; }

    public string? SubeMersisNo { get; set; }

    public string? SubeMuhgrupkodu { get; set; }

    public bool? SubeFuture { get; set; }

    public string? SubeMnMuhfserino { get; set; }

    public string? SubeYetkiliEmail { get; set; }

    public string? SubeCadde { get; set; }

    public string? SubeMahalle { get; set; }

    public string? SubeSokak { get; set; }

    public string? SubeSemt { get; set; }

    public string? SubeAptNo { get; set; }

    public string? SubeDaireNo { get; set; }

    public string? SubePostaKodu { get; set; }

    public string? SubeIlce { get; set; }

    public string? SubeIl { get; set; }

    public string? SubeUlke { get; set; }

    public string? SubeAdresKodu { get; set; }

    public double? SubeGpsEnlem { get; set; }

    public double? SubeGpsBoylam { get; set; }

    public string? SubeTelUlkeKodu { get; set; }

    public string? SubeTelBolgekodu { get; set; }

    public string? SubeTelNo1 { get; set; }

    public string? SubeTelNo2 { get; set; }

    public string? SubeTelFaxno { get; set; }

    public string? SubeTelModem { get; set; }

    public int? SubeDatacenterno { get; set; }

    public string? SubeEIskurNo { get; set; }

    public string? SubeEIskurTcno { get; set; }

    public string? SubeEIskurSifre { get; set; }

    public double? SubeRusumOrani { get; set; }

    public string? SubeEmutabakatsubekodu { get; set; }

    public byte? SubeEFaturaMukellefiyetTipi { get; set; }

    public string? SubeEFaturaMukellefiyetKodu { get; set; }

    public bool? SubeIkportalEntegrasyonFl { get; set; }

    public int? SubeIdmId { get; set; }

    public int? SubeIdmServiceUserId { get; set; }
}
