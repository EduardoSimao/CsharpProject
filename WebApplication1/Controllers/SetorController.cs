using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SetorController : Controller
    {
        private readonly Context _context;

        public SetorController(Context context)
        {
            _context = context;
        }

        // GET: Setor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Setores.ToListAsync());

        }


        // GET: Setor/Create
        public IActionResult Create(int id = 0)
        {
            if (id == 0)
                return View(new Setor());
            else
                return View(_context.Setores.Find(id));

        }

        // POST: Setor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SetorID,Descricao,Situacao")] Setor setor)
        {
            if (ModelState.IsValid)
            {
                if (setor.SetorID == 0)
                    _context.Add(setor);
                else
                    _context.Update(setor);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(setor);
        }

        // GET: Setor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var setor = await _context.Setores.FindAsync(id);
            _context.Setores.Remove(setor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}
