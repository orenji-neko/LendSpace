using LendSpace.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace LendSpace.Services
{
    public class AuthProvider : AuthenticationStateProvider
    {
        private readonly SignInManager<UserModel> _signInManager;
        private readonly UserManager<UserModel> _userManager;

        public AuthProvider(SignInManager<UserModel> signInManager, UserManager<UserModel> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var principal = _signInManager.Context.User;

                if (_signInManager.IsSignedIn(principal))
                {
                    var user = await _userManager.GetUserAsync(principal);

                    var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(user);
                    return new AuthenticationState(claimsPrincipal);
                }

                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            catch
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
        }
        public async Task<UserModel?> GetCurrentUser()
        {
            try
            {
                var authState = await GetAuthenticationStateAsync();
                var principal = authState.User;

                if (principal.Identity?.IsAuthenticated ?? false)
                {
                    return await _userManager.GetUserAsync(principal);
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
