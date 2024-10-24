namespace PratikMuhasebe.Server.DTOs;

public class A06Response
{
    public string? Baslik { get; set; }
    public bool Basarili { get; set; }
    public List<GonderilenNakit>? GonderilenNakit { get; set; }

}
public class GonderilenNakit
{
    public string? Tablo { get; set; }
    public string? KaynakMuhasebeKodu { get; set; }
    public string? HedefMuhasebeKodu { get; set; }
    public double Tutar { get; set; }
    public string? BelgeNo { get; set; }
    public DateTime IslemTarihi { get; set; }
    public string? HavaleAciklama { get; set; }
    public string? IslemAciklama { get; set; }
    public string? Aciklama { get; set; }

}
