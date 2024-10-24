using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SiparisEsleme
{
    public Guid SeGuid { get; set; }

    public short SeDbcno { get; set; }

    public int? SeSpecRecno { get; set; }

    public bool? SeIptal { get; set; }

    public short? SeFileid { get; set; }

    public bool? SeHidden { get; set; }

    public bool? SeKilitli { get; set; }

    public bool? SeDegisti { get; set; }

    public int? SeChecksum { get; set; }

    public short? SeCreateUser { get; set; }

    public DateTime SeCreateDate { get; set; }

    public short? SeLastupUser { get; set; }

    public DateTime? SeLastupDate { get; set; }

    public string? SeSpecial1 { get; set; }

    public string? SeSpecial2 { get; set; }

    public string? SeSpecial3 { get; set; }

    public byte? SeTalepTabloId { get; set; }

    public Guid? SeTalepUid { get; set; }

    public byte? SeTeminTabloId { get; set; }

    public Guid? SeTeminUid { get; set; }

    public double? SeEslesenMiktar { get; set; }

    public string? SeAciklama { get; set; }

    public double? SeTeslimMiktar { get; set; }

    public byte? SeKayitTipi { get; set; }
}
