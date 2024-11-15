using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChuongtrinhQLDiemTHPT
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
       
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            dgDangnhap.Rows.Clear();
            cl.LoadToDataGridView(dgDangnhap, "Dangnhap.txt");
            

            string m="noadmin"; string n="admin";
            int dem = 0; int dem1 = 0;
            string[] mang = new string[2] { txtTaikhoan.Text.Trim(), txtMatkhau.Text.Trim() };
            //

            //
            for (int i = 0; i < dgDangnhap.RowCount-1; i++)
            {

                if ((mang[0].ToString().ToLower() == dgDangnhap[0, i].Value.ToString().ToLower().Trim()) && (mang[1].ToString().ToLower() == dgDangnhap[1, i].Value.ToString().ToLower().Trim()) && n.ToLower().Trim() == dgDangnhap[2, i].Value.ToString().ToLower().ToLower().Trim())
                {
                    
                    dem = dem + 1;
                    
                }
                if ((mang[0].ToString().ToLower() == dgDangnhap[0, i].Value.ToString().ToLower().Trim()) && (mang[1].ToString().ToLower() == dgDangnhap[1, i].Value.ToString().ToLower().Trim()) && m.ToLower().Trim() == dgDangnhap[2, i].Value.ToString().ToLower().Trim())
                {
                    dem1 = dem1 + 1;
                }
            }
            //

            //1.2. So sánh biến đếm, nếu tăng thì đúng, nếu không tăng thì sai.

            //
            if (mang[0] != "" && mang[1] != "")
            {
                //1.2.a Kiểm tra admin

                //
                if (dem > 0)
                {
                    this.Hide();
                  MessageBox.Show("Chào mừng quản lý "+mang[0]+" đã quay trở lại với hệ thống.");
                  frmChuongtrinhchinh.kt = true;
                }
                //1.2.b Kiểm tra noadmin
                                    
                //
                else if (dem1 > 0)
                {
                    this.Hide();
                    MessageBox.Show("Chào mừng thành viên " + mang[0] + " đã quay trở lại với hệ thống.");
                    frmChuongtrinhchinh.kt2 = true;
                }
                else if (dem1 == 0&&dem==0)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai thông tin. Vui lòng thử lại !");
                }                       
            }
            else
            {
                MessageBox.Show("Không được để trống các mục.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //
        }
      
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }
    }
}
