namespace PratikMuhasebe.Server.DTOs;

public class A04Response
{
    public string? Baslik { get; set; }
    public bool Basarili { get; set; }
    public List<Virman>? Virmanlar { get; set; }

}
public class Virman
{
    public string? Tablo { get; set; }
    public string? TransferNo { get; set; }
    public string? KaynakMuhasebeKodu { get; set; }
    public string? HedefMuhasebeKodu { get; set; }
    public double Tutar { get; set; }
    public string? BelgeNo { get; set; }
    public DateTime IslemTarihi { get; set; }
    public string? HavaleAcıklama { get; set; }
    public string? IslemAciklama { get; set; }
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
