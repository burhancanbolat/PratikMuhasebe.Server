using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BakimPdiTanimlari
{
    public Guid BpdiGuid { get; set; }

    public short BpdiDbcno { get; set; }

    public int? BpdiSpecRecno { get; set; }

    public bool? BpdiIptal { get; set; }

    public short? BpdiFileid { get; set; }

    public bool? BpdiHidden { get; set; }

    public bool? BpdiKilitli { get; set; }

    public bool? BpdiDegisti { get; set; }

    public int? BpdiChecksum { get; set; }

    public short? BpdiCreateUser { get; set; }

    public DateTime BpdiCreateDate { get; set; }

    public short? BpdiLastupUser { get; set; }

    public DateTime? BpdiLastupDate { get; set; }

    public string? BpdiSpecial1 { get; set; }

    public string? BpdiSpecial2 { get; set; }

    public string? BpdiSpecial3 { get; set; }

    public string? BpdiKodu { get; set; }

    public DateTime? BpdiKontrolTarihi { get; set; }

    public string? BpdiStokKodu { get; set; }

    public string? BpdiCihazSeri { get; set; }

    public int? BpdiSayac { get; set; }

    public string? BpdiGidecegiCari { get; set; }

    public string? BpdiPerskodu { get; set; }

    public byte? BpdiKontrolSonucu { get; set; }

    public string? BpdiAciklama1 { get; set; }

    public string? BpdiAciklama2 { get; set; }
}
