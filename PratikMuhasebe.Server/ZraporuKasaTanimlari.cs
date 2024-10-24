using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class ZraporuKasaTanimlari
{
    public Guid ZparGuid { get; set; }

    public short ZparDbcno { get; set; }

    public int? ZparSpecRecno { get; set; }

    public bool? ZparIptal { get; set; }

    public short? ZparFileid { get; set; }

    public bool? ZparHidden { get; set; }

    public bool? ZparKilitli { get; set; }

    public bool? ZparDegisti { get; set; }

    public int? ZparChecksum { get; set; }

    public short? ZparCreateUser { get; set; }

    public DateTime ZparCreateDate { get; set; }

    public short? ZparLastupUser { get; set; }

    public DateTime? ZparLastupDate { get; set; }

    public string? ZparSpecial1 { get; set; }

    public string? ZparSpecial2 { get; set; }

    public string? ZparSpecial3 { get; set; }

    public string? ZparKasaSicilNo { get; set; }

    public int? ZparDepNo { get; set; }

    public int? ZparDepoKasaNo { get; set; }

    public byte? ZparKasaTipi { get; set; }

    public byte? ZparOkcTipi { get; set; }

    public byte? ZparBaglantiTipi { get; set; }

    public string? ZparKasaMarka { get; set; }

    public string? ZparKasaModel { get; set; }

    public string? ZparAciklama { get; set; }

    public string? ZparDosyaYoluSunucuAdi { get; set; }

    public string? ZparDosyaVeritabaniAdi { get; set; }

    public string? ZparCalismaGrubuAdi { get; set; }

    public string? ZparCalismaGrubuSifresi { get; set; }

    public string? ZparVeriTabaniSifresi { get; set; }
}
