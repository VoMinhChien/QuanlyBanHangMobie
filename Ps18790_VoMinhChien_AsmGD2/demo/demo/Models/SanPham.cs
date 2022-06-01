using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace demo.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietGioHang = new HashSet<ChiTietGioHang>();
        }

        public int MaSanPham { get; set; }
        public string HinhAnh { get; set; }
        public string TenSanPham { get; set; }
        public string GiaSanPham { get; set; }
        public bool? TinhTrang { get; set; }
        public int? MaTheLoai { get; set; }
        public string ThongTin { get; set; }
        public string Khac { get; set; }
        public bool? Isdelete { get; set; }

        public virtual TheLoai MaTheLoaiNavigation { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHang { get; set; }
    }
}
