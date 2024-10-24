using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PromopuanTanimlari
{
    public Guid PuanGuid { get; set; }

    public short PuanDbcno { get; set; }

    public int? PuanSpecRecno { get; set; }

    public bool? PuanIptal { get; set; }

    public short? PuanFileid { get; set; }

    public bool? PuanHidden { get; set; }

    public bool? PuanKilitli { get; set; }

    public bool? PuanDegisti { get; set; }

    public int? PuanCheckSum { get; set; }

    public short? PuanCreateUser { get; set; }

    public DateTime PuanCreateDate { get; set; }

    public short? PuanLastupUser { get; set; }

    public DateTime? PuanLastupDate { get; set; }

    public string? PuanSpecial1 { get; set; }

    public string? PuanSpecial2 { get; set; }

    public string? PuanSpecial3 { get; set; }

    public byte? PuanTipi { get; set; }

    public string? PuanKodu { get; set; }

    public string? PuanIsmi { get; set; }

    public byte? PuanBagliPosOdemeTipi { get; set; }

    public string? PuanBazpuanKodu { get; set; }

    public string? PuanKampanyaKodu { get; set; }

    public string? PuanSatisHizmetKodu { get; set; }

    public DateTime? PuanIlkKullanimTarihi { get; set; }

    public int? PuanKullanimBaslangici { get; set; }

    public DateTime? PuanSonKullanmaTarihi { get; set; }

    public int? PuanGecerlilikSuresi { get; set; }

    public string? PuanSeriNoYapisi { get; set; }

    public string? PuanHarcamaStokKodYapisi { get; set; }

    public string? PuanHarcamaStokSorguCumlesi { get; set; }

    public double? PuanDeger { get; set; }

    public double? PuanEvraktaMaxKullanim { get; set; }

    public double? PuanHarcamaMinEvrakTutari { get; set; }

    public byte? PuanYansitmaIskontoIndex { get; set; }

    public byte? PuanYetersizIadedeYapilacak { get; set; }

    public bool? PuanPromosyonlariDurdurur { get; set; }

    public byte? PuanGuvenlikKontrolu { get; set; }
}
