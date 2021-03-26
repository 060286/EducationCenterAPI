using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class GiaoVien
    {
        public GiaoVien()
        {
            KhoaHocs = new HashSet<KhoaHoc>();
            LopHocs = new HashSet<LopHoc>();
        }

        public int MaGiaoVien { get; set; }
        public string TenGiaoVien { get; set; }
        public string HinhAnh { get; set; }
        public decimal? MucLuong { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public string MatKhau { get; set; }
        public int? MaGvdd { get; set; }
        public string Email { get; set; }
        public int? Sdt { get; set; }
        public string GhiChu { get; set; }
        public int? MaTrinhDo { get; set; }
        public string DiaChi { get; set; }
        public string QuocTich { get; set; }
        public bool? TrangThai { get; set; }

        public virtual GvDiemDanh MaGvddNavigation { get; set; }
        public virtual TrinhDo MaTrinhDoNavigation { get; set; }
        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}
