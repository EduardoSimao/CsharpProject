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
    public class IndicadorController : Controller
    {
        private readonly Context _context;

        public IndicadorController(Context context)
        {
            _context = context;
        }

        // GET: Indicador
        public async Task<IActionResult> Index()
        {

            return View(await _context.Indicadores.ToListAsync());
        }


        // GET: Indicador/Create
        public IActionResult Create(int id = 0)
        {
            ViewBag.SetorList = _context.Setores.Select(c => new SelectListItem { Value = c.SetorID.ToString(), Text = c.Descricao }).ToList();

            if (id == 0)
            {

                return View(new Indicador());
            }
            else
            {

                return View(_context.Indicadores.Find(id));
            }

        }

        // POST: Indicador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IndicadorId,Descricao,Situacao,SetorID")] Indicador indicador)
        {
            if (ModelState.IsValid)
            {

                if (indicador.IndicadorId == 0)
                    _context.Add(indicador);

                else
                    _context.Update(indicador);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception err)
                {

                }
                return RedirectToAction(nameof(Index));


            }
            return View(indicador);
        }

        
        // GET: Indicador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var indicador = await _context.Indicadores.FindAsync(id);
            _context.Indicadores.Remove(indicador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

    }
}
