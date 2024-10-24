using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelEgitimTalepleri
{
    public Guid PetGuid { get; set; }

    public short PetDbcno { get; set; }

    public int? PetSpecRecno { get; set; }

    public bool? PetIptal { get; set; }

    public short? PetFileid { get; set; }

    public bool? PetHidden { get; set; }

    public bool? PetKilitli { get; set; }

    public bool? PetDegisti { get; set; }

    public int? PetChecksum { get; set; }

    public short? PetCreateUser { get; set; }

    public DateTime PetCreateDate { get; set; }

    public short? PetLastupUser { get; set; }

    public DateTime? PetLastupDate { get; set; }

    public string? PetSpecial1 { get; set; }

    public string? PetSpecial2 { get; set; }

    public string? PetSpecial3 { get; set; }

    public string? PetPerskodu { get; set; }

    public DateTime? PetTaleptarihi { get; set; }

    public string? PetEgitimkodu { get; set; }

    public byte? PetTalepdurumu { get; set; }

    public int? PetOnaylayanKullanici { get; set; }
}
