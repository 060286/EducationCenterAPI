using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class KhoaHoc
    {
        public KhoaHoc()
        {
            LopHocs = new HashSet<LopHoc>();
            ThoiKhoaBieus = new HashSet<ThoiKhoaBieu>();
        }

        public int MaKhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool? TinhTrang { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public decimal? GiaTien { get; set; }
        public string MoTa { get; set; }
        public int? MaGiaoVien { get; set; }
        public int? SoTuan { get; set; }
        public int? MaDanhMuc { get; set; }
        public int? LuaTuoiPhuHop { get; set; }

        public virtual DanhMucKhoaHoc MaDanhMucNavigation { get; set; }
        public virtual GiaoVien MaGiaoVienNavigation { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieus { get; set; }
    }
}
