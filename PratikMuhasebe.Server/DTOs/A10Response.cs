namespace PratikMuhasebe.Server.DTOs;

public class A10Response
{
    public string? Baslik { get; set; }
    public bool Basarili { get; set; }
    public List<Zararlar>? Zararlar { get; set; }
}
public class Zararlar
{
    public string? MuhasebeKodu { get; set; }
    public string? KarsilayanHesap { get; set; }
    public DateTime Tarih { get; set; }
    public string? BelgeNo { get; set; }
    public double MeblagBSMVDahil { get; set; }
    public string? Aciklama { get; set; }

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