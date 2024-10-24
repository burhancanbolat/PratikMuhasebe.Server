using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokCariIskontoTanimlari
{
    public Guid IskGuid { get; set; }

    public short IskDbcno { get; set; }

    public int? IskSpecRecno { get; set; }

    public bool? IskIptal { get; set; }

    public short? IskFileid { get; set; }

    public bool? IskHidden { get; set; }

    public bool? IskKilitli { get; set; }

    public bool? IskDegisti { get; set; }

    public int? IskChecksum { get; set; }

    public short? IskCreateUser { get; set; }

    public DateTime IskCreateDate { get; set; }

    public short? IskLastupUser { get; set; }

    public DateTime? IskLastupDate { get; set; }

    public string? IskSpecial1 { get; set; }

    public string? IskSpecial2 { get; set; }

    public string? IskSpecial3 { get; set; }

    public string? IskStokKod { get; set; }

    public string? IskCariKod { get; set; }

    public string? IskIsim { get; set; }

    public int? IskUygulamaOdemePlani { get; set; }

    public double? IskBedelsizReferansMiktar { get; set; }

    public string? IskIsk1Aciklama { get; set; }

    public byte? IskIsk1Uygulama { get; set; }

    public double? IskIsk1Yuzde { get; set; }

    public string? IskIsk2Aciklama { get; set; }

    public byte? IskIsk2Uygulama { get; set; }

    public double? IskIsk2Yuzde { get; set; }

    public string? IskIsk3Aciklama { get; set; }

    public byte? IskIsk3Uygulama { get; set; }

    public double? IskIsk3Yuzde { get; set; }

    public string? IskIsk4Aciklama { get; set; }

    public byte? IskIsk4Uygulama { get; set; }

    public double? IskIsk4Yuzde { get; set; }

    public string? IskIsk5Aciklama { get; set; }

    public byte? IskIsk5Uygulama { get; set; }

    public double? IskIsk5Yuzde { get; set; }

    public string? IskIsk6Aciklama { get; set; }

    public byte? IskIsk6Uygulama { get; set; }

    public double? IskIsk6Yuzde { get; set; }

    public string? IskMas1Aciklama { get; set; }

    public byte? IskMas1Uygulama { get; set; }

    public double? IskMas1Yuzde { get; set; }

    public string? IskMas2Aciklama { get; set; }

    public byte? IskMas2Uygulama { get; set; }

    public double? IskMas2Yuzde { get; set; }

    public string? IskMas3Aciklama { get; set; }

    public byte? IskMas3Uygulama { get; set; }

    public double? IskMas3Yuzde { get; set; }

    public string? IskMas4Aciklama { get; set; }

    public byte? IskMas4Uygulama { get; set; }

    public double? IskMas4Yuzde { get; set; }
}
