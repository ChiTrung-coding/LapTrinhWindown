namespace ChuongtrinhQLDiemTHPT
{
    partial class frmTKBangdiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKBangdiem));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgbangdiem = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNienkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTBm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbHoki = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNamhoc = new System.Windows.Forms.ComboBox();
            this.cbNienkhoa = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbangdiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgbangdiem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.cbMon);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.cbHoki);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cbNamhoc);
            this.splitContainer1.Panel2.Controls.Add(this.cbNienkhoa);
            this.splitContainer1.Panel2.Controls.Add(this.cbLop);
            this.splitContainer1.Size = new System.Drawing.Size(953, 464);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgbangdiem
            // 
            this.dgbangdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgbangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbangdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTen,
            this.clLop,
            this.clMonhoc,
            this.clMieng,
            this.cl15,
            this.cl45,
            this.clTH,
            this.clDiemthi,
            this.clHanhkiem,
            this.clThoidiem,
            this.clNamhoc,
            this.clNienkhoa,
            this.clGhichu,
            this.clTBm});
            this.dgbangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgbangdiem.Location = new System.Drawing.Point(0, 0);
            this.dgbangdiem.Name = "dgbangdiem";
            this.dgbangdiem.RowHeadersVisible = false;
            this.dgbangdiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbangdiem.Size = new System.Drawing.Size(953, 326);
            this.dgbangdiem.TabIndex = 1;
            // 
            // clMa
            // 
            this.clMa.FillWeight = 60F;
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
            this.clLop.FillWeight = 60F;
            this.clLop.HeaderText = "Lớp";
            this.clLop.Name = "clLop";
            this.clLop.ReadOnly = true;
            // 
            // clMonhoc
            // 
            this.clMonhoc.FillWeight = 80F;
            this.clMonhoc.HeaderText = "Môn học";
            this.clMonhoc.Name = "clMonhoc";
            this.clMonhoc.ReadOnly = true;
            // 
            // clMieng
            // 
            this.clMieng.FillWeight = 30F;
            this.clMieng.HeaderText = "Miệng";
            this.clMieng.Name = "clMieng";
            this.clMieng.ReadOnly = true;
            // 
            // cl15
            // 
            this.cl15.FillWeight = 80F;
            this.cl15.HeaderText = "15 phút";
            this.cl15.Name = "cl15";
            this.cl15.ReadOnly = true;
            // 
            // cl45
            // 
            this.cl45.FillWeight = 80F;
            this.cl45.HeaderText = "45 phút";
            this.cl45.Name = "cl45";
            this.cl45.ReadOnly = true;
            // 
            // clTH
            // 
            this.clTH.FillWeight = 30F;
            this.clTH.HeaderText = "TH";
            this.clTH.Name = "clTH";
            this.clTH.ReadOnly = true;
            // 
            // clDiemthi
            // 
            this.clDiemthi.FillWeight = 30F;
            this.clDiemthi.HeaderText = "Điểm Thi";
            this.clDiemthi.Name = "clDiemthi";
            this.clDiemthi.ReadOnly = true;
            // 
            // clHanhkiem
            // 
            this.clHanhkiem.FillWeight = 80F;
            this.clHanhkiem.HeaderText = "Hạnh kiểm";
            this.clHanhkiem.Name = "clHanhkiem";
            this.clHanhkiem.ReadOnly = true;
            // 
            // clThoidiem
            // 
            this.clThoidiem.FillWeight = 80F;
            this.clThoidiem.HeaderText = "Học kì";
            this.clThoidiem.Name = "clThoidiem";
            this.clThoidiem.ReadOnly = true;
            // 
            // clNamhoc
            // 
            this.clNamhoc.HeaderText = "Năm học";
            this.clNamhoc.Name = "clNamhoc";
            this.clNamhoc.ReadOnly = true;
            // 
            // clNienkhoa
            // 
            this.clNienkhoa.HeaderText = "Niên khoá";
            this.clNienkhoa.Name = "clNienkhoa";
            this.clNienkhoa.ReadOnly = true;
            // 
            // clGhichu
            // 
            this.clGhichu.HeaderText = "Ghi Chú";
            this.clGhichu.Name = "clGhichu";
            this.clGhichu.ReadOnly = true;
            // 
            // clTBm
            // 
            this.clTBm.FillWeight = 80F;
            this.clTBm.HeaderText = "TBM";
            this.clTBm.Name = "clTBm";
            this.clTBm.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "&In Phieu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Niên Khóa";
            // 
            // cbMon
            // 
            this.cbMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(269, 52);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(117, 24);
            this.cbMon.TabIndex = 3;
            this.cbMon.SelectedIndexChanged += new System.EventHandler(this.cbThoidiem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học Kì";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(403, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông báo";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(526, 91);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // cbHoki
            // 
            this.cbHoki.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbHoki.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoki.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoki.FormattingEnabled = true;
            this.cbHoki.Items.AddRange(new object[] {
            "Kì I",
            "Kì II"});
            this.cbHoki.Location = new System.Drawing.Point(75, 86);
            this.cbHoki.Name = "cbHoki";
            this.cbHoki.Size = new System.Drawing.Size(117, 24);
            this.cbHoki.TabIndex = 2;
            this.cbHoki.SelectedIndexChanged += new System.EventHandler(this.cbMon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(205, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn";
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNamhoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Location = new System.Drawing.Point(269, 22);
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(117, 24);
            this.cbNamhoc.TabIndex = 4;
            this.cbNamhoc.SelectedIndexChanged += new System.EventHandler(this.cbNamhoc_SelectedIndexChanged);
            // 
            // cbNienkhoa
            // 
            this.cbNienkhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNienkhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNienkhoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNienkhoa.FormattingEnabled = true;
            this.cbNienkhoa.Location = new System.Drawing.Point(75, 22);
            this.cbNienkhoa.Name = "cbNienkhoa";
            this.cbNienkhoa.Size = new System.Drawing.Size(117, 24);
            this.cbNienkhoa.TabIndex = 4;
            this.cbNienkhoa.SelectedIndexChanged += new System.EventHandler(this.cbNienkhoa_SelectedIndexChanged);
            // 
            // cbLop
            // 
            this.cbLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(75, 52);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(117, 24);
            this.cbLop.TabIndex = 4;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // frmTKBangdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(953, 464);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTKBangdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Điểm Môn";
            this.Load += new System.EventHandler(this.frmTKBangdiem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbangdiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgbangdiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.ComboBox cbHoki;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNienkhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl15;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl45;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHanhkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNienkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTBm;
        private System.Windows.Forms.Button button1;
    }
}