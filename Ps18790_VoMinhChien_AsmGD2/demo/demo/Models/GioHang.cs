using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace demo.Models
{
    public partial class GioHang
    {
        public GioHang()
        {
            ChiTietGioHang = new HashSet<ChiTietGioHang>();
        }

        public int MaGioHang { get; set; }
        public int? MaKhachHang { get; set; }
        public string ThanhTien { get; set; }
        public string ThueVat { get; set; }
        public string TongTien { get; set; }
        public bool? TrangThai { get; set; }

        public virtual KhachHang MaKhachHangNavigation { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHang { get; set; }
    }
}
