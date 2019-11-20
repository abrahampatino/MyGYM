using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyectov1.Data;

namespace Proyectov1.Areas.Administrador.Controllers
{
    [Area("Administrador"), Authorize]
    public class AdminController : Controller
    {
        // GET: AdminD:\User\Desktop\Proyectov1\Areas\Administrador\Controllers\AdminController.cs
        private readonly db_gym_webContext _context;
        public AdminController(db_gym_webContext context)
        {
            _context = context;
        }
        
        [Route("Admin")]
        public ActionResult Index()
        {
            var ident = User.Identity as ClaimsIdentity;
            var role = ident.RoleClaimType;

            if(role.Equals("admin"))
            {
                return View();
            }
            else
            {
                return Redirect("/DeniedPermission");
            }
        }

    }
}