namespace PratikMuhasebe.Server.DTOs;

public class A11Response
{
    public string? Baslik { get; set; }
    public bool Basarili { get; set; }
    public List<Giderler>? Giderler { get; set; }
}
public class Giderler
{
    public DateTime Tarih { get; set; }
    public string? MuhasebeKodu { get; set; }
    public double MeblagBSMVDahil { get; set; }
    public string? Aciklama { get; set; }
    public string? BelgeNo { get; set; }
    public string? Proje { get; set; }
    public string? Kategori { get; set; }
    public string? Ticarethane { get; set; }
    public string? OdemeYontemi { get; set; }
    public string? OdemeYontemiA { get; set; }
    public string? Iban { get; set; }
    public string? BankaDekontNo { get; set; }
    public double Tutar { get; set; }
    public double KDV { get; set; }
    public DateTime OdenmeTarihi { get; set; }
    public string? FaturaNo { get; set; }

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
