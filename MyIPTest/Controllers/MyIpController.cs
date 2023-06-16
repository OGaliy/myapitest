using Microsoft.AspNetCore.Mvc;

namespace MyIPTest.Controllers;

[ApiController]
[Route("[controller]")]
public class MyIpController : ControllerBase
{
    [HttpGet]
    public string? Get()
    {
        return HttpContext.Connection?.RemoteIpAddress?.ToString();
    }
}