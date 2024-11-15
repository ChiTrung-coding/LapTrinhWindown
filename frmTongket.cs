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
    public partial class frmTongket : Form
    {
        public frmTongket()
        {
            InitializeComponent();
        }
        clsThaotac cl = new clsThaotac();
        void Load1()
        {
            StreamReader sr = new StreamReader("Hocsinh.txt");
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                string[] xau = new string[] { mang[0], mang[1], mang[2],"", mang[3], mang[4] };
                dgTongket.Rows.Add(xau);
                Line = sr.ReadLine();
            }
            sr.Close();

        }
        void Load2() 
        {
            StreamReader sr1 = new StreamReader("Diem.txt");
            string Line1 = sr1.ReadLine();
            while ((Line1 != null) && (Line1 != " "))
            {
                string[] xau = Line1.Split(';');


                for (int i = dgTongket.Rows.Count - 2; i >= 0; i--)
                {
                    if (xau[0] == dgTongket[0, i].Value.ToString())
                    { dgTongket[3, i].Value = xau[10]; }
                }

                Line1 = sr1.ReadLine();
            }
            sr1.Close();
        }
        void Tinhtong()
        {
            float Tong = 0;
            for (int i = 0; i < dgTongket.Rows.Count - 1; i++)
            {
                bool ktrong = false;
                for (int j = 6; j < 17; j++)
                {
                    if (dgTongket[j, i].Value == null)
                    {
                        ktrong = true;
                        break;
                    }
                }
                if (ktrong == true)
                {
                    dgTongket[18, i].Value = string.Copy("Chưa đủ điểm .");
                    continue;
                }
                //viet tinh tong nhu bin hthuong

                float Toan = float.Parse(dgTongket[6, i].Value.ToString());
                float Li = float.Parse(dgTongket[7, i].Value.ToString());
                float Hoa = float.Parse(dgTongket[8, i].Value.ToString());
                float Sinh = float.Parse(dgTongket[9, i].Value.ToString());
                float Van = float.Parse(dgTongket[10, i].Value.ToString());
                float NN = float.Parse(dgTongket[11, i].Value.ToString());
                float Su = float.Parse(dgTongket[12, i].Value.ToString());
                float Dia = float.Parse(dgTongket[13, i].Value.ToString());
                float CN = float.Parse(dgTongket[14, i].Value.ToString());
                float TD = float.Parse(dgTongket[15, i].Value.ToString());
                float TH = float.Parse(dgTongket[16, i].Value.ToString());
                float GDCD = float.Parse(dgTongket[17, i].Value.ToString());

                if (dgTongket[2, i].Value.ToString().Substring(dgTongket[2, i].Value.ToString().Length - 2, 1).ToLower() == "a")
                {
                    Tong = (Toan * 2 + Li * 2 + Hoa * 2 + Sinh * 2 + Van + NN + Su + Dia + CN + TD + TH + GDCD) / 16;
                }
                if (dgTongket[2, i].Value.ToString().Substring(dgTongket[2, i].Value.ToString().Length - 2, 1).ToLower() == "b")
                {
                    Tong = (Toan + Li + Hoa + Sinh + Van + NN + Su + Dia + CN + TD + TH + GDCD) / 12;
                }
                if (dgTongket[2, i].Value.ToString().Substring(dgTongket[2, i].Value.ToString().Length - 2, 1).ToLower() == "c")
                {
                    Tong = (Toan + Li + Hoa + Sinh + Van * 2 + NN * 2 + Su * 2 + Dia * 2 + CN + TD + TH + GDCD) / 16;
                }

                dgTongket[18, i].Value = Tong.ToString();

                float giatri=float.Parse(dgTongket[18,i].Value.ToString());

                if (giatri > 8.5) { dgTongket[19, i].Value = "Giỏi"; }
                if (giatri < 8.5&&giatri>6.5) { dgTongket[19, i].Value = "Khá"; }
                if (giatri<6.5&&giatri>5) { dgTongket[19, i].Value = "Trung Bình"; }
                if (giatri < 5&&giatri>3.5) { dgTongket[19, i].Value = "Yếu"; }
                if (giatri < 3.5) { dgTongket[19, i].Value = "Kém"; }
                    
                    
            }
        }
        private void frmTongket_Load(object sender, EventArgs e)
        {
            Load1();
            Load2();
            StreamReader sr = new StreamReader("Thongke.txt");
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');


                for (int i = dgTongket.Rows.Count - 2; i >= 0; i--)
                {
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Toán")
                    { dgTongket[6, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Lí")
                    { dgTongket[7, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Hóa")
                    { dgTongket[8, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Sinh")
                    { dgTongket[9, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Văn")
                    { dgTongket[10, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Ngoại ngữ")
                    { dgTongket[11, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Sử")
                    { dgTongket[12, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Địa")
                    { dgTongket[13, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Công nghệ")
                    { dgTongket[14, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "TD")
                    { dgTongket[15, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Tin học")
                    { dgTongket[16, i].Value = mang[14]; }
                    if (dgTongket[0, i].Value.ToString() == mang[0] && mang[3].Substring(0, mang[3].Length - 3) == "Giáo dục công dân")
                    { dgTongket[17, i].Value = mang[14]; }
                }

                Line = sr.ReadLine();
            }
            sr.Close();
            Tinhtong();
            cl.WriteDataGridViewToFile(dgTongket, "Tongket.txt");

            cl.AdddatainCb(cbLop,2, Application.StartupPath + "/Hocsinh.txt");
            cl.AdddatainCb(cbNamhoc, 4, Application.StartupPath + "/Hocsinh.txt");
            cl.LocDuLieuTrung(cbLop);
            cl.LocDuLieuTrung(cbNamhoc);
        }

        private void cbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgTongket.Rows.Clear();
            cl.LoadToDataGridView(dgTongket, "Tongket.txt");
            clsThaotac.LocDataGridView(dgTongket, cbNamhoc, 5);
        }
      

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgTongket.Rows.Clear();
            cl.LoadToDataGridView(dgTongket, "Tongket.txt");
            clsThaotac.LocDataGridView(dgTongket, cbNamhoc, 5);
            clsThaotac.LocDataGridView(dgTongket, cbLop, 2);
        }

        private void cbhocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgTongket.Rows.Clear();
            cl.LoadToDataGridView(dgTongket, "Tongket.txt");
            clsThaotac.LocDataGridView(dgTongket, cbNamhoc, 5);
            clsThaotac.LocDataGridView(dgTongket, cbLop, 2);
            clsThaotac.LocDataGridView(dgTongket, cbhocki, 3);
        }
        private void btThongke_Click(object sender, EventArgs e)
        {
            clsThaotac.Export2Excel(dgTongket);
        }
    }
       
}
