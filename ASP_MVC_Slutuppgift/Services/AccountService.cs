using ASP_MVC_Slutuppgift.Models;
using ASP_MVC_Slutuppgift.Views.Account;
using Microsoft.AspNetCore.Identity;

namespace ASP_MVC_Slutuppgift.Services;

public class AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, IHttpContextAccessor contextAccessor)
{
    internal async Task<ApplicationUser> GetUserByIdAsync()
    {
        var loggedInUserId = userManager.GetUserId(contextAccessor.HttpContext.User);
        ApplicationUser user = await userManager.FindByIdAsync(loggedInUserId);

        return user;
    }
    internal async Task<UserPageVM> GetUserInfoAsync()
    {
        var user = await GetUserByIdAsync();   
        
        return new UserPageVM
        {
            Username = contextAccessor.HttpContext!.User.Identity!.Name!,
            FirstName = user.FirstName,
            LastName = user.LastName,
        };
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
