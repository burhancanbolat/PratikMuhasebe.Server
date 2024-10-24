using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimTalepleri
{
    public Guid UtlGuid { get; set; }

    public short UtlDbcno { get; set; }

    public int? UtlSpecRecno { get; set; }

    public bool? UtlIptal { get; set; }

    public short? UtlFileid { get; set; }

    public bool? UtlHidden { get; set; }

    public bool? UtlKilitli { get; set; }

    public bool? UtlDegisti { get; set; }

    public int? UtlChecksum { get; set; }

    public short? UtlCreateUser { get; set; }

    public DateTime UtlCreateDate { get; set; }

    public short? UtlLastupUser { get; set; }

    public DateTime? UtlLastupDate { get; set; }

    public string? UtlSpecial1 { get; set; }

    public string? UtlSpecial2 { get; set; }

    public string? UtlSpecial3 { get; set; }

    public int? UtlFirmano { get; set; }

    public int? UtlSubeno { get; set; }

    public DateTime? UtlTarihi { get; set; }

    public DateTime? UtlTeslimTarihi { get; set; }

    public string? UtlEvrakSeri { get; set; }

    public int? UtlEvrakSira { get; set; }

    public int? UtlSatirNo { get; set; }

    public string? UtlBelgeNo { get; set; }

    public DateTime? UtlBelgeTarihi { get; set; }

    public string? UtlSorMerk { get; set; }

    public string? UtlStokKodu { get; set; }

    public string? UtlSaticiKodu { get; set; }

    public double? UtlMiktari { get; set; }

    public double? UtlPlanlananMiktar { get; set; }

    public string? UtlAciklama { get; set; }

    public int? UtlDepoNo { get; set; }

    public bool? UtlKapatFl { get; set; }

    public string? UtlProjekodu { get; set; }

    public string? UtlPartiKodu { get; set; }

    public int? UtlLotNo { get; set; }

    public Guid? UtlSipUid { get; set; }

    public string? UtlKapatmanedenkod { get; set; }
}
