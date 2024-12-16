using ASP_MVC_Slutuppgift.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Slutuppgift.Controllers;
public class HomeController(DataService dataService) : Controller
{
    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var model = await dataService.GetAllCarsForHomeIndexAsync();
        return View(model);
    }
}