using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class SatinalmaTalepleri
{
    public Guid StlGuid { get; set; }

    public short StlDbcno { get; set; }

    public int? StlSpecRecno { get; set; }

    public bool? StlIptal { get; set; }

    public short? StlFileid { get; set; }

    public bool? StlHidden { get; set; }

    public bool? StlKilitli { get; set; }

    public bool? StlDegisti { get; set; }

    public int? StlChecksum { get; set; }

    public short? StlCreateUser { get; set; }

    public DateTime StlCreateDate { get; set; }

    public short? StlLastupUser { get; set; }

    public DateTime? StlLastupDate { get; set; }

    public string? StlSpecial1 { get; set; }

    public string? StlSpecial2 { get; set; }

    public string? StlSpecial3 { get; set; }

    public int? StlFirmano { get; set; }

    public int? StlSubeno { get; set; }

    public DateTime? StlTarihi { get; set; }

    public DateTime? StlTeslimTarihi { get; set; }

    public string? StlEvrakSeri { get; set; }

    public int? StlEvrakSira { get; set; }

    public int? StlSatirNo { get; set; }

    public string? StlBelgeNo { get; set; }

    public DateTime? StlBelgeTarihi { get; set; }

    public string? StlSorMerk { get; set; }

    public string? StlStokKodu { get; set; }

    public string? StlSaticiKodu { get; set; }

    public double? StlMiktari { get; set; }

    public double? StlTeslimMiktari { get; set; }

    public string? StlAciklama { get; set; }

    public string? StlAciklama2 { get; set; }

    public int? StlDepoNo { get; set; }

    public bool? StlKapatFl { get; set; }

    public string? StlProjekodu { get; set; }

    public string? StlPartiKodu { get; set; }

    public int? StlLotNo { get; set; }

    public short? StlOnaylayanKulNo { get; set; }

    public bool? StlCagrilabilirFl { get; set; }

    public byte? StlHarekettipi { get; set; }

    public string? StlTalepEden { get; set; }

    public string? StlKapatmanedenkod { get; set; }

    public Guid? StlKaynakSipUid { get; set; }

    public string? StlHareketGrupKodu1 { get; set; }

    public string? StlHareketGrupKodu2 { get; set; }

    public string? StlHareketGrupKodu3 { get; set; }

    public byte? StlBirimPntr { get; set; }

    public double? StlFranchiseFiyati { get; set; }
}
