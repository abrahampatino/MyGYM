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
    public class MobiliariosController : Controller
    {
        private readonly db_gym_webContext _context;

        public MobiliariosController(db_gym_webContext context)
        {
            _context = context;
        }

        // GET: Mobiliarios
        [Route("/Admin/Mobiliario"), Authorize]
        public async Task<IActionResult> Index()
        {
            var db_gym_webContext = _context.Mobiliario.Include(m => m.Apa).OrderBy(m=>m.MobApaNombre);
            return View(await db_gym_webContext.ToListAsync());
        }

        // GET: Mobiliarios/Create
        [Authorize, Route("/Admin/Mobiliario/Create")]
        public IActionResult Create()
        {
            ViewData["ApaId"] = new SelectList(_context.Aparato, "ApaId", "ApaNombre");
            return View();
        }

        // POST: Mobiliarios/Create
        [HttpPost]
        [Authorize, Route("/Admin/Mobiliario/Create")]
        public async Task<IActionResult> Create([Bind("MobId,ApaId,MobApaNombre,ApaEstatus")] Mobiliario mobiliario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mobiliario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApaId"] = new SelectList(_context.Aparato, "ApaId", "ApaNombre", mobiliario.ApaId);
            return View(mobiliario);
        }

        // GET: Mobiliarios/Edit/5
        [Authorize, Route("/Admin/Mobiliario/Edit/{id}")]
        public async Task<IActionResult> Edit(int  id)
        {
            var mobiliario =  await _context.Mobiliario.Where(s => s.MobId == id).SingleAsync();
            if (mobiliario == null)
            {
                return NotFound();
            }
            ViewData["ApaId"] = new SelectList(_context.Aparato, "ApaId", "ApaNombre", mobiliario.ApaId);
            return View(mobiliario);
        }

        // POST: Mobiliarios/Edit/5
        [HttpPost]
        [Authorize, Route("/Admin/Mobiliario/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("MobId,ApaId,MobApaNombre,ApaEstatus")] Mobiliario mobiliario)
        {
            if (id != mobiliario.MobId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mobiliario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MobiliarioExists(mobiliario.MobId))
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
            ViewData["ApaId"] = new SelectList(_context.Aparato, "ApaId", "ApaNombre", mobiliario.ApaId);
            return View(mobiliario);
        }

        // GET: Mobiliarios/Delete/5
        [Authorize, Route("/Admin/Mobiliario/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mobiliario = await _context.Mobiliario
                .Include(m => m.Apa)
                .FirstOrDefaultAsync(m => m.MobId == id);
            if (mobiliario == null)
            {
                return NotFound();
            }

            return View(mobiliario);
        }

        // POST: Mobiliarios/Delete/5
        [HttpPost, Route("/Admin/Mobiliario/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mobiliario = await _context.Mobiliario.Where(m => m.MobId == id).SingleAsync();
            _context.Mobiliario.Remove(mobiliario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MobiliarioExists(int id)
        {
            return _context.Mobiliario.Any(e => e.MobId == id);
        }
    }
}
