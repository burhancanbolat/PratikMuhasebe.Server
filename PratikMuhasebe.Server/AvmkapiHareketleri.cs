using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmkapiHareketleri
{
    public Guid KapihGuid { get; set; }

    public short KapihDbcno { get; set; }

    public int? KapihSpecRecNo { get; set; }

    public bool? KapihIptal { get; set; }

    public short? KapihFileid { get; set; }

    public bool? KapihHidden { get; set; }

    public bool? KapihKilitli { get; set; }

    public bool? KapihDegisti { get; set; }

    public int? KapihChecksum { get; set; }

    public short? KapihCreateUser { get; set; }

    public DateTime KapihCreateDate { get; set; }

    public short? KapihLastupUser { get; set; }

    public DateTime? KapihLastupDate { get; set; }

    public string? KapihSpecial1 { get; set; }

    public string? KapihSpecial2 { get; set; }

    public string? KapihSpecial3 { get; set; }

    public int? KapihFirmano { get; set; }

    public int? KapihSubeno { get; set; }

    public string? KapihKapikodu { get; set; }

    public DateTime? KapihTarih { get; set; }

    public int? KapihZiyaretciSayisi { get; set; }
}
