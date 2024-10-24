using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ProformaSatinalmaSartlari
{
    public Guid ProsasGuid { get; set; }

    public short ProsasDbcno { get; set; }

    public int? ProsasSpecRecno { get; set; }

    public bool? ProsasIptal { get; set; }

    public short? ProsasFileid { get; set; }

    public bool? ProsasHidden { get; set; }

    public bool? ProsasKilitli { get; set; }

    public bool? ProsasDegisti { get; set; }

    public int? ProsasChecksum { get; set; }

    public short? ProsasCreateUser { get; set; }

    public DateTime ProsasCreateDate { get; set; }

    public short? ProsasLastupUser { get; set; }

    public DateTime? ProsasLastupDate { get; set; }

    public string? ProsasSpecial1 { get; set; }

    public string? ProsasSpecial2 { get; set; }

    public string? ProsasSpecial3 { get; set; }

    public string? ProsasStokKod { get; set; }

    public string? ProsasCariKod { get; set; }

    public string? ProsasEvrakNoSeri { get; set; }

    public int? ProsasEvrakNoSira { get; set; }

    public DateTime? ProsasEvrakTarih { get; set; }

    public int? ProsasSatirNo { get; set; }

    public string? ProsasBelgeNo { get; set; }

    public DateTime? ProsasBelgeTarih { get; set; }

    public double? ProsasAsgariMiktar { get; set; }

    public short? ProsasTeslimSure { get; set; }

    public DateTime? ProsasBaslaTarih { get; set; }

    public DateTime? ProsasBitisTarih { get; set; }

    public double? ProsasBrutFiyat { get; set; }

    public string? ProsasIskAcik1 { get; set; }

    public byte? ProsasIskUyg1 { get; set; }

    public byte? ProsasIskDurum1 { get; set; }

    public byte? ProsasIskVergi1 { get; set; }

    public double? ProsasIskKriter1 { get; set; }

    public double? ProsasIskYuzde1 { get; set; }

    public double? ProsasIskMiktar1 { get; set; }

    public string? ProsasIskAcik2 { get; set; }

    public byte? ProsasIskUyg2 { get; set; }

    public byte? ProsasIskDurum2 { get; set; }

    public byte? ProsasIskVergi2 { get; set; }

    public double? ProsasIskKriter2 { get; set; }

    public double? ProsasIskYuzde2 { get; set; }

    public double? ProsasIskMiktar2 { get; set; }

    public string? ProsasIskAcik3 { get; set; }

    public byte? ProsasIskUyg3 { get; set; }

    public byte? ProsasIskDurum3 { get; set; }

    public byte? ProsasIskVergi3 { get; set; }

    public double? ProsasIskKriter3 { get; set; }

    public double? ProsasIskYuzde3 { get; set; }

    public double? ProsasIskMiktar3 { get; set; }

    public string? ProsasIskAcik4 { get; set; }

    public byte? ProsasIskUyg4 { get; set; }

    public byte? ProsasIskDurum4 { get; set; }

    public byte? ProsasIskVergi4 { get; set; }

    public double? ProsasIskKriter4 { get; set; }

    public double? ProsasIskYuzde4 { get; set; }

    public double? ProsasIskMiktar4 { get; set; }

    public string? ProsasIskAcik5 { get; set; }

    public byte? ProsasIskUyg5 { get; set; }

    public byte? ProsasIskDurum5 { get; set; }

    public byte? ProsasIskVergi5 { get; set; }

    public double? ProsasIskKriter5 { get; set; }

    public double? ProsasIskYuzde5 { get; set; }

    public double? ProsasIskMiktar5 { get; set; }

    public string? ProsasIskAcik6 { get; set; }

    public byte? ProsasIskUyg6 { get; set; }

    public byte? ProsasIskDurum6 { get; set; }

    public byte? ProsasIskVergi6 { get; set; }

    public double? ProsasIskKriter6 { get; set; }

    public double? ProsasIskYuzde6 { get; set; }

    public double? ProsasIskMiktar6 { get; set; }

    public string? ProsasMasAcik1 { get; set; }

    public byte? ProsasMasUyg1 { get; set; }

    public byte? ProsasMasDurum1 { get; set; }

    public byte? ProsasMasVergi1 { get; set; }

    public double? ProsasMasKriter1 { get; set; }

    public double? ProsasMasYuzde1 { get; set; }

    public double? ProsasMasMiktar1 { get; set; }

    public string? ProsasMasAcik2 { get; set; }

    public byte? ProsasMasUyg2 { get; set; }

    public byte? ProsasMasDurum2 { get; set; }

    public byte? ProsasMasVergi2 { get; set; }

    public double? ProsasMasKriter2 { get; set; }

    public double? ProsasMasYuzde2 { get; set; }

    public double? ProsasMasMiktar2 { get; set; }

    public string? ProsasMasAcik3 { get; set; }

    public byte? ProsasMasUyg3 { get; set; }

    public byte? ProsasMasDurum3 { get; set; }

    public byte? ProsasMasVergi3 { get; set; }

    public double? ProsasMasKriter3 { get; set; }

    public double? ProsasMasYuzde3 { get; set; }

    public double? ProsasMasMiktar3 { get; set; }

    public string? ProsasMasAcik4 { get; set; }

    public byte? ProsasMasUyg4 { get; set; }

    public byte? ProsasMasDurum4 { get; set; }

    public byte? ProsasMasVergi4 { get; set; }

    public double? ProsasMasKriter4 { get; set; }

    public double? ProsasMasYuzde4 { get; set; }

    public double? ProsasMasMiktar4 { get; set; }

    public int? ProsasOdemePlan { get; set; }

    public double? ProsasNetAlisKdvli { get; set; }

    public double? ProsasKarOran { get; set; }

    public double? ProsasNetSatisKdvli { get; set; }

    public double? ProsasSatisFiyat { get; set; }

    public byte? ProsasDovizCinsi { get; set; }

    public byte? ProsasEvrtipi { get; set; }

    public string? ProsasAciklama { get; set; }

    public int? ProsasDepoNo { get; set; }

    public bool? ProsasMaliyetteKullanFl { get; set; }

    public double? ProsasIlaveMaliyetTutari { get; set; }

    public double? ProsasIlaveMaliyetYuzdesi { get; set; }

    public bool? ProsasKesinlestiFl { get; set; }

    public Guid? ProsasSasUid { get; set; }

    public byte? ProsasMiktarTip { get; set; }

    public double? ProsasMiktar { get; set; }

    public string? ProsasProjeKodu { get; set; }

    public string? ProsasSrmmrkKodu { get; set; }
}
