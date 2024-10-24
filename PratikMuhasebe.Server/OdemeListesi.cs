using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class OdemeListesi
{
    public Guid OlGuid { get; set; }

    public short OlDbcno { get; set; }

    public int? OlSpecRecno { get; set; }

    public bool? OlIptal { get; set; }

    public short? OlFileid { get; set; }

    public bool? OlHidden { get; set; }

    public bool? OlKilitli { get; set; }

    public bool? OlDegisti { get; set; }

    public int? OlChecksum { get; set; }

    public short? OlCreateUser { get; set; }

    public DateTime OlCreateDate { get; set; }

    public short? OlLastupUser { get; set; }

    public DateTime? OlLastupDate { get; set; }

    public string? OlSpecial1 { get; set; }

    public string? OlSpecial2 { get; set; }

    public string? OlSpecial3 { get; set; }

    public string? OlCarikodu { get; set; }

    public double? OlTutari { get; set; }

    public DateTime? OlOrtVadeTarih { get; set; }

    public string? OlCekList1 { get; set; }

    public string? OlCekList2 { get; set; }

    public string? OlCekList3 { get; set; }

    public string? OlCekList4 { get; set; }

    public string? OlCekList5 { get; set; }

    public string? OlCekList6 { get; set; }

    public string? OlCekList7 { get; set; }

    public string? OlCekList8 { get; set; }

    public string? OlCekList9 { get; set; }

    public string? OlCekList10 { get; set; }

    public double? OlOdenenTutar { get; set; }

    public DateTime? OlOdenenVade { get; set; }

    public byte? OlOdemeCinsi { get; set; }

    public string? OlKasBankKd1 { get; set; }

    public string? OlKasBankKd2 { get; set; }

    public string? OlKasBankKd3 { get; set; }

    public string? OlKasBankKd4 { get; set; }

    public string? OlKasBankKd5 { get; set; }

    public string? OlKasBankKd6 { get; set; }

    public string? OlKasBankKd7 { get; set; }

    public string? OlKasBankKd8 { get; set; }

    public string? OlKasBankKd9 { get; set; }

    public string? OlKasBankKd10 { get; set; }

    public string? OlKesideYeri { get; set; }

    public int? OlOpsiyongun { get; set; }

    public byte? OlCarigrup { get; set; }

    public byte? OlCaridovizcins { get; set; }

    public string? OlSrmmrkkodu { get; set; }

    public string? OlKarsisrmmrkkodu { get; set; }

    public string? OlAciklama { get; set; }

    public short? OlOnaylayankulno { get; set; }

    public bool? OlOnayliFl { get; set; }

    public byte? OlBakiyeSekli { get; set; }

    public byte? OlOdemeSekli { get; set; }

    public byte? OlAlacakfatevrtip { get; set; }

    public string? OlAlacakfatevrnoSeri { get; set; }

    public int? OlAlacakfatevrnoSira { get; set; }

    public Guid? OlAlacakfatUid { get; set; }

    public DateTime? OlAlacakfatvadetarihi { get; set; }

    public Guid? OlOdemeevragiUid { get; set; }
}
