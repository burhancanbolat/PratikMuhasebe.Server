using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace PratikMuhasebe.Server.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class A01Controller : ControllerBase
{
	private readonly HttpClient _httpClient;
	private readonly MikroDbV16Test2Context _context;
	private readonly IMemoryCache _memoryCache;

	public A01Controller(IHttpClientFactory httpClientFactory, MikroDbV16Test2Context context, IMemoryCache memoryCache)
	{
		_httpClient = httpClientFactory.CreateClient();
		_context = context;
		_memoryCache = memoryCache;
	}

	[HttpPost]
	public async Task<ActionResult> TemsilcileriEkle(string sonId,bool TemsilcileriAl)
	{
		return Ok();
	}
}
