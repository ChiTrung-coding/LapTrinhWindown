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
    public partial class frmQLLop : Form
    {
        public frmQLLop()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
        int hangchon;
        void Trong()
        {
            cbBanhoc.Text = "";
            cbLop.Text = "";
        }
        private void frmQLLop_Load(object sender, EventArgs e)
        {
        }

        private void dgQLLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hangchon = e.RowIndex;
            cbLop.Text = dgQLLop[1, hangchon].Value.ToString();
            cbNamhoc.Text = dgQLLop[2, hangchon].Value.ToString();
            cbBanhoc.Text = dgQLLop[3, hangchon].Value.ToString();

        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int j = dgQLLop.RowCount - 2; j >= 0; j--)
            {
                if ((cbLop.Text.ToLower().Trim() == dgQLLop[1, j].Value.ToString().ToLower().Trim() && cbBanhoc.Text.ToLower().Trim() == dgQLLop[2, j].Value.ToString().ToLower().Trim()) || (cbLop.Text.ToLower().Trim() == dgQLLop[1, j].Value.ToString().ToLower().Trim()))
                {
                    dem = dem + 1;
                }
            }
            if (dem == 0)
            {
                if (cbLop.Text != "" && cbBanhoc.Text != "")
                {
                    //
                    string[] mang = { "", cbLop.Text.Trim(), cbNamhoc.Text.Trim(), cbBanhoc.Text.Trim() };
                    dgQLLop.Rows.Clear();
                    cl.LoadToDataGridView(dgQLLop, "Lop.txt");
                    dgQLLop.Rows.Add(mang); 
                    cl.WriteDataGridViewToFile(dgQLLop, "Lop.txt");
                    cbNamhoc_SelectedIndexChanged(sender, e);
                    cbLop.Text = "";
                    //

                }
                else
                {
                    MessageBox.Show("Không được để trống, vui lòng điền đầy đủ các thành phần quan trọng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Trùng thông tin với lớp khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbLop.Text != "" && cbBanhoc.Text != "")
            {
                int a = 0;
                for (int i = 0; i < dgQLLop.Rows.Count - 1; i++)
                {
                    int b = int.Parse(dgQLLop[0, i].Value.ToString());
                    a = b + 1;
                }
                //
                dgQLLop.Rows.Clear();
                cl.LoadToDataGridView(dgQLLop, "Lop.txt");
                for (int i = 0; i < dgQLLop.RowCount - 1; ++i)
                {
                    if (cbLop.Text.ToLower().Trim() == dgQLLop[1, i].Value.ToString().ToLower().Trim() && cbNamhoc.Text.ToLower().Trim() == dgQLLop[2, i].Value.ToString().ToLower().Trim())
                    {
                        dgQLLop[3, i].Value = cbBanhoc.Text.Trim();
                    }
                }
                cl.WriteDataGridViewToFile(dgQLLop, "Lop.txt");
                cbNamhoc_SelectedIndexChanged(sender, e);
                Trong();
                //

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
                dgQLLop.Rows.Clear();
                cl.LoadToDataGridView(dgQLLop, "Lop.txt");

                for (int i = 0; i < dgQLLop.RowCount - 1; i++)
                {
                    if (cbLop.Text.ToLower().Trim() == dgQLLop[1, i].Value.ToString().ToLower().Trim() && cbNamhoc.Text.ToLower().Trim() == dgQLLop[2, i].Value.ToString().ToLower().Trim())
                    {
                        dgQLLop.Rows.RemoveAt(i);
                    }
                }
                cl.WriteDataGridViewToFile(dgQLLop, "Lop.txt");
                cbNamhoc_SelectedIndexChanged(sender, e);
                int a = dgQLLop.Rows.Count;
                for (int i = dgQLLop.Rows.Count - 2; i >= hangchon; i--)
                {
                    --a;
                    dgQLLop[0, i].Value = a.ToString();

                }
                Trong();

            }
        }

        private void cbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgQLLop.Rows.Clear();
            cl.LoadToDataGridView(dgQLLop, "Lop.txt");
            clsThaotac.LocDataGridView(dgQLLop, cbNamhoc, 2);
            int a = 1;
            for (int i = 0; i < dgQLLop.Rows.Count - 1; i++)
            {
                dgQLLop[0, i].Value = a.ToString();
                ++a;
            }
        }

        private void cbNamhoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
            else e.Handled = false;
        }

    }
}
