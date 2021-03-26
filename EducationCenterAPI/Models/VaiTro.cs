using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class VaiTro
    {
        public VaiTro()
        {
            DangNhaps = new HashSet<DangNhap>();
        }

        public string MaVaiTro { get; set; }
        public string TenVaiTro { get; set; }

        public virtual ICollection<DangNhap> DangNhaps { get; set; }
    }
}
