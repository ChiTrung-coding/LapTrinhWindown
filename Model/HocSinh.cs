using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ChuongtrinhQLDiemTHPT.Models
{
    internal class HocSinh
    {
      //  [Key]
        public long MaSoGV { get; set; }

      //  [StringLength(100)]
        public string TenGV { get; set; }

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

       // [StringLength(100)]
        public string Email { get; set; }

       // [StringLength(10)]
        public string HocVi { get; set; }

      //  [ForeignKey(nameof(Khoa))]
        public long KhoaID { get; set; }
      //  public virtual Khoa Khoa { get; set; }

       
    }
}
