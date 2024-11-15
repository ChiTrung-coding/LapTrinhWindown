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
    public partial class frmQLHocsinh : Form
    {
        public frmQLHocsinh()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
        int hangchon;
    

        private void cbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cl.AdddatainCb(cbLopcu, 2, "Hocsinh.txt");
            cl.LocDuLieuTrung(cbLopcu);
            cl.AdddatainCb(cbLopmoi, 2, "Hocsinh.txt");
            cl.LocDuLieuTrung(cbLopmoi);
            dgLopcu.Rows.Clear();
            cl.LoadToDataGridView(dgLopcu, "Hocsinh.txt");
            clsThaotac.LocDataGridView(dgLopcu, cbNamhoc, 3);
            dgLopmoi.Rows.Clear();
            cl.LoadToDataGridView(dgLopmoi, "Hocsinh.txt");
            clsThaotac.LocDataGridView(dgLopmoi, cbNamhoc, 3); 
        }
        private void cbLopcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            grLopcu.Text ="Lớp " + cbLopcu.Text.Trim();
            dgLopcu.Rows.Clear();
            cl.LoadToDataGridView(dgLopcu, "Hocsinh.txt");
          
            clsThaotac.LocDataGridView(dgLopcu, cbNamhoc, 3);
            clsThaotac.LocDataGridView(dgLopcu, cbLopcu, 2);
        }

        private void cbLopmoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            grLopmoi.Text = "Lớp " + cbLopmoi.Text.Trim();
            dgLopmoi.Rows.Clear();
            cl.LoadToDataGridView(dgLopmoi, "Hocsinh.txt");
            clsThaotac.LocDataGridView(dgLopmoi, cbNamhoc, 3);
            clsThaotac.LocDataGridView(dgLopmoi, cbLopmoi, 2);
        }

        private void btChuyen_Click(object sender, EventArgs e)
        {
            dgLopcu.Rows.Clear();
            cl.LoadToDataGridView(dgLopcu, "Hocsinh.txt");
            for (int i = 0; i < dgLopcu.RowCount - 1; i++)
            {
                if (txt1Ma.Text == dgLopcu[0, i].Value.ToString() && txtTen.Text == dgLopcu[1, i].Value.ToString() && txtLop.Text == dgLopcu[2, i].Value.ToString() && txtNgaysinh.Text == dgLopcu[5, i].Value.ToString() && txtGioitinh.Text == dgLopcu[6, i].Value.ToString() && txtQue.Text == dgLopcu[7, i].Value.ToString())
                { dgLopcu[2, i].Value = cbLopmoi.Text; }
            }
            cl.WriteDataGridViewToFile(dgLopcu, "Hocsinh.txt");
            cbLopcu_SelectedIndexChanged(sender, e);
            cbLopmoi_SelectedIndexChanged(sender, e);
            MessageBox.Show("Bạn đã chuyển thành công ! ","Thông báo" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dgLopcu_CellClick(object sender, DataGridViewCellEventArgs e)
        { hangchon=e.RowIndex;
        txt1Ma.Text = dgLopcu[0, hangchon].Value.ToString();
        txtTen.Text = dgLopcu[1, hangchon].Value.ToString();
        txtLop.Text = dgLopcu[2, hangchon].Value.ToString();
        txtNgaysinh.Text = dgLopcu[5, hangchon].Value.ToString();
        txtGioitinh.Text = dgLopcu[6, hangchon].Value.ToString();
        txtQue.Text = dgLopcu[7, hangchon].Value.ToString();
        }

        // Thông tin học sinh.

        void Ma()
        {
            string Ma1 = cbNienkhoa.Text.Substring(2, 2);
            string Ma2 = cbNienkhoa.Text.Substring(7, 2);
            int a = 0;
            if ((dgThongtinHS.RowCount - 1) != 0)
            {
                for (int i = 0; i < dgThongtinHS.RowCount - 1; i++)
                {
                    int b = int.Parse(dgThongtinHS[0, i].Value.ToString().Substring((dgThongtinHS[0, i].Value.ToString().Length - 2), 2));
                    if (i != 0)
                    {
                        if (i != b)
                        {
                            b = b + 1;
                            a = int.Parse(Ma1 + Ma2 + b.ToString());
                        }
                        if (i == b)
                        {
                            int Ma = int.Parse(Ma1 + Ma2 + "00");
                            a = Ma + (dgThongtinHS.RowCount - 1);
                        }

                    }
                    else if (i == 0)
                    {
                        int Ma = int.Parse(Ma1 + Ma2 + "00");
                        a = Ma + (dgThongtinHS.RowCount - 1);
                    }
                }
                txtMa.Text = cbLop.Text + "0" + a.ToString();
            }
            else
            {
                txtMa.Text = cbLop.Text + Ma1 + Ma2 + "00";
            }
        }
        int hangchon2;
        private void dgThongtinHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangchon2 = e.RowIndex;
            txtMa.Text=dgThongtinHS[0,hangchon2].Value.ToString();
            txtTTTen.Text=dgThongtinHS[1,hangchon2].Value.ToString();
            mkngaysinh.Text = dgThongtinHS[5, hangchon2].Value.ToString();
            cbGioitinh.Text = dgThongtinHS[6, hangchon2].Value.ToString();
            txtTTQue.Text = dgThongtinHS[7, hangchon2].Value.ToString();
            txtGhichu.Text = dgThongtinHS[8, hangchon2].Value.ToString();

        }

        private void cbNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgThongtinHS.Rows.Clear();
            cl.LoadToDataGridView(dgThongtinHS, "Hocsinh.txt");
            clsThaotac.LocDataGridView(dgThongtinHS, cbNienkhoa, 4);
        }

        private void cmbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgThongtinHS.Rows.Clear();
            cl.LoadToDataGridView(dgThongtinHS, "Hocsinh.txt");
            clsThaotac.LocDataGridView(dgThongtinHS, cbNienkhoa, 4);
            clsThaotac.LocDataGridView(dgThongtinHS, cmbNamhoc, 3);
            
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgThongtinHS.Rows.Clear();
            cl.LoadToDataGridView(dgThongtinHS, "Hocsinh.txt");
            clsThaotac.LocDataGridView(dgThongtinHS, cbNienkhoa, 4);
            clsThaotac.LocDataGridView(dgThongtinHS, cmbNamhoc, 3);
            clsThaotac.LocDataGridView(dgThongtinHS, cbLop, 2);
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            
                if (cbNienkhoa.Text != "" && cmbNamhoc.Text != "" && cbLop.Text != "" && cbGioitinh.Text != "" && txtTTTen.Text != "" && mkngaysinh.Text != "" && txtTTQue.Text != "")
                {
                    Ma();
                    string[] mang = { txtMa.Text.Trim(),txtTTTen.Text.Trim(), cbLop.Text.Trim(), cmbNamhoc.Text.Trim(), cbNienkhoa.Text.Trim(), mkngaysinh.Text.Trim(),cbGioitinh.Text.Trim(), txtTTQue.Text.Trim(), txtGhichu.Text.Trim() };
                    dgThongtinHS.Rows.Clear();
                    cl.LoadToDataGridView(dgThongtinHS, "Hocsinh.txt");
                    dgThongtinHS.Rows.Add(mang);
                    MessageBox.Show("Nhập thành công ! ");
                    cl.WriteDataGridViewToFile(dgThongtinHS, "Hocsinh.txt");
                    //
                    cbLop_SelectedIndexChanged(sender, e);
                    //
                }
                else
                {
                    MessageBox.Show("Không được để trống, vui lòng điền đầy đủ các thành phần quan trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbNienkhoa.Text != "" && cmbNamhoc.Text != "" && cbLop.Text != "" && cbGioitinh.Text != "" && txtTTTen.Text != "" && mkngaysinh.Text != "" && txtTTQue.Text != "")
            {

                dgThongtinHS.Rows.Clear();
                cl.LoadToDataGridView(dgThongtinHS, "Hocsinh.txt");
                for (int i = 0; i < dgThongtinHS.RowCount - 1; ++i)
                {
                    if (txtMa.Text.ToLower().Trim() == dgThongtinHS[0, i].Value.ToString().ToLower().Trim() )
                    {
                        dgThongtinHS[1, i].Value = txtTTTen.Text.Trim();
                        dgThongtinHS[5, i].Value = mkngaysinh.Text.Trim();
                        dgThongtinHS[6, i].Value = cbGioitinh.Text.Trim();
                        dgThongtinHS[7, i].Value = txtTTQue.Text.Trim();
                        dgThongtinHS[8, i].Value = txtGhichu.Text.Trim();
                    }
                }
                cl.WriteDataGridViewToFile(dgThongtinHS, "Hocsinh.txt");
                cbLop_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Không được để trống, vui lòng điền đầy đủ các thành phần quan trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgThongtinHS.Rows.Clear();
                cl.LoadToDataGridView(dgThongtinHS, "Hocsinh.txt");
                for (int i = 0; i < dgThongtinHS.RowCount - 1; ++i)
                {
                    if (txtMa.Text.ToLower().Trim() == dgThongtinHS[0, i].Value.ToString().ToLower().Trim())
                    {
                        dgThongtinHS.Rows.RemoveAt(i);
                    }
                }
                cl.WriteDataGridViewToFile(dgThongtinHS, "Hocsinh.txt");
                cbLop_SelectedIndexChanged(sender, e);
            }
        }

        private void frmQLHocsinh_Load(object sender, EventArgs e)
        {
            cl.AdddatainCb(cbLop, 1, "Lop.txt");
            
        }

        private void cbNienkhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
            else e.Handled = false;
        }

        private void cmbNamhoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbNienkhoa_KeyPress(sender, e);
        }

        private void cbNamhoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbNienkhoa_KeyPress(sender, e);
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
