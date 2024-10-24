namespace PratikMuhasebe.Server.DTOs;

public class A09Response
{
	public string? Baslik { get; set; }
	public bool Basarili { get; set; }
	public List<Transferler>? Transferler { get; set; }
	public List<Takaslar>? Takaslar { get; set; }
	public List<Virmanlar>? Virmanlar { get; set; }
}
