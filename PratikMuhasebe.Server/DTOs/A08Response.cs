namespace PratikMuhasebe.Server.DTOs;

public class A08Response
{
    public string? Baslik { get; set; }
    public bool Basarili { get; set; }
    public List<Kesinti>? Kesintiler { get; set; }
}
public class Kesinti
{
    public string? PanelID { get; set; }
    public DateTime BelgeTarihi { get; set; }
    public DateTime Tarih { get; set; }
    public string? MuhasebeKodu { get; set; }
    public string? EvrakNo { get; set; }
    public string? BelgeNo { get; set; }
    public double MeblagBSMVDahil { get; set; }
    public string? Aciklama { get; set; }
    public string? IslemAciklama { get; set; }
}
