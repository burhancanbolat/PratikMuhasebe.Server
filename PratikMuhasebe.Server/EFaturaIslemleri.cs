using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EFaturaIslemleri
{
    public Guid EfiGuid { get; set; }

    public short EfiDbcno { get; set; }

    public int? EfiSpecRecno { get; set; }

    public bool? EfiIptal { get; set; }

    public short? EfiFileid { get; set; }

    public bool? EfiHidden { get; set; }

    public bool? EfiKilitli { get; set; }

    public bool? EfiDegisti { get; set; }

    public int? EfiChecksum { get; set; }

    public short? EfiCreateUser { get; set; }

    public DateTime EfiCreateDate { get; set; }

    public short? EfiLastupUser { get; set; }

    public DateTime? EfiLastupDate { get; set; }

    public string? EfiSpecial1 { get; set; }

    public string? EfiSpecial2 { get; set; }

    public string? EfiSpecial3 { get; set; }

    public byte? EfiTip { get; set; }

    public string? EfiEvraknoSeri { get; set; }

    public int? EfiEvraknoSira { get; set; }

    public byte? EfiEvrakTipi { get; set; }

    public string? EfiGibSeriSira { get; set; }

    public string? EfiUuid { get; set; }

    public bool? EfiOnaylandiFl { get; set; }

    public short? EfiOnaylayanKulNo { get; set; }

    public DateTime? EfiOnaylamaTarihi { get; set; }

    public byte? EfiIslemTipi { get; set; }

    public int? EfiYazdirmaSayisi { get; set; }

    public bool? EfiEfaturaolustuFl { get; set; }

    public short? EfiEfaturaolusturanKulNo { get; set; }

    public DateTime? EfiEfaturaolusturmatarihi { get; set; }

    public bool? EfiKabuledildiFl { get; set; }

    public short? EfiKabuledenKulNo { get; set; }

    public DateTime? EfiKabuletmeTarihi { get; set; }

    public bool? EfiRededildiFl { get; set; }

    public short? EfiRededenKulNo { get; set; }

    public DateTime? EfiRededilmeTarihi { get; set; }

    public bool? EfiGonderildiFl { get; set; }

    public short? EfiGonderenKulNo { get; set; }

    public DateTime? EfiGonderimTarihi { get; set; }

    public bool? EfiBaglamaFl { get; set; }

    public short? EfiBaglayanKulNo { get; set; }

    public DateTime? EfiBaglamaTarihi { get; set; }

    public bool? EfiBagsilFl { get; set; }

    public short? EfiBagsilenKulNo { get; set; }

    public DateTime? EfiBagisilTarihi { get; set; }

    public bool? EfiIcerikabulFl { get; set; }

    public short? EfiIcerikabuledenKulNo { get; set; }

    public DateTime? EfiIcerikabulTarihi { get; set; }

    public bool? EfiYazdirmaFl { get; set; }

    public short? EfiYazdiranKulNo { get; set; }

    public DateTime? EfiYazdirmaTarihi { get; set; }

    public byte? EfiEfaturaislemTipi { get; set; }

    public bool? EfiFpgonderildiFl { get; set; }

    public short? EfiFpgonderenKulNo { get; set; }

    public DateTime? EfiFpgonderimTarihi { get; set; }

    public bool? EfiIptalFl { get; set; }

    public short? EfiIptaledenKulNo { get; set; }

    public DateTime? EfiIptalTarihi { get; set; }

    public string? EfiEarsivIptalNedeni { get; set; }

    public DateTime? EfiEarsivIptalTarihi { get; set; }

    public string? EfiEfaturaaQueueuuid { get; set; }

    public Guid? EfiTeslimedenUid { get; set; }

    public string? EfiTeslimedenAdi { get; set; }

    public string? EfiTeslimedenSoyadi { get; set; }

    public Guid? EfiTeslimalanUid { get; set; }

    public string? EfiTeslimalanAdi { get; set; }

    public string? EfiTeslimalanSoyadi { get; set; }

    public string? EfiCarikod { get; set; }

    public bool? EfiShematronGecmediFl { get; set; }
}
