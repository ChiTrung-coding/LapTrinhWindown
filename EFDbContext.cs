﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;


namespace QLDSV.Models
{
    internal class BangDiem
    {
      //  [ForeignKey(nameof(LopTinChi))]
        public long LopTCID { get; set; }
        public virtual TongKet LopTinChi { get; set; }

      //  [ForeignKey(nameof(SinhVien))]
        public long MaSoSV { get; set; }
        public virtual BangDiem SinhVien { get; set; }

      //  [Column(TypeName = "decimal(5, 2)")]
        public decimal DiemChuyenCan { get; set; }

      //  [Column(TypeName = "decimal(5, 2)")]
        public decimal DiemGiuaKy { get; set; }

     //   [Column(TypeName = "decimal(5, 2)")]
        public decimal DiemThiCuoiKy { get; set; }

        public short TiLeDiemQuaTrinh { get; set; }

        public short TiLeDiemThiCuoiKy { get; set; }

      //  [Column(TypeName = "decimal(5, 2)")]
        public decimal DiemTB { get; set; }
    }
}
