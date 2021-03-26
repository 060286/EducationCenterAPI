using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class CtHoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaKhoaHoc { get; set; }
        public int SoLuong { get; set; }

        public virtual HoaDon MaHoaDonNavigation { get; set; }
        public virtual KhoaHoc MaKhoaHocNavigation { get; set; }
    }
}
