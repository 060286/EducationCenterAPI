using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class BangDiem
    {
        public int MaBangDiem { get; set; }
        public double? Kt1 { get; set; }
        public double? Kt2 { get; set; }
        public double? Thil1 { get; set; }
        public int? MaHocVien { get; set; }
        public int? MaLopHoc { get; set; }
        public double? KetQua { get; set; }

        public virtual HocVien MaHocVienNavigation { get; set; }
        public virtual LopHoc MaLopHocNavigation { get; set; }
    }
}
