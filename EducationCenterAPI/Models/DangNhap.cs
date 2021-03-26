using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class DangNhap
    {
        public int MaTaiKhoan { get; set; }
        public string TenNguoiDung { get; set; }
        public string TaiKhoan { get; set; }
        public string MaVaiTro { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }

        public virtual VaiTro MaVaiTroNavigation { get; set; }
    }
}
