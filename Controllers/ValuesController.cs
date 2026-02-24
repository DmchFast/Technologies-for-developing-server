using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_ASP.NET_Core.Controllers;

[Route("/")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public object Start()
    {
        return new { message = "Добро пожаловать в моё приложение ASP.NET Core!" };
    }

    [HttpGet("html")]
    public IActionResult Html()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "page", "index.html");
        return PhysicalFile(filePath, "text/html");
    }
}
