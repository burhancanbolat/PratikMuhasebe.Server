using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class CekiListesi
{
    public Guid CklGuid { get; set; }

    public short CklDbcno { get; set; }

    public int? CklSpecRecno { get; set; }

    public bool? CklIptal { get; set; }

    public short? CklFileid { get; set; }

    public bool? CklHidden { get; set; }

    public bool? CklKilitli { get; set; }

    public bool? CklDegisti { get; set; }

    public int? CklCheckSum { get; set; }

    public short? CklCreateUser { get; set; }

    public DateTime CklCreateDate { get; set; }

    public short? CklLastupUser { get; set; }

    public DateTime? CklLastupDate { get; set; }

    public string? CklSpecial1 { get; set; }

    public string? CklSpecial2 { get; set; }

    public string? CklSpecial3 { get; set; }

    public byte? CklEvrakTip { get; set; }

    public string? CklEvrakSeri { get; set; }

    public int? CklEvrakSira { get; set; }

    public string? CklStokKodu { get; set; }

    public byte? CklBedenPntr { get; set; }

    public double? CklMiktari { get; set; }

    public short? CklAnaAmbalajNo { get; set; }

    public short? CklAltAmbalajNo { get; set; }
}
