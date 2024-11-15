using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDSV.Models
{
    internal class TaiKhoan
    {
        public int TaiKhoanID { get; set; }

      //  [StringLength(100)]
        public string MatKhau { get; set; }

      //  [StringLength(10)]
        public string VaiTro { get; set; }

       // [ForeignKey(nameof(GiangVien))]
        public long MaSoGV { get; set; }
       // public virtual GiangVien GiangVien { get; set; }

        public bool TinhTrang { get; set; }
    }
}
