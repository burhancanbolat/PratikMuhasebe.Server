namespace PratikMuhasebe.Server.DTOs;

public class A05Response
{
    public string? Baslik { get; set; }
    public bool Basarili { get; set; }
    public List<Tahakkuk>? Tahakkuk { get; set; }
    public List<KurumTahakkuk>? KurumTahakkuk { get; set; }
}
public class Tahakkuk
{
    public string? MuhasebeKodu { get; set; }
    public double BrutKar { get; set; }
    public int Adet { get; set; }
    public double FaturaFiyat { get; set; }
    public string? Masraf { get; set; }
    public double Prim { get; set; }
    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }
    public List<OdenenKurumlar>? OdenenKurumlar { get; set; }
}
public class OdenenKurumlar
{
    public string? KurumKodu { get; set; }
    public string? MuhasebeKodu { get; set; }
    public int Adet { get; set; }
    public double FaturaFiyat { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }
}
public class KurumTahakkuk
{
    public string? MuhasebeKodu { get; set; }
    public string? KurumKodu { get; set; }
    public string? BankaKodu { get; set; }
    public string? PortalKodu { get; set; }
    public bool AnlikOdeme { get; set; }
    public int Adet { get; set; }
    public double FaturaFiyat { get; set; }

    public int BanMainProgramNo { get; set; }
    public int BanVersionNo { get; set; }
    public int BanMenuNo { get; set; }
    public string? BanMikroSpecial1 { get; set; }
    public string? BanMikroSpecial2 { get; set; }
    public string? BanMikroSpecial3 { get; set; }
    public string? BanExternalProgramType { get; set; }
    public int BanExternalProgramId { get; set; }
    public string? BanHash { get; set; }
}
