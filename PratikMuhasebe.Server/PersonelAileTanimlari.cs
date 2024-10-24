using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelAileTanimlari
{
    public Guid PaGuid { get; set; }

    public short PaDbcno { get; set; }

    public int? PaSpecRecno { get; set; }

    public bool? PaIptal { get; set; }

    public short? PaFileid { get; set; }

    public bool? PaHidden { get; set; }

    public bool? PaKilitli { get; set; }

    public bool? PaDegisti { get; set; }

    public int? PaChecksum { get; set; }

    public short? PaCreateUser { get; set; }

    public DateTime PaCreateDate { get; set; }

    public short? PaLastupUser { get; set; }

    public DateTime? PaLastupDate { get; set; }

    public string? PaSpecial1 { get; set; }

    public string? PaSpecial2 { get; set; }

    public string? PaSpecial3 { get; set; }

    public string? PaPerKodu { get; set; }

    public byte? PaYakinlik { get; set; }

    public short? PaCocukSiraNo { get; set; }

    public string? PaAd { get; set; }

    public string? PaSoyad { get; set; }

    public string? PaIlkSoyad { get; set; }

    public string? PaTcKimlik { get; set; }

    public byte? PaCinsiyet { get; set; }

    public DateTime? PaDogumTar { get; set; }

    public string? PaDogumYer { get; set; }

    public byte? PaUcretli { get; set; }

    public byte? PaTahsili { get; set; }

    public byte? PaSakatlik { get; set; }

    public string? PaCadde { get; set; }

    public string? PaMahalle { get; set; }

    public string? PaSokak { get; set; }

    public string? PaSemt { get; set; }

    public string? PaAptNo { get; set; }

    public string? PaDaireNo { get; set; }

    public string? PaPostaKodu { get; set; }

    public string? PaIlce { get; set; }

    public string? PaIl { get; set; }

    public string? PaUlke { get; set; }

    public string? PaAdresKodu { get; set; }

    public string? PaTelUlkeKodu { get; set; }

    public string? PaTelBolgekodu { get; set; }

    public string? PaTelNo1 { get; set; }

    public DateTime? PaEvlilikTarihi { get; set; }

    public byte? PaAgineTabii { get; set; }

    public bool? PaOgrenimeDevamEdiyor { get; set; }

    public byte? PaMaasBanka { get; set; }

    public string? PaBankaHesapno { get; set; }
}
