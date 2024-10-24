using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CihazHareketleri
{
    public Guid ChHarGuid { get; set; }

    public short ChHarDbcno { get; set; }

    public int? ChHarSpecRecNo { get; set; }

    public bool? ChHarIptal { get; set; }

    public short? ChHarFileid { get; set; }

    public bool? ChHarHidden { get; set; }

    public bool? ChHarKilitli { get; set; }

    public bool? ChHarDegisti { get; set; }

    public int? ChHarChecksum { get; set; }

    public short? ChHarCreateUser { get; set; }

    public DateTime ChHarCreateDate { get; set; }

    public short? ChHarLastupUser { get; set; }

    public DateTime? ChHarLastupDate { get; set; }

    public string? ChHarSpecial1 { get; set; }

    public string? ChHarSpecial2 { get; set; }

    public string? ChHarSpecial3 { get; set; }

    public string? ChHarSeriNo { get; set; }

    public string? ChHarStokKodu { get; set; }

    public byte? ChHarMasterTablo { get; set; }

    public Guid? ChHarMasterUid { get; set; }

    public bool? ChHarRezerveFl { get; set; }
}
