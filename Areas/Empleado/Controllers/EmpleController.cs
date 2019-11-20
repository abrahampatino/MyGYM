using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyectov1.Data;
using Proyectov1.Models;

namespace Proyectov1.Areas.Empleado.Controllers
{
    [Area("Empleado"), Authorize]
    public class EmpleController : Controller
    {
        // GET: AdminD:\User\Desktop\Proyectov1\Areas\Administrador\Controllers\AdminController.cs
        private readonly db_gym_webContext _context;
        public EmpleController(db_gym_webContext context)
        {
            _context = context;
        }
        
        [Route("Emple")]
        public IActionResult Index()
        {
            var ident = User.Identity as ClaimsIdentity;
            var role = ident.RoleClaimType;

            if(role.Equals("admin") || role.Equals("employee"))
            {
                return View();
            }
            else
            {
                return Redirect("/DeniedPermission");
            }
        }

        [Route("Emple/MiPerfil")]
        public IActionResult MiPerfil()
        {
            var name = User.Identity.Name;
            var persona = _context.Persona.Include(p => p.Usu).Where(p => p.Usu.UsuName == name).Single();
            ViewData["numsocios"] = _context.Persona.Where(s => s.InsoInst == persona.PerId && persona.PerEstado.Value).CountAsync().Result;
            return View(persona);
        }

        [Route("Emple/MisSocios")]
        public IActionResult MisSocios()
        {
            var name = User.Identity.Name;
            var persona = _context.Persona.Include(p => p.Usu).Where(p => p.Usu.UsuName == name).Single();
            var personas = _context.Persona.Where(p => p.InsoInst == persona.PerId && persona.PerEstado.Value);
            ViewData["numsocios"] = _context.Persona.Where(s => s.InsoInst == persona.PerId && persona.PerEstado.Value).CountAsync().Result;
            return View(personas);
        }

        [Route("Emple/MisSocios/Edit/{id}")]
        public async Task<IActionResult> Edit(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var persona = await _context.Persona.Where(p => p.PerId == id.Value).Include(p => p.Usu).FirstOrDefaultAsync();
            ViewData["Instru"] = _context.Persona.Where(p => p.PerTipo == "2").OrderBy(p => p.PerNombre).ToList();
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        [HttpPost, Route("Emple/MisSocios/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("PerId,SocTelefono,SocPeso,SocAltura")] Persona persona)
        {
            if (id != persona.PerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var person = await _context.Persona.Where(p => p.PerId == persona.PerId).Include(p=>p.Usu).SingleAsync();
                    person.SocAltura = persona.SocAltura;
                    person.SocPeso = persona.SocPeso;
                    person.SocTelefono = persona.SocTelefono;
                    _context.Update(person);

                    await _context.SaveChangesAsync();
                    //Correo.EmailSend("Modificacion de Usuario", person);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.PerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuId"] = new SelectList(_context.Usuario, "UsuId", "UsuName", persona.UsuId);
            return View(persona);
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.PerId == id);
        }
    }
}