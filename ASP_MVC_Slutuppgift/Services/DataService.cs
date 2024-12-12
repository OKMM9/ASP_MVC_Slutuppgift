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
    public CreateVM GetVehicleTypeSelectList()
    {
        return new CreateVM
        {
            CategoryList = dbContext.Categories
                .Select(o => new SelectListItem
                {
                    Value = o.Id.ToString(),
                    Text = o.Name
                })
                .ToArray()
        };
    }
    public async Task<CarIndexVM> GetAllCarsAsync()
    {
        var ret = new CarIndexVM
        {
            Temp = stateService.TempDataConfirmation,
            CarItems = await dbContext.Cars
                .Select(o => new CarIndexVM.CarItemsVM
                {
                    Id = o.Id,
                    Model = o.Model,
                    Category = o.Category.Name,
                    LicensePlate = o.LicensePlate,
                })
                .OrderBy(o => o.Model)
                .ToListAsync(),
        };

        return ret;
    }
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
            stateService.TempDataConfirmation = $"Vehicle with license plate: {viewModel.LicensePlate} successfully registered!";
        }
    }
    public async Task<List<UserDto>> GetUsersAsync()
    {
        var ret = await dbContext.Users
            .Select(u => new UserDto()
            {
                Id = u.Id,
                Username = u.UserName!,
                FirstName = u.FirstName,
                LastName = u.LastName,
            })
            .ToListAsync();
        return ret;
    }
    public async Task<AdminIndexVM> GetUserInfoFromApiAsync()
    {
        string url = "https://localhost:7216/api/getusers";

        HttpClient httpClient = clientFactory.CreateClient();
        List<UserDto> users = await httpClient.GetFromJsonAsync<List<UserDto>>(url) ?? new List<UserDto>();

        var ret = new AdminIndexVM
        {
            Users = users
            .Select(u => new AdminIndexVM.UserListVM
            {
                Id = u.Id,
                Username = u.Username,
                FirstName = u.FirstName,
                LastName = u.LastName,

            })
            .ToList(),
        };
        return ret;
    }
}
