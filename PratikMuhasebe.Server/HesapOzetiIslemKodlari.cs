using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class HesapOzetiIslemKodlari
{
    public Guid EhozGuid { get; set; }

    public short EhozDbcno { get; set; }

    public int? EhozSpecRecno { get; set; }

    public bool? EhozIptal { get; set; }

    public short? EhozFileid { get; set; }

    public bool? EhozHidden { get; set; }

    public bool? EhozKilitli { get; set; }

    public bool? EhozDegisti { get; set; }

    public int? EhozChecksum { get; set; }

    public short? EhozCreateUser { get; set; }

    public DateTime EhozCreateDate { get; set; }

    public short? EhozLastupUser { get; set; }

    public DateTime? EhozLastupDate { get; set; }

    public string? EhozSpecial1 { get; set; }

    public string? EhozSpecial2 { get; set; }

    public string? EhozSpecial3 { get; set; }

    public byte? EhozBankahesapcinsi { get; set; }

    public string? EhozBankahesapkodu { get; set; }

    public int? EhozSatirno { get; set; }

    public string? EhozIslemkodu { get; set; }

    public string? EhozIslemaciklamasi { get; set; }

    public byte? EhozKarsihesapcinsi { get; set; }

    public string? EhozKarsihesapkodu { get; set; }

    public byte? EhozKarsihesapgrupno { get; set; }

    public byte? EhozEvraktipi { get; set; }

    public byte? EhozStfonpntr { get; set; }

    public string? EhozEvrakseri { get; set; }

    public string? EhozFaturacirocarikodu { get; set; }

    public string? EhozSrmmrk { get; set; }

    public string? EhozProje { get; set; }

    public byte? EhozMfisKisaevraktipi { get; set; }

    public byte? EhozMfisSatistipi { get; set; }

    public byte? EhozMfisAlistipi { get; set; }

    public byte? EhozMfisTahtedtipi { get; set; }

    public string? EhozMfisDigerevrakadi { get; set; }

    public string? EhozSaticiKodu { get; set; }

    public string? EhozHareketGrupKodu1 { get; set; }

    public string? EhozHareketGrupKodu2 { get; set; }

    public string? EhozHareketGrupKodu3 { get; set; }
}
