using ChuongtrinhQLDiemTHPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDSV.Models
{
    internal class Lop
    {
        public Lop()
        {
          //  this.GiangViens = new HashSet<GiangVien>();
            this.MonHocs = new HashSet<MonHoc>();
            this.LopDanhNghias = new HashSet<LopDanhNghia>();
            this.LopTinChis = new HashSet<TongKet>();
        }
     //   [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long KhoaID { get; set; }

      //  [Required]
      //  [StringLength(10)]
        public string MaKhoa { get; set; }

      //  [Required]
       // [StringLength(100)]
        public string TenKhoa { get; set; }

      //  [InverseProperty("Khoa")]
      //  public virtual ICollection<GiangVien> GiangViens { get; set; }

      //  [InverseProperty("Khoa")]
        public virtual ICollection<MonHoc> MonHocs { get; set; }

      //  [InverseProperty("Khoa")]
        public virtual ICollection<LopDanhNghia> LopDanhNghias { get; set; }

       // [InverseProperty("Khoa")]
        public virtual ICollection<TongKet> LopTinChis { get; set; }
    }
}
