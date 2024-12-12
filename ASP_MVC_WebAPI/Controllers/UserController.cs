using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_WebAPI.Controllers;
[ApiController]
[Route("api/cities")]
public class UserController : ControllerBase
{
    public IActionResult Index()
    {
        return Ok();
    }
}
