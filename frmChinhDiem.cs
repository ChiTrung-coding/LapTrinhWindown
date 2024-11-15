using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace ChuongtrinhQLDiemTHPT
{
    public partial class frmChinhDiem : Form
    {
        public frmChinhDiem()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();

        int hangchon;
        void Chen()
        {

            //cl.LoadToDataGridView(dgBangdiem, "Diem.txt");
            StreamReader sr = new StreamReader(Application.StartupPath + "/Hocsinh.txt");
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                for (int i = 0; i < dgBangdiem.RowCount - 1; i++)
                {
                    if (mang[1].ToLower().Trim() == dgBangdiem[1, i].Value.ToString().ToLower().Trim() && mang[2].ToLower().Trim() == dgBangdiem[2, i].Value.ToString().ToLower().Trim())
                    {
                        dgBangdiem[0, i].Value = mang[0].Trim();
                    }

                }
                Line = sr.ReadLine();
            }
            sr.Close();
        }

        private void frmChinhDiem_Load(object sender, EventArgs e)
        {

            cl.AdddatainCb(cbLop, 2, Application.StartupPath + "/Hocsinh.txt");
            cl.AdddatainCb(cbNamhoc, 3, Application.StartupPath + "/Hocsinh.txt");
            cl.AdddatainCb(cbNienkhoa, 4, Application.StartupPath + "/Hocsinh.txt");
            cl.AdddatainCb2(cbMonhoc, 1, Application.StartupPath + "/Banhoc.txt");
            cl.LocDuLieuTrung(cbLop);
            cl.LocDuLieuTrung(cbNienkhoa);
            cl.LocDuLieuTrung(cbNamhoc);


        }

        private void dgBangdiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangchon = e.RowIndex;
            txtMa.Text = dgBangdiem[0, hangchon].Value.ToString();
            cbTen.Text = dgBangdiem[1, hangchon].Value.ToString();
            //
            string[] srtdiem15 = dgBangdiem[5, hangchon].Value.ToString().Split(',');
            txt151.Text = srtdiem15[0];
            txt152.Text = srtdiem15[1];
            txt153.Text = srtdiem15[2];
            string[] srtdiem45 = dgBangdiem[6, hangchon].Value.ToString().Split(',');
            txt451.Text = srtdiem45[0];
            txt452.Text = srtdiem45[1];
            txt453.Text = srtdiem45[2];
            //
            txtMieng.Text = dgBangdiem[4, hangchon].Value.ToString();
            txtthuchanh.Text = dgBangdiem[7, hangchon].Value.ToString();
            txthocki.Text = dgBangdiem[8, hangchon].Value.ToString();
            cbHanhkiem.Text = dgBangdiem[9, hangchon].Value.ToString();
            txtGhichu.Text = dgBangdiem[13, hangchon].Value.ToString();

        }

        private void cbNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgBangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgBangdiem, Application.StartupPath + "/Diem.txt");
            clsThaotac.LocDataGridView(dgBangdiem, cbNienkhoa, 12);


        }
        //
        private void cbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgBangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgBangdiem, Application.StartupPath + "/Diem.txt");
            clsThaotac.LocDataGridView(dgBangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgBangdiem, cbNamhoc, 11);


        }
        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cl.DoichieuDL(cbLop, cbTen, Application.StartupPath + "/Hocsinh.txt");
            dgBangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgBangdiem, Application.StartupPath + "/Diem.txt");
            clsThaotac.LocDataGridView(dgBangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgBangdiem, cbNamhoc, 11);
            clsThaotac.LocDataGridView(dgBangdiem, cbLop, 2);

        }
        private void cbMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgBangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgBangdiem, Application.StartupPath + "/Diem.txt");
            clsThaotac.LocDataGridView(dgBangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgBangdiem, cbNamhoc, 11);
            clsThaotac.LocDataGridView(dgBangdiem, cbLop, 2);
            clsThaotac.LocDataGridView(dgBangdiem, cbMonhoc, 3);

        }
        private void cbHocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgBangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgBangdiem, Application.StartupPath + "/Diem.txt");
            clsThaotac.LocDataGridView(dgBangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgBangdiem, cbNamhoc, 11);
            clsThaotac.LocDataGridView(dgBangdiem, cbLop, 2);
            clsThaotac.LocDataGridView(dgBangdiem, cbMonhoc, 3);
            clsThaotac.LocDataGridView(dgBangdiem, cbHocki, 10);
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            int dem = 0, dem1 = 0;
            for (int i = dgBangdiem.RowCount - 2; i >= 0; i--)
            {
                if (txtMa.Text == dgBangdiem[0, i].Value.ToString())
                {
                    dem1 = dem1 + 1;
                }
            }
            for (int i = 0; i < cbTen.Items.Count; i++)
            {
                if (cbTen.Text.ToLower().Trim() == cbTen.Items[i].ToString().ToLower().Trim())
                {
                    dem = dem + 1;
                }
            }
            if (cbNienkhoa.Text != "" && cbNamhoc.Text != "" && cbLop.Text != "" && cbMonhoc.Text != "" && cbHocki.Text != "" && cbTen.Text != "")
            {
                if (dem > 0)
                {
                    if (dem1 < 1)
                    {
                        txtMa.Text = "";
                        //
                        string srtdiem15 = txt151.Text.Trim() + "," + txt152.Text.Trim() + "," + txt153.Text.Trim();
                        string srtdiem45 = txt451.Text.Trim() + "," + txt452.Text.Trim() + "," + txt453.Text.Trim();
                        //
                        string[] mang = { txtMa.Text, cbTen.Text.Trim(), cbLop.Text.Trim(), cbMonhoc.Text.Trim(), txtMieng.Text.Trim(), srtdiem15, srtdiem45, txtthuchanh.Text.Trim(), txthocki.Text.Trim(), cbHanhkiem.Text.Trim(), cbHocki.Text.Trim(), cbNamhoc.Text.Trim(), cbNienkhoa.Text.Trim(), txtGhichu.Text.Trim() };
                        dgBangdiem.Rows.Clear();
                        cl.LoadToDataGridView(dgBangdiem,Application.StartupPath + "/Diem.txt");
                        dgBangdiem.Rows.Add(mang);
                        Chen();
                        for (int i = 0; i < dgBangdiem.RowCount - 1; i++)
                        {
                            txtMa.Text = dgBangdiem[0, i].Value.ToString();
                        }
                        MessageBox.Show("Nhập thành công ! ");
                        cl.WriteDataGridViewToFile(dgBangdiem, Application.StartupPath + "/Diem.txt");
                        cbHocki_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thông tin của học sinh này đã đuợc nhập");
                    }
                }
                else { MessageBox.Show("Không có học sinh này trong danh sách, đề nghị vào mục quản lý học sinh để biết thêm chi tiết."); }
            }
            else { MessageBox.Show("Không được để trống, vui lòng điền đầy đủ các thành phần quan trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            string srtdiem15 = txt151.Text.Trim() + "," + txt152.Text.Trim() + "," + txt153.Text.Trim();
            string srtdiem45 = txt451.Text.Trim() + "," + txt452.Text.Trim() + "," + txt453.Text.Trim();
            dgBangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgBangdiem, Application.StartupPath + "/Diem.txt");
            for (int i = 0; i < dgBangdiem.RowCount - 1; i++)
            {
                if (txtMa.Text == dgBangdiem[0, i].Value.ToString() && cbLop.Text == dgBangdiem[2, i].Value.ToString())
                {
                    dgBangdiem[1, hangchon].Value = cbTen.Text.Trim();
                    dgBangdiem[4, hangchon].Value = txtMieng.Text.Trim();
                    dgBangdiem[5, hangchon].Value = srtdiem15;
                    dgBangdiem[6, hangchon].Value = srtdiem45;
                    dgBangdiem[7, hangchon].Value = txtthuchanh.Text.Trim();
                    dgBangdiem[8, hangchon].Value = txthocki.Text.Trim();
                    dgBangdiem[9, hangchon].Value = cbHanhkiem.Text.Trim();
                    dgBangdiem[10, hangchon].Value = cbHocki.Text.Trim();
                    dgBangdiem[13, hangchon].Value = txtGhichu.Text.Trim();
                }
            }
            cl.WriteDataGridViewToFile(dgBangdiem, Application.StartupPath + "/Diem.txt");
            cbHocki_SelectedIndexChanged(sender, e);
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgBangdiem.Rows.Clear();
                cl.LoadToDataGridView(dgBangdiem, Application.StartupPath + "/Diem.txt");
                //
                for (int i = 0; i < dgBangdiem.RowCount - 1; i++)
                {
                    if (txtMa.Text == dgBangdiem[0, i].Value.ToString() && cbLop.Text == dgBangdiem[2, i].Value.ToString())
                    {
                        dgBangdiem.Rows.RemoveAt(i);
                    }
                }
                cl.WriteDataGridViewToFile(dgBangdiem, Application.StartupPath + "/Diem.txt");
                cbHocki_SelectedIndexChanged(sender, e);
            }
        }

        private void txtMieng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else e.Handled = false;
        }

        private void txt151_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void txt152_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void txt153_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void txt451_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void txt452_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void txt453_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void txtthuchanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void txthocki_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMieng_KeyPress(sender, e);
        }

        private void cbNienkhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
            else e.Handled = false;
        }

        private void cbNamhoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            cbNienkhoa_KeyPress(sender, e);
        }
        //
        private void txtMieng_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txtMieng);
        }

        private void txt151_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txt151);
        }

        private void txt152_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txt152);
        }

        private void txt153_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txt153);
        }

        private void txt451_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txt451);

        }

        private void txt452_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txt452);
        }

        private void txt453_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txt453);
        }

        private void txtthuchanh_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txtthuchanh);
        }

        private void txthocki_Leave(object sender, EventArgs e)
        {
            cl.Sosanh(txthocki);
        }
    }
}
