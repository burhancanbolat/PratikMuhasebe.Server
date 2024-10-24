using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class UretimOperasyonlari
{
    public Guid OpGuid { get; set; }

    public short OpDbcno { get; set; }

    public int? OpSpecRecno { get; set; }

    public bool? OpIptal { get; set; }

    public short? OpFileid { get; set; }

    public bool? OpHidden { get; set; }

    public bool? OpKilitli { get; set; }

    public bool? OpDegisti { get; set; }

    public int? OpCheckSum { get; set; }

    public short? OpCreateUser { get; set; }

    public DateTime OpCreateDate { get; set; }

    public short? OpLastupUser { get; set; }

    public DateTime? OpLastupDate { get; set; }

    public string? OpSpecial1 { get; set; }

    public string? OpSpecial2 { get; set; }

    public string? OpSpecial3 { get; set; }

    public string? OpKodu { get; set; }

    public string? OpAciklama { get; set; }

    public byte? OpBirimi { get; set; }

    public bool? OpUrunGirisOlustur { get; set; }

    public bool? OpUretimeSevkOlustur { get; set; }

    public double? OpSabitMaliyet { get; set; }

    public double? OpDegiskenMaliyet { get; set; }

    public string? OpSorumlulukMerkezi { get; set; }

    public bool? OpAraOperasyon { get; set; }

    public bool? OpPlanlamaTarihiniEtkilemez { get; set; }

    public double? OpIscilikMaliyet { get; set; }

    public double? OpGenelUretimMaliyet { get; set; }

    public byte? OpZamanPlanlamasiYapilacak { get; set; }

    public bool? OpMiktarSureyiEtkilemez { get; set; }
}
