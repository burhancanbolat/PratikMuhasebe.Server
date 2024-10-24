using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class BankaOnlineAktarimSablon
{
    public Guid BoasGuid { get; set; }

    public short BoasDbcno { get; set; }

    public int? BoasSpecRecno { get; set; }

    public bool? BoasIptal { get; set; }

    public short? BoasFileid { get; set; }

    public bool? BoasHidden { get; set; }

    public bool? BoasKilitli { get; set; }

    public bool? BoasDegisti { get; set; }

    public int? BoasChecksum { get; set; }

    public short? BoasCreateUser { get; set; }

    public DateTime BoasCreateDate { get; set; }

    public short? BoasLastupUser { get; set; }

    public DateTime? BoasLastupDate { get; set; }

    public string? BoasSpecial1 { get; set; }

    public string? BoasSpecial2 { get; set; }

    public string? BoasSpecial3 { get; set; }

    public string? BoasKod { get; set; }

    public byte? BoasEvrakTip { get; set; }

    public string? BoasEvraknoSeri { get; set; }

    public string? BoasProjekodu { get; set; }

    public string? BoasSrmrkkodu { get; set; }

    public string? BoasSaticiKodu { get; set; }

    public string? BoasHareketGrupKodu1 { get; set; }

    public string? BoasHareketGrupKodu2 { get; set; }

    public string? BoasHareketGrupKodu3 { get; set; }

    public byte? BoasHesapCinsi { get; set; }

    public string? BoasHesapKodu { get; set; }

    public byte? BoasHesapGrubu { get; set; }

    public string? BoasCiroCariKodu { get; set; }
}
