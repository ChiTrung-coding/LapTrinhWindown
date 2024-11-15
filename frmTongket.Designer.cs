namespace ChuongtrinhQLDiemTHPT
{
    partial class frmTongket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongket));
            this.dgTongket = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNienkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgoaingu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCongnghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTinhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGDCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTBCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNamhoc = new System.Windows.Forms.ComboBox();
            this.btThongke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbhocki = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTongket)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTongket
            // 
            this.dgTongket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTongket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTongket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTen,
            this.clLop,
            this.clHocKi,
            this.clNienkhoa,
            this.clNamhoc,
            this.clToan,
            this.clLy,
            this.clHoa,
            this.clSinh,
            this.clVan,
            this.clNgoaingu,
            this.clSu,
            this.clDia,
            this.clCongnghe,
            this.clTD,
            this.clTinhoc,
            this.clGDCD,
            this.clTBCM,
            this.clHocLuc,
            this.clHanhkiem});
            this.dgTongket.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgTongket.Location = new System.Drawing.Point(0, 0);
            this.dgTongket.Name = "dgTongket";
            this.dgTongket.RowHeadersVisible = false;
            this.dgTongket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTongket.Size = new System.Drawing.Size(968, 399);
            this.dgTongket.TabIndex = 0;
            // 
            // clMa
            // 
            this.clMa.HeaderText = "Mã HS";
            this.clMa.Name = "clMa";
            this.clMa.ReadOnly = true;
            // 
            // clTen
            // 
            this.clTen.HeaderText = "Họ và Tên";
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            // 
            // clLop
            // 
            this.clLop.HeaderText = "Lớp";
            this.clLop.Name = "clLop";
            this.clLop.ReadOnly = true;
            // 
            // clHocKi
            // 
            this.clHocKi.HeaderText = "Học Kì";
            this.clHocKi.Name = "clHocKi";
            this.clHocKi.ReadOnly = true;
            // 
            // clNienkhoa
            // 
            this.clNienkhoa.HeaderText = "Niên khóa";
            this.clNienkhoa.Name = "clNienkhoa";
            this.clNienkhoa.ReadOnly = true;
            // 
            // clNamhoc
            // 
            this.clNamhoc.HeaderText = "Năm học";
            this.clNamhoc.Name = "clNamhoc";
            this.clNamhoc.ReadOnly = true;
            // 
            // clToan
            // 
            this.clToan.HeaderText = "Toán";
            this.clToan.Name = "clToan";
            this.clToan.ReadOnly = true;
            // 
            // clLy
            // 
            this.clLy.HeaderText = "Lý";
            this.clLy.Name = "clLy";
            this.clLy.ReadOnly = true;
            // 
            // clHoa
            // 
            this.clHoa.HeaderText = "Hóa";
            this.clHoa.Name = "clHoa";
            this.clHoa.ReadOnly = true;
            // 
            // clSinh
            // 
            this.clSinh.HeaderText = "Sinh";
            this.clSinh.Name = "clSinh";
            this.clSinh.ReadOnly = true;
            // 
            // clVan
            // 
            this.clVan.HeaderText = "Văn";
            this.clVan.Name = "clVan";
            this.clVan.ReadOnly = true;
            // 
            // clNgoaingu
            // 
            this.clNgoaingu.HeaderText = "Ngoại ngữ";
            this.clNgoaingu.Name = "clNgoaingu";
            this.clNgoaingu.ReadOnly = true;
            // 
            // clSu
            // 
            this.clSu.HeaderText = "Sử";
            this.clSu.Name = "clSu";
            this.clSu.ReadOnly = true;
            // 
            // clDia
            // 
            this.clDia.HeaderText = "Địa";
            this.clDia.Name = "clDia";
            this.clDia.ReadOnly = true;
            // 
            // clCongnghe
            // 
            this.clCongnghe.HeaderText = "Công nghệ";
            this.clCongnghe.Name = "clCongnghe";
            this.clCongnghe.ReadOnly = true;
            // 
            // clTD
            // 
            this.clTD.HeaderText = "TD";
            this.clTD.Name = "clTD";
            this.clTD.ReadOnly = true;
            // 
            // clTinhoc
            // 
            this.clTinhoc.HeaderText = "Tin học";
            this.clTinhoc.Name = "clTinhoc";
            this.clTinhoc.ReadOnly = true;
            // 
            // clGDCD
            // 
            this.clGDCD.HeaderText = "Giáo dục công dân";
            this.clGDCD.Name = "clGDCD";
            this.clGDCD.ReadOnly = true;
            // 
            // clTBCM
            // 
            this.clTBCM.HeaderText = "TB các môn";
            this.clTBCM.Name = "clTBCM";
            this.clTBCM.ReadOnly = true;
            // 
            // clHocLuc
            // 
            this.clHocLuc.HeaderText = "Hoc lực";
            this.clHocLuc.Name = "clHocLuc";
            this.clHocLuc.ReadOnly = true;
            // 
            // clHanhkiem
            // 
            this.clHanhkiem.HeaderText = "Hạnh kiểm";
            this.clHanhkiem.Name = "clHanhkiem";
            this.clHanhkiem.ReadOnly = true;
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Location = new System.Drawing.Point(122, 420);
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(121, 24);
            this.cbNamhoc.TabIndex = 1;
            this.cbNamhoc.SelectedIndexChanged += new System.EventHandler(this.cbNamhoc_SelectedIndexChanged);
            // 
            // btThongke
            // 
            this.btThongke.Location = new System.Drawing.Point(828, 414);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(75, 41);
            this.btThongke.TabIndex = 2;
            this.btThongke.Text = "&In phiếu";
            this.btThongke.UseVisualStyleBackColor = true;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm học";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(366, 420);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 24);
            this.cbLop.TabIndex = 1;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp";
            // 
            // cbhocki
            // 
            this.cbhocki.FormattingEnabled = true;
            this.cbhocki.Items.AddRange(new object[] {
            "Kì I",
            "Kì II"});
            this.cbhocki.Location = new System.Drawing.Point(596, 420);
            this.cbhocki.Name = "cbhocki";
            this.cbhocki.Size = new System.Drawing.Size(121, 24);
            this.cbhocki.TabIndex = 1;
            this.cbhocki.SelectedIndexChanged += new System.EventHandler(this.cbhocki_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học kì";
            // 
            // frmTongket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThongke);
            this.Controls.Add(this.cbhocki);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbNamhoc);
            this.Controls.Add(this.dgTongket);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTongket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng Kết";
            this.Load += new System.EventHandler(this.frmTongket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTongket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTongket;
        private System.Windows.Forms.ComboBox cbNamhoc;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNienkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgoaingu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCongnghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTinhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGDCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTBCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHanhkiem;
        private System.Windows.Forms.ComboBox cbhocki;
        private System.Windows.Forms.Label label2;
    }
}