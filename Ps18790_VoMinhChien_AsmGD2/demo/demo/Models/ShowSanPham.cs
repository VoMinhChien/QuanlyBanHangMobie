namespace demo.Models
{
    public partial class ShowSanPham
    {
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
        
       
    }
}
