using Btrans.Server.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PratikMuhasebe.Server.DTOs;
using PratikMuhasebe.Server.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Btrans.Server.Controllers;
[Authorize]
[Route("api/[controller]/[action]")]
[ApiController]
public class AccountController : ControllerBase
{
	private readonly UserManager<AppUser> userManager;
	private readonly RoleManager<IdentityRole> roleManager;
	private readonly IConfiguration configuration;

	public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
	{
		this.configuration = configuration;
		this.roleManager = roleManager;
		this.userManager = userManager;
	}
	[AllowAnonymous]
	[HttpPost]
	private async Task<ActionResult<string>> Register(RegisterDto registerDto)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}

		var user = new AppUser
		{
			Email = registerDto.Email,
			FullName = registerDto.FullName,
			UserName = registerDto.Email,
		};
		var result = await userManager.CreateAsync(user, registerDto.Password);

		if (!result.Succeeded)
		{
			return BadRequest(result.Errors);
		}
		if (registerDto.Roles is null)
		{
			await userManager.AddToRoleAsync(user, "Admin");
		}
		else
		{
			foreach (var role in registerDto.Roles)
			{
				await userManager.AddToRoleAsync(user, role);
			}
		}
		return Ok(new AuthResponseDto
		{
			IsSuccess = true,
			Message = "Hesabınız Başarıyla Oluşturuldu",
		});
	}

	[AllowAnonymous]
	[HttpPost]
	public async Task<ActionResult<AuthResponseDto>> Login(LoginDto loginDto)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}
		var user = await userManager.FindByEmailAsync(loginDto.Email);
		if (user is null)
		{
			return Unauthorized(new AuthResponseDto
			{
				IsSuccess = false,
				Message = "Kullanıcı Bulunamadı"
			});
		}
		var result = await userManager.CheckPasswordAsync(user, loginDto.Password);
		if (!result)
		{
			return Unauthorized(new AuthResponseDto
			{
				IsSuccess = false,
				Message = "Şifre Hatalı"
			});
		}
		var token = GenerateToken(user);

		return Ok(new AuthResponseDto
		{
			IsSuccess = true,
			Message = "Giriş Başarılı",
			Token = token
		});
	}


	[HttpGet]
	private async Task<ActionResult<UserDetailDto>> GetUserDetail()
	{
		var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
		var user = await userManager.FindByIdAsync(currentUserId!);

		if (user is null)
		{
			return NotFound(new AuthResponseDto
			{
				IsSuccess = false,
				Message = "Kullanıcı Bulunamadı"
			});
		}
		return Ok(new UserDetailDto
		{
			Id = user.Id,
			Email = user.Email,
			FullName = user.FullName,
			Roles = [.. await userManager.GetRolesAsync(user)],
			PhoneNumber = user.PhoneNumber,
			PhoneNumberConfirmed = user.PhoneNumberConfirmed,
			AccessFailedCount = user.AccessFailedCount,
			TwoFactorEnabled = user.TwoFactorEnabled,
		});

	}

	[HttpGet]
	private async Task<ActionResult<IEnumerable<UserDetailDto>>> GetUsers()
	{
		var users = await userManager.Users.ToListAsync();

		var userDtos = new List<UserDetailDto>();

		foreach (var user in users)
		{
			var roles = await userManager.GetRolesAsync(user);
			var userDto = new UserDetailDto
			{
				Id = user.Id,
				Email = user.Email,
				FullName = user.FullName,
				Roles = roles.ToArray(),
				PhoneNumber = user.PhoneNumber,
				PhoneNumberConfirmed = user.PhoneNumberConfirmed,
				AccessFailedCount = user.AccessFailedCount,
				TwoFactorEnabled = user.TwoFactorEnabled,
			};
			userDtos.Add(userDto);
		}

		return Ok(userDtos);
	}

	private string GenerateToken(AppUser user)
	{
		var tokenHandler = new JwtSecurityTokenHandler();
		var key = Encoding.ASCII.GetBytes(configuration.GetSection("JWTSettings").GetSection("SecurityKey").Value!);

		var roles = userManager.GetRolesAsync(user).Result;

		List<Claim> claims = [
			new(JwtRegisteredClaimNames.Email, user.Email ?? ""),
			new(JwtRegisteredClaimNames.Name, user.FullName ?? ""),
			new(JwtRegisteredClaimNames.NameId, user.Id ?? ""),
			new(JwtRegisteredClaimNames.Aud, configuration.GetSection("JWTSettings").GetSection("ValidAudience").Value!),
			new(JwtRegisteredClaimNames.Iss, configuration.GetSection("JWTSettings").GetSection("ValidIssuer").Value!),
		];
		foreach (var role in roles)
		{
			claims.Add(new Claim(ClaimTypes.Role, role));
		}
		var tokenDescriptor = new SecurityTokenDescriptor
		{
			Subject = new ClaimsIdentity(claims),
			Expires = DateTime.UtcNow.AddDays(1),
			SigningCredentials = new SigningCredentials(
				new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
		};
		var token = tokenHandler.CreateToken(tokenDescriptor);
		return tokenHandler.WriteToken(token);
	}
}
