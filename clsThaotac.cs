using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ms=Microsoft.Office.Interop.Excel;

namespace ChuongtrinhQLDiemTHPT
{
    class clsThaotac
    {
        /// <summary>
        /// Phương thức Load dữ liệu từ Text lên DataGridView
        /// </summary>
        /// <param name="dg">Tên DataGridView</param>
        /// <param name="TenFile">Tên File</param>
        public void LoadToDataGridView(DataGridView dg, string TenFile)
        {
            StreamReader sr = new StreamReader(TenFile);
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                dg.Rows.Add(mang);
                Line = sr.ReadLine();
            }
            sr.Close();
        }
        /// <summary>
        /// Phương thức Lưu Dữ liệu vào Text từ DataGridView
        /// </summary>
        /// <param name="dg">Tên DataGridView</param>
        /// <param name="pathFile">Tên File</param>
        public void WriteDataGridViewToFile(DataGridView dg, string pathFile)
        {
            StreamWriter sw = new StreamWriter(pathFile);
            string Line = "";

            for (int i = 0; i < dg.Rows.Count - 1; ++i)
            {
                if (i == dg.NewRowIndex)
                {
                    break;
                }
                Line = "";
                for (int j = 0; j < dg.Columns.Count; ++j)
                {
                    Line += dg[j, i].Value + ";";
                }
                sw.WriteLine(Line);
            }
            sw.Close();
        }
        /// <summary>
        /// Phương thức ghi nối dữ liệu
        /// </summary>
        /// <param name="TenFile">Tên tệp ghi</param>
        /// <param name="Dulieu">Dữ liệu cần ghi</param>
        public void SavedataToFile(string TenFile, string Dulieu)
        {
            StreamWriter sw = File.AppendText(TenFile);
            sw.WriteLine(Dulieu);
            sw.Close();
        }
        /// <summary>
        /// Phương thức chèn vào Combobox
        /// </summary>
        /// <param name="cb">ComboBox</param>
        /// <param name="chiso">Chỉ số mảng trong tệp dữ liệu</param>
        /// <param name="TenFile">Tên Tệp</param>
        public void AdddatainCb(ComboBox cb, byte chiso, string TenFile)
        {

            cb.Items.Clear();
            StreamReader sr = new StreamReader(TenFile);
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                cb.Items.Add(mang[chiso]);
                Line = sr.ReadLine();
            }
            sr.Close();

        }
        /// <summary>
        /// Phương thức chèn vào Combobox
        /// </summary>
        /// <param name="cb">ComboBox</param>
        /// <param name="chiso">Chỉ số mảng trong tệp dữ liệu</param>
        /// <param name="TenFile">Tên Tệp</param>
        public void AdddatainCb2(ComboBox cb, byte chiso, string TenFile)
        {

            cb.Items.Clear();
            StreamReader sr = new StreamReader(TenFile);
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                string a = mang[0].Substring(mang[0].Length - 2, 1);
                cb.Items.Add(mang[chiso] + " " + a + mang[2]);
                Line = sr.ReadLine();
            }
            sr.Close();

        }
        /// <summary>
        /// Phương thức Lọc dữ liệu trùng trong DataGridView, lấy ra một dữ liệu đưa vào.
        /// </summary>
        /// <param name="dgr">DataGridView</param>
        /// <param name="cb">ComboBox đưa dư liệu vào</param>
        /// <param name="chiso">Chỉ số cột</param>
        public static void LocDataGridView(DataGridView dgr, ComboBox cb, byte chiso)
        {
            for (int i = dgr.RowCount - 2; i >= 0; i--)
            {
                string a = dgr[chiso, i].Value.ToString().ToLower().Trim();
                if (cb.Text.ToLower().Trim() != a)
                {
                    dgr.Rows.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// Phương thức hiển thị giờ.
        /// </summary>
        /// <param name="Ngaythangnam">Đưa ra ngày tháng</param>
        /// <param name="Gio">Đưa ra giờ hệ thống</param>
        /// <param name="timeofday">Thời gian của ngày</param>
        public void Hienngay(ref string Ngaythangnam, ref string Gio, ref string timeofday)
        {
            string[] a = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] b = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };
            string[] c = { "AM", "PM" };
            string[] d = { "Sáng", "Chiều" };
            string thu = "";
            string tgngay = "";
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string thoigian = DateTime.Now.ToString().Substring(9, 9);
            //
            for (int i = 0; i < c.Length; i++)
            {
                if (DateTime.Now.ToString().Substring(DateTime.Now.ToString().Length - 2, 2).ToLower().Trim() == c[i].ToLower().Trim())
                { tgngay = d[i]; }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (DateTime.Now.DayOfWeek.ToString().ToLower().Trim() == a[i].ToLower().Trim())
                { thu = b[i]; }

            }
            Ngaythangnam = thu + ", " + ngay + "/" + thang + "/" + nam;
            Gio = thoigian;
            timeofday = tgngay;
        }
        /// <summary>
        /// Phương thức Lọc dữ liệu trùng trong ComboBox.
        /// </summary>
        /// <param name="cb">ComboBox</param>
        public void LocDuLieuTrung(ComboBox cb)
        {
            for (int j = 0; j < cb.Items.Count; j++)
            {
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (cb.Items[j].ToString() == cb.Items[i].ToString())
                    {
                        cb.Items.RemoveAt(i);
                    }
                }
            }
        }
        /// <summary>
        /// Đối chiếu dữ liệu trung nhau giữa hai ComboBox.
        /// </summary>
        /// <param name="cb1">ComboBox 1</param>
        /// <param name="cb2">ComboBox 2</param>
        /// <param name="TenTep">Tên Tệp lưu dữ liệu</param>
        public void DoichieuDL(ComboBox cb1, ComboBox cb2, string TenFile)
        {
            cb2.Items.Clear();
            StreamReader sr = new StreamReader(TenFile);
            string Line = sr.ReadLine();
            while ((Line != null) && (Line != " "))
            {
                string[] mang = Line.Split(';');
                if (cb1.Text.ToLower().Trim() == mang[2].ToLower().Trim())
                {

                    cb2.Items.Add(mang[1]);
                }
                Line = sr.ReadLine();
            }
            sr.Close();
        }
        /// <summary>
        /// Kiểm tra nhập điểm 0-10
        /// </summary>
        /// <param name="txt">TextBox điểm</param>
        public void Sosanh(TextBox txt)
        {
            if (txt.Text == null || txt.Text == "")
            { txt.Text = "0"; }
            else
            {
                float diem = float.Parse(txt.Text); if (diem > 10) { MessageBox.Show("Nhap vào điểm trong khoảng 0-10, xin mời nhập lại."); txt.Focus(); }
            }
        }
        /// <summary>
        /// Ghi dữ liệu vào Excel.
        /// </summary>
        /// <param name="dgr">DataGridView</param>
        public static void Export2Excel(DataGridView dgr)
        {
            System.Globalization.CultureInfo old = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ms.ApplicationClass exa = new ms.ApplicationClass();
            ms.Workbook wb = exa.Application.Workbooks.Add(ms.XlSheetType.xlWorksheet);
            ms.Worksheet ws = (ms.Worksheet)exa.ActiveSheet;
            exa.Visible = true;
            for (int i = 0; i < dgr.Columns.Count; ++i)
            {
                ws.Cells[1, i + 1] = dgr.Columns[i].HeaderText;
            }
            ms.Range ran = ws.get_Range("a1", "z1");
            ran.Font.Bold = true;
            ran.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Navy);

            for (int i = 0; i < dgr.Rows.Count; ++i)
            {
                for (int j = 0; j < dgr.Columns.Count; ++j)
                {
                    ws.Cells[i + 2, j + 1] = dgr[j, i].Value;
                }
            }
            ws.Columns.AutoFit();
            System.Threading.Thread.CurrentThread.CurrentCulture = old;
        }
        public static void Timtu(DataGridView dg,ComboBox cb, string TenTep)
        {
            StreamReader findword = File.OpenText(TenTep);
            string strxau = findword.ReadLine();
            string[] splitstr;

            while (strxau != null && strxau != "")
            {
                splitstr = strxau.Split(';');
                int i = 0;
                while (i <= splitstr[1].Length - cb.Text.Length)
                {
                    if (splitstr[1].Substring(i, cb.Text.Length).Equals(cb.Text, StringComparison.OrdinalIgnoreCase))
                    {

                        dg.Rows.Add();
                        dg[i, dg.Rows.Count - 2].Value = splitstr[i];
                        break;
                    }
                    else
                    { ++i; }

                }
                strxau = findword.ReadLine();
            }
            findword.Close();
        }
    }
}

