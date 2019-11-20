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
    public class AparatosController : Controller
    {
        private readonly db_gym_webContext _context;

        
        public AparatosController(db_gym_webContext context)
        {
            _context = context;
        }

        // GET: Aparatos
        [Route("/Admin/Aparatos"), Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aparato.OrderBy(a => a.ApaNombre).ToListAsync());
        }

        // GET: Aparatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aparato = await _context.Aparato
                .FirstOrDefaultAsync(m => m.ApaId == id);
            if (aparato == null)
            {
                return NotFound();
            }

            return View(aparato);
        }

        // GET: Aparatos/Create
        [Route("/Admin/Aparatos/Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Aparatos/Create
        [HttpPost, Route("/Admin/Aparatos/Create")]
        public async Task<IActionResult> Create([Bind("ApaId,ApaNombre,ApaDescripcion")] Aparato aparato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aparato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aparato);
        }

        // GET: Aparatos/Edit/5
        [Route("/Admin/Aparatos/Edit/{id}")]
        public async Task<IActionResult> Edit(int ? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aparato = await _context.Aparato.FindAsync(id);
            if (aparato == null)
            {
                return NotFound();
            }
            return View(aparato);
        }

        // POST: Aparatos/Edit/5
        [HttpPost, Route("/Admin/Aparatos/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("ApaId,ApaNombre,ApaDescripcion")] Aparato aparato)
        {
            if (id != aparato.ApaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aparato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AparatoExists(aparato.ApaId))
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
            return View(aparato);
        }

        // GET: Aparatos/Delete/5
        [Route("/Admin/Aparatos/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aparato = await _context.Aparato
                .FirstOrDefaultAsync(m => m.ApaId == id);
            if (aparato == null)
            {
                return NotFound();
            }

            return View(aparato);
        }

        // POST: Aparatos/Delete/5
        [HttpPost, Route("/Admin/Aparatos/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aparato = await _context.Aparato.FindAsync(id);
            _context.Aparato.Remove(aparato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AparatoExists(int id)
        {
            return _context.Aparato.Any(e => e.ApaId == id);
        }
    }
}
