using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class GiderKatilimSozlesmeleri
{
    public Guid GksGuid { get; set; }

    public short GksDbcno { get; set; }

    public int? GksSpecRecNo { get; set; }

    public bool? GksIptal { get; set; }

    public short? GksFileid { get; set; }

    public bool? GksHidden { get; set; }

    public bool? GksKilitli { get; set; }

    public bool? GksDegisti { get; set; }

    public int? GksChecksum { get; set; }

    public short? GksCreateUser { get; set; }

    public DateTime GksCreateDate { get; set; }

    public short? GksLastupUser { get; set; }

    public DateTime? GksLastupDate { get; set; }

    public string? GksSpecial1 { get; set; }

    public string? GksSpecial2 { get; set; }

    public string? GksSpecial3 { get; set; }

    public int? GksFirmano { get; set; }

    public int? GksSubeno { get; set; }

    public DateTime? GksEvraktarihi { get; set; }

    public string? GksEvrakseri { get; set; }

    public int? GksEvraksira { get; set; }

    public int? GksEvraksatir { get; set; }

    public string? GksCarikodu { get; set; }

    public byte? GksGrupno { get; set; }

    public string? GksCarisrmmrk { get; set; }

    public string? GksProje { get; set; }

    public string? GksHizmetkodu { get; set; }

    public string? GksSrmmrkkodu { get; set; }

    public DateTime? GksGecerliliktarihi { get; set; }

    public string? GksAciklama { get; set; }

    public byte? GksTipi { get; set; }

    public double? GksMiktar { get; set; }

    public double? GksKarorani { get; set; }

    public double? GksSabittutar { get; set; }

    public string? GksDagitimanahtari { get; set; }

    public double? GksMintutar { get; set; }

    public double? GksMaxtutar { get; set; }

    public int? GksOpno { get; set; }

    public string? GksKesfatseri { get; set; }

    public int? GksKesfatsira { get; set; }
}
