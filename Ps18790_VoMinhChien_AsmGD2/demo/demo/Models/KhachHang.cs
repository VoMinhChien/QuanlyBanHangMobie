using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace demo.Models
{
    public partial class KhachHang
    {
        //public KhachHang()
        //{
        //    GioHang = new HashSet<GioHang>();
        //}
        [Key]
        public int MaKhachHang { get; set; }
        
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [StringLength(maximumLength: 255, MinimumLength = 10, ErrorMessage = "Nhập email từ 10 - 255 kí tự")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(maximumLength: 255, MinimumLength = 6, ErrorMessage = "Nhập mật khẩu từ 6 - 255 kí tự")]
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public int? VaiTro { get; set; }
       
        public bool? Isdelete { get; set; }

        public virtual GopY GopY { get; set; }
        public virtual ICollection<GioHang> GioHang { get; set; }
    }
}
