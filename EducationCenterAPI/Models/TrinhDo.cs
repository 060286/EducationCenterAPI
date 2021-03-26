using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class TrinhDo
    {
        public TrinhDo()
        {
            GiaoViens = new HashSet<GiaoVien>();
        }

        public int MaTrinhDo { get; set; }
        public string TenTrinhDo { get; set; }
        public string GhiChu { get; set; }
        public bool? TinhTrang { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
    }
}
