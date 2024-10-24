using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelIzinTalepleri
{
    public Guid PitGuid { get; set; }

    public short PitDbcno { get; set; }

    public int? PitSpecRecno { get; set; }

    public bool? PitIptal { get; set; }

    public short? PitFileid { get; set; }

    public bool? PitHidden { get; set; }

    public bool? PitKilitli { get; set; }

    public bool? PitDegisti { get; set; }

    public int? PitChecksum { get; set; }

    public short? PitCreateUser { get; set; }

    public DateTime PitCreateDate { get; set; }

    public short? PitLastupUser { get; set; }

    public DateTime? PitLastupDate { get; set; }

    public string? PitSpecial1 { get; set; }

    public string? PitSpecial2 { get; set; }

    public string? PitSpecial3 { get; set; }

    public string? PitPersKod { get; set; }

    public int? PitMaliYil { get; set; }

    public int? PitSatirNo { get; set; }

    public DateTime? PitTalepTarihi { get; set; }

    public byte? PitIzinTipi { get; set; }

    public byte? PitGunSayisi { get; set; }

    public byte? PitYolIzni { get; set; }

    public DateTime? PitBaslangictarih { get; set; }

    public byte? PitIzinDurum { get; set; }

    public int? PitOnaylayanKullanici { get; set; }

    public string? PitCadde { get; set; }

    public string? PitMahalle { get; set; }

    public string? PitSokak { get; set; }

    public string? PitSemt { get; set; }

    public string? PitAptNo { get; set; }

    public string? PitDaireNo { get; set; }

    public string? PitPostaKodu { get; set; }

    public string? PitIlce { get; set; }

    public string? PitIl { get; set; }

    public string? PitUlke { get; set; }

    public string? PitAdresKodu { get; set; }

    public string? PitTel1 { get; set; }

    public string? PitTel2 { get; set; }

    public string? PitEmail { get; set; }

    public string? PitAmac { get; set; }

    public string? PitAciklama1 { get; set; }

    public string? PitAciklama2 { get; set; }

    public double? PitSaat { get; set; }

    public DateTime? PitBaslamaSaati { get; set; }

    public byte? PitEksikcalismanedeni { get; set; }
}
