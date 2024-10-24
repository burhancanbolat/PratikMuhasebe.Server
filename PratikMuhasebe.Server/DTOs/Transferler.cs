using System.ComponentModel.DataAnnotations;

namespace PratikMuhasebe.Server.DTOs;

public class Transferler
{
    public string Tarih { get; set; }
	public string KaynakMuhasebeKodu { get; set; }
	public string HedefMuhasebeKodu { get; set; }
	[Key]
	public string BelgeNo { get; set; }
	public string Tutar { get; set; }
	public string Aciklama { get; set; }
}
