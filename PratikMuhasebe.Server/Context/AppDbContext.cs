using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PratikMuhasebe.Server.DTOs;
using PratikMuhasebe.Server.Models;
using System.Collections.Generic;

namespace PratikMuhasebe.Server.Context;

public class AppDbContext : IdentityDbContext<AppUser>
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}
	public DbSet<Takaslar> Takaslar { get; set; }
	public DbSet<Virmanlar> Virmanlar { get; set; }
	public DbSet<Transferler> Transferler { get; set; }

}
