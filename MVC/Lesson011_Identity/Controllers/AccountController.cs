using Lesson011_Identity.IdentityEnities;
using Lesson011_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lesson011_Identity.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, 
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(
                    temp => temp.Errors).SelectMany(temp => temp.ErrorMessage);
                  
                return View(loginDto);
            }
            var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, false,false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("Loging", "Invalid email or password");

            return View(loginDto);
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
                await _signInManager.SignInAsync(newuser, isPersistent: true);
                return RedirectToAction(nameof(HomeController.Index),"Home");
            }

            return View();
        }


    }
}
