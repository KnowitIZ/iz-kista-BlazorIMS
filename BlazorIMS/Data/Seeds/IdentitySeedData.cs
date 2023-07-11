using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorIMS.Data.Seeds
{
    public class IdentitySeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var serviceProvider = app.ApplicationServices.CreateScope().ServiceProvider;
            UserManager<IdentityUser> userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            CreateAccountAsync(userManager, roleManager, "admin_izl@knowit.se", "secret", "Admins").Wait();

            CreateAccountAsync(userManager, roleManager, "e1test@knowit.se", "1", "Employees").Wait();
            CreateAccountAsync(userManager, roleManager, "e2test@knowit.se", "1", "Employees").Wait();
        }

        public static async Task CreateAccountAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,
            string email, string password, string role)
        {
            if (await userManager.FindByNameAsync(email) == null)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
                IdentityUser user = new IdentityUser
                {
                    UserName = email,
                    Email = email
                };
                IdentityResult result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}
