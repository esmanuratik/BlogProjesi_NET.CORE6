using Blog_ENTİTY.Entities;
using Blog_ENTİTY.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blog_WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]//Login sayfasına hiç erişmezsem bu syafya hiç erişemeyeceğim için bunu yazamlıyım.Authorize komutunu controlera verdiğm için buraya da erişmek zorunda olduğum için bu kodu verdim.       
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(userLoginViewModel.Email);

                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, userLoginViewModel.Password, userLoginViewModel.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    }
                    else
                    {
                        ModelState.AddModelError("", "E-Mail Adresi veya Şifre Hatalıdır!!!");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-Mail Adresi veya Şifre Hatalıdır!!!");
                    return View();
                }
            }
            else
            {
                return View();
            }

        }

    }
}
