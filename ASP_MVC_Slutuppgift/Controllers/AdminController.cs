using ASP_MVC_Slutuppgift.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Slutuppgift.Controllers;
public class AdminController(DataService dataService) : Controller
{
    [HttpGet("admin/start")]
    public async Task<IActionResult> AdminIndex()
    {
        var model = await dataService.GetUserInfoFromApiAsync();
        return View(model);
    }

}
