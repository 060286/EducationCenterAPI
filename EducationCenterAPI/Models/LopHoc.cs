using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class LopHoc
    {
        public LopHoc()
        {
            BangDiems = new HashSet<BangDiem>();
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaLopHoc { get; set; }
        public string TenLopHoc { get; set; }
        public bool? TinhTrang { get; set; }
        public int? MaGiaoVien { get; set; }
        public int? MaKhoaHoc { get; set; }

        public virtual GiaoVien MaGiaoVienNavigation { get; set; }
        public virtual KhoaHoc MaKhoaHocNavigation { get; set; }
        public virtual LopHocTuan LopHocTuan { get; set; }
        public virtual ICollection<BangDiem> BangDiems { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
