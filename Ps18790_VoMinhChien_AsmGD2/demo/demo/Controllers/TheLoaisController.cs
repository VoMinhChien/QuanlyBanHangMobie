﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using demo.Models;

namespace demo.Controllers
{
    public class TheLoaisController : Controller
    {
        private readonly C4Context _context;

        public TheLoaisController(C4Context context)
        {
            _context = context;
        }

        // GET: TheLoais
        public async Task<IActionResult> Index()
        {
            return View(await _context.TheLoai.ToListAsync());
        }

        // GET: TheLoais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theLoai = await _context.TheLoai
                .FirstOrDefaultAsync(m => m.MaTheLoai == id);
            if (theLoai == null)
            {
                return NotFound();
            }

            return View(theLoai);
        }

        // GET: TheLoais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TheLoais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTheLoai,TenTheLoai,Isdelete")] TheLoai theLoai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theLoai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theLoai);
        }

        // GET: TheLoais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theLoai = await _context.TheLoai.FindAsync(id);
            if (theLoai == null)
            {
                return NotFound();
            }
            return View(theLoai);
        }

        // POST: TheLoais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTheLoai,TenTheLoai,Isdelete")] TheLoai theLoai)
        {
            if (id != theLoai.MaTheLoai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theLoai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheLoaiExists(theLoai.MaTheLoai))
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
            return View(theLoai);
        }

        // GET: TheLoais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theLoai = await _context.TheLoai
                .FirstOrDefaultAsync(m => m.MaTheLoai == id);
            if (theLoai == null)
            {
                return NotFound();
            }

            return View(theLoai);
        }

        // POST: TheLoais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var theLoai = await _context.TheLoai.FindAsync(id);
            _context.TheLoai.Remove(theLoai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheLoaiExists(int id)
        {
            return _context.TheLoai.Any(e => e.MaTheLoai == id);
        }
    }
}
