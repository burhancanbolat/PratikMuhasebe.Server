namespace PratikMuhasebe.Server.DTOs;

public class GelenHareketler
{
    public string? PanelID { get; set; }
    public DateTime BelgeTarihi { get; set; }
    public string? MuhasebeKodu { get; set; }
    public string? EvrakNo { get; set; }
    public string? BelgeNo { get; set; }
    public string? BankaKodu { get; set; }
    public string? Meblag { get; set; }
    public string? Aciklama { get; set; }
    public string? IslemAciklama { get; set; }

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

