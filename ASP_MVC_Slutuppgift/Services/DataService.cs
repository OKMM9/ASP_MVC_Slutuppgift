using ASP_MVC_Slutuppgift.Models;
using ASP_MVC_Slutuppgift.Views.Admin;
using ASP_MVC_Slutuppgift.Views.Cars;
using ASP_MVC_Slutuppgift.Views.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ASP_MVC_Slutuppgift.Services;

public class DataService(ApplicationDbContext dbContext, StateService stateService, IHttpClientFactory clientFactory)
{
    public async Task<CreateVM> GetVehicleTypeSelectListAsync()
    {
        var categoriesSelect = await dbContext.Categories
                .Select(o => new SelectListItem
                {
                    Value = o.Id.ToString(),
                    Text = o.Name
                })
                .ToArrayAsync();
        
        return new CreateVM()
        {
            CategoryList = categoriesSelect
        };
    }
    //public async Task<CarIndexVM> GetAllCarsAsync()
    //{
    //    var ret = new CarIndexVM
    //    {
    //        Temp = stateService.TempDataCreateVehicleConfirmation,
    //        CarItems = await dbContext.Cars
    //            .Select(o => new CarIndexVM.CarItemsVM
    //            {
    //                Id = o.Id,
    //                Model = o.Model,
    //                Category = o.Category.Name,
    //                LicensePlate = o.LicensePlate,
    //            })
    //            .OrderBy(o => o.Model)
    //            .ToListAsync(),
    //    };

    //    return ret;
    //}
    public async Task<IndexVM> GetAllCarsForHomeIndexAsync()
    {
        var ret = new IndexVM
        {
            CarItems = await dbContext.Cars
                .Select(o => new IndexVM.CarItemsVM
                {
                    Id = o.Id,
                    Model = o.Model,
                    Category = o.Category.Name,
                })
                .OrderBy(o => o.Model)
                .ToListAsync(),
        };

        return ret;
    }
    public async Task<DetailsVM> GetCarDetailByIdAsync(int id)
    {
        var ret = await dbContext.Cars
            .Where(c => c.Id == id)
            .Select(c => new DetailsVM
            {
                Id = c.Id,
                Model = c.Model,
                Category = c.Category.Name,
                LicensePlate = c.LicensePlate,
                Description = c.Description
            })
            .SingleOrDefaultAsync();
        return ret;
    }
    public async Task TryCreateNewVehicle(CreateVM viewModel)
    {
        var ret = dbContext.Cars.Add(new Car()
        {
            Model = viewModel.Model,
            LicensePlate = viewModel.LicensePlate,
            Description = viewModel.Description,
            CategoryId = viewModel.CategoryId
        });
        var result = await dbContext.SaveChangesAsync();

        if (result > 0)
        {
            stateService.TempDataCreateVehicleConfirmation = $"Vehicle with license plate: {viewModel.LicensePlate} successfully registered!";
        }
    }
    public async Task<List<CarDto>> GetCarsForApiAsync()
    {
        var ret = await dbContext.Cars
            .Select(u => new CarDto()
            {
                Id = u.Id,
                Model = u.Model,
                Category = u.Category.Name,
                LicensePlate = u.LicensePlate,
                Description = u.Description,
            })
            .ToListAsync();
        return ret;
    }
    public async Task<CarIndexVM> GetCarInfoFromApiAsync()
    {
        string url = "https://localhost:7216/api/getcars";

        HttpClient httpClient = clientFactory.CreateClient();
        List<CarDto> cars = await httpClient.GetFromJsonAsync<List<CarDto>>(url) ?? new List<CarDto>();

        var ret = new CarIndexVM
        {
            Temp = stateService.TempDataCreateVehicleConfirmation,
            CarItems = cars
            .Select(u => new CarIndexVM.CarItemsVM
            {
                Id = u.Id,
                Model = u.Model,
                Category = u.Category,
                LicensePlate = u.LicensePlate,
                Description = u.Description
            })
            .ToList(),
        };
        return ret;
    }
    public async Task<AdminIndexVM> GetUsersForAdminVMAsync()
    {
        var users = await dbContext.Users
                .Select(u => new AdminIndexVM.UserListVM()
                {
                    Id = u.Id,
                    Username = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                })
                .ToListAsync();

        return new AdminIndexVM()
        {
            Users = users
        };
    }
}
