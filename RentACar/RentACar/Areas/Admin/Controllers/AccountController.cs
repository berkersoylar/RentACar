using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace RentACar.Areas.Admin.Controllers
{  
        [Area("Admin")]
        public class AccountController : Controller
        {
            public IActionResult Login() => View();

            [HttpPost]
            public async Task<IActionResult> Login(string username, string password)
            {
                if (username == "admin" && password == "1234")
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "AdminUser"),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                    var identity = new ClaimsIdentity(claims, "AdminCookie");
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync("AdminCookie", principal);
                    return RedirectToAction("Index", "Car", new { area = "Admin" });
                }
                ViewBag.Error = "Geçersiz Giriş Bilgisi";
                return View();
            }
            public async Task<IActionResult> Logout()
            {
                await HttpContext.SignOutAsync("AdminCookie");
                return RedirectToAction("Login");
            }
        }
 }

