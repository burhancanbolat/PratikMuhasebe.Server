namespace PratikMuhasebe.Server.DTOs;

public class A03Response
{
	public string? Baslik { get; set; }
	public bool Basarili { get; set; }
    public List<GelenHareketler>? GelenHareketler { get; set; }
    public List<GidenHareketler>? GidenHareketler { get; set; }
    public List<Kesintiler>? Kesintiler { get; set; }
}
