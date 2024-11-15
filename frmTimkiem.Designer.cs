namespace ChuongtrinhQLDiemTHPT
{
    partial class frmTimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiem));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgTimkiem = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNienkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNamhoc = new System.Windows.Forms.ComboBox();
            this.cbThoidiem = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTkHanhkiem = new System.Windows.Forms.RadioButton();
            this.rbTkHocluc = new System.Windows.Forms.RadioButton();
            this.rbTkQue = new System.Windows.Forms.RadioButton();
            this.rbTkTen = new System.Windows.Forms.RadioButton();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimkiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgTimkiem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cbNamhoc);
            this.splitContainer1.Panel2.Controls.Add(this.cbThoidiem);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.cbTimkiem);
            this.splitContainer1.Panel2.Controls.Add(this.btTimkiem);
            this.splitContainer1.Size = new System.Drawing.Size(917, 435);
            this.splitContainer1.SplitterDistance = 616;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgTimkiem
            // 
            this.dgTimkiem.AllowUserToDeleteRows = false;
            this.dgTimkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTen,
            this.clLop,
            this.clNamhoc,
            this.clNienkhoa,
            this.clNgaySinh,
            this.clGioiTinh,
            this.clQue,
            this.clHocki,
            this.clHanhKiem,
            this.clHocLuc});
            this.dgTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTimkiem.Location = new System.Drawing.Point(0, 0);
            this.dgTimkiem.Name = "dgTimkiem";
            this.dgTimkiem.ReadOnly = true;
            this.dgTimkiem.RowHeadersVisible = false;
            this.dgTimkiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTimkiem.Size = new System.Drawing.Size(616, 435);
            this.dgTimkiem.TabIndex = 1;
            // 
            // clMa
            // 
            this.clMa.FillWeight = 50F;
            this.clMa.HeaderText = "Mã HS";
            this.clMa.Name = "clMa";
            this.clMa.ReadOnly = true;
            // 
            // clTen
            // 
            this.clTen.FillWeight = 120F;
            this.clTen.HeaderText = "Họ và Tên";
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            // 
            // clLop
            // 
            this.clLop.FillWeight = 50F;
            this.clLop.HeaderText = "Lớp";
            this.clLop.Name = "clLop";
            this.clLop.ReadOnly = true;
            // 
            // clNamhoc
            // 
            this.clNamhoc.HeaderText = "Năm học";
            this.clNamhoc.Name = "clNamhoc";
            this.clNamhoc.ReadOnly = true;
            // 
            // clNienkhoa
            // 
            this.clNienkhoa.HeaderText = "Niên Khoá";
            this.clNienkhoa.Name = "clNienkhoa";
            this.clNienkhoa.ReadOnly = true;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.FillWeight = 80F;
            this.clNgaySinh.HeaderText = "Ngày Sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.ReadOnly = true;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.FillWeight = 50F;
            this.clGioiTinh.HeaderText = "Giới Tính";
            this.clGioiTinh.Name = "clGioiTinh";
            this.clGioiTinh.ReadOnly = true;
            // 
            // clQue
            // 
            this.clQue.HeaderText = "Quê Quán";
            this.clQue.Name = "clQue";
            this.clQue.ReadOnly = true;
            // 
            // clHocki
            // 
            this.clHocki.HeaderText = "Học kì";
            this.clHocki.Name = "clHocki";
            this.clHocki.ReadOnly = true;
            // 
            // clHanhKiem
            // 
            this.clHanhKiem.FillWeight = 80F;
            this.clHanhKiem.HeaderText = "Hạnh Kiểm";
            this.clHanhKiem.Name = "clHanhKiem";
            this.clHanhKiem.ReadOnly = true;
            // 
            // clHocLuc
            // 
            this.clHocLuc.FillWeight = 80F;
            this.clHocLuc.HeaderText = "Học Lực";
            this.clHocLuc.Name = "clHocLuc";
            this.clHocLuc.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "TÌM KIẾM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thời Điểm";
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Items.AddRange(new object[] {
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cbNamhoc.Location = new System.Drawing.Point(116, 74);
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(149, 24);
            this.cbNamhoc.TabIndex = 9;
            // 
            // cbThoidiem
            // 
            this.cbThoidiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbThoidiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbThoidiem.FormattingEnabled = true;
            this.cbThoidiem.Items.AddRange(new object[] {
            "Kì I",
            "Kì II"});
            this.cbThoidiem.Location = new System.Drawing.Point(116, 108);
            this.cbThoidiem.Name = "cbThoidiem";
            this.cbThoidiem.Size = new System.Drawing.Size(149, 24);
            this.cbThoidiem.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTkHanhkiem);
            this.groupBox1.Controls.Add(this.rbTkHocluc);
            this.groupBox1.Controls.Add(this.rbTkQue);
            this.groupBox1.Controls.Add(this.rbTkTen);
            this.groupBox1.Location = new System.Drawing.Point(20, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 229);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rbTkHanhkiem
            // 
            this.rbTkHanhkiem.AutoSize = true;
            this.rbTkHanhkiem.Location = new System.Drawing.Point(49, 161);
            this.rbTkHanhkiem.Name = "rbTkHanhkiem";
            this.rbTkHanhkiem.Size = new System.Drawing.Size(196, 20);
            this.rbTkHanhkiem.TabIndex = 0;
            this.rbTkHanhkiem.TabStop = true;
            this.rbTkHanhkiem.Text = "Tìm học sinh theo hạnh kiểm ";
            this.rbTkHanhkiem.UseVisualStyleBackColor = true;
            this.rbTkHanhkiem.CheckedChanged += new System.EventHandler(this.rbTkHanhkiem_CheckedChanged);
            // 
            // rbTkHocluc
            // 
            this.rbTkHocluc.AutoSize = true;
            this.rbTkHocluc.Location = new System.Drawing.Point(49, 123);
            this.rbTkHocluc.Name = "rbTkHocluc";
            this.rbTkHocluc.Size = new System.Drawing.Size(123, 20);
            this.rbTkHocluc.TabIndex = 0;
            this.rbTkHocluc.TabStop = true;
            this.rbTkHocluc.Text = "Tìm theo học lực";
            this.rbTkHocluc.UseVisualStyleBackColor = true;
            this.rbTkHocluc.CheckedChanged += new System.EventHandler(this.rbTkHocluc_CheckedChanged);
            // 
            // rbTkQue
            // 
            this.rbTkQue.AutoSize = true;
            this.rbTkQue.Location = new System.Drawing.Point(49, 80);
            this.rbTkQue.Name = "rbTkQue";
            this.rbTkQue.Size = new System.Drawing.Size(111, 20);
            this.rbTkQue.TabIndex = 0;
            this.rbTkQue.TabStop = true;
            this.rbTkQue.Text = "Tìm theo nơi ở";
            this.rbTkQue.UseVisualStyleBackColor = true;
            this.rbTkQue.CheckedChanged += new System.EventHandler(this.rbTkQue_CheckedChanged);
            // 
            // rbTkTen
            // 
            this.rbTkTen.AutoSize = true;
            this.rbTkTen.Location = new System.Drawing.Point(49, 35);
            this.rbTkTen.Name = "rbTkTen";
            this.rbTkTen.Size = new System.Drawing.Size(129, 20);
            this.rbTkTen.TabIndex = 0;
            this.rbTkTen.TabStop = true;
            this.rbTkTen.Text = "Tìm kiếm theo tên";
            this.rbTkTen.UseVisualStyleBackColor = true;
            this.rbTkTen.CheckedChanged += new System.EventHandler(this.rbTkTen_CheckedChanged);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Location = new System.Drawing.Point(116, 143);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(151, 24);
            this.cbTimkiem.TabIndex = 7;
            // 
            // btTimkiem
            // 
            this.btTimkiem.Location = new System.Drawing.Point(25, 143);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btTimkiem.TabIndex = 5;
            this.btTimkiem.Text = "&Tìm Kiếm";
            this.btTimkiem.UseVisualStyleBackColor = true;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // frmTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(917, 435);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Học Sinh";
            this.Load += new System.EventHandler(this.frmTimkiem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTimkiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThoidiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTkHanhkiem;
        private System.Windows.Forms.RadioButton rbTkHocluc;
        private System.Windows.Forms.RadioButton rbTkQue;
        private System.Windows.Forms.RadioButton rbTkTen;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNienkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocki;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocLuc;
        private System.Windows.Forms.Label label3;

    }
}