using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;


namespace ChuongtrinhQLDiemTHPT.Models
{
    internal class MonHoc
    {
        public MonHoc()
        {
         //   this.LopTinChis = new HashSet<LopTinChi>();
        }

     //   [Key]
        public long MaMon { get; set; }

      //  [StringLength(100)]
        public string TenMon { get; set; }

        public int SoTinChi { get; set; }

        public int SoTietLT { get; set; }

        public int SoTietTH { get; set; }

      //  [ForeignKey(nameof(Khoa))]
        public long KhoaID { get; set; }
      // public virtual Lop Khoa { get; set; }

       // [InverseProperty("MonHoc")]
      //  public virtual ICollection<LopTinChi> LopTinChis { get; set; }
    }
}
