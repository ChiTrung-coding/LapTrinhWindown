namespace ChuongtrinhQLDiemTHPT
{
    partial class frmQLLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLop));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBanhoc = new System.Windows.Forms.ComboBox();
            this.cbNamhoc = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.dgQLLop = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQLLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỚP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbBanhoc);
            this.splitContainer1.Panel1.Controls.Add(this.cbNamhoc);
            this.splitContainer1.Panel1.Controls.Add(this.cbLop);
            this.splitContainer1.Panel1.Controls.Add(this.btXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btNhap);
            this.splitContainer1.Panel1.Controls.Add(this.btSua);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgQLLop);
            this.splitContainer1.Size = new System.Drawing.Size(770, 356);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ban học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lớp";
            // 
            // cbBanhoc
            // 
            this.cbBanhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBanhoc.FormattingEnabled = true;
            this.cbBanhoc.Items.AddRange(new object[] {
            "Khoa học tự nhiên (A)",
            "Cơ bản (B)",
            "Khoa học xã hội (C)"});
            this.cbBanhoc.Location = new System.Drawing.Point(132, 55);
            this.cbBanhoc.Name = "cbBanhoc";
            this.cbBanhoc.Size = new System.Drawing.Size(267, 24);
            this.cbBanhoc.TabIndex = 1;
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Items.AddRange(new object[] {
            "2023-2024",
            "2024-2025"});
            this.cbNamhoc.Location = new System.Drawing.Point(287, 18);
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(112, 24);
            this.cbNamhoc.TabIndex = 0;
            this.cbNamhoc.SelectedIndexChanged += new System.EventHandler(this.cbNamhoc_SelectedIndexChanged);
            this.cbNamhoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNamhoc_KeyPress);
            // 
            // cbLop
            // 
            this.cbLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "10a1",
            "10a2",
            "10a3",
            "10a4",
            "10b1",
            "10b2",
            "10b3",
            "10c1",
            "10c2",
            "11a1",
            "11a2",
            "11a3",
            "11a4",
            "11b1",
            "11b2",
            "11b3",
            "11c1",
            "11c2",
            "12a1",
            "12a2",
            "12a3",
            "12a4",
            "12b1",
            "12b2",
            "12b3",
            "12c1",
            "12c2"});
            this.cbLop.Location = new System.Drawing.Point(132, 18);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(81, 24);
            this.cbLop.TabIndex = 0;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(651, 34);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 24);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(457, 34);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(75, 24);
            this.btNhap.TabIndex = 2;
            this.btNhap.Text = "&Nhập";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(552, 34);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 24);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // dgQLLop
            // 
            this.dgQLLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgQLLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQLLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clLop,
            this.clNamhoc,
            this.clBan});
            this.dgQLLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQLLop.Location = new System.Drawing.Point(0, 0);
            this.dgQLLop.Name = "dgQLLop";
            this.dgQLLop.RowHeadersVisible = false;
            this.dgQLLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgQLLop.Size = new System.Drawing.Size(770, 258);
            this.dgQLLop.TabIndex = 0;
            this.dgQLLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQLLop_CellClick);
            // 
            // clSTT
            // 
            this.clSTT.FillWeight = 30F;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
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
            this.clNamhoc.FillWeight = 50F;
            this.clNamhoc.HeaderText = "Năm học";
            this.clNamhoc.Name = "clNamhoc";
            this.clNamhoc.ReadOnly = true;
            // 
            // clBan
            // 
            this.clBan.HeaderText = "Phân Ban";
            this.clBan.Name = "clBan";
            this.clBan.ReadOnly = true;
            // 
            // frmQLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 398);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQLLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lớp";
            this.Load += new System.EventHandler(this.frmQLLop_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQLLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgQLLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBanhoc;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBan;
    }
}