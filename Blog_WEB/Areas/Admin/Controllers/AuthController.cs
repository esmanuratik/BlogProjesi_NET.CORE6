using Blog_ENTİTY.Entities;
using Blog_ENTİTY.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blog_WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //Login sayfasına hiç erişmezsem bu sayfaya hiç erişemeyeceğim için bunu yazmalıyım.Authorize komutunu controllera verdiğim için buraya da erişmek zorunda olduğum için bu kodu verdim.  
        [AllowAnonymous]     
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {          
                if (ModelState.IsValid)
                {
                    var user = await userManager.Users.FirstOrDefaultAsync(x=>x.Email == userLoginViewModel.Email);

                if (user == null)
                {
                    // Kullanıcı bulunamadı, bu durumu hata mesajı göstererek işaret et
                    ModelState.AddModelError("", "Kullanıcı Bulunamadı!");
                    return View();
                }
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

        [Authorize]//birisinin logout olması için öncelikli olarak login olması gerekmektedir
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new {Area="" });
        }

    }
 
   
}

