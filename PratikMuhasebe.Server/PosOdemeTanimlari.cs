using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PosOdemeTanimlari
{
    public Guid PotGuid { get; set; }

    public short PotDbcno { get; set; }

    public int? PotSpecRecNo { get; set; }

    public bool? PotIptal { get; set; }

    public short? PotFileid { get; set; }

    public bool? PotHidden { get; set; }

    public bool? PotKilitli { get; set; }

    public bool? PotDegisti { get; set; }

    public int? PotChecksum { get; set; }

    public short? PotCreateUser { get; set; }

    public DateTime PotCreateDate { get; set; }

    public short? PotLastupUser { get; set; }

    public DateTime? PotLastupDate { get; set; }

    public string? PotSpecial1 { get; set; }

    public string? PotSpecial2 { get; set; }

    public string? PotSpecial3 { get; set; }

    public byte? PotNo { get; set; }

    public string? PotAdi { get; set; }

    public byte? PotCariCinsi { get; set; }

    public string? PotCariKodu { get; set; }

    public byte? PotDovizCinsi { get; set; }

    public byte? PotTipi { get; set; }

    public byte? PotKrediKartVadesi { get; set; }

    public byte? PotTaksitSayisi { get; set; }

    public string? PotNixdorfDvz { get; set; }

    public int? PotFiyatKodu { get; set; }

    public string? PotCariGrupKodu { get; set; }

    public string? PotTcmbKodu { get; set; }

    public bool? PotTcmbPuan { get; set; }

    public byte? PotGuvenlikKontrolu { get; set; }

    public byte? PotShop9000OdemeTipi { get; set; }

    public byte? PotGenius220OdemeTipi { get; set; }

    public byte? PotGeniusIiiOdemeTipi { get; set; }

    public byte? PotWincor143OdemeTipi { get; set; }

    public byte? PotWincor148OdemeTipi { get; set; }

    public byte? PotWincor150OdemeTipi { get; set; }

    public byte? PotIntPosOdemeTipi { get; set; }

    public byte? PotIntMpos2001OdemeTipi { get; set; }

    public byte? PotEsPosOdemeTipi { get; set; }

    public byte? PotEsPos4000OdemeTipi { get; set; }

    public byte? PotTeraOdemeTipi { get; set; }

    public byte? PotOle5700OdemeTipi { get; set; }

    public byte? PotEsPos5000OdemeTipi { get; set; }

    public byte? PotGenius2SqlOdemeTipi { get; set; }

    public byte? PotHuginPosOdemeTipi { get; set; }

    public byte? PotBeko500OdemeTipi { get; set; }

    public byte? PotEnPosYnokcOdemeTipi { get; set; }

    public byte? PotOlivettiPbtOdemeTipi { get; set; }

    public byte? PotNcrOdemeTipi { get; set; }

    public byte? PotNcrAsrOdemeTipi { get; set; }

    public string? PtTaksitTanim1Adi { get; set; }

    public int? PtTaksitTanim1Odeme { get; set; }

    public int? PtTaksitTanim1FiyatKodu { get; set; }

    public byte? PtTaksitTanim1GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim1KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim2Adi { get; set; }

    public int? PtTaksitTanim2Odeme { get; set; }

    public int? PtTaksitTanim2FiyatKodu { get; set; }

    public byte? PtTaksitTanim2GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim2KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim3Adi { get; set; }

    public int? PtTaksitTanim3Odeme { get; set; }

    public int? PtTaksitTanim3FiyatKodu { get; set; }

    public byte? PtTaksitTanim3GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim3KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim4Adi { get; set; }

    public int? PtTaksitTanim4Odeme { get; set; }

    public int? PtTaksitTanim4FiyatKodu { get; set; }

    public byte? PtTaksitTanim4GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim4KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim5Adi { get; set; }

    public int? PtTaksitTanim5Odeme { get; set; }

    public int? PtTaksitTanim5FiyatKodu { get; set; }

    public byte? PtTaksitTanim5GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim5KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim6Adi { get; set; }

    public int? PtTaksitTanim6Odeme { get; set; }

    public int? PtTaksitTanim6FiyatKodu { get; set; }

    public byte? PtTaksitTanim6GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim6KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim7Adi { get; set; }

    public int? PtTaksitTanim7Odeme { get; set; }

    public int? PtTaksitTanim7FiyatKodu { get; set; }

    public byte? PtTaksitTanim7GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim7KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim8Adi { get; set; }

    public int? PtTaksitTanim8Odeme { get; set; }

    public int? PtTaksitTanim8FiyatKodu { get; set; }

    public byte? PtTaksitTanim8GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim8KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim9Adi { get; set; }

    public int? PtTaksitTanim9Odeme { get; set; }

    public int? PtTaksitTanim9FiyatKodu { get; set; }

    public byte? PtTaksitTanim9GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim9KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim10Adi { get; set; }

    public int? PtTaksitTanim10Odeme { get; set; }

    public int? PtTaksitTanim10FiyatKodu { get; set; }

    public byte? PtTaksitTanim10GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim10KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim11Adi { get; set; }

    public int? PtTaksitTanim11Odeme { get; set; }

    public int? PtTaksitTanim11FiyatKodu { get; set; }

    public byte? PtTaksitTanim11GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim11KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim12Adi { get; set; }

    public int? PtTaksitTanim12Odeme { get; set; }

    public int? PtTaksitTanim12FiyatKodu { get; set; }

    public byte? PtTaksitTanim12GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim12KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim13Adi { get; set; }

    public int? PtTaksitTanim13Odeme { get; set; }

    public int? PtTaksitTanim13FiyatKodu { get; set; }

    public byte? PtTaksitTanim13GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim13KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim14Adi { get; set; }

    public int? PtTaksitTanim14Odeme { get; set; }

    public int? PtTaksitTanim14FiyatKodu { get; set; }

    public byte? PtTaksitTanim14GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim14KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim15Adi { get; set; }

    public int? PtTaksitTanim15Odeme { get; set; }

    public int? PtTaksitTanim15FiyatKodu { get; set; }

    public byte? PtTaksitTanim15GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim15KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim16Adi { get; set; }

    public int? PtTaksitTanim16Odeme { get; set; }

    public int? PtTaksitTanim16FiyatKodu { get; set; }

    public byte? PtTaksitTanim16GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim16KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim17Adi { get; set; }

    public int? PtTaksitTanim17Odeme { get; set; }

    public int? PtTaksitTanim17FiyatKodu { get; set; }

    public byte? PtTaksitTanim17GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim17KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim18Adi { get; set; }

    public int? PtTaksitTanim18Odeme { get; set; }

    public int? PtTaksitTanim18FiyatKodu { get; set; }

    public byte? PtTaksitTanim18GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim18KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim19Adi { get; set; }

    public int? PtTaksitTanim19Odeme { get; set; }

    public int? PtTaksitTanim19FiyatKodu { get; set; }

    public byte? PtTaksitTanim19GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim19KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim20Adi { get; set; }

    public int? PtTaksitTanim20Odeme { get; set; }

    public int? PtTaksitTanim20FiyatKodu { get; set; }

    public byte? PtTaksitTanim20GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim20KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim21Adi { get; set; }

    public int? PtTaksitTanim21Odeme { get; set; }

    public int? PtTaksitTanim21FiyatKodu { get; set; }

    public byte? PtTaksitTanim21GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim21KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim22Adi { get; set; }

    public int? PtTaksitTanim22Odeme { get; set; }

    public int? PtTaksitTanim22FiyatKodu { get; set; }

    public byte? PtTaksitTanim22GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim22KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim23Adi { get; set; }

    public int? PtTaksitTanim23Odeme { get; set; }

    public int? PtTaksitTanim23FiyatKodu { get; set; }

    public byte? PtTaksitTanim23GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim23KkartTaksitSayisi { get; set; }

    public string? PtTaksitTanim24Adi { get; set; }

    public int? PtTaksitTanim24Odeme { get; set; }

    public int? PtTaksitTanim24FiyatKodu { get; set; }

    public byte? PtTaksitTanim24GuvenlikKontrolu { get; set; }

    public byte? PtTaksitTanim24KkartTaksitSayisi { get; set; }
}
