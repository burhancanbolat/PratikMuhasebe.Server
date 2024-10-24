using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class KullaniciOnayTanimlari
{
    public Guid KoGuid { get; set; }

    public short KoDbcno { get; set; }

    public int? KoSpecRecno { get; set; }

    public bool? KoIptal { get; set; }

    public short? KoFileid { get; set; }

    public bool? KoHidden { get; set; }

    public bool? KoKilitli { get; set; }

    public bool? KoDegisti { get; set; }

    public int? KoChecksum { get; set; }

    public short? KoCreateUser { get; set; }

    public DateTime KoCreateDate { get; set; }

    public short? KoLastupUser { get; set; }

    public DateTime? KoLastupDate { get; set; }

    public string? KoSpecial1 { get; set; }

    public string? KoSpecial2 { get; set; }

    public string? KoSpecial3 { get; set; }

    public int? KoKullaniciNo { get; set; }

    public int? KoFirmaNo { get; set; }

    public byte? KoEvrakTip { get; set; }

    public bool? KoEvrakOnaylayabilir { get; set; }

    public double? KoEvrakLimiti { get; set; }

    public byte? KoEvrakYetkiTipi { get; set; }

    public byte? KoEvrakMinOnaySayisi { get; set; }
}
