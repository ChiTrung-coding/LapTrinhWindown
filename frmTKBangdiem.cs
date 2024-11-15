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
    public partial class frmTKBangdiem : Form
    {
        public frmTKBangdiem()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
        private void frmTKBangdiem_Load(object sender, EventArgs e)
        {
            cl.AdddatainCb(cbLop, 2, Application.StartupPath + "/Hocsinh.txt");
            cl.AdddatainCb(cbNamhoc, 3, Application.StartupPath + "/Hocsinh.txt");
            cl.AdddatainCb(cbNienkhoa, 4, Application.StartupPath + "/Hocsinh.txt");
            cl.AdddatainCb2(cbMon, 1, Application.StartupPath + "/Banhoc.txt");
            cl.LoadToDataGridView(dgbangdiem, Application.StartupPath + "/Diem.txt");
            cl.LocDuLieuTrung(cbLop);
            cl.LocDuLieuTrung(cbNienkhoa);
            cl.LocDuLieuTrung(cbNamhoc);

            double Tong = 0;
            for (int i = dgbangdiem.RowCount - 2; i >= 0; i--)
            {
                string[] t15 = dgbangdiem[5, i].Value.ToString().Split(',');
                string[] t45 = dgbangdiem[6, i].Value.ToString().Split(',');
                float pmieng = float.Parse(dgbangdiem[4, i].Value.ToString());
                //
                float p151 = float.Parse(t15[0]);
                float p152 = float.Parse(t15[1]);
                float p153 = float.Parse(t15[2]);
                //
                float p451 = float.Parse(t45[0]);
                float p452 = float.Parse(t45[1]);
                float p453 = float.Parse(t45[2]);
                // 
                float th = float.Parse(dgbangdiem[7, i].Value.ToString());
                //
                float hk = float.Parse(dgbangdiem[8, i].Value.ToString());
                //
                Tong = (pmieng + p151 + p152 + p153) + (p451 + p452 + p453 + th) * 2 + (hk) * 3;
                double Chia = Tong / 15;
                double TBM = Math.Round(Chia, 2);
                dgbangdiem[14, i].Value = TBM.ToString();
            }
            cl.WriteDataGridViewToFile(dgbangdiem, "Thongke.txt");
            //dgbangdiem.Rows.Clear();
        }


        private void cbNienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgbangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgbangdiem, "Thongke.txt");
            clsThaotac.LocDataGridView(dgbangdiem, cbNienkhoa, 12);
        }

        private void cbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgbangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgbangdiem, "Thongke.txt");
            clsThaotac.LocDataGridView(dgbangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgbangdiem, cbNamhoc, 11);
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgbangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgbangdiem, "Thongke.txt");
            clsThaotac.LocDataGridView(dgbangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgbangdiem, cbNamhoc, 11);
            clsThaotac.LocDataGridView(dgbangdiem, cbLop, 2);
        }

        private void cbThoidiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgbangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgbangdiem, "Thongke.txt");
            clsThaotac.LocDataGridView(dgbangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgbangdiem, cbNamhoc, 11);
            clsThaotac.LocDataGridView(dgbangdiem, cbLop, 2);
            clsThaotac.LocDataGridView(dgbangdiem, cbMon, 3);
        }

        private void cbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgbangdiem.Rows.Clear();
            cl.LoadToDataGridView(dgbangdiem, "Thongke.txt");
            clsThaotac.LocDataGridView(dgbangdiem, cbNienkhoa, 12);
            clsThaotac.LocDataGridView(dgbangdiem, cbNamhoc, 11);
            clsThaotac.LocDataGridView(dgbangdiem, cbLop, 2);
            clsThaotac.LocDataGridView(dgbangdiem, cbHoki, 3);
            clsThaotac.LocDataGridView(dgbangdiem, cbMon, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsThaotac.Export2Excel(dgbangdiem);
        }

    }
}
