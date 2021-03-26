using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class QuanLyTrungTamContext : DbContext
    {
        public QuanLyTrungTamContext()
        {
        }

        public QuanLyTrungTamContext(DbContextOptions<QuanLyTrungTamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BangDiem> BangDiems { get; set; }
        public virtual DbSet<ChucNang> ChucNangs { get; set; }
        public virtual DbSet<CtHoaDon> CtHoaDons { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<DanhMucKhoaHoc> DanhMucKhoaHocs { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<GvDiemDanh> GvDiemDanhs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HocVien> HocViens { get; set; }
        public virtual DbSet<HvDiemDanh> HvDiemDanhs { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<LopHocTuan> LopHocTuans { get; set; }
        public virtual DbSet<PhuHuynh> PhuHuynhs { get; set; }
        public virtual DbSet<ThoiKhoaBieu> ThoiKhoaBieus { get; set; }
        public virtual DbSet<TrinhDo> TrinhDos { get; set; }
        public virtual DbSet<Tuan> Tuans { get; set; }
        public virtual DbSet<VaiTro> VaiTros { get; set; }
        public virtual DbSet<VaiTroChucNang> VaiTroChucNangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=IT-TAMLV\\SQLEXPRESS;Initial Catalog=QuanLyTrungTam;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BangDiem>(entity =>
            {
                entity.HasKey(e => e.MaBangDiem);

                entity.ToTable("BangDiem");

                entity.Property(e => e.KetQua).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kt1)
                    .HasColumnName("KT1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kt2)
                    .HasColumnName("KT2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Thil1)
                    .HasColumnName("THIL1")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MaHocVienNavigation)
                    .WithMany(p => p.BangDiems)
                    .HasForeignKey(d => d.MaHocVien)
                    .HasConstraintName("FK_BangDiem_HocVien1");

                entity.HasOne(d => d.MaLopHocNavigation)
                    .WithMany(p => p.BangDiems)
                    .HasForeignKey(d => d.MaLopHoc)
                    .HasConstraintName("FK_BangDiem_LopHoc");
            });

            modelBuilder.Entity<ChucNang>(entity =>
            {
                entity.HasKey(e => e.MaChucNang);

                entity.ToTable("ChucNang");

                entity.Property(e => e.MaChucNang).HasMaxLength(50);

                entity.Property(e => e.TenChucNang)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CtHoaDon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CT_HoaDon");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CT_HoaDon_HoaDon");

                entity.HasOne(d => d.MaKhoaHocNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaKhoaHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CT_HoaDon_KhoaHoc");
            });

            modelBuilder.Entity<DangNhap>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK_TaiKhoan");

                entity.ToTable("DangNhap");

                entity.Property(e => e.MaVaiTro).HasMaxLength(50);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaiKhoan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenNguoiDung).HasMaxLength(100);

                entity.HasOne(d => d.MaVaiTroNavigation)
                    .WithMany(p => p.DangNhaps)
                    .HasForeignKey(d => d.MaVaiTro)
                    .HasConstraintName("FK_DangNhap_VaiTro");
            });

            modelBuilder.Entity<DanhMucKhoaHoc>(entity =>
            {
                entity.HasKey(e => e.MaDanhMuc);

                entity.ToTable("DanhMucKhoaHoc");

                entity.Property(e => e.TenDanhMuc).HasMaxLength(100);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GiaoVien>(entity =>
            {
                entity.HasKey(e => e.MaGiaoVien);

                entity.ToTable("GiaoVien");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.MaGvdd).HasColumnName("MaGVDD");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.MucLuong)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Mức lương thể hiện tiền lương của giáo vien");

                entity.Property(e => e.NgayDangKy).HasColumnType("date");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.QuocTich).HasMaxLength(50);

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenGiaoVien).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MaGvddNavigation)
                    .WithMany(p => p.GiaoViens)
                    .HasForeignKey(d => d.MaGvdd)
                    .HasConstraintName("FK_GiaoVien_GV_DiemDanh");

                entity.HasOne(d => d.MaTrinhDoNavigation)
                    .WithMany(p => p.GiaoViens)
                    .HasForeignKey(d => d.MaTrinhDo)
                    .HasConstraintName("FK_GiaoVien_TrinhDo");
            });

            modelBuilder.Entity<GvDiemDanh>(entity =>
            {
                entity.HasKey(e => e.MaGvdd);

                entity.ToTable("GV_DiemDanh");

                entity.Property(e => e.MaGvdd).HasColumnName("MaGVDD");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.Tuan).HasColumnType("date");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon);

                entity.ToTable("HoaDon");

                entity.Property(e => e.NgayLap).HasColumnType("datetime");

                entity.Property(e => e.TongTien)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MaHocVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaHocVien)
                    .HasConstraintName("FK_HoaDon_HocVien1");

                entity.HasOne(d => d.MaLopHocNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaLopHoc)
                    .HasConstraintName("FK_HoaDon_LopHoc");
            });

            modelBuilder.Entity<HocVien>(entity =>
            {
                entity.HasKey(e => e.MaHocVien);

                entity.ToTable("HocVien");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.MaHvdd).HasColumnName("MaHVDD");

                entity.Property(e => e.MatKhau).HasMaxLength(100);

                entity.Property(e => e.NgayDangKy).HasColumnType("date");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Nguon).HasMaxLength(100);

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TaiKhoan).HasMaxLength(100);

                entity.Property(e => e.TenHocVien).HasMaxLength(100);

                entity.Property(e => e.TrangThai).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MaHvddNavigation)
                    .WithMany(p => p.HocViens)
                    .HasForeignKey(d => d.MaHvdd)
                    .HasConstraintName("FK_HocVien_HV_DiemDanh");
            });

            modelBuilder.Entity<HvDiemDanh>(entity =>
            {
                entity.HasKey(e => e.MaHvdd);

                entity.ToTable("HV_DiemDanh");

                entity.Property(e => e.MaHvdd).HasColumnName("MaHVDD");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.Tuan).HasColumnType("date");
            });

            modelBuilder.Entity<KhoaHoc>(entity =>
            {
                entity.HasKey(e => e.MaKhoaHoc);

                entity.ToTable("KhoaHoc");

                entity.Property(e => e.GiaTien)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.SoTuan).HasDefaultValueSql("((0))");

                entity.Property(e => e.TenKhoaHoc).HasMaxLength(100);

                entity.HasOne(d => d.MaDanhMucNavigation)
                    .WithMany(p => p.KhoaHocs)
                    .HasForeignKey(d => d.MaDanhMuc)
                    .HasConstraintName("FK_KhoaHoc_DanhMucKhoaHoc");

                entity.HasOne(d => d.MaGiaoVienNavigation)
                    .WithMany(p => p.KhoaHocs)
                    .HasForeignKey(d => d.MaGiaoVien)
                    .HasConstraintName("FK_KhoaHoc_GiaoVien");
            });

            modelBuilder.Entity<LopHoc>(entity =>
            {
                entity.HasKey(e => e.MaLopHoc);

                entity.ToTable("LopHoc");

                entity.Property(e => e.TenLopHoc).HasMaxLength(100);

                entity.HasOne(d => d.MaGiaoVienNavigation)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.MaGiaoVien)
                    .HasConstraintName("FK_LopHoc_GiaoVien");

                entity.HasOne(d => d.MaKhoaHocNavigation)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.MaKhoaHoc)
                    .HasConstraintName("FK_LopHoc_KhoaHoc");
            });

            modelBuilder.Entity<LopHocTuan>(entity =>
            {
                entity.HasKey(e => e.MaLopHoc);

                entity.ToTable("LopHoc_Tuan");

                entity.Property(e => e.MaLopHoc).ValueGeneratedNever();

                entity.HasOne(d => d.MaLopHocNavigation)
                    .WithOne(p => p.LopHocTuan)
                    .HasForeignKey<LopHocTuan>(d => d.MaLopHoc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LopHoc_Tuan_LopHoc");

                entity.HasOne(d => d.MaTuanNavigation)
                    .WithMany(p => p.LopHocTuans)
                    .HasForeignKey(d => d.MaTuan)
                    .HasConstraintName("FK_LopHoc_Tuan_Tuan");
            });

            modelBuilder.Entity<PhuHuynh>(entity =>
            {
                entity.HasKey(e => e.MaPhuHuynh);

                entity.ToTable("PhuHuynh");

                entity.Property(e => e.DiaChi).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenPhuHuynh).HasMaxLength(100);

                entity.HasOne(d => d.MaHocVienNavigation)
                    .WithMany(p => p.PhuHuynhs)
                    .HasForeignKey(d => d.MaHocVien)
                    .HasConstraintName("FK_PhuHuynh_HocVien");
            });

            modelBuilder.Entity<ThoiKhoaBieu>(entity =>
            {
                entity.HasKey(e => e.MaTkb)
                    .HasName("PK_ThoiKhoaBieu_1");

                entity.ToTable("ThoiKhoaBieu");

                entity.Property(e => e.MaTkb).HasColumnName("MaTKB");

                entity.Property(e => e.ThoiGianHoc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MaKhoaHocNavigation)
                    .WithMany(p => p.ThoiKhoaBieus)
                    .HasForeignKey(d => d.MaKhoaHoc)
                    .HasConstraintName("FK_ThoiKhoaBieu_KhoaHoc");
            });

            modelBuilder.Entity<TrinhDo>(entity =>
            {
                entity.HasKey(e => e.MaTrinhDo);

                entity.ToTable("TrinhDo");

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.TenTrinhDo).HasMaxLength(50);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Tuan>(entity =>
            {
                entity.HasKey(e => e.MaTuan);

                entity.ToTable("Tuan");

                entity.Property(e => e.TenTuan).HasMaxLength(50);
            });

            modelBuilder.Entity<VaiTro>(entity =>
            {
                entity.HasKey(e => e.MaVaiTro);

                entity.ToTable("VaiTro");

                entity.Property(e => e.MaVaiTro).HasMaxLength(50);

                entity.Property(e => e.TenVaiTro)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VaiTroChucNang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VaiTro_ChucNang");

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.MaChucNang).HasMaxLength(50);

                entity.Property(e => e.MaVaiTro).HasMaxLength(50);

                entity.HasOne(d => d.MaChucNangNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaChucNang)
                    .HasConstraintName("FK_VaiTro_ChucNang_ChucNang");

                entity.HasOne(d => d.MaVaiTroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaVaiTro)
                    .HasConstraintName("FK_VaiTro_ChucNang_VaiTro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
