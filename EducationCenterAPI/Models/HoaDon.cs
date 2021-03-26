using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class HoaDon
    {
        public int MaHoaDon { get; set; }
        public decimal? TongTien { get; set; }
        public DateTime? NgayLap { get; set; }
        public string GhiChu { get; set; }
        public bool? TinhTrang { get; set; }
        public int? MaKhoaHoc { get; set; }
        public int? MaLopHoc { get; set; }
        public int? MaHocVien { get; set; }

        public virtual HocVien MaHocVienNavigation { get; set; }
        public virtual LopHoc MaLopHocNavigation { get; set; }
    }
}
