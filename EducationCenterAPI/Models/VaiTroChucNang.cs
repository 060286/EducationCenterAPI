using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class VaiTroChucNang
    {
        public string MaVaiTro { get; set; }
        public string MaChucNang { get; set; }
        public string GhiChu { get; set; }

        public virtual ChucNang MaChucNangNavigation { get; set; }
        public virtual VaiTro MaVaiTroNavigation { get; set; }
    }
}
