using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class LopHocTuan
    {
        public int MaLopHoc { get; set; }
        public int? MaTuan { get; set; }
        public int? SoGio { get; set; }

        public virtual LopHoc MaLopHocNavigation { get; set; }
        public virtual Tuan MaTuanNavigation { get; set; }
    }
}
