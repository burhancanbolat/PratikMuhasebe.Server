using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimMalzemePlanlama
{
    public Guid UplGuid { get; set; }

    public short UplDbcno { get; set; }

    public int? UplSpecRecno { get; set; }

    public bool? UplIptal { get; set; }

    public short? UplFileid { get; set; }

    public bool? UplHidden { get; set; }

    public bool? UplKilitli { get; set; }

    public bool? UplDegisti { get; set; }

    public int? UplChecksum { get; set; }

    public short? UplCreateUser { get; set; }

    public DateTime UplCreateDate { get; set; }

    public short? UplLastupUser { get; set; }

    public DateTime? UplLastupDate { get; set; }

    public string? UplSpecial1 { get; set; }

    public string? UplSpecial2 { get; set; }

    public string? UplSpecial3 { get; set; }

    public string? UplIsemri { get; set; }

    public int? UplSatirno { get; set; }

    public byte? UplUretimTuket { get; set; }

    public string? UplKodu { get; set; }

    public string? UplFasoncukod { get; set; }

    public DateTime? UplHarTarih { get; set; }

    public double? UplMiktar { get; set; }

    public string? UplAciklama { get; set; }

    public int? UplDepno { get; set; }

    public string? UplUrstokkod { get; set; }

    public double? UplUretMiktar { get; set; }

    public string? UplPartiKod { get; set; }

    public int? UplLotno { get; set; }

    public byte? UplSarfturu { get; set; }

    public double? UplSarfmiktari { get; set; }

    public short? UplSafhano { get; set; }

    public byte? UplPlanlamaTipi { get; set; }

    public byte? UplNereden { get; set; }

    public byte? UplHesapTipi { get; set; }

    public DateTime? UplGecerlilikTarihi { get; set; }

    public double? UplRezervasyonMiktari { get; set; }

    public double? UplRezervedenTeslimEdilen { get; set; }

    public string? UplReceteTanimKodu { get; set; }

    public byte? UplReceteCinsi { get; set; }
}
