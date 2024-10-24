using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelIzinleri
{
    public Guid PzGuid { get; set; }

    public short PzDbcno { get; set; }

    public int? PzSpecRecno { get; set; }

    public bool? PzIptal { get; set; }

    public short? PzFileid { get; set; }

    public bool? PzHidden { get; set; }

    public bool? PzKilitli { get; set; }

    public bool? PzDegisti { get; set; }

    public int? PzChecksum { get; set; }

    public short? PzCreateUser { get; set; }

    public DateTime PzCreateDate { get; set; }

    public short? PzLastupUser { get; set; }

    public DateTime? PzLastupDate { get; set; }

    public string? PzSpecial1 { get; set; }

    public string? PzSpecial2 { get; set; }

    public string? PzSpecial3 { get; set; }

    public short? PzIzinYil { get; set; }

    public string? PzPersKod { get; set; }

    public int? PzIzinNo { get; set; }

    public byte? PzIzinTipi { get; set; }

    public byte? PzGunSayisi { get; set; }

    public byte? PzYolIzni { get; set; }

    public DateTime? PzBaslangictarih { get; set; }

    public Guid? PzBagliTalepUid { get; set; }

    public string? PzIzinAciklama { get; set; }

    public DateTime? PzGerceklesenDonusTarihi { get; set; }

    public byte? PzIzinDetayTipi { get; set; }

    public DateTime? PzBitistarihi { get; set; }

    public DateTime? PzIsbasitarihi { get; set; }

    public double? PzSaat { get; set; }

    public DateTime? PzBaslamaSaati { get; set; }

    public byte? PzEksikcalismanedeni { get; set; }
}
