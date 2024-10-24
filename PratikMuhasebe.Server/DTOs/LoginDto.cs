namespace PratikMuhasebe.Server.DTOs;

public class LoginDto
{
	public required string Email { get; set; } = string.Empty;
	public required string Password { get; set; } = string.Empty;
}
