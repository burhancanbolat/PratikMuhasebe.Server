using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EvrakGenelParametreleri
{
    public Guid EgpGuid { get; set; }

    public short EgpDbcno { get; set; }

    public int? EgpSpecRecno { get; set; }

    public bool? EgpIptal { get; set; }

    public short? EgpFileid { get; set; }

    public bool? EgpHidden { get; set; }

    public bool? EgpKilitli { get; set; }

    public bool? EgpDegisti { get; set; }

    public int? EgpChecksum { get; set; }

    public short? EgpCreateUser { get; set; }

    public DateTime EgpCreateDate { get; set; }

    public short? EgpLastupUser { get; set; }

    public DateTime? EgpLastupDate { get; set; }

    public string? EgpSpecial1 { get; set; }

    public string? EgpSpecial2 { get; set; }

    public string? EgpSpecial3 { get; set; }

    public int? EgpProgramNo { get; set; }

    public string? EgpAciklamaBaslik1 { get; set; }

    public string? EgpAciklamaBaslik2 { get; set; }

    public string? EgpAciklamaBaslik3 { get; set; }

    public string? EgpAciklamaBaslik4 { get; set; }

    public string? EgpAciklamaBaslik5 { get; set; }

    public string? EgpAciklamaBaslik6 { get; set; }

    public string? EgpAciklamaBaslik7 { get; set; }

    public string? EgpAciklamaBaslik8 { get; set; }

    public string? EgpAciklamaBaslik9 { get; set; }

    public string? EgpAciklamaBaslik10 { get; set; }

    public string? EgpFormAdi { get; set; }

    public bool? EgpTarihKontroluPasifFl { get; set; }

    public bool? EgpKilitKaydedinceFl { get; set; }

    public bool? EgpKilitDokunceFl { get; set; }

    public bool? EgpKilitMailFl { get; set; }

    public bool? EgpKilitOnzilemeFl { get; set; }

    public bool? EgpKilitliDokFl { get; set; }

    public bool? EgpKilitliMailFl { get; set; }

    public bool? EgpKilitliOzizleFl { get; set; }
}
