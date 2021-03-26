using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class HocVien
    {
        public HocVien()
        {
            BangDiems = new HashSet<BangDiem>();
            HoaDons = new HashSet<HoaDon>();
            PhuHuynhs = new HashSet<PhuHuynh>();
        }

        public int MaHocVien { get; set; }
        public string TenHocVien { get; set; }
        public string MatKhau { get; set; }
        public string TaiKhoan { get; set; }
        public string HinhAnh { get; set; }
        public int? MaHvdd { get; set; }
        public string GioiTinh { get; set; }
        public int? Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GhiChu { get; set; }
        public bool? TrangThai { get; set; }
        public string Nguon { get; set; }

        public virtual HvDiemDanh MaHvddNavigation { get; set; }
        public virtual ICollection<BangDiem> BangDiems { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<PhuHuynh> PhuHuynhs { get; set; }
    }
}
