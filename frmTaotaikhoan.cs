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
    public partial class frmTaotaikhoan : Form
    {
        public frmTaotaikhoan()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
        int hangchon;
        private void frmTaotaikhoan_Load(object sender, EventArgs e)
        {
            cl.LoadToDataGridView(dgTaotaikhoan, Application.StartupPath + "/Dangnhap.txt");
            cl.AdddatainCb(cbTaikhoan, 0, Application.StartupPath + "/Dangnhap.txt"); cbTaikhoan.Select();
            cl.AdddatainCb(cbMatkhau, 1, Application.StartupPath + "/Dangnhap.txt");
            lbSoTK.Text = (dgTaotaikhoan.Rows.Count - 1).ToString();
        
        }

        private void dgTaotaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangchon = e.RowIndex;
            cbTaikhoan.Text = dgTaotaikhoan[0, hangchon].Value.ToString();
            cbMatkhau.Text = dgTaotaikhoan[1, hangchon].Value.ToString();
            cbQuyen.Text = dgTaotaikhoan[2, hangchon].Value.ToString();
        }

        private void btTao_Click(object sender, EventArgs e)
        {
             int d = 0;
            string[] mang = new string[2] { txtTaikhoan.Text, txtNhapMK1.Text };

            if (txtNhapMK1.Text.ToLower() == txtNhapMK2.Text.ToLower())
            {
                for (int i = 0; i < dgTaotaikhoan.Rows.Count - 1; i++)
                {
                    if ((mang[0] == dgTaotaikhoan[0, i].Value.ToString()) && (mang[1] == dgTaotaikhoan [1, i].Value.ToString()))
                    {
                        d = d + 1;
                    }

                }
                if ((txtTaikhoan.Text != "") && (txtNhapMK1.Text != ""))
                {
                    if (d > 0)
                    {
                        MessageBox.Show("Tài khoản này đã có người sử dụng, hãy vui lòng đăng kí với tài khoản khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dgTaotaikhoan.Rows.Add();
                        //
                        lbSoTK.Text = (dgTaotaikhoan.Rows.Count - 1).ToString();
                        //
                        int i = dgTaotaikhoan.RowCount - 2;
                        dgTaotaikhoan[0, i].Value = txtTaikhoan.Text;
                        dgTaotaikhoan[1, i].Value = txtNhapMK1.Text;
                        dgTaotaikhoan[2, i].Value = "noadmin";
                        MessageBox.Show("Tạo thành công ! ");
                        cl.WriteDataGridViewToFile(dgTaotaikhoan, Application.StartupPath + "/Dangnhap.txt");
                        //
                        dgTaotaikhoan.Text = "";
                        txtNhapMK1.Text = "";
                        txtNhapMK2.Text = "";
                    }
                }
                else
                { MessageBox.Show("Không được để trống, vui lòng điền đầy đủ các thành phần quan trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                MessageBox.Show("Hai ô mật khẩu không giống nhau, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapMK2.Text = "";
            }
        }

      private void btSua_Click(object sender, EventArgs e)
        {
             int dem = 0;
             for (int i = 0; i < dgTaotaikhoan.RowCount - 1; i++)
            {
                if (cbTaikhoan.Text.ToLower() == dgTaotaikhoan[0, i].Value.ToString().ToLower() && cbMatkhau.Text.ToLower() == dgTaotaikhoan[1, i].Value.ToString().ToLower() && cbQuyen.Text.ToLower() == dgTaotaikhoan[2, i].Value.ToString().ToLower())
                {
                    dem = dem + 1;
                }
            }
            if (dem == 0)
            {
                if ((cbMatkhau.Text != "") && (cbTaikhoan.Text != "") && (cbQuyen.Text != ""))
                {
                    dgTaotaikhoan[1, hangchon].Value = cbMatkhau.Text;
                    dgTaotaikhoan[0, hangchon].Value = cbTaikhoan.Text;
                    dgTaotaikhoan[2, hangchon].Value = cbQuyen.Text;
                    cl.WriteDataGridViewToFile(dgTaotaikhoan, Application.StartupPath + "/Dangnhap.txt");
                }
                else
                {
                    MessageBox.Show("Không được để trống, vui lòng điền đầy đủ các thành phần quan trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản sửa lại đã bị trùng thông tin với tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xoá tài khoản này ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
            {
                dgTaotaikhoan.Rows.RemoveAt(hangchon);
                lbSoTK.Text = (dgTaotaikhoan.Rows.Count - 1).ToString();
                cl.WriteDataGridViewToFile(dgTaotaikhoan, Application.StartupPath + "/Dangnhap.txt");
            }
        }

        
        }
}
