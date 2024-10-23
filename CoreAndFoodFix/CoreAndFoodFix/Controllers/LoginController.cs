using CoreAndFoodFix.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace CoreAndFoodFix.Controllers
{
    public class LoginController : Controller
    {

        Context c = new Context();

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        
                }
        [AllowAnonymous]
        [HttpPost]
        public async Task <IActionResult> Index(Admin p)
        {
            var datavalue = c.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password ==p.Password);

            if (datavalue != null) 
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.UserName)
                };
                var useridenty = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridenty);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Category");
			}
			else
			{
				ModelState.AddModelError(string.Empty, "Invalid username or password.");
				return View(); // Hatalı giriş durumunda Index.cshtml view'ini döndür
			}
		}
		[HttpGet]
		public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

	}
}
