using demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace demo.Controllers
{
    public class ShowGioHangController : Controller
    {
        private readonly C4Context _context;

        public ShowGioHangController(C4Context context)
        {
            _context = context;
        }
        public SanPham Find(int id)
        {
            var a = _context.SanPham.Find(id);
            return a;
        }
        [Route("index")]

        public IActionResult Index()
        {
            var cart = SessionExtensions.GetobjectFromJson<List<Items>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;

            if (cart != null)
            {
                ViewBag.total = cart.Sum(item => double.Parse(item.sp.GiaSanPham) * item.SoLuong);
            }


            return View();
        }
        private int isExist(int id)
        {
            List<Items> cart = SessionExtensions.GetobjectFromJson<List<Items>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].sp.MaSanPham.Equals(id))
                {
                    return i;
                }  
            }
            return -1;
        }
        [Route("buy/{id}")]
        public IActionResult buy(int id)
        {
            if (SessionExtensions.GetobjectFromJson<List<Items>>(HttpContext.Session, "cart") == null)
            {
                List<Items> cart = new List<Items>();
                cart.Add(new Items
                {
                    sp = Find(id),
                    SoLuong = 1
                });
                SessionExtensions.SetobjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Items> cart = SessionExtensions.
                                 GetobjectFromJson<List<Items>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].SoLuong++;
                }
                else
                {
                    cart.Add(new Items
                    {
                        sp = Find(id),
                        SoLuong = 1
                    });
                }
                SessionExtensions.SetobjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");

        }
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<Items> cart = SessionExtensions.GetobjectFromJson<List<Items>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionExtensions.SetobjectAsJson(HttpContext.Session,"cart", cart);
            return RedirectToAction("Index");
        }
    }
}
