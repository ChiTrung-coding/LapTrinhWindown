namespace ChuongtrinhQLDiemTHPT
{
    partial class frmQLBanhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBanhoc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbHeso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBanhoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMon = new System.Windows.Forms.ComboBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.dgMonhoc = new System.Windows.Forms.DataGridView();
            this.clBanhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonhoc)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btSua);
            this.splitContainer1.Panel1.Controls.Add(this.btNhap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgMonhoc);
            this.splitContainer1.Size = new System.Drawing.Size(895, 459);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 63);
            this.label4.TabIndex = 4;
            this.label4.Text = "Môn học";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHeso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBanhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMon);
            this.groupBox1.Location = new System.Drawing.Point(21, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // cmbHeso
            // 
            this.cmbHeso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHeso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHeso.FormattingEnabled = true;
            this.cmbHeso.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbHeso.Location = new System.Drawing.Point(103, 128);
            this.cmbHeso.Name = "cmbHeso";
            this.cmbHeso.Size = new System.Drawing.Size(144, 24);
            this.cmbHeso.TabIndex = 2;
            this.cmbHeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbHeso_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // cbBanhoc
            // 
            this.cbBanhoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBanhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBanhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanhoc.FormattingEnabled = true;
            this.cbBanhoc.Items.AddRange(new object[] {
            "Khoa học tự nhiên (A)",
            "Cơ bản (B)",
            "Khoa học xã hội (C)"});
            this.cbBanhoc.Location = new System.Drawing.Point(103, 46);
            this.cbBanhoc.Name = "cbBanhoc";
            this.cbBanhoc.Size = new System.Drawing.Size(144, 24);
            this.cbBanhoc.TabIndex = 2;
            this.cbBanhoc.SelectedIndexChanged += new System.EventHandler(this.cbBanhoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phân ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã GV";
            // 
            // cmbMon
            // 
            this.cmbMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMon.FormattingEnabled = true;
            this.cmbMon.Items.AddRange(new object[] {
            "Toán",
            "Lí",
            "Hóa",
            "Sinh",
            "Văn",
            "Ngoại ngữ",
            "Sử",
            "Địa",
            "Công nghệ",
            "TD",
            "Tin học",
            "Giáo dục công dân"});
            this.cmbMon.Location = new System.Drawing.Point(103, 87);
            this.cmbMon.Name = "cmbMon";
            this.cmbMon.Size = new System.Drawing.Size(144, 24);
            this.cmbMon.TabIndex = 2;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(238, 402);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 34);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(134, 402);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 34);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(34, 402);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(75, 34);
            this.btNhap.TabIndex = 1;
            this.btNhap.Text = "&Nhập";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // dgMonhoc
            // 
            this.dgMonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clBanhoc,
            this.clMon,
            this.clHeso});
            this.dgMonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMonhoc.Location = new System.Drawing.Point(0, 0);
            this.dgMonhoc.Name = "dgMonhoc";
            this.dgMonhoc.RowHeadersVisible = false;
            this.dgMonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMonhoc.Size = new System.Drawing.Size(546, 459);
            this.dgMonhoc.TabIndex = 0;
            this.dgMonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMonhoc_CellClick);
            // 
            // clBanhoc
            // 
            this.clBanhoc.HeaderText = "Phân ban";
            this.clBanhoc.Name = "clBanhoc";
            this.clBanhoc.ReadOnly = true;
            this.clBanhoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clMon
            // 
            this.clMon.HeaderText = "Môn học";
            this.clMon.Name = "clMon";
            this.clMon.ReadOnly = true;
            this.clMon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clHeso
            // 
            this.clHeso.HeaderText = "Mã Giáo Viên";
            this.clHeso.Name = "clHeso";
            this.clHeso.ReadOnly = true;
            this.clHeso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmQLBanhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 459);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQLBanhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.frmQLBanhoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbHeso;
        private System.Windows.Forms.ComboBox cbBanhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridView dgMonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBanhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHeso;
    }
}