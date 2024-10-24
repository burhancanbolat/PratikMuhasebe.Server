using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokBagTanimlari
{
    public Guid BagGuid { get; set; }

    public short BagDbcno { get; set; }

    public int? BagSpecRecNo { get; set; }

    public bool? BagIptal { get; set; }

    public short? BagFileid { get; set; }

    public bool? BagHidden { get; set; }

    public bool? BagKilitli { get; set; }

    public bool? BagDegisti { get; set; }

    public int? BagChecksum { get; set; }

    public short? BagCreateUser { get; set; }

    public DateTime BagCreateDate { get; set; }

    public short? BagLastupUser { get; set; }

    public DateTime? BagLastupDate { get; set; }

    public string? BagSpecial1 { get; set; }

    public string? BagSpecial2 { get; set; }

    public string? BagSpecial3 { get; set; }

    public string? BagKodu { get; set; }

    public string? BagStokkodu { get; set; }

    public string? BagPartikodu { get; set; }

    public int? BagLotno { get; set; }

    public string? BagAciklama1 { get; set; }

    public string? BagAciklama2 { get; set; }

    public double? BagMiktar { get; set; }

    public double? BagMiktar2 { get; set; }

    public Guid? BagHarUid { get; set; }
}
