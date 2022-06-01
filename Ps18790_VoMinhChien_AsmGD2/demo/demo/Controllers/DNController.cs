using demo.Models;
using demo.TienIch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace demo.Controllers
{
    public class DNController : Controller
    {
        private readonly C4Context context;

        public DNController(C4Context context)
        {
            this.context = context;
        }
       // [Route("/")]
        public IActionResult Index()
        {
            var user = Session.GetSessionData<KhachHang>(HttpContext.Session, "user");

            ViewBag.user = user;

           return View();
        }
        public IActionResult KhHang()
        {
            var user = Session.GetSessionData<KhachHang>(HttpContext.Session, "user");

            ViewBag.user = user;

            return View();
        }

        [Route("/dangnhap")]
        public IActionResult DangNhap()
        {
            return View();
        }

       [Route("/dangnhap")]
        [HttpPost]
        public async Task<IActionResult> DangNhap(KhachHang user)
        {
            if (ModelState.IsValid)
            {

                var existsEmail = await context.KhachHang
                    .SingleOrDefaultAsync(u => u.Email == user.Email && u.MatKhau == user.MatKhau);

                if (existsEmail != null)
                {

                    Session.SetSessionData(HttpContext.Session, "user", user);

                    TempData["alert"] = Alert.ShowAlert(Alerts.Success, "Đăng nhập thành công");

                    Session.SetSessionData(HttpContext.Session, "user", user);

                    TempData["alert"] = Alert.ShowAlert(Alerts.Success, "Đăng nhập thành công");
                    if (existsEmail.VaiTro == 0)
                    {
                        return RedirectToAction("KhHang");
                    }
                    else if (existsEmail.VaiTro == 1)
                    {
                        return RedirectToAction("index");
                    }
                }

                TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Email hoặc mật khẩu không chính xác");

                return View(user);
            }

            return View(user);
        }

        [Route("/dangky")]
        public IActionResult DangKy()
        {
            return View();
        }

       [Route("/dangky")]
        [HttpPost]
        public async Task<IActionResult> DangKy(KhachHang user)
        {
            if (ModelState.IsValid)
            {

                var existsEmail = await context.KhachHang
                    .SingleOrDefaultAsync(u => u.Email == user.Email);

                if (existsEmail == null)
                {
                    var newUser = new KhachHang
                    {
                        Email = user.Email,
                        MatKhau = user.MatKhau
                    };

                    await context.KhachHang.AddAsync(newUser);
                    await context.SaveChangesAsync();

                    TempData["alert"] = Alert
                        .ShowAlert(Alerts.Success, "Đăng ký thành công");

                    return RedirectToAction("DangNhap");
                }


                TempData["alert"] = Alert
                        .ShowAlert(Alerts.Danger, "Email đã tồn tại");

                return View(user);
            }

            return View(user);
        }
        public IActionResult giaodien()
        {
            return View();
        }
    }

}
