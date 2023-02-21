using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class SecurityChampionsController : ControllerBase
{
    private readonly ILogger<SecurityChampionsController> _logger;

    public SecurityChampionsController(ILogger<SecurityChampionsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSecurityChampions")]
    public string Get()
    {
        return "Hello Security Champions meetup 3!👋🏻";
    }
}
