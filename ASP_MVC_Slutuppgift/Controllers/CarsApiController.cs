using ASP_MVC_Slutuppgift.Models;
using ASP_MVC_Slutuppgift.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Slutuppgift.Controllers;
[Route("api/")]
[ApiController]
public class CarsApiController(DataService dataService) : ControllerBase
{
    [HttpGet("getcars")]
    public async Task<ActionResult<List<CarDto>>?> GetCarsAsync()
    {
        return Ok(await dataService.GetCarsForApiAsync());
    }
}