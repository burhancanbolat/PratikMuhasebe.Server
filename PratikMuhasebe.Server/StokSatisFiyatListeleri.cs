using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokSatisFiyatListeleri
{
    public Guid SfiyatGuid { get; set; }

    public short SfiyatDbcno { get; set; }

    public int? SfiyatSpecRecno { get; set; }

    public bool? SfiyatIptal { get; set; }

    public short? SfiyatFileid { get; set; }

    public bool? SfiyatHidden { get; set; }

    public bool? SfiyatKilitli { get; set; }

    public bool? SfiyatDegisti { get; set; }

    public int? SfiyatChecksum { get; set; }

    public short? SfiyatCreateUser { get; set; }

    public DateTime SfiyatCreateDate { get; set; }

    public short? SfiyatLastupUser { get; set; }

    public DateTime? SfiyatLastupDate { get; set; }

    public string? SfiyatSpecial1 { get; set; }

    public string? SfiyatSpecial2 { get; set; }

    public string? SfiyatSpecial3 { get; set; }

    public string? SfiyatStokkod { get; set; }

    public int? SfiyatListesirano { get; set; }

    public int? SfiyatDeposirano { get; set; }

    public int? SfiyatOdemeplan { get; set; }

    public byte? SfiyatBirimPntr { get; set; }

    public double? SfiyatFiyati { get; set; }

    public byte? SfiyatDoviz { get; set; }

    public string? SfiyatIskontokod { get; set; }

    public byte? SfiyatDegNedeni { get; set; }

    public double? SfiyatPrimyuzdesi { get; set; }

    public string? SfiyatKampanyakod { get; set; }

    public double? SfiyatDovizKuru { get; set; }
}
