using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class PhuHuynh
    {
        public int MaPhuHuynh { get; set; }
        public string TenPhuHuynh { get; set; }
        public int? Sdt { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int? MaHocVien { get; set; }

        public virtual HocVien MaHocVienNavigation { get; set; }
    }
}
