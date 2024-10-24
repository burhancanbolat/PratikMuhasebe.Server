using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EbelgeEvrakHareketleri
{
    public Guid EbhGuid { get; set; }

    public short EbhDbcno { get; set; }

    public int? EbhSpecRecNo { get; set; }

    public bool? EbhIptal { get; set; }

    public short? EbhFileid { get; set; }

    public bool? EbhHidden { get; set; }

    public bool? EbhKilitli { get; set; }

    public bool? EbhDegisti { get; set; }

    public int? EbhCheckSum { get; set; }

    public short? EbhCreateUser { get; set; }

    public DateTime EbhCreateDate { get; set; }

    public short? EbhLastupUser { get; set; }

    public DateTime? EbhLastupDate { get; set; }

    public string? EbhSpecial1 { get; set; }

    public string? EbhSpecial2 { get; set; }

    public string? EbhSpecial3 { get; set; }

    public byte? EbhHareketTipi { get; set; }

    public Guid? EbhRelatedUid { get; set; }

    public byte? EbhOdemeSekli { get; set; }

    public string? EbhOdemeAciklama { get; set; }

    public string? EbhOdemeAracisi { get; set; }

    public string? EbhSatisinWebadresi { get; set; }

    public DateTime? EbhGonderiTarihi { get; set; }

    public string? EbhGonderiTasiyan { get; set; }

    public string? EbhGonderiNo { get; set; }

    public string? EbhIadeFatNo1 { get; set; }

    public DateTime? EbhIadeFatTarihi1 { get; set; }

    public string? EbhEkliDosya { get; set; }

    public string? EbhMukellefiyetdosyano { get; set; }

    public DateTime? EbhMukellefiyetdonembasi { get; set; }

    public DateTime? EbhMukellefiyetdonemsonu { get; set; }
}
