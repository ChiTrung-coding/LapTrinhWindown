using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;


namespace QLDSV.Models
{
    internal class TongKet
    {
        public TongKet()
        {
            this.BangDiems = new HashSet<BangDiem>();
        }
      //  [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long LopTCID { get; set; }

     //   [StringLength(10)]
        public string MaLopTC { get; set; }

      //  [ForeignKey(nameof(MonHoc))]
        public long MaMon { get; set; }
       // public virtual MonHoc MonHoc { get; set; }

      //  [ForeignKey(nameof(GiangVien))]
        public long MaSoGV { get; set; }
       // public virtual GiangVien GiangVien { get; set; }

      //  [StringLength(10)]
        public string HocKy { get; set; }

        public short NamHoc { get; set; }

      //  [ForeignKey(nameof(Khoa))]
        public long KhoaID { get; set; }
        public virtual Lop Khoa { get; set; }

       // [InverseProperty("LopTinChi")]
        public virtual ICollection<BangDiem> BangDiems { get; set; }
    }
}
