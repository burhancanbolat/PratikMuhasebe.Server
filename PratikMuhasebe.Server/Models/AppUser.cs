using Microsoft.AspNetCore.Identity;

namespace PratikMuhasebe.Server.Models;

public class AppUser : IdentityUser
{
	public string FullName { get; set; } = string.Empty;
}
