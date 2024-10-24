using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class IsMerkezleri
{
    public Guid IsMGuid { get; set; }

    public short IsMDbcno { get; set; }

    public int? IsMSpecRecno { get; set; }

    public bool? IsMIptal { get; set; }

    public short? IsMFileid { get; set; }

    public bool? IsMHidden { get; set; }

    public bool? IsMKilitli { get; set; }

    public bool? IsMDegisti { get; set; }

    public int? IsMCheckSum { get; set; }

    public short? IsMCreateUser { get; set; }

    public DateTime IsMCreateDate { get; set; }

    public short? IsMLastupUser { get; set; }

    public DateTime? IsMLastupDate { get; set; }

    public string? IsMSpecial1 { get; set; }

    public string? IsMSpecial2 { get; set; }

    public string? IsMSpecial3 { get; set; }

    public string? IsMKodu { get; set; }

    public string? IsMAciklama { get; set; }

    public string? IsMGrupKodu1 { get; set; }

    public string? IsMGrupKodu2 { get; set; }

    public string? IsMGrupKodu3 { get; set; }

    public string? IsMGrupKodu4 { get; set; }

    public string? IsMGrupKodu5 { get; set; }

    public byte? IsMCalisanSayisi { get; set; }

    public string? IsMMakinaKodu { get; set; }

    public string? IsMSmkodu { get; set; }

    public string? IsMTakvimKodu { get; set; }

    public bool? IsMCokluIsEmriFl { get; set; }

    public double? IsMKapasitesi { get; set; }

    public string? IsMKapasiteBirimi { get; set; }

    public double? IsMHizi { get; set; }

    public string? IsMHizBirimi { get; set; }

    public string? IsMHizZamanBirimi { get; set; }

    public byte? IsMZamanPlanlamasiYapilacak { get; set; }

    public int? IsMRenk { get; set; }
}
