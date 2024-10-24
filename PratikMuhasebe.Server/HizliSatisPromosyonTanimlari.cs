using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HizliSatisPromosyonTanimlari
{
    public Guid HsptGuid { get; set; }

    public short HsptDbcno { get; set; }

    public int? HsptSpecRecno { get; set; }

    public bool? HsptIptal { get; set; }

    public short? HsptFileid { get; set; }

    public bool? HsptHidden { get; set; }

    public bool? HsptKilitli { get; set; }

    public bool? HsptDegisti { get; set; }

    public int? HsptChecksum { get; set; }

    public short? HsptCreateUser { get; set; }

    public DateTime HsptCreateDate { get; set; }

    public short? HsptLastupUser { get; set; }

    public DateTime? HsptLastupDate { get; set; }

    public string? HsptSpecial1 { get; set; }

    public string? HsptSpecial2 { get; set; }

    public string? HsptSpecial3 { get; set; }

    public string HsptKodu { get; set; } = null!;

    public string HsptAdi { get; set; } = null!;

    public int HsptMaxKullanimSayisi { get; set; }

    public double HsptAlisVerisLimiti { get; set; }

    public byte HsptPromosyonTipi { get; set; }

    public byte HsptAltPromosyonTipi { get; set; }

    public byte HsptIndirimTipi { get; set; }

    public double HsptDegeri { get; set; }

    public string HsptAciklama { get; set; } = null!;

    public double HsptKriterUrunMinimumAlimAdedi { get; set; }

    public double HsptUygulanacakUrunAdedi { get; set; }

    public byte HsptCariSiralamaSekli { get; set; }

    public string HsptCariTaramaIlkKod { get; set; } = null!;

    public string HsptCariTaramaSonKod { get; set; } = null!;

    public string HsptCariTaramaYapisi { get; set; } = null!;

    public byte HsptEsasUrunlerSiralamaSekli { get; set; }

    public string HsptEsasUrunlerTaramaIlkKod { get; set; } = null!;

    public string HsptEsasUrunlerTaramaSonKod { get; set; } = null!;

    public string HsptEsasUrunlerTaramaYapisi { get; set; } = null!;

    public byte HsptPromUrunlerSiralamaSekli { get; set; }

    public string HsptPromUrunlerTaramaIlkKod { get; set; } = null!;

    public string HsptPromUrunlerTaramaSonKod { get; set; } = null!;

    public string HsptPromUrunlerTaramaYapisi { get; set; } = null!;

    public int HsptOncelikNo { get; set; }

    public byte HsptPromGecerlilikKontrolu { get; set; }

    public bool HsptPasifFl { get; set; }

    public string HsptBirimAd { get; set; } = null!;

    public bool HsptOdemeTipiNakit { get; set; }

    public bool HsptOdemeTipiKrediKarti { get; set; }

    public bool HsptOdemeTipiYemekFisi { get; set; }

    public bool HsptOdemeTipiAcikHesap { get; set; }

    public bool HsptPromosyonBirlestirilsinFl { get; set; }

    public string HsptPromosyonGrupKodu { get; set; } = null!;
}
