using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class ThoiKhoaBieu
    {
        public int MaTkb { get; set; }
        public string ThoiGianHoc { get; set; }
        public bool ThuHai { get; set; }
        public bool ThuBa { get; set; }
        public bool ThuTu { get; set; }
        public bool ThuNam { get; set; }
        public bool ThuSau { get; set; }
        public bool ThuBay { get; set; }
        public bool ChuNhat { get; set; }
        public int? MaKhoaHoc { get; set; }

        public virtual KhoaHoc MaKhoaHocNavigation { get; set; }
    }
}
