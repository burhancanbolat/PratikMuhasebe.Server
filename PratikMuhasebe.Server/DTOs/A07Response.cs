namespace PratikMuhasebe.Server.DTOs;

public class A07Response
{
    public string? Baslik { get; set; }
    public bool Basarili { get; set; }
    public List<Cekimler>? Cekimler { get; set; }
    public List<Iadeler>? Iadeler { get; set; }
}
public class Cekimler
{
    public string? MuhasebeKodu { get; set; }
    public List<Poslar>? Poslar { get; set; }
}
public class Poslar
{
    public string? MuhasebeKodu { get; set; }
    public string? TermimalNo { get; set; }
    public List<Liste>? Liste { get; set; }
}
public class Liste
{
    public DateTime CekimGun { get; set; }
    public DateTime TahsilatGun { get; set; }
    public string? BelgeNo { get; set; }
    public int Adet { get; set; }
    public double PostanCekilen { get; set; }
    public double BankaKomisyon { get; set; }
    public double HesabaYatan { get; set; }
}
public class Iadeler
{
    public string? FirmaMuhasebeKodu { get; set; }
    public string? BankaMuhasebeKodu { get; set; }
    public string? BelgeNo { get; set; }
    public string? TerminalNo { get; set; }
    public DateTime IadeGun { get; set; }
    public double PostanCekilen { get; set; }
    public double BankaKomisyon { get; set; }
    public double IadeEdilen { get; set; }
}