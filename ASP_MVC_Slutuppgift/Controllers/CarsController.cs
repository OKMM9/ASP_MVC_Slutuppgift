﻿using ASP_MVC_Slutuppgift.Services;
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
        var model = await dataService.GetCarInfoFromApiAsync();

        return View(model);
    }
    //TODO
    [HttpGet("bookvehicle/{id}")]
    public async Task<IActionResult> Book(int id)
    {
        return View();
    }
    //TODO
    [HttpPost("bookvehicle/{id}")]
    public async Task<IActionResult> Book(BookVM viewModel)
    {
        return View();
    }
    [Authorize(Roles = "Admin")]
    [HttpGet("cars/create")]
    public async Task<IActionResult> Create()
    {
        var model = await dataService.GetVehicleTypeSelectListAsync();
        return View(model);
    }
    [Authorize(Roles = "Admin")]
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
