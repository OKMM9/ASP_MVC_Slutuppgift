using ASP_MVC_Slutuppgift.Models;
using ASP_MVC_Slutuppgift.Views.Account;
using Microsoft.AspNetCore.Identity;

namespace ASP_MVC_Slutuppgift.Services;

public class AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, IHttpContextAccessor contextAccessor, StateService stateService)
{
    internal async Task<ApplicationUser> GetLoggedInUserAsync()
    {
        var loggedInUserId = userManager.GetUserId(contextAccessor.HttpContext.User);
        ApplicationUser user = await userManager.FindByIdAsync(loggedInUserId);

        return user;
    }
    internal async Task<UserPageVM> GetUserInfoAsync()
    {
        var user = await GetLoggedInUserAsync();

        return new UserPageVM
        {
            Username = contextAccessor.HttpContext!.User.Identity!.Name!,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Temp = stateService.TempDataUserUpdateConfirmation
        };
    }
    internal async Task<EditUserVM> GetUserInfoForEditUser()
    {
        var user = await GetLoggedInUserAsync();

        return new EditUserVM()
        {
            FirstName = user.FirstName ?? string.Empty,
            LastName = user.LastName ?? string.Empty,
            Email = user.Email ?? string.Empty,
        };
    }
    internal async Task<string?> UpdateUserAsync(EditUserVM viewModel)
    {
        var user = await GetLoggedInUserAsync();

        user.FirstName = viewModel.FirstName ?? string.Empty;
        user.LastName = viewModel.LastName ?? string.Empty;
        user.Email = viewModel.Email;

        var result = await userManager.UpdateAsync(user);

        bool successfullyChanged = result.Succeeded;

        if (successfullyChanged)
        {
            stateService.TempDataUserUpdateConfirmation = $"User successfully updated!";
        }

        return successfullyChanged ? null : result.Errors.First().Description;
    }
    internal async Task<string?> TryRegisterUserAsync(RegisterVM viewModel)
    {
        var user = new ApplicationUser
        {
            UserName = viewModel.Username
        };

        IdentityResult result = await
            userManager.CreateAsync(user, viewModel.Password);

        string role = viewModel.IsAdmin ? "Admin" : "User";

        var roleResult = await userManager.AddToRoleAsync(user, role);

        bool wasUserCreated = result.Succeeded;

        return wasUserCreated ? null : result.Errors.First().Description;
    }
    internal async Task<string?> TryLoginAsync(LoginVM viewModel)   
    {
        SignInResult result = await signInManager.PasswordSignInAsync(
            viewModel.Username,
            viewModel.Password,
            isPersistent: false,
            lockoutOnFailure: false);
        
        bool wasUserSignedIn = result.Succeeded;

        return wasUserSignedIn ? null : "Invalid Username or Password";
    }
    internal async Task LogoutUser()
    {
        await signInManager.SignOutAsync();
    }
}
