using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmSayacHareketleri
{
    public Guid AvmshGuid { get; set; }

    public short AvmshDbcno { get; set; }

    public int? AvmshSpecRecno { get; set; }

    public bool? AvmshIptal { get; set; }

    public short? AvmshFileid { get; set; }

    public bool? AvmshHidden { get; set; }

    public bool? AvmshKilitli { get; set; }

    public bool? AvmshDegisti { get; set; }

    public int? AvmshChecksum { get; set; }

    public short? AvmshCreateUser { get; set; }

    public DateTime AvmshCreateDate { get; set; }

    public short? AvmshLastupUser { get; set; }

    public DateTime? AvmshLastupDate { get; set; }

    public string? AvmshSpecial1 { get; set; }

    public string? AvmshSpecial2 { get; set; }

    public string? AvmshSpecial3 { get; set; }

    public byte? AvmshTuru { get; set; }

    public int? AvmshFirmaNo { get; set; }

    public int? AvmshSubeNo { get; set; }

    public DateTime? AvmshTarihi { get; set; }

    public string? AvmshEvraknoSeri { get; set; }

    public int? AvmshEvraknoSira { get; set; }

    public int? AvmshSatirno { get; set; }

    public string? AvmshBelgeNo { get; set; }

    public DateTime? AvmshBelgeTarih { get; set; }

    public string? AvmshSayackodu { get; set; }

    public double? AvmshSonokuma { get; set; }

    public Guid? AvmshFatUid { get; set; }

    public string? AvmshAciklama { get; set; }

    public Guid? AvmshKaltutFatUid { get; set; }

    public Guid? AvmshMerkezSayacUid { get; set; }

    public Guid? AvmshYansitmaDekontUid { get; set; }

    public double? AvmshKayipyuzdesi { get; set; }
}
