using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class EFaturaConverterTanimlari
{
    public Guid CnvGuid { get; set; }

    public short CnvDbcno { get; set; }

    public int? CnvSpecRecno { get; set; }

    public bool? CnvIptal { get; set; }

    public short? CnvFileid { get; set; }

    public bool? CnvHidden { get; set; }

    public bool? CnvKilitli { get; set; }

    public bool? CnvDegisti { get; set; }

    public int? CnvChecksum { get; set; }

    public short? CnvCreateUser { get; set; }

    public DateTime CnvCreateDate { get; set; }

    public short? CnvLastupUser { get; set; }

    public DateTime? CnvLastupDate { get; set; }

    public string? CnvSpecial1 { get; set; }

    public string? CnvSpecial2 { get; set; }

    public string? CnvSpecial3 { get; set; }

    public string? CnvKodu { get; set; }

    public string? CnvCariVergiNo { get; set; }

    public string? CnvAciklama { get; set; }

    public short? CnvOncelikSiraNo { get; set; }

    public byte? CnvKuralTipi { get; set; }
}
