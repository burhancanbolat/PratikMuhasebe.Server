using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class MuhasebeFisDetaylari
{
    public Guid MfdGuid { get; set; }

    public short MfdDbcno { get; set; }

    public int? MfdSpecRecno { get; set; }

    public bool? MfdIptal { get; set; }

    public short? MfdFileid { get; set; }

    public bool? MfdHidden { get; set; }

    public bool? MfdKilitli { get; set; }

    public bool? MfdDegisti { get; set; }

    public int? MfdChecksum { get; set; }

    public short? MfdCreateUser { get; set; }

    public DateTime MfdCreateDate { get; set; }

    public short? MfdLastupUser { get; set; }

    public DateTime? MfdLastupDate { get; set; }

    public string? MfdSpecial1 { get; set; }

    public string? MfdSpecial2 { get; set; }

    public string? MfdSpecial3 { get; set; }

    public byte? MfdTicariTip { get; set; }

    public byte? MfdEvraktip { get; set; }

    public string? MfdEvrakSeri { get; set; }

    public int? MfdEvrakSira { get; set; }

    public string? MfdCariunvan { get; set; }

    public string? MfdCarivergidaireadi { get; set; }

    public string? MfdCarivergidaireno { get; set; }

    public double? MfdBsbakonututar { get; set; }

    public byte? MfdBsbatabii { get; set; }

    public string? MfdCariulkekodno { get; set; }

    public DateTime? MfdBelgetarihi { get; set; }

    public byte? MfdTutarnereden { get; set; }

    public byte? MfdCaritipi { get; set; }

    public string? MfdCarikodu { get; set; }

    public string? MfdCarimuhkodu { get; set; }

    public string? MfdBelgeno { get; set; }

    public byte? MfdKdvid { get; set; }

    public double? MfdKdvtutar { get; set; }

    public string? MfdMalhizmetkodu { get; set; }

    public string? MfdMalhizmetcinsi { get; set; }

    public double? MfdMalhizmetmiktari { get; set; }

    public string? MfdMalhizmetbirim { get; set; }

    public string? MfdGgbGcbNo { get; set; }

    public string? MfdAracivergidaireadi { get; set; }

    public string? MfdAracivergidaireno { get; set; }

    public string? MfdEximulkekodu { get; set; }

    public double? MfdBsbakonuufrstutar { get; set; }

    public string? MfdAciklama { get; set; }

    public double? MfdCaritutar { get; set; }

    public byte? MfdKisaevraktipi { get; set; }

    public byte? MfdSatistipi { get; set; }

    public byte? MfdAlistipi { get; set; }

    public byte? MfdTahtedtipi { get; set; }

    public string? MfdDigerevrakadi { get; set; }

    public byte? MfdEvraktur { get; set; }

    public bool? MfdEBelgemi { get; set; }

    public byte? MfdEBelgemiNereden { get; set; }

    public string? MfdEvrakHubid { get; set; }

    public string? MfdEvrakHubglbid { get; set; }

    public byte? MfdEvrakBaglantisi { get; set; }

    public string? MfdEvrakDisyazilimid { get; set; }

    public byte? MfdEvrakDisyazilimTip { get; set; }
}
