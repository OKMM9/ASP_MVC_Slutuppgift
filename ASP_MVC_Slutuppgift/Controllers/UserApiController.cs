using ASP_MVC_Slutuppgift.Models;
using ASP_MVC_Slutuppgift.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Slutuppgift.Controllers;
[Route("api/")]
[ApiController]
public class UserApiController(DataService dataService) : ControllerBase
{
    [HttpGet("getusers")]
    public async Task<ActionResult<List<UserDto>>?> GetUsersAsync()
    {
        return Ok(await dataService.GetUsersAsync());
    }
}