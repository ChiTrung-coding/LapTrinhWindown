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
    public partial class frmQLBanhoc : Form
    {
        public frmQLBanhoc()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
        int hangchon ;
        public void Moi()
        {
            cmbMon.Text = ""; cbBanhoc.Text = ""; cmbHeso.Text = "";
        }
        private void cbBanhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgMonhoc.Rows.Clear();
            cl.LoadToDataGridView(dgMonhoc, Application.StartupPath + "/Banhoc.txt");
            clsThaotac.LocDataGridView(dgMonhoc, cbBanhoc, 0);
        }

        private void dgMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangchon = e.RowIndex;
            cbBanhoc.Text = dgMonhoc[0, hangchon].Value.ToString();
            cmbMon.Text = dgMonhoc[1, hangchon].Value.ToString();
            cmbHeso.Text = dgMonhoc[2, hangchon].Value.ToString();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            //string a = cbBanhoc.Text.Substring(cbBanhoc.Text.Length - 2, 1);
            int dem = 0;
            for (int j =dgMonhoc.RowCount - 2 ; j >= 0  ; j--)
            {
                if ((cmbMon.Text == dgMonhoc[1, j].Value.ToString()))
                {
                    dem = dem +1;
                }
            }
            if(dem==0)
            {
                if (cmbMon.Text != ""&& cbBanhoc.Text != "" && cmbHeso.Text != "")
                {
                    //
                    string[] mang = { cbBanhoc.Text.Trim(), cmbMon.Text.Trim(), cmbHeso.Text.Trim() };
                    dgMonhoc.Rows.Clear();
                    cl.LoadToDataGridView(dgMonhoc, Application.StartupPath + "/Banhoc.txt");
                    dgMonhoc.Rows.Add(mang);
                    MessageBox.Show("Nhập thành công ! ");
                    cl.WriteDataGridViewToFile(dgMonhoc, Application.StartupPath + "/Banhoc.txt");
                    //
                    cbBanhoc_SelectedIndexChanged(sender, e);
                    //
                }
                else
                {
                    MessageBox.Show("Không được để trống, vui lòng điền đầy đủ các thành phần quan trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                MessageBox.Show("Trùng thông tin với môn học khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //string a = cbBanhoc.Text.Substring(cbBanhoc.Text.Length - 2, 1);
                if (cmbMon.Text != "" && cbBanhoc.Text != "" && cmbHeso.Text != "")
                {

                    dgMonhoc.Rows.Clear();
                    cl.LoadToDataGridView(dgMonhoc, Application.StartupPath + "/Banhoc.txt");
                    for (int i = 0; i < dgMonhoc.RowCount - 1; ++i)
                    {
                        if (cbBanhoc.Text.ToLower().Trim() == dgMonhoc[0, i].Value.ToString().ToLower().Trim() && cmbMon.Text.ToLower().Trim()== dgMonhoc[1, i].Value.ToString().ToLower().Trim())
                        {
                            dgMonhoc[2, i].Value = cmbHeso.Text.Trim();
                            //dgMonhoc[1, i].Value = cmbMon.Text.Trim().Substring(0, cmbMon.Text.Trim().Length-2) + " " + a + "-" + cmbHeso.Text.Trim();
                        }
                    }
                    cl.WriteDataGridViewToFile(dgMonhoc, Application.StartupPath + "/Banhoc.txt");
                    //
                    cbBanhoc_SelectedIndexChanged(sender, e);
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
                dgMonhoc.Rows.Clear();
                cl.LoadToDataGridView(dgMonhoc, Application.StartupPath + "/Banhoc.txt");

                for (int i = 0; i < dgMonhoc.RowCount - 1; i++)
                {
                    if (cbBanhoc.Text.ToLower().Trim() == dgMonhoc[0, i].Value.ToString().ToLower().Trim() && cmbMon.Text.ToLower().Trim()== dgMonhoc[1, i].Value.ToString().ToLower().Trim())
                    {
                        dgMonhoc.Rows.RemoveAt(i);
                    }
                }
                cl.WriteDataGridViewToFile(dgMonhoc, Application.StartupPath + "/Banhoc.txt");
                cbBanhoc_SelectedIndexChanged(sender, e);
            }
        }

        private void frmQLBanhoc_Load(object sender, EventArgs e)
        {

        }

        private void cmbHeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else e.Handled = false;
        }

       
       
    }
}
