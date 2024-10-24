using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PeriyodikEvraklar
{
    public Guid PeGuid { get; set; }

    public short PeDbcno { get; set; }

    public int? PeSpecRecNo { get; set; }

    public bool? PeIptal { get; set; }

    public short? PeFileid { get; set; }

    public bool? PeHidden { get; set; }

    public bool? PeKilitli { get; set; }

    public bool? PeDegisti { get; set; }

    public int? PeChecksum { get; set; }

    public short? PeCreateUser { get; set; }

    public DateTime PeCreateDate { get; set; }

    public short? PeLastupUser { get; set; }

    public DateTime? PeLastupDate { get; set; }

    public string? PeSpecial1 { get; set; }

    public string? PeSpecial2 { get; set; }

    public string? PeSpecial3 { get; set; }

    public int? PeFirmano { get; set; }

    public int? PeSubeno { get; set; }

    public byte? PeTip { get; set; }

    public DateTime? PeEvraktarihi { get; set; }

    public string? PeEvrakseri { get; set; }

    public int? PeEvraksira { get; set; }

    public int? PeEvraksatir { get; set; }

    public string? PeBelgeno { get; set; }

    public DateTime? PeBelgeTarih { get; set; }

    public string? PeCarikodu { get; set; }

    public string? PeCarisrmmrk { get; set; }

    public int? PeAdresno { get; set; }

    public DateTime? PeSonrakifaturatarihi { get; set; }

    public short? PePeriyot { get; set; }

    public byte? PePeriyottipi { get; set; }

    public int? PeAdet { get; set; }

    public string? PeGenelaciklama { get; set; }

    public byte? PeHarekettipi { get; set; }

    public string? PeHareketkodu { get; set; }

    public string? PeSatiraciklama { get; set; }

    public double? PeMiktari { get; set; }

    public double? PeFiyati { get; set; }

    public double? PeIskonto1 { get; set; }

    public double? PeIskonto2 { get; set; }

    public double? PeIskonto3 { get; set; }

    public double? PeIskonto4 { get; set; }

    public double? PeIskonto5 { get; set; }

    public double? PeIskonto6 { get; set; }

    public double? PeMasraf1 { get; set; }

    public double? PeMasraf2 { get; set; }

    public double? PeMasraf3 { get; set; }

    public double? PeMasraf4 { get; set; }

    public byte? PeIskonto11 { get; set; }

    public byte? PeIskonto21 { get; set; }

    public byte? PeIskonto31 { get; set; }

    public byte? PeIskonto41 { get; set; }

    public byte? PeIskonto51 { get; set; }

    public byte? PeIskonto61 { get; set; }

    public byte? PeMasraf11 { get; set; }

    public byte? PeMasraf21 { get; set; }

    public byte? PeMasraf31 { get; set; }

    public byte? PeMasraf41 { get; set; }

    public bool? PeIsk1 { get; set; }

    public bool? PeIsk2 { get; set; }

    public bool? PeIsk3 { get; set; }

    public bool? PeIsk4 { get; set; }

    public bool? PeIsk5 { get; set; }

    public bool? PeIsk6 { get; set; }

    public bool? PeMas1 { get; set; }

    public bool? PeMas2 { get; set; }

    public bool? PeMas3 { get; set; }

    public bool? PeMas4 { get; set; }

    public byte? PeVergipntr { get; set; }

    public int? PeOpno { get; set; }

    public byte? PeGrupno { get; set; }

    public byte? PeDovizCins { get; set; }

    public double? PeDovizKur { get; set; }

    public byte? PeKarsidcinsi { get; set; }

    public double? PeKarsidKur { get; set; }

    public byte? PeFaturalamakuru { get; set; }

    public string? PeSrmmrkkodu { get; set; }

    public string? PeProjekodu { get; set; }

    public string? PePlasiyerkodu { get; set; }

    public bool? PePasif { get; set; }

    public string? PeIstisna { get; set; }
}
