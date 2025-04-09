using LendSpace.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LendSpace.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<UserModel> _signInManager;

        public AccountController(SignInManager<UserModel> signInManager)
        {
            _signInManager = signInManager;
        }

        /*
         * [POST] /api/account/logout
         */
        [HttpPost("[action]")]
        public async Task<ActionResult> Logout()
        {
            Console.WriteLine("Logout...");
            await _signInManager.SignOutAsync();
            return NoContent();
        }
    }
}
