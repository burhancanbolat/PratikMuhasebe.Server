using System.ComponentModel.DataAnnotations;

namespace PratikMuhasebe.Server.DTOs;

public class Virmanlar
{
    public string Tarih { get; set; }
	public string KaynakMuhasebeKodu { get; set; }
	public string HedefMuhasebeKodu { get; set; }
	[Key]
	public string BelgeNo { get; set; }
	public string Tutar { get; set; }
	public string Aciklama { get; set; }
	public string Tablo { get; set; }
	public string IslemTarihi { get; set; }
	public string HavaleAciklama { get; set; }
	public string IslemAciklama { get; set; }
}