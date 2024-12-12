using ASP_MVC_Slutuppgift.Services;
using ASP_MVC_Slutuppgift.Views.Cars;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Slutuppgift.Controllers;
[Authorize]
public class CarsController(DataService dataService) : Controller
{    
    [HttpGet("cars")]
    public async Task<IActionResult> CarIndex()
    {
        var model = await dataService.GetAllCarsAsync();

        return View(model);
    }
    [HttpGet("bookvehicle/{id}")]
    public async Task<IActionResult> Book(int id)
    {
        return View();
    }
    [HttpPost("bookvehicle/{id}")]
    public async Task<IActionResult> Book(BookVM viewModel)
    {
        return View();
    }
    [HttpGet("cars/create")]
    public IActionResult Create()
    {
        var model = dataService.GetVehicleTypeSelectList();
        return View(model);
    } 
    [HttpPost("cars/create")]
    public async Task<IActionResult> Create(CreateVM viewModel)
    {
        if (!ModelState.IsValid)
            return View(viewModel);

        await dataService.TryCreateNewVehicle(viewModel);

        return RedirectToAction(nameof(CarIndex));
    }
    [HttpGet("cars/details/{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var model = await dataService.GetCarDetailByIdAsync(id);
        return View(model);
    }
}
