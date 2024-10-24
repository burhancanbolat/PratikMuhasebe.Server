using Btrans.Server.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PratikMuhasebe.Server.DTOs;
using PratikMuhasebe.Server.Models;

namespace Btrans.Server.Controllers;
[Authorize(Roles = "Admin")]
[Route("api/[controller]/[action]")]
[ApiController]
public class RolesController : ControllerBase
{
	private readonly RoleManager<IdentityRole> roleManager;
	private readonly UserManager<AppUser> userManager;

	private RolesController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
	{
		this.roleManager = roleManager;
		this.userManager = userManager;
	}

	[HttpPost]
	private async Task<IActionResult> CreateRole([FromBody] CreateRoleDto createRoleDto)
	{
		if (string.IsNullOrEmpty(createRoleDto.RoleName))
		{
			return BadRequest("Rol ismi girmek zorunlu");
		}
		var roleExist = await roleManager.RoleExistsAsync(createRoleDto.RoleName);

		if (roleExist)
		{
			return BadRequest("Rol zaten mevcut");
		}
		var roleResult = await roleManager.CreateAsync(new IdentityRole(createRoleDto.RoleName));

		if (roleResult.Succeeded)
		{
			return Ok(new { message = "Rol Başarıyla Oluşturuldu" });
		}

		return BadRequest("Rol oluşturulamadı");
	}
	[AllowAnonymous]
	[HttpGet]
	private async Task<ActionResult<IEnumerable<RoleResponseDto>>> GetRoles()
	{
		var roles = await roleManager.Roles.ToListAsync();

		var roleDtos = new List<RoleResponseDto>();

		foreach (var role in roles)
		{
			var usersInRole = await userManager.GetUsersInRoleAsync(role.Name!);
			var roleDto = new RoleResponseDto
			{
				Id = role.Id,
				Name = role.Name,
				TotalUsers = usersInRole.Count
			};
			roleDtos.Add(roleDto);
		}

		return Ok(roleDtos);
	}

	[HttpDelete]
	private async Task<IActionResult> DeleteRole(string id)
	{
		var role = await roleManager.FindByIdAsync(id);
		if (role is null)
		{
			return NotFound("Rol Bulunamadı");
		}
		if (role.Id == "ef52910b-e109-4740-9304-2390568fbcd1")
		{
			return Ok(new { message = "Admin rolü silinemez" });
		}
		else
		{
			var result = await roleManager.DeleteAsync(role);
			if (result.Succeeded)
			{
				return Ok(new { message = "Rol başarıyla silindi" });
			}
		}


		return BadRequest("Rol Silinemedi");
	}

	[HttpPost]
	private async Task<IActionResult> AssignRole([FromBody] RoleAssignDto roleAssignDto)
	{
		var user = await userManager.FindByIdAsync(roleAssignDto.UserId);

		if (user is null)
		{
			return NotFound("Kullanıcı Bulunamadı");
		}

		var role = await roleManager.FindByIdAsync(roleAssignDto.RoleId);

		if (role is null)
		{
			return NotFound("Rol Bulunamadı");
		}

		var result = await userManager.AddToRoleAsync(user, role.Name!);

		if (result.Succeeded)
		{
			return Ok(new { message = "Rol Başarıyla Atandı." });
		}

		var error = result.Errors.FirstOrDefault();

		return BadRequest(error!.Description);
	}

}
