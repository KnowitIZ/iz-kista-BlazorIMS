using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BlazorIMS.Services
{
    //https://learn.microsoft.com/en-us/aspnet/core/blazor/security/?view=aspnetcore-7.0
    public class CurrentUserService
    {
        private readonly AuthenticationStateProvider _authenticationStateAsync;
        private readonly UserManager<IdentityUser> _userManager;
        private ClaimsPrincipal? _claimsPrincipal;

        public CurrentUserService(AuthenticationStateProvider authenticationStateAsync, UserManager<IdentityUser> userManager)
        {
            _authenticationStateAsync = authenticationStateAsync;
            _userManager = userManager;
        }

        public async Task<IdentityUser> GetCurrentUser()
        {
            IdentityUser? user = null;
            var authstate = await _authenticationStateAsync.GetAuthenticationStateAsync();
            _claimsPrincipal = authstate?.User;
            if (_claimsPrincipal != null)
            {
                user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == _claimsPrincipal!.Identity!.Name);
            }

            return user!;
        }
        public async Task<ClaimsPrincipal?> GetClaimsPrinciple()
        {
            var authstate = await _authenticationStateAsync.GetAuthenticationStateAsync();
            
            return authstate?.User;
        }

        public async Task<bool> IsAuthenticated()
        {
            var authstate = await _authenticationStateAsync.GetAuthenticationStateAsync();

            return (bool)(authstate?.User.Identity!.IsAuthenticated!);
        }

        public async Task<bool> IsInRole(string role)
        {
            var authstate = await _authenticationStateAsync.GetAuthenticationStateAsync();

            return (bool)(authstate?.User.IsInRole(role)!);
        }
    }
}
