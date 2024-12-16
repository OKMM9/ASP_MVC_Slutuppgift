using ASP_MVC_Slutuppgift.Services;
using ASP_MVC_Slutuppgift.Views.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Slutuppgift.Controllers;
public class AccountController(AccountService accountService) : Controller
{
    [HttpGet("login")]
    public IActionResult Login()
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction("Index", "Home");

        return View();
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginVM viewModel)
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction("Index", "Home");

        if (!ModelState.IsValid)
            return View();

        var errorMessage = await accountService.TryLoginAsync(viewModel);

        if (errorMessage != null)
        {
            ModelState.AddModelError(string.Empty, errorMessage);
            return View();
        }

        return RedirectToAction(nameof(UserPage));
    }

    [HttpGet("logout")]
    public async Task<IActionResult> LogoutAsync()
    {
        await accountService.LogoutUser();
        return RedirectToAction(nameof(HomeController.Index), "Home");
    }

    [Authorize]
    [HttpGet("userpage")]
    public async Task<IActionResult> UserPage()
    {
        var model = await accountService.GetUserInfoAsync();

        return View(model);
    }

    [HttpGet("register")]
    public IActionResult Register()
    {
        if (User.Identity.IsAuthenticated) 
            return RedirectToAction("Index", "Home"); 

        return View();
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync(RegisterVM viewModel)
    {
        if (User.Identity.IsAuthenticated)
            return RedirectToAction("Index", "Home");

        if (!ModelState.IsValid)
            return View();

        var errorMessage = await accountService.TryRegisterUserAsync(viewModel);

        if (errorMessage != null)
        {
            ModelState.AddModelError(string.Empty, errorMessage);
            return View();
        }

        return RedirectToAction(nameof(UserPage));
    }

    [Authorize]
    [HttpGet("edituser")]
    public async Task<IActionResult> EditUser()
    {
        var model = await accountService.GetUserInfoForEditUser();

        return View(model);
    }

    [Authorize]
    [HttpPost("edituser")]
    public async Task<IActionResult> EditUser(EditUserVM viewModel)
    {
        if (!ModelState.IsValid)
            return View();

        var errorMessage = await accountService.UpdateUserAsync(viewModel);

        if (errorMessage != null)
        {
            ModelState.AddModelError($"{errorMessage}", errorMessage);
            return View();
        }
        return RedirectToAction(nameof(UserPage));
    }
}
