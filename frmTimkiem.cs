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
    public partial class frmTimkiem : Form
    {
        public frmTimkiem()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
        private void btTimkiem_Click(object sender, EventArgs e)
            {
            dgTimkiem.Rows.Clear();
            cl.LoadToDataGridView(dgTimkiem, Application.StartupPath + "/timkiem.txt");
            //clsThaotac.LocDataGridView(dgTimkiem, cbNamhoc, 9);
            clsThaotac.LocDataGridView(dgTimkiem, cbThoidiem,8 );
            if (rbTkTen.Checked == true)
            { clsThaotac.LocDataGridView(dgTimkiem, cbTimkiem, 1); }
            if (rbTkQue.Checked == true)
                {clsThaotac.LocDataGridView(dgTimkiem, cbTimkiem, 7);}
            if (rbTkHocluc.Checked == true)
            { clsThaotac.LocDataGridView(dgTimkiem, cbTimkiem,10); }
            if (rbTkHanhkiem.Checked == true)
            { clsThaotac.LocDataGridView(dgTimkiem, cbTimkiem, 9); }
        }

        private void rbTkTen_CheckedChanged(object sender, EventArgs e)
        {

            cl.AdddatainCb(cbTimkiem, 1, Application.StartupPath + "/timkiem.txt"); cl.LocDuLieuTrung(cbTimkiem);
        }

        private void rbTkQue_CheckedChanged(object sender, EventArgs e)
        {
            cl.AdddatainCb(cbTimkiem, 7, Application.StartupPath + "/timkiem.txt"); cl.LocDuLieuTrung(cbTimkiem);
        }

        private void rbTkHocluc_CheckedChanged(object sender, EventArgs e)
        {
        cbTimkiem.Items.Clear();
            string[] mang ={"Giỏi","Khá","Trung bình","Yếu","Kém" };
            cbTimkiem.Items.AddRange(mang);
        }

        private void rbTkHanhkiem_CheckedChanged(object sender, EventArgs e)
        {
        cbTimkiem.Items.Clear();
        string[] mang = { "Tốt", "Khá", "TB", "Yếu", "Kém" };
        cbTimkiem.Items.AddRange(mang);
        }

        private void frmTimkiem_Load(object sender, EventArgs e)
        {

            cl.LoadToDataGridView(dgTimkiem, Application.StartupPath + "/Hocsinh.txt");
            StreamReader sr = new StreamReader(Application.StartupPath + "/Thongke.txt");
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                for (int i = 0; i < dgTimkiem.RowCount - 1; i++)
                {
                    dgTimkiem[8, i].Value = "";
                    dgTimkiem[9, i].Value = "";
                    dgTimkiem[10, i].Value = "";

                    if (mang[0].ToLower().Trim() == dgTimkiem[0, i].Value.ToString().ToLower().Trim() && mang[1].ToLower().Trim() == dgTimkiem[1, i].Value.ToString().ToLower().Trim())
                    {

                        dgTimkiem[8, i].Value = mang[10].Trim();
                        dgTimkiem[9, i].Value = mang[9].Trim();
                        dgTimkiem[10, i].Value = mang[15].Trim();


                    }

                }
                Line = sr.ReadLine();
            }
            sr.Close();
            cl.WriteDataGridViewToFile(dgTimkiem, Application.StartupPath + "/Timkiem.txt");
            dgTimkiem.Rows.Clear();
        }

        
    }
}
