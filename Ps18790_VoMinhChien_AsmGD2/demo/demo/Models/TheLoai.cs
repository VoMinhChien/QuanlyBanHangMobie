using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace demo.Models
{
    public partial class TheLoai
    {
        public TheLoai()
        {
            SanPham = new HashSet<SanPham>();
        }

        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public bool? Isdelete { get; set; }

        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
