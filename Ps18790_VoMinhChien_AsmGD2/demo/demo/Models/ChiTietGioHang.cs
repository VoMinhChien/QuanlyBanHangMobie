using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace demo.Models
{
    public partial class ChiTietGioHang
    {
        public int MaChiTietGioHang { get; set; }
        public int? MaGioHang { get; set; }
        public int? MaSanPham { get; set; }
        public int? SoLuong { get; set; }

        public virtual GioHang MaGioHangNavigation { get; set; }
        public virtual SanPham MaSanPhamNavigation { get; set; }
    }
}
