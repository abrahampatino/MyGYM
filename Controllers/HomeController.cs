using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyectov1.Data;
using Proyectov1.Models;

namespace Proyectov1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly db_gym_webContext _context;
        public HomeController(db_gym_webContext context)
        {
            _context = context;
        }

        // GET: Home2
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View("Login");
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Index(Login login)
        {
            try
            {
                var user = _context.Usuario.Where(u => u.UsuName == login.User).Single();

                if (user.UsuName.Equals(login.User) && user.UsuPass.Equals(login.Password))
                {
                    var ro = _context.Rol.Where(r => r.UsuId == user.UsuId).Single();

                    String role = "";
                    if (ro.RolAdmin.Value)
                    {
                        role = "admin";
                    }
                    else if(ro.RolEmployee.Value)
                    {
                        role = "employee"; 
                    }
                    else
                    {
                        role = "socio";
                    }

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, login.User)
                    };
                    
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, null, role);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(identity),
                            new AuthenticationProperties
                            {
                                ExpiresUtc = DateTime.UtcNow.AddMinutes(5),
                                IsPersistent = true
                            });
                    return RedirectToAction("RedirectToSection");
                }
                else
                {
                    
                    return View("Login");
                }
            }
            catch(Exception)
            {
                return View("Login");
            }
        }

        [Authorize]
        public IActionResult RedirectToSection()
        {
            var ident = User.Identity as ClaimsIdentity;
            var role = ident.RoleClaimType;
            if (role.Equals("admin"))
            {
                return Redirect("/Admin");
            }
            else if(role.Equals("employee"))
            {
                return Redirect("/Emple");
            }
            else if(role.Equals("socio"))
            {
                return Redirect("/Socio");
            }
            return View();
        }

        [Authorize, Route("/DeniedPermission")]
        public IActionResult DeniedPermission()
        {
            return View();
        }
        
        [Route("/SingOut")]
        public IActionResult SingOut()
        {
            HttpContext.SignOutAsync("Cookies");
            return Redirect("/");
        }
    }
}