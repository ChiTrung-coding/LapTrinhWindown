using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;


namespace QLDSV.Models
{
    internal class LopDanhNghia
    {
        public LopDanhNghia()
        {
            this.SinhViens = new HashSet<BangDiem>();
        }
      //  [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long LopDNID { get; set; }

        //[StringLength(10)]
        public string MaLopDN { get; set; }

       //[ForeignKey(nameof(GiangVien))]
        public long MaSoGV { get; set; }
       // public virtual GiangVien GiangVien { get; set; }

       // [ForeignKey(nameof(Khoa))]
        public long KhoaID { get; set; }
        public virtual Lop Khoa { get; set; }

        public int SoLuongSV { get; set; }

        public short NamNhapHocCuaSV { get; set; }

      //  [InverseProperty("LopDanhNghia")]
        public virtual ICollection<BangDiem> SinhViens { get; set; }
    }
}
