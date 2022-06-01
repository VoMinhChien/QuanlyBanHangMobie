using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using demo.Models;

namespace demo.Controllers
{
    public class ChiTietGioHangsController : Controller
    {
        private readonly C4Context _context;

        public ChiTietGioHangsController(C4Context context)
        {
            _context = context;
        }

        // GET: ChiTietGioHangs
        public async Task<IActionResult> Index()
        {
            var c4Context = _context.ChiTietGioHang.Include(c => c.MaGioHangNavigation).Include(c => c.MaSanPhamNavigation);
            return View(await c4Context.ToListAsync());
        }

        // GET: ChiTietGioHangs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietGioHang = await _context.ChiTietGioHang
                .Include(c => c.MaGioHangNavigation)
                .Include(c => c.MaSanPhamNavigation)
                .FirstOrDefaultAsync(m => m.MaChiTietGioHang == id);
            if (chiTietGioHang == null)
            {
                return NotFound();
            }

            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHangs/Create
        public IActionResult Create()
        {
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang");
            ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "MaSanPham");
            return View();
        }

        // POST: ChiTietGioHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaChiTietGioHang,MaGioHang,MaSanPham,SoLuong")] ChiTietGioHang chiTietGioHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chiTietGioHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang", chiTietGioHang.MaGioHang);
            ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "MaSanPham", chiTietGioHang.MaSanPham);
            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietGioHang = await _context.ChiTietGioHang.FindAsync(id);
            if (chiTietGioHang == null)
            {
                return NotFound();
            }
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang", chiTietGioHang.MaGioHang);
            ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "MaSanPham", chiTietGioHang.MaSanPham);
            return View(chiTietGioHang);
        }

        // POST: ChiTietGioHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaChiTietGioHang,MaGioHang,MaSanPham,SoLuong")] ChiTietGioHang chiTietGioHang)
        {
            if (id != chiTietGioHang.MaChiTietGioHang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietGioHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietGioHangExists(chiTietGioHang.MaChiTietGioHang))
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
            ViewData["MaGioHang"] = new SelectList(_context.GioHang, "MaGioHang", "MaGioHang", chiTietGioHang.MaGioHang);
            ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "MaSanPham", chiTietGioHang.MaSanPham);
            return View(chiTietGioHang);
        }

        // GET: ChiTietGioHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chiTietGioHang = await _context.ChiTietGioHang
                .Include(c => c.MaGioHangNavigation)
                .Include(c => c.MaSanPhamNavigation)
                .FirstOrDefaultAsync(m => m.MaChiTietGioHang == id);
            if (chiTietGioHang == null)
            {
                return NotFound();
            }

            return View(chiTietGioHang);
        }

        // POST: ChiTietGioHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chiTietGioHang = await _context.ChiTietGioHang.FindAsync(id);
            _context.ChiTietGioHang.Remove(chiTietGioHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietGioHangExists(int id)
        {
            return _context.ChiTietGioHang.Any(e => e.MaChiTietGioHang == id);
        }
    }
}
