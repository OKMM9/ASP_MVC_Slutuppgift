using ASP_MVC_Slutuppgift.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Slutuppgift.Controllers;
[Authorize(Roles = "Admin")]
public class AdminController(DataService dataService) : Controller
{
    [HttpGet("admin/start")]
    public async Task<IActionResult> AdminIndex()
    {
        var model = await dataService.GetUsersForAdminVMAsync();
        return View(model);
    }
}
