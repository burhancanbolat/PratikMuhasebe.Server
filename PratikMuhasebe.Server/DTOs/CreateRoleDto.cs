using System.ComponentModel.DataAnnotations;

namespace PratikMuhasebe.Server.DTOs;

public class CreateRoleDto
{
	[Required(ErrorMessage = "Rol ismi girmek zorunlu.")]
	public string RoleName { get; set; } = null!;
}
