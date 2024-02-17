using bds_site_web_version7_.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace bds_site_web_version7_.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
       
            private UserManager<User> userManager;
            private SignInManager<User> signInManager;

            public AccountController(UserManager<User> userMgr, SignInManager<User> signinMgr)
            {
                userManager = userMgr;
                signInManager = signinMgr;
            }

            [AllowAnonymous]
            public IActionResult Login()
            {
                
                
                return View();
            }

            [HttpPost]
            [AllowAnonymous]
            [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string Email, string Password, string ReturnUrl)
        {
            if ((Email == "vanleroy53@gmail.com") && (Password == "Admin"))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Email)
                };
                var claimsIdentity = new ClaimsIdentity(claims, "Login");

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnUrl == null ? "/Statistiques/Statistiques" : ReturnUrl);
            }
            else
                return View();
        }

        [Authorize]
        public IActionResult Logout()
        {
            return View();
        }

    }
    
}
