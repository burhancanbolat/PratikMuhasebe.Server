using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class StokSatisFiyatListeTanimlari
{
    public Guid SflGuid { get; set; }

    public short SflDbcno { get; set; }

    public int? SflSpecRecno { get; set; }

    public bool? SflIptal { get; set; }

    public short? SflFileid { get; set; }

    public bool? SflHidden { get; set; }

    public bool? SflKilitli { get; set; }

    public bool? SflDegisti { get; set; }

    public int? SflChecksum { get; set; }

    public short? SflCreateUser { get; set; }

    public DateTime SflCreateDate { get; set; }

    public short? SflLastupUser { get; set; }

    public DateTime? SflLastupDate { get; set; }

    public string? SflSpecial1 { get; set; }

    public string? SflSpecial2 { get; set; }

    public string? SflSpecial3 { get; set; }

    public int? SflSirano { get; set; }

    public string? SflAciklama { get; set; }

    public byte? SflFiyatuygulama { get; set; }

    public string? SflFiyatformul { get; set; }

    public byte? SflOdepluygulama { get; set; }

    public string? SflOdeplformul { get; set; }

    public int? SflSabitOdemePlani { get; set; }

    public bool? SflKdvdahil { get; set; }

    public DateTime? SflIlktarih { get; set; }

    public DateTime? SflSontarih { get; set; }

    public int? SflYerineuygulanacakfiyat { get; set; }

    public byte? SflKurhesaplamasekli { get; set; }

    public byte? SflDovizUygulama { get; set; }

    public byte? SflSabitDoviz { get; set; }

    public byte? SflIskontoUygulama { get; set; }

    public string? SflSabitIskonto { get; set; }

    public double? SflSabitKur { get; set; }

    public byte? SflKampanyaUygulama { get; set; }

    public string? SflSabitKampanya { get; set; }

    public bool? SflKampanyaVadeGozardi { get; set; }

    public bool? SflKampanyaIskontoGozardi { get; set; }

    public bool? SflOtvdahil { get; set; }

    public bool? SflOivdahil { get; set; }
}
