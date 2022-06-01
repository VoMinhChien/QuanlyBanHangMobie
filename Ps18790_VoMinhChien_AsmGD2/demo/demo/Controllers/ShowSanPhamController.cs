using demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Controllers
{
    public class ShowSanPhamController : Controller
    {
        private readonly C4Context context;

        public ShowSanPhamController(C4Context context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index(int MaTheLoai)
        {
            var sanPhamTheoMa = await context.SanPhams.Where(s => s.MaTheLoai == MaTheLoai).ToListAsync();

            ViewBag.SanPhams = sanPhamTheoMa;
            return View();
        }


        [Route("/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var currentProduct = await context.SanPhams.SingleAsync(p => p.MaSanPham == id  );
            

            ViewBag.CurrentProduct = currentProduct;
            return View();
        }


    }
}
