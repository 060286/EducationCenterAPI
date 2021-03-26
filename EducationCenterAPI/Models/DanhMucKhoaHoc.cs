using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class DanhMucKhoaHoc
    {
        public DanhMucKhoaHoc()
        {
            KhoaHocs = new HashSet<KhoaHoc>();
        }

        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public bool? TinhTrang { get; set; }

        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }
    }
}
