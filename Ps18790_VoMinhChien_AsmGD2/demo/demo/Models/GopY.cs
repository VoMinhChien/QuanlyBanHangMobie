using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace demo.Models
{
    public partial class GopY
    {
        public int MaKhachHang { get; set; }
        public string ChuDe { get; set; }
        public string NoiDung { get; set; }

        public virtual KhachHang MaKhachHangNavigation { get; set; }
    }
}
