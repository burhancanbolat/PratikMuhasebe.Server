using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class AvmCariHasilatHareketleri
{
    public Guid ChGuid { get; set; }

    public short ChDbcno { get; set; }

    public int? ChSpecRecNo { get; set; }

    public bool? ChIptal { get; set; }

    public short? ChFileid { get; set; }

    public bool? ChHidden { get; set; }

    public bool? ChKilitli { get; set; }

    public bool? ChDegisti { get; set; }

    public int? ChChecksum { get; set; }

    public short? ChCreateUser { get; set; }

    public DateTime ChCreateDate { get; set; }

    public short? ChLastupUser { get; set; }

    public DateTime? ChLastupDate { get; set; }

    public string? ChSpecial1 { get; set; }

    public string? ChSpecial2 { get; set; }

    public string? ChSpecial3 { get; set; }

    public int? ChFirmano { get; set; }

    public int? ChSubeno { get; set; }

    public DateTime? ChEvraktarihi { get; set; }

    public string? ChEvrakseri { get; set; }

    public int? ChEvraksira { get; set; }

    public int? ChEvraksatir { get; set; }

    public string? ChCarikodu { get; set; }

    public string? ChCarisrmmrk { get; set; }

    public DateTime? ChTarihi { get; set; }

    public string? ChHizmetkodu { get; set; }

    public string? ChAciklama { get; set; }

    public double? ChFiyati { get; set; }

    public byte? ChGrupno { get; set; }

    public int? ChOpno { get; set; }

    public string? ChSrmmrkkodu { get; set; }

    public byte? ChDovizCins { get; set; }

    public double? ChDovizKur { get; set; }

    public double? ChAltDovizKur { get; set; }

    public short? ChOnaylayanKulNo { get; set; }

    public bool? ChCagrilabilirFl { get; set; }

    public double? ChCiroKiraOrani { get; set; }

    public double? ChCiroKirasi { get; set; }

    public bool? ChSozlesmeOlustuFl { get; set; }

    public string? ChKiraKodu { get; set; }

    public int? ChFisSayisi { get; set; }

    public double? ChAsgariKira { get; set; }

    public double? ChKesGerekCiroKirasi { get; set; }

    public double? ChKesGerekCiroKuru { get; set; }

    public byte? ChVergiPntr { get; set; }

    public double? ChVergi { get; set; }

    public bool? ChhesaplandiFl { get; set; }

    public double? ChOrtakGider { get; set; }

    public string? ChProjeKodu { get; set; }

    public double? ChDvzfiyati { get; set; }

    public double? ChAnaKesGerekCiroKirasi { get; set; }

    public bool? ChOran1Fl { get; set; }

    public bool? ChOran2Fl { get; set; }

    public bool? ChOran3Fl { get; set; }
}
