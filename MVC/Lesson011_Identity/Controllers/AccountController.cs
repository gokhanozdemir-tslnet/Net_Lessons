using Lesson011_Identity.IdentityEnities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lesson011_Identity.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserDto user)
        {

            ApplicationUser newuser = new ApplicationUser
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password,
                ConfirmPassword = user.ConfirmPassword,
                UserName = user.Email,
                Phone =user.Phone,
                PhoneNumber=user.Phone
            };

            IdentityResult result = await _userManager.CreateAsync(newuser);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(HomeController.Index),"Home");
            }

            return View();
        }


    }
}
