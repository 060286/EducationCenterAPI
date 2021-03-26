using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class GvDiemDanh
    {
        public GvDiemDanh()
        {
            GiaoViens = new HashSet<GiaoVien>();
        }

        public int MaGvdd { get; set; }
        public int? TrangThai { get; set; }
        public string GhiChu { get; set; }
        public bool ThuHai { get; set; }
        public bool ThuBa { get; set; }
        public bool ThuTu { get; set; }
        public bool ThuNam { get; set; }
        public bool ThuSau { get; set; }
        public bool ThuBay { get; set; }
        public bool ChuNhat { get; set; }
        public DateTime? Tuan { get; set; }

        public virtual ICollection<GiaoVien> GiaoViens { get; set; }
    }
}
