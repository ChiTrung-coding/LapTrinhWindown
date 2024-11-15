using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ChuongtrinhQLDiemTHPT
{
    public partial class frmChuongtrinhchinh : Form
    {
        public frmChuongtrinhchinh()
        {
            InitializeComponent();
        }

        clsThaotac cl = new clsThaotac();
        public static bool kt, kt2;
        private void frmChuongtrinhchinh_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            timer1.Enabled = true;
            skMain.Active = false;
            frmDangnhap frm0 = new frmDangnhap();
            frm0.ShowDialog();
            if (kt)
            {
                mnDangnhap.Enabled = false;
                mnQL.Enabled = true;
                mnTK.Enabled = true;
                mnTKiem.Enabled = true;
                mnuTaotaikhoan.Enabled = true;
                mnDangxuat.Enabled = true;
            }
            if (kt2)
            {
                mnDangnhap.Enabled = false;
                mnTK.Enabled = true;
                mnTKiem.Enabled = true;
                mnDangxuat.Enabled = true;

            }
        }

        private void mnDangnhap_Click(object sender, EventArgs e)
        {
            frmChuongtrinhchinh_Load(sender, e);
        }

        private void mnuTaotaikhoan_Click(object sender, EventArgs e)
        {
            frmTaotaikhoan frm1 = new frmTaotaikhoan();
            frm1.ShowDialog();
        }

        private void mnDangxuat_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo" , MessageBoxButtons.OK);
            mnDangnhap.Enabled = true;
            mnQL.Enabled = false;
            mnTK.Enabled = false;
            mnTKiem.Enabled = false;
            mnuTaotaikhoan.Enabled = false;
            mnDangxuat.Enabled = false;
            kt = false;
            kt2 = false;
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuQLLop_Click(object sender, EventArgs e)
        {
            frmQLLop frm2 = new frmQLLop();
            frm2.ShowDialog();
        }

        private void mnQLHocSinh_Click(object sender, EventArgs e)
        {
            frmQLHocsinh frm3 = new frmQLHocsinh();
            frm3.ShowDialog();
        }

        private void mnQLMonHoc_Click(object sender, EventArgs e)
        {
            frmQLBanhoc frm4 = new frmQLBanhoc();
            frm4.ShowDialog();
        }

        private void mnQLDiem_Click(object sender, EventArgs e)
        {
            frmChinhDiem frm5 = new frmChinhDiem();
            frm5.ShowDialog();
        }

        private void mnTKBangDiem_Click(object sender, EventArgs e)
        {
            frmTKBangdiem frm6 = new frmTKBangdiem();
            frm6.ShowDialog();
        }

        private void mnTKTongKet_Click(object sender, EventArgs e)
        {

        }

        private void mnTKTimKiem_Click(object sender, EventArgs e)
        {
            frmTimkiem frm8 = new frmTimkiem();
            frm8.ShowDialog();
        }

        private void mnAbout_Click(object sender, EventArgs e)
        {
            frmGioithieu gt = new frmGioithieu();
            gt.ShowDialog();
        }

        private void mnHDSD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("hdsd.doc");
        }
        private void mnuGiaodien1_Click_1(object sender, EventArgs e)
        {
            skMain.Active = false;
        }

        private void mnuGiaodien2_Click(object sender, EventArgs e)
        {
            skMain.Active = true;
            skMain.ApplyAdditionalBuiltInSkins(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string a = "", b = "", c = "";
            cl.Hienngay(ref a, ref b, ref c);
            TTlbtime.Text = a;
            TTlbtime1.Text = b;
            TTlbtime3.Text = c;
        }

        private void media10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skMain.Active = true;
            skMain.ApplyAdditionalBuiltInSkins(1);
        }

        private void steelBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skMain.Active = true;
            skMain.ApplyAdditionalBuiltInSkins(2);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChuongtrinhchinh main = new frmChuongtrinhchinh();
            main.Show();
        }

        private void mnuTongket_Click(object sender, EventArgs e)
        {
            frmTongket Tkret = new frmTongket();
            Tkret.ShowDialog();
        }

        private void frmChuongtrinhchinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else e.Cancel = true;
        }
    }
}
