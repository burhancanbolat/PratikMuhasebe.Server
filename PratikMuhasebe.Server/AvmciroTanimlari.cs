using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmciroTanimlari
{
    public Guid AvmcGuid { get; set; }

    public short AvmcDbcno { get; set; }

    public int? AvmcSpecRecno { get; set; }

    public bool? AvmcIptal { get; set; }

    public short? AvmcFileid { get; set; }

    public bool? AvmcHidden { get; set; }

    public bool? AvmcKilitli { get; set; }

    public bool? AvmcDegisti { get; set; }

    public int? AvmcChecksum { get; set; }

    public short? AvmcCreateUser { get; set; }

    public DateTime AvmcCreateDate { get; set; }

    public short? AvmcLastupUser { get; set; }

    public DateTime? AvmcLastupDate { get; set; }

    public string? AvmcSpecial1 { get; set; }

    public string? AvmcSpecial2 { get; set; }

    public string? AvmcSpecial3 { get; set; }

    public string? AvmcCirokiraKodu { get; set; }

    public byte? AvmcCirobildirimperiyodu { get; set; }

    public byte? AvmcCirodegperyodu { get; set; }

    public byte? AvmcCirodegdvzkriteri { get; set; }

    public byte? AvmcCirodvzdegerleme { get; set; }

    public short? AvmcCirobildirimgecikmesuresi { get; set; }

    public short? AvmcCirobildirimsuresi { get; set; }

    public short? AvmcCirokiraodemevadesi { get; set; }

    public double? AvmcCirokiraodemevadfyuz { get; set; }

    public string? AvmcCirokirahizmetkodu { get; set; }

    public byte? AvmcCirokiraodemecinsi { get; set; }

    public byte? AvmcCirokiraodemegunu { get; set; }

    public byte? AvmcCirokirasiperyodu { get; set; }

    public short? AvmcCirokirasiperyodaraligi { get; set; }

    public byte? AvmcCiroKirasiHesYontemi { get; set; }

    public double? AvmcCirokirasiorani { get; set; }

    public double? AvmcCirokirasiorani2 { get; set; }

    public double? AvmcCirokirasiorani3 { get; set; }

    public DateTime? AvmcCirokirasi1Bastar { get; set; }

    public DateTime? AvmcCirokirasi1Bittar { get; set; }

    public double? AvmcCirokirasi1Orani { get; set; }

    public double? AvmcCirokirasi1Tavan11 { get; set; }

    public double? AvmcCirokirasi1Tavan12 { get; set; }

    public double? AvmcCirokirasi1Tavan13 { get; set; }

    public double? AvmcCirokirasi1Carpani11 { get; set; }

    public double? AvmcCirokirasi1Carpani12 { get; set; }

    public double? AvmcCirokirasi1Carpani13 { get; set; }

    public bool? AvmcCirokirasi1TavanAyriDegFl1 { get; set; }

    public double? AvmcCirokirasi1Orani2 { get; set; }

    public double? AvmcCirokirasi1Tavan21 { get; set; }

    public double? AvmcCirokirasi1Tavan22 { get; set; }

    public double? AvmcCirokirasi1Tavan213 { get; set; }

    public double? AvmcCirokirasi1Carpani21 { get; set; }

    public double? AvmcCirokirasi1Carpani22 { get; set; }

    public double? AvmcCirokirasi1Carpani23 { get; set; }

    public bool? AvmcCirokirasi1TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi1Orani3 { get; set; }

    public double? AvmcCirokirasi1Tavan31 { get; set; }

    public double? AvmcCirokirasi1Tavan32 { get; set; }

    public double? AvmcCirokirasi1Tavan33 { get; set; }

    public double? AvmcCirokirasi1Carpani31 { get; set; }

    public double? AvmcCirokirasi1Carpani32 { get; set; }

    public double? AvmcCirokirasi1Carpani33 { get; set; }

    public bool? AvmcCirokirasi1TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi2Bastar { get; set; }

    public DateTime? AvmcCirokirasi2Bittar { get; set; }

    public double? AvmcCirokirasi2Orani { get; set; }

    public double? AvmcCirokirasi2Tavan1 { get; set; }

    public double? AvmcCirokirasi2Tavan2 { get; set; }

    public double? AvmcCirokirasi2Tavan3 { get; set; }

    public double? AvmcCirokirasi2Carpani1 { get; set; }

    public double? AvmcCirokirasi2Carpani2 { get; set; }

    public double? AvmcCirokirasi2Carpani3 { get; set; }

    public bool? AvmcCirokirasi2TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi2Orani2 { get; set; }

    public double? AvmcCirokirasi2Tavan21 { get; set; }

    public double? AvmcCirokirasi2Tavan22 { get; set; }

    public double? AvmcCirokirasi2Tavan213 { get; set; }

    public double? AvmcCirokirasi2Carpani21 { get; set; }

    public double? AvmcCirokirasi2Carpani22 { get; set; }

    public double? AvmcCirokirasi2Carpani23 { get; set; }

    public bool? AvmcCirokirasi2TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi2Orani3 { get; set; }

    public double? AvmcCirokirasi2Tavan31 { get; set; }

    public double? AvmcCirokirasi2Tavan32 { get; set; }

    public double? AvmcCirokirasi2Tavan33 { get; set; }

    public double? AvmcCirokirasi2Carpani31 { get; set; }

    public double? AvmcCirokirasi2Carpani32 { get; set; }

    public double? AvmcCirokirasi2Carpani33 { get; set; }

    public bool? AvmcCirokirasi2TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi3Bastar { get; set; }

    public DateTime? AvmcCirokirasi3Bittar { get; set; }

    public double? AvmcCirokirasi3Orani { get; set; }

    public double? AvmcCirokirasi3Tavan1 { get; set; }

    public double? AvmcCirokirasi3Tavan2 { get; set; }

    public double? AvmcCirokirasi3Tavan3 { get; set; }

    public double? AvmcCirokirasi3Carpani1 { get; set; }

    public double? AvmcCirokirasi3Carpani2 { get; set; }

    public double? AvmcCirokirasi3Carpani3 { get; set; }

    public bool? AvmcCirokirasi3TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi3Orani2 { get; set; }

    public double? AvmcCirokirasi3Tavan21 { get; set; }

    public double? AvmcCirokirasi3Tavan22 { get; set; }

    public double? AvmcCirokirasi3Tavan23 { get; set; }

    public double? AvmcCirokirasi3Carpani21 { get; set; }

    public double? AvmcCirokirasi3Carpani22 { get; set; }

    public double? AvmcCirokirasi3Carpani23 { get; set; }

    public bool? AvmcCirokirasi3TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi3Orani3 { get; set; }

    public double? AvmcCirokirasi3Tavan31 { get; set; }

    public double? AvmcCirokirasi3Tavan32 { get; set; }

    public double? AvmcCirokirasi3Tavan33 { get; set; }

    public double? AvmcCirokirasi3Carpani31 { get; set; }

    public double? AvmcCirokirasi3Carpani32 { get; set; }

    public double? AvmcCirokirasi3Carpani33 { get; set; }

    public bool? AvmcCirokirasi3TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi4Bastar { get; set; }

    public DateTime? AvmcCirokirasi4Bittar { get; set; }

    public double? AvmcCirokirasi4Orani { get; set; }

    public double? AvmcCirokirasi4Tavan1 { get; set; }

    public double? AvmcCirokirasi4Tavan2 { get; set; }

    public double? AvmcCirokirasi4Tavan3 { get; set; }

    public double? AvmcCirokirasi4Carpani1 { get; set; }

    public double? AvmcCirokirasi4Carpani2 { get; set; }

    public double? AvmcCirokirasi4Carpani3 { get; set; }

    public bool? AvmcCirokirasi4TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi4Orani2 { get; set; }

    public double? AvmcCirokirasi4Tavan21 { get; set; }

    public double? AvmcCirokirasi4Tavan22 { get; set; }

    public double? AvmcCirokirasi4Tavan213 { get; set; }

    public double? AvmcCirokirasi4Carpani21 { get; set; }

    public double? AvmcCirokirasi4Carpani22 { get; set; }

    public double? AvmcCirokirasi4Carpani23 { get; set; }

    public bool? AvmcCirokirasi4TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi4Orani3 { get; set; }

    public double? AvmcCirokirasi4Tavan31 { get; set; }

    public double? AvmcCirokirasi4Tavan32 { get; set; }

    public double? AvmcCirokirasi4Tavan33 { get; set; }

    public double? AvmcCirokirasi4Carpani31 { get; set; }

    public double? AvmcCirokirasi4Carpani32 { get; set; }

    public double? AvmcCirokirasi4Carpani33 { get; set; }

    public bool? AvmcCirokirasi4TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi5Bastar { get; set; }

    public DateTime? AvmcCirokirasi5Bittar { get; set; }

    public double? AvmcCirokirasi5Orani { get; set; }

    public double? AvmcCirokirasi5Tavan1 { get; set; }

    public double? AvmcCirokirasi5Tavan2 { get; set; }

    public double? AvmcCirokirasi5Tavan3 { get; set; }

    public double? AvmcCirokirasi5Carpani1 { get; set; }

    public double? AvmcCirokirasi5Carpani2 { get; set; }

    public double? AvmcCirokirasi5Carpani3 { get; set; }

    public bool? AvmcCirokirasi5TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi5Orani2 { get; set; }

    public double? AvmcCirokirasi5Tavan21 { get; set; }

    public double? AvmcCirokirasi5Tavan22 { get; set; }

    public double? AvmcCirokirasi5Tavan213 { get; set; }

    public double? AvmcCirokirasi5Carpani21 { get; set; }

    public double? AvmcCirokirasi5Carpani22 { get; set; }

    public double? AvmcCirokirasi5Carpani23 { get; set; }

    public bool? AvmcCirokirasi5TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi5Orani3 { get; set; }

    public double? AvmcCirokirasi5Tavan31 { get; set; }

    public double? AvmcCirokirasi5Tavan32 { get; set; }

    public double? AvmcCirokirasi5Tavan33 { get; set; }

    public double? AvmcCirokirasi5Carpani31 { get; set; }

    public double? AvmcCirokirasi5Carpani32 { get; set; }

    public double? AvmcCirokirasi5Carpani33 { get; set; }

    public bool? AvmcCirokirasi5TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi6Bastar { get; set; }

    public DateTime? AvmcCirokirasi6Bittar { get; set; }

    public double? AvmcCirokirasi6Orani { get; set; }

    public double? AvmcCirokirasi6Tavan1 { get; set; }

    public double? AvmcCirokirasi6Tavan2 { get; set; }

    public double? AvmcCirokirasi6Tavan3 { get; set; }

    public double? AvmcCirokirasi6Carpani1 { get; set; }

    public double? AvmcCirokirasi6Carpani2 { get; set; }

    public double? AvmcCirokirasi6Carpani3 { get; set; }

    public bool? AvmcCirokirasi6TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi6Orani2 { get; set; }

    public double? AvmcCirokirasi6Tavan21 { get; set; }

    public double? AvmcCirokirasi6Tavan22 { get; set; }

    public double? AvmcCirokirasi6Tavan213 { get; set; }

    public double? AvmcCirokirasi6Carpani21 { get; set; }

    public double? AvmcCirokirasi6Carpani22 { get; set; }

    public double? AvmcCirokirasi6Carpani23 { get; set; }

    public bool? AvmcCirokirasi6TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi6Orani3 { get; set; }

    public double? AvmcCirokirasi6Tavan31 { get; set; }

    public double? AvmcCirokirasi6Tavan32 { get; set; }

    public double? AvmcCirokirasi6Tavan33 { get; set; }

    public double? AvmcCirokirasi6Carpani31 { get; set; }

    public double? AvmcCirokirasi6Carpani32 { get; set; }

    public double? AvmcCirokirasi6Carpani33 { get; set; }

    public bool? AvmcCirokirasi6TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi7Bastar { get; set; }

    public DateTime? AvmcCirokirasi7Bittar { get; set; }

    public double? AvmcCirokirasi7Orani { get; set; }

    public double? AvmcCirokirasi7Tavan1 { get; set; }

    public double? AvmcCirokirasi7Tavan2 { get; set; }

    public double? AvmcCirokirasi7Tavan3 { get; set; }

    public double? AvmcCirokirasi7Carpani1 { get; set; }

    public double? AvmcCirokirasi7Carpani2 { get; set; }

    public double? AvmcCirokirasi7Carpani3 { get; set; }

    public bool? AvmcCirokirasi7TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi7Orani2 { get; set; }

    public double? AvmcCirokirasi7Tavan21 { get; set; }

    public double? AvmcCirokirasi7Tavan22 { get; set; }

    public double? AvmcCirokirasi7Tavan213 { get; set; }

    public double? AvmcCirokirasi7Carpani21 { get; set; }

    public double? AvmcCirokirasi7Carpani22 { get; set; }

    public double? AvmcCirokirasi7Carpani23 { get; set; }

    public bool? AvmcCirokirasi7TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi7Orani3 { get; set; }

    public double? AvmcCirokirasi7Tavan31 { get; set; }

    public double? AvmcCirokirasi7Tavan32 { get; set; }

    public double? AvmcCirokirasi7Tavan33 { get; set; }

    public double? AvmcCirokirasi7Carpani31 { get; set; }

    public double? AvmcCirokirasi7Carpani32 { get; set; }

    public double? AvmcCirokirasi7Carpani33 { get; set; }

    public bool? AvmcCirokirasi7TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi8Bastar { get; set; }

    public DateTime? AvmcCirokirasi8Bittar { get; set; }

    public double? AvmcCirokirasi8Orani { get; set; }

    public double? AvmcCirokirasi8Tavan1 { get; set; }

    public double? AvmcCirokirasi8Tavan2 { get; set; }

    public double? AvmcCirokirasi8Tavan3 { get; set; }

    public double? AvmcCirokirasi8Carpani1 { get; set; }

    public double? AvmcCirokirasi8Carpani2 { get; set; }

    public double? AvmcCirokirasi8Carpani3 { get; set; }

    public bool? AvmcCirokirasi8TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi8Orani2 { get; set; }

    public double? AvmcCirokirasi8Tavan21 { get; set; }

    public double? AvmcCirokirasi8Tavan22 { get; set; }

    public double? AvmcCirokirasi8Tavan213 { get; set; }

    public double? AvmcCirokirasi8Carpani21 { get; set; }

    public double? AvmcCirokirasi8Carpani22 { get; set; }

    public double? AvmcCirokirasi8Carpani23 { get; set; }

    public bool? AvmcCirokirasi8TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi8Orani3 { get; set; }

    public double? AvmcCirokirasi8Tavan31 { get; set; }

    public double? AvmcCirokirasi8Tavan32 { get; set; }

    public double? AvmcCirokirasi8Tavan33 { get; set; }

    public double? AvmcCirokirasi8Carpani31 { get; set; }

    public double? AvmcCirokirasi8Carpani32 { get; set; }

    public double? AvmcCirokirasi8Carpani33 { get; set; }

    public bool? AvmcCirokirasi8TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi9Bastar { get; set; }

    public DateTime? AvmcCirokirasi9Bittar { get; set; }

    public double? AvmcCirokirasi9Orani { get; set; }

    public double? AvmcCirokirasi9Tavan1 { get; set; }

    public double? AvmcCirokirasi9Tavan2 { get; set; }

    public double? AvmcCirokirasi9Tavan3 { get; set; }

    public double? AvmcCirokirasi9Carpani1 { get; set; }

    public double? AvmcCirokirasi9Carpani2 { get; set; }

    public double? AvmcCirokirasi9Carpani3 { get; set; }

    public bool? AvmcCirokirasi9TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi9Orani2 { get; set; }

    public double? AvmcCirokirasi9Tavan21 { get; set; }

    public double? AvmcCirokirasi9Tavan22 { get; set; }

    public double? AvmcCirokirasi9Tavan213 { get; set; }

    public double? AvmcCirokirasi9Carpani21 { get; set; }

    public double? AvmcCirokirasi9Carpani22 { get; set; }

    public double? AvmcCirokirasi9Carpani23 { get; set; }

    public bool? AvmcCirokirasi9TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi9Orani3 { get; set; }

    public double? AvmcCirokirasi9Tavan31 { get; set; }

    public double? AvmcCirokirasi9Tavan32 { get; set; }

    public double? AvmcCirokirasi9Tavan33 { get; set; }

    public double? AvmcCirokirasi9Carpani31 { get; set; }

    public double? AvmcCirokirasi9Carpani32 { get; set; }

    public double? AvmcCirokirasi9Carpani33 { get; set; }

    public bool? AvmcCirokirasi9TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi10Bastar { get; set; }

    public DateTime? AvmcCirokirasi10Bittar { get; set; }

    public double? AvmcCirokirasi10Orani { get; set; }

    public double? AvmcCirokirasi10Tavan1 { get; set; }

    public double? AvmcCirokirasi10Tavan2 { get; set; }

    public double? AvmcCirokirasi10Tavan3 { get; set; }

    public double? AvmcCirokirasi10Carpani1 { get; set; }

    public double? AvmcCirokirasi10Carpani2 { get; set; }

    public double? AvmcCirokirasi10Carpani3 { get; set; }

    public bool? AvmcCirokirasi10TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi10Orani2 { get; set; }

    public double? AvmcCirokirasi10Tavan21 { get; set; }

    public double? AvmcCirokirasi10Tavan22 { get; set; }

    public double? AvmcCirokirasi10Tavan213 { get; set; }

    public double? AvmcCirokirasi10Carpani21 { get; set; }

    public double? AvmcCirokirasi10Carpani22 { get; set; }

    public double? AvmcCirokirasi10Carpani23 { get; set; }

    public bool? AvmcCirokirasi10TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi10Orani3 { get; set; }

    public double? AvmcCirokirasi10Tavan31 { get; set; }

    public double? AvmcCirokirasi10Tavan32 { get; set; }

    public double? AvmcCirokirasi10Tavan33 { get; set; }

    public double? AvmcCirokirasi10Carpani31 { get; set; }

    public double? AvmcCirokirasi10Carpani32 { get; set; }

    public double? AvmcCirokirasi10Carpani33 { get; set; }

    public bool? AvmcCirokirasi10TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi11Bastar { get; set; }

    public DateTime? AvmcCirokirasi11Bittar { get; set; }

    public double? AvmcCirokirasi11Orani { get; set; }

    public double? AvmcCirokirasi11Tavan1 { get; set; }

    public double? AvmcCirokirasi11Tavan2 { get; set; }

    public double? AvmcCirokirasi11Tavan3 { get; set; }

    public double? AvmcCirokirasi11Carpani1 { get; set; }

    public double? AvmcCirokirasi11Carpani2 { get; set; }

    public double? AvmcCirokirasi11Carpani3 { get; set; }

    public bool? AvmcCirokirasi11TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi11Orani2 { get; set; }

    public double? AvmcCirokirasi11Tavan21 { get; set; }

    public double? AvmcCirokirasi11Tavan22 { get; set; }

    public double? AvmcCirokirasi11Tavan213 { get; set; }

    public double? AvmcCirokirasi11Carpani21 { get; set; }

    public double? AvmcCirokirasi11Carpani22 { get; set; }

    public double? AvmcCirokirasi11Carpani23 { get; set; }

    public bool? AvmcCirokirasi11TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi11Orani3 { get; set; }

    public double? AvmcCirokirasi11Tavan31 { get; set; }

    public double? AvmcCirokirasi11Tavan32 { get; set; }

    public double? AvmcCirokirasi11Tavan33 { get; set; }

    public double? AvmcCirokirasi11Carpani31 { get; set; }

    public double? AvmcCirokirasi11Carpani32 { get; set; }

    public double? AvmcCirokirasi11Carpani33 { get; set; }

    public bool? AvmcCirokirasi11TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi12Bastar { get; set; }

    public DateTime? AvmcCirokirasi12Bittar { get; set; }

    public double? AvmcCirokirasi12Orani { get; set; }

    public double? AvmcCirokirasi12Tavan1 { get; set; }

    public double? AvmcCirokirasi12Tavan2 { get; set; }

    public double? AvmcCirokirasi12Tavan3 { get; set; }

    public double? AvmcCirokirasi12Carpani1 { get; set; }

    public double? AvmcCirokirasi12Carpani2 { get; set; }

    public double? AvmcCirokirasi12Carpani3 { get; set; }

    public bool? AvmcCirokirasi12TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi12Orani2 { get; set; }

    public double? AvmcCirokirasi12Tavan21 { get; set; }

    public double? AvmcCirokirasi12Tavan22 { get; set; }

    public double? AvmcCirokirasi12Tavan213 { get; set; }

    public double? AvmcCirokirasi12Carpani21 { get; set; }

    public double? AvmcCirokirasi12Carpani22 { get; set; }

    public double? AvmcCirokirasi12Carpani23 { get; set; }

    public bool? AvmcCirokirasi12TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi12Orani3 { get; set; }

    public double? AvmcCirokirasi12Tavan31 { get; set; }

    public double? AvmcCirokirasi12Tavan32 { get; set; }

    public double? AvmcCirokirasi12Tavan33 { get; set; }

    public double? AvmcCirokirasi12Carpani31 { get; set; }

    public double? AvmcCirokirasi12Carpani32 { get; set; }

    public double? AvmcCirokirasi12Carpani33 { get; set; }

    public bool? AvmcCirokirasi12TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi13Bastar { get; set; }

    public DateTime? AvmcCirokirasi13Bittar { get; set; }

    public double? AvmcCirokirasi13Orani { get; set; }

    public double? AvmcCirokirasi13Tavan1 { get; set; }

    public double? AvmcCirokirasi13Tavan2 { get; set; }

    public double? AvmcCirokirasi13Tavan3 { get; set; }

    public double? AvmcCirokirasi13Carpani1 { get; set; }

    public double? AvmcCirokirasi13Carpani2 { get; set; }

    public double? AvmcCirokirasi13Carpani3 { get; set; }

    public bool? AvmcCirokirasi13TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi13Orani2 { get; set; }

    public double? AvmcCirokirasi13Tavan21 { get; set; }

    public double? AvmcCirokirasi13Tavan22 { get; set; }

    public double? AvmcCirokirasi13Tavan213 { get; set; }

    public double? AvmcCirokirasi13Carpani21 { get; set; }

    public double? AvmcCirokirasi13Carpani22 { get; set; }

    public double? AvmcCirokirasi13Carpani23 { get; set; }

    public bool? AvmcCirokirasi13TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi13Orani3 { get; set; }

    public double? AvmcCirokirasi13Tavan31 { get; set; }

    public double? AvmcCirokirasi13Tavan32 { get; set; }

    public double? AvmcCirokirasi13Tavan33 { get; set; }

    public double? AvmcCirokirasi13Carpani31 { get; set; }

    public double? AvmcCirokirasi13Carpani32 { get; set; }

    public double? AvmcCirokirasi13Carpani33 { get; set; }

    public bool? AvmcCirokirasi13TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi14Bastar { get; set; }

    public DateTime? AvmcCirokirasi14Bittar { get; set; }

    public double? AvmcCirokirasi14Orani { get; set; }

    public double? AvmcCirokirasi14Tavan1 { get; set; }

    public double? AvmcCirokirasi14Tavan2 { get; set; }

    public double? AvmcCirokirasi14Tavan3 { get; set; }

    public double? AvmcCirokirasi14Carpani1 { get; set; }

    public double? AvmcCirokirasi14Carpani2 { get; set; }

    public double? AvmcCirokirasi14Carpani3 { get; set; }

    public bool? AvmcCirokirasi14TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi14Orani2 { get; set; }

    public double? AvmcCirokirasi14Tavan21 { get; set; }

    public double? AvmcCirokirasi14Tavan22 { get; set; }

    public double? AvmcCirokirasi14Tavan213 { get; set; }

    public double? AvmcCirokirasi14Carpani21 { get; set; }

    public double? AvmcCirokirasi14Carpani22 { get; set; }

    public double? AvmcCirokirasi14Carpani23 { get; set; }

    public bool? AvmcCirokirasi14TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi14Orani3 { get; set; }

    public double? AvmcCirokirasi14Tavan31 { get; set; }

    public double? AvmcCirokirasi14Tavan32 { get; set; }

    public double? AvmcCirokirasi14Tavan33 { get; set; }

    public double? AvmcCirokirasi14Carpani31 { get; set; }

    public double? AvmcCirokirasi14Carpani32 { get; set; }

    public double? AvmcCirokirasi14Carpani33 { get; set; }

    public bool? AvmcCirokirasi14TavanAyriDegFl3 { get; set; }

    public DateTime? AvmcCirokirasi15Bastar { get; set; }

    public DateTime? AvmcCirokirasi15Bittar { get; set; }

    public double? AvmcCirokirasi15Orani { get; set; }

    public double? AvmcCirokirasi15Tavan1 { get; set; }

    public double? AvmcCirokirasi15Tavan2 { get; set; }

    public double? AvmcCirokirasi15Tavan3 { get; set; }

    public double? AvmcCirokirasi15Carpani1 { get; set; }

    public double? AvmcCirokirasi15Carpani2 { get; set; }

    public double? AvmcCirokirasi15Carpani3 { get; set; }

    public bool? AvmcCirokirasi15TavanAyriDegFl { get; set; }

    public double? AvmcCirokirasi15Orani2 { get; set; }

    public double? AvmcCirokirasi15Tavan21 { get; set; }

    public double? AvmcCirokirasi15Tavan22 { get; set; }

    public double? AvmcCirokirasi15Tavan213 { get; set; }

    public double? AvmcCirokirasi15Carpani21 { get; set; }

    public double? AvmcCirokirasi15Carpani22 { get; set; }

    public double? AvmcCirokirasi15Carpani23 { get; set; }

    public bool? AvmcCirokirasi15TavanAyriDegFl2 { get; set; }

    public double? AvmcCirokirasi15Orani3 { get; set; }

    public double? AvmcCirokirasi15Tavan31 { get; set; }

    public double? AvmcCirokirasi15Tavan32 { get; set; }

    public double? AvmcCirokirasi15Tavan33 { get; set; }

    public double? AvmcCirokirasi15Carpani31 { get; set; }

    public double? AvmcCirokirasi15Carpani32 { get; set; }

    public double? AvmcCirokirasi15Carpani33 { get; set; }

    public bool? AvmcCirokirasi15TavanAyriDegFl3 { get; set; }
}
