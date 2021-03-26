using System;
using System.Collections.Generic;

#nullable disable

namespace EducationCenterAPI.Models
{
    public partial class Tuan
    {
        public Tuan()
        {
            LopHocTuans = new HashSet<LopHocTuan>();
        }

        public int MaTuan { get; set; }
        public string TenTuan { get; set; }

        public virtual ICollection<LopHocTuan> LopHocTuans { get; set; }
    }
}
