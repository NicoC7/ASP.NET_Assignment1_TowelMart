﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TowelMart.Data;
using TowelMart.Models;

namespace TowelMart.Controllers
{
    public class TowelsController : Controller
    {
        private readonly TowelMartContext _context;

        public TowelsController(TowelMartContext context)
        {
            _context = context;
        }

        // GET: Towels
        public async Task<IActionResult> Index(string towelSize, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> sizeQuery = from t in _context.Towel
                                           orderby t.Size
                                           select t.Size;

            var towels = from t in _context.Towel
                         select t;

            if (!string.IsNullOrEmpty(searchString))
            {
                towels = towels.Where(s => s.Color.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(towelSize))
            {
                towels = towels.Where(x => x.Size == towelSize);
            }

            var towelSizeVM = new TowelSizeViewModel
            {
                Sizes = new SelectList(await sizeQuery.Distinct().ToListAsync()),
                Towels = await towels.ToListAsync()
            };

            return View(towelSizeVM);
        }


        
         //Last Code Working
         /*
          public async Task<IActionResult> Index(string searchString)
        {
            var towels = from t in _context.Towel
                         select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                towels = towels.Where(s => s.Color.Contains(searchString));
            }

            return View(await towels.ToListAsync());
        }
        */
        

        // GET: Towels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var towel = await _context.Towel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (towel == null)
            {
                return NotFound();
            }

            return View(towel);
        }

        // GET: Towels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Towels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Color,ReleaseDate,Size,Price,StockQuantity,Material,Brand,ImageUrl")] Towel towel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(towel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(towel);
        }

        // GET: Towels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var towel = await _context.Towel.FindAsync(id);
            if (towel == null)
            {
                return NotFound();
            }
            return View(towel);
        }

        // POST: Towels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Color,ReleaseDate,Size,Price,StockQuantity,Material,Brand,ImageUrl")] Towel towel)
        {
            if (id != towel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(towel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TowelExists(towel.Id))
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
            return View(towel);
        }

        // GET: Towels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var towel = await _context.Towel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (towel == null)
            {
                return NotFound();
            }

            return View(towel);
        }

        // POST: Towels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var towel = await _context.Towel.FindAsync(id);
            _context.Towel.Remove(towel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TowelExists(int id)
        {
            return _context.Towel.Any(e => e.Id == id);
        }
    }
}
