using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyectov1.Data;
using Proyectov1.Models;

namespace Proyectov1.Areas.Administrador.Controllers
{
    [Area("Administrador"), Authorize]
    public class EmpleadosController : Controller
    {
        private readonly db_gym_webContext _context;

        public EmpleadosController(db_gym_webContext context)
        {
            _context = context;
        }

        // GET: Personas
        [Route("/Admin/Empleados")]
        public async Task<IActionResult> Index()
        {
            var db_gym_webContext = _context.Persona.Include(p => p.Usu).Where(p => p.PerTipo == "2").OrderBy(p => p.PerNombre);
            return View(await db_gym_webContext.ToListAsync());
        }

        // GET: Personas/Create
        [Route("/Admin/Empleados/Create")]
        public IActionResult Create()
        {
            ViewData["UsuId"] = new SelectList(_context.Usuario, "UsuId", "UsuName");
            return View();
        }

        // POST: Personas/Create
        [HttpPost, Route("/Admin/Empleados/Create")]
        public async Task<IActionResult> Create([Bind("PerId,PerNombre,PerNombre2,PerPaterno,PerMaterno,PerTipo,UsuId,EmpRfc,EmpImss,Usu")] Persona persona)
       {
            if (ModelState.IsValid)
            {

                await _context.Usuario.AddAsync(persona.Usu);
                await _context.SaveChangesAsync();
                var user_id = await _context.Usuario.Where(u => u.UsuName == persona.Usu.UsuName).FirstAsync();
                await _context.Rol.AddAsync(new Rol() { RolSocio = false, RolEmployee = true, RolAdmin = false, UsuId = user_id.UsuId });
                persona.PerTipo = "2";
                persona.UsuId = user_id.UsuId;
                _context.Persona.Add(persona);
                await _context.SaveChangesAsync();
                Correo.EmailSend("Alta de Usuario", persona);
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuId"] = new SelectList(_context.Usuario, "UsuId", "UsuName", persona.UsuId);
            return View(persona);
        }

        // GET: Personas/Edit/5
        [Route("/Admin/Empleados/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona.Where(p=>p.PerId == id.Value).Include(p => p.Usu).FirstOrDefaultAsync();
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        [HttpPost, Route("/Admin/Empleados/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("PerId,PerNombre,PerNombre2,PerPaterno,PerMaterno,PerTipo,UsuId,EmpRfc,EmpImss,PerEstado,Usu")] Persona persona)
        {
            if (id != persona.PerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);

                    await _context.SaveChangesAsync();
                    Correo.EmailSend("Modificacion de Usuario", persona);
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

        // GET: Personas/Delete/5
        [Route("/Admin/Empleados/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Persona
                .Include(p => p.Usu)
                .FirstOrDefaultAsync(m => m.PerId == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, Route("/Admin/Empleados/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.Persona.Where(p => p.PerId == id).Include(p => p.Usu).SingleAsync();
            var rol = await _context.Rol.Where(r => r.UsuId == persona.UsuId).SingleAsync();
            _context.Persona.Remove(persona);
            _context.Rol.Remove(rol);
            _context.Usuario.Remove(persona.Usu);
            await _context.SaveChangesAsync();
            Correo.EmailSend("Baja de Usuario", persona);
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.Persona.Any(e => e.PerId == id);
        }
    }
}
