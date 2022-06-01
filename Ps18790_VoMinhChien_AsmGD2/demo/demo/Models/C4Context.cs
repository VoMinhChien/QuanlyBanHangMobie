using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace demo.Models
{
    public partial class C4Context : DbContext
    {
        public DbSet<SanPham> SanPhams { get; set; }
        
        public C4Context()
        {
        }

        public C4Context(DbContextOptions<C4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietGioHang> ChiTietGioHang { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<GopY> GopY { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {

        //        optionsBuilder.UseSqlServer("Server=DESKTOP-P18IOHQ\\SQLEXPRESS;Database=C#4;Integrated Security=True");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietGioHang>(entity =>
            {
                entity.HasKey(e => e.MaChiTietGioHang)
                    .HasName("PK__ChiTietG__BBF474986E44601A");

                entity.HasOne(d => d.MaGioHangNavigation)
                    .WithMany(p => p.ChiTietGioHang)
                    .HasForeignKey(d => d.MaGioHang)
                    .HasConstraintName("FK__ChiTietGi__MaGio__2E1BDC42");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietGioHang)
                    .HasForeignKey(d => d.MaSanPham)
                    .HasConstraintName("FK__ChiTietGi__MaSan__2F10007B");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasKey(e => e.MaGioHang)
                    .HasName("PK__GioHang__F5001DA3613F4A6C");

                entity.Property(e => e.ThanhTien).HasMaxLength(100);

                entity.Property(e => e.ThueVat)
                    .HasColumnName("ThueVAT")
                    .HasMaxLength(100);

                entity.Property(e => e.TongTien).HasMaxLength(100);

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.GioHang)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK__GioHang__MaKhach__2B3F6F97");
            });

            modelBuilder.Entity<GopY>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__GopY__88D2F0E512CEA738");

                entity.Property(e => e.MaKhachHang).ValueGeneratedNever();

                entity.Property(e => e.ChuDe).HasMaxLength(50);

                entity.Property(e => e.NoiDung).HasMaxLength(500);

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithOne(p => p.GopY)
                    .HasForeignKey<GopY>(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GopY__MaKhachHan__31EC6D26");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E5218108F6");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.HoTen).HasMaxLength(500);

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.MatKhau).HasMaxLength(100);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D9BFE96B9");

                entity.Property(e => e.GiaSanPham).HasMaxLength(100);

                entity.Property(e => e.HinhAnh).HasMaxLength(100);

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.Khac).HasMaxLength(500);

                entity.Property(e => e.TenSanPham).HasMaxLength(200);

                entity.Property(e => e.ThongTin).HasMaxLength(1000);

                entity.HasOne(d => d.MaTheLoaiNavigation)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.MaTheLoai)
                    .HasConstraintName("FK__SanPham__MaTheLo__286302EC");
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.HasKey(e => e.MaTheLoai)
                    .HasName("PK__TheLoai__D73FF34AA32D7C64");

                entity.Property(e => e.Isdelete).HasColumnName("isdelete");

                entity.Property(e => e.TenTheLoai).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
