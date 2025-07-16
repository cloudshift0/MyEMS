using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using EMS.Models.Models;

public class DbInitializer
{
    public static async Task SeedRolesAndAdmin(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        string[] roles = { "Admin", "Manager", "Employee", "HR", "IT Support", "Finance", "User" };

        foreach (string role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        // Create admin user
        var adminUser = new ApplicationUser
        {
            UserName = "admin@ems.com",
            Email = "admin@ems.com",
            FullName = "System Administrator",
            IsActive = true,
            EmailConfirmed = true
        };

        var user = await userManager.FindByEmailAsync(adminUser.Email);
        if (user == null)
        {
            var result = await userManager.CreateAsync(adminUser, "Admin@123");
            if (result.Succeeded)
                await userManager.AddToRoleAsync(adminUser, "Admin");
        }
    }
}
