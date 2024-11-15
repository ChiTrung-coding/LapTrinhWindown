using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChuongtrinhQLDiemTHPT.Models
{
    internal class BangDiem
    {
       // [Key]
        public long MaSoSV { get; set; }

      //  [StringLength(100)]
        public string TenSV { get; set; }

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

       // [StringLength(200)]
        public string DiaChi { get; set; }

      //  [StringLength(10)]
        public string SoDienThoai { get; set; }

       // [StringLength(100)]
        public string Email { get; set; }

        public bool TrangThai { get; set; }

     //   [ForeignKey(nameof(LopDanhNghia))]
        public long LopDNID { get; set; }
      //  public virtual LopDanhNghia LopDanhNghia { get; set; }
    }
}
