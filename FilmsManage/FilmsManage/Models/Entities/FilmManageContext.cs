using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FilmsManage.Models.Entities;

public partial class FilmManageContext : DbContext
{
    public FilmManageContext()
    {
    }

    public FilmManageContext(DbContextOptions<FilmManageContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DangPhim> DangPhims { get; set; }

    public virtual DbSet<DanhSachDatVeOnline> DanhSachDatVeOnlines { get; set; }

    public virtual DbSet<Ghe> Ghes { get; set; }

    public virtual DbSet<Gium> Gia { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiGhe> LoaiGhes { get; set; }

    public virtual DbSet<LoaiPhim> LoaiPhims { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Phim> Phims { get; set; }

    public virtual DbSet<PhongChieu> PhongChieus { get; set; }

    public virtual DbSet<QuocGium> QuocGia { get; set; }

    public virtual DbSet<Quyen> Quyens { get; set; }

    public virtual DbSet<TinhTrang> TinhTrangs { get; set; }

    public virtual DbSet<Ve> Ves { get; set; }

    public virtual DbSet<XuatChieu> XuatChieus { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=HAIDANG\\SQLEXPRESS;Initial Catalog=FilmManage;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DangPhim>(entity =>
        {
            entity.HasKey(e => e.MaDangPhim).HasName("PK__DangPhim__D957C0F546179B05");

            entity.ToTable("DangPhim");

            entity.Property(e => e.TenDangPhim).HasMaxLength(255);
        });

        modelBuilder.Entity<DanhSachDatVeOnline>(entity =>
        {
            entity.HasKey(e => e.MaDatVe).HasName("PK__DanhSach__6A32C5930DA14948");

            entity.ToTable("DanhSachDatVeOnline");

            entity.Property(e => e.TrangThaiDatVe).HasMaxLength(255);

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.DanhSachDatVeOnlines)
                .HasForeignKey(d => d.MaKhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DanhSachD__MaKha__6477ECF3");

            entity.HasOne(d => d.MaPhimNavigation).WithMany(p => p.DanhSachDatVeOnlines)
                .HasForeignKey(d => d.MaPhim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DanhSachD__MaPhi__66603565");

            entity.HasOne(d => d.MaXuatChieuNavigation).WithMany(p => p.DanhSachDatVeOnlines)
                .HasForeignKey(d => d.MaXuatChieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DanhSachD__MaXua__656C112C");
        });

        modelBuilder.Entity<Ghe>(entity =>
        {
            entity.HasKey(e => e.SoGhe).HasName("PK__Ghe__278288CB16928A46");

            entity.ToTable("Ghe");

            entity.HasOne(d => d.MaLoaiGheNavigation).WithMany(p => p.Ghes)
                .HasForeignKey(d => d.MaLoaiGhe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ghe__MaLoaiGhe__412EB0B6");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.Ghes)
                .HasForeignKey(d => d.MaPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ghe__MaPhong__3F466844");

            entity.HasOne(d => d.MaTinhTrangNavigation).WithMany(p => p.Ghes)
                .HasForeignKey(d => d.MaTinhTrang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ghe__MaTinhTrang__403A8C7D");
        });

        modelBuilder.Entity<Gium>(entity =>
        {
            entity.HasKey(e => e.MaGia).HasName("PK__Gia__3CD3DE5EB0D2BF28");

            entity.Property(e => e.SoTien).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.IdLoaiGheNavigation).WithMany(p => p.Gia)
                .HasForeignKey(d => d.IdLoaiGhe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Gia__IdLoaiGhe__5070F446");

            entity.HasOne(d => d.MaDangPhimNavigation).WithMany(p => p.Gia)
                .HasForeignKey(d => d.MaDangPhim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Gia__MaDangPhim__4F7CD00D");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__KhachHan__88D2F0E510DA4305");

            entity.ToTable("KhachHang");

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.MatKhau).HasMaxLength(100);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenDangNhap).HasMaxLength(100);
        });

        modelBuilder.Entity<LoaiGhe>(entity =>
        {
            entity.HasKey(e => e.MaLoaiGhe).HasName("PK__LoaiGhe__965BB4C12F1C44A0");

            entity.ToTable("LoaiGhe");

            entity.Property(e => e.TenLoaiGhe).HasMaxLength(255);
        });

        modelBuilder.Entity<LoaiPhim>(entity =>
        {
            entity.HasKey(e => e.MaLoaiPhim).HasName("PK__LoaiPhim__9CA05BEF82C8524C");

            entity.ToTable("LoaiPhim");

            entity.Property(e => e.TenLoaiPhim).HasMaxLength(255);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdNhanVien).HasName("PK__NhanVien__B8294845AF983CE7");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MatKhau).HasMaxLength(100);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.TenDangNhap).HasMaxLength(100);
            entity.Property(e => e.TenNhanVien).HasMaxLength(255);

            entity.HasOne(d => d.MaQuyenNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaQuyen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NhanVien__MaQuye__45F365D3");
        });

        modelBuilder.Entity<Phim>(entity =>
        {
            entity.HasKey(e => e.MaPhim).HasName("PK__Phim__4AC03DE3F8A39BFC");

            entity.ToTable("Phim");

            entity.Property(e => e.AnhDaiDien).HasMaxLength(255);
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.MoTaPhim).HasMaxLength(255);
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.NoiDungPhim).HasMaxLength(255);

            entity.HasOne(d => d.IdQuocGiaNavigation).WithMany(p => p.Phims)
                .HasForeignKey(d => d.IdQuocGia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__IdQuocGia__5DCAEF64");

            entity.HasOne(d => d.MaDangPhimNavigation).WithMany(p => p.Phims)
                .HasForeignKey(d => d.MaDangPhim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaDangPhim__5CD6CB2B");

            entity.HasOne(d => d.MaLoaiPhimNavigation).WithMany(p => p.Phims)
                .HasForeignKey(d => d.MaLoaiPhim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaLoaiPhim__5BE2A6F2");

            entity.HasOne(d => d.MaXuatChieuNavigation).WithMany(p => p.Phims)
                .HasForeignKey(d => d.MaXuatChieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaXuatChie__5AEE82B9");
        });

        modelBuilder.Entity<PhongChieu>(entity =>
        {
            entity.HasKey(e => e.IdPhongChieu).HasName("PK__PhongChi__77D0B8D0054529AF");

            entity.ToTable("PhongChieu");

            entity.Property(e => e.TenPhongChieu).HasMaxLength(255);
        });

        modelBuilder.Entity<QuocGium>(entity =>
        {
            entity.HasKey(e => e.IdQuocGia).HasName("PK__QuocGia__DEA34C5EEEF471EE");

            entity.Property(e => e.TenNuoc).HasMaxLength(255);
        });

        modelBuilder.Entity<Quyen>(entity =>
        {
            entity.HasKey(e => e.MaQuyen).HasName("PK__Quyen__1D4B7ED4FB81CA68");

            entity.ToTable("Quyen");

            entity.Property(e => e.TenQuyen).HasMaxLength(255);
        });

        modelBuilder.Entity<TinhTrang>(entity =>
        {
            entity.HasKey(e => e.MaTinhTrang).HasName("PK__TinhTran__89F8F6696FF2807B");

            entity.ToTable("TinhTrang");

            entity.Property(e => e.TenTinhTrang).HasMaxLength(255);
        });

        modelBuilder.Entity<Ve>(entity =>
        {
            entity.HasKey(e => e.IdVe).HasName("PK__Ve__B7700A99C0B63D61");

            entity.ToTable("Ve");

            entity.Property(e => e.DonGia).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.Ves)
                .HasForeignKey(d => d.IdNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__IdNhanVien__6B24EA82");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.Ves)
                .HasForeignKey(d => d.MaPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaPhong__693CA210");

            entity.HasOne(d => d.MaXuatChieuNavigation).WithMany(p => p.Ves)
                .HasForeignKey(d => d.MaXuatChieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaXuatChieu__6A30C649");

            entity.HasOne(d => d.SoGheNavigation).WithMany(p => p.Ves)
                .HasForeignKey(d => d.SoGhe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__SoGhe__6C190EBB");
        });

        modelBuilder.Entity<XuatChieu>(entity =>
        {
            entity.HasKey(e => e.MaXuatChieu).HasName("PK__XuatChie__46080F55184DA7E3");

            entity.ToTable("XuatChieu");

            entity.HasOne(d => d.IdPhongChieuNavigation).WithMany(p => p.XuatChieus)
                .HasForeignKey(d => d.IdPhongChieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__XuatChieu__IdPho__4BAC3F29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
