namespace ChuongtrinhQLDiemTHPT
{
    partial class frmTaotaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaotaikhoan));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btTao = new System.Windows.Forms.Button();
            this.txtNhapMK2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhapMK1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.cbMatkhau = new System.Windows.Forms.ComboBox();
            this.cbTaikhoan = new System.Windows.Forms.ComboBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.lbSoTK = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgTaotaikhoan = new System.Windows.Forms.DataGridView();
            this.clTaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaotaikhoan)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btTao);
            this.splitContainer1.Panel1.Controls.Add(this.txtNhapMK2);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtNhapMK1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtTaikhoan);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbQuyen);
            this.splitContainer1.Panel2.Controls.Add(this.cbMatkhau);
            this.splitContainer1.Panel2.Controls.Add(this.cbTaikhoan);
            this.splitContainer1.Panel2.Controls.Add(this.btXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btSua);
            this.splitContainer1.Panel2.Controls.Add(this.lbSoTK);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.dgTaotaikhoan);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(704, 387);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // btTao
            // 
            this.btTao.Location = new System.Drawing.Point(83, 352);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(75, 23);
            this.btTao.TabIndex = 9;
            this.btTao.Text = "&Tạo";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // txtNhapMK2
            // 
            this.txtNhapMK2.Location = new System.Drawing.Point(112, 211);
            this.txtNhapMK2.Name = "txtNhapMK2";
            this.txtNhapMK2.Size = new System.Drawing.Size(100, 22);
            this.txtNhapMK2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhập lại MK";
            // 
            // txtNhapMK1
            // 
            this.txtNhapMK1.Location = new System.Drawing.Point(112, 172);
            this.txtNhapMK1.Name = "txtNhapMK1";
            this.txtNhapMK1.Size = new System.Drawing.Size(100, 22);
            this.txtNhapMK1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(112, 133);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(100, 22);
            this.txtTaikhoan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 158);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "TẠO TÀI KHOẢN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbQuyen
            // 
            this.cbQuyen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbQuyen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Items.AddRange(new object[] {
            "admin",
            "noadmin"});
            this.cbQuyen.Location = new System.Drawing.Point(335, 311);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(121, 24);
            this.cbQuyen.TabIndex = 10;
            // 
            // cbMatkhau
            // 
            this.cbMatkhau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMatkhau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMatkhau.FormattingEnabled = true;
            this.cbMatkhau.Location = new System.Drawing.Point(181, 311);
            this.cbMatkhau.Name = "cbMatkhau";
            this.cbMatkhau.Size = new System.Drawing.Size(121, 24);
            this.cbMatkhau.TabIndex = 10;
            // 
            // cbTaikhoan
            // 
            this.cbTaikhoan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTaikhoan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTaikhoan.FormattingEnabled = true;
            this.cbTaikhoan.Location = new System.Drawing.Point(17, 311);
            this.cbTaikhoan.Name = "cbTaikhoan";
            this.cbTaikhoan.Size = new System.Drawing.Size(121, 24);
            this.cbTaikhoan.TabIndex = 10;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(142, 352);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "&Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(34, 352);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 9;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // lbSoTK
            // 
            this.lbSoTK.AutoSize = true;
            this.lbSoTK.ForeColor = System.Drawing.Color.Red;
            this.lbSoTK.Location = new System.Drawing.Point(394, 355);
            this.lbSoTK.Name = "lbSoTK";
            this.lbSoTK.Size = new System.Drawing.Size(31, 16);
            this.lbSoTK.TabIndex = 5;
            this.lbSoTK.Text = "------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Số tài khoản hiện có";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Quyền sử dụng";
            // 
            // dgTaotaikhoan
            // 
            this.dgTaotaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTaotaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaotaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTaikhoan,
            this.clMatkhau,
            this.clQuyen});
            this.dgTaotaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgTaotaikhoan.Location = new System.Drawing.Point(0, 0);
            this.dgTaotaikhoan.Name = "dgTaotaikhoan";
            this.dgTaotaikhoan.RowHeadersVisible = false;
            this.dgTaotaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTaotaikhoan.Size = new System.Drawing.Size(468, 262);
            this.dgTaotaikhoan.TabIndex = 0;
            this.dgTaotaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTaotaikhoan_CellClick);
            // 
            // clTaikhoan
            // 
            this.clTaikhoan.HeaderText = "Tài khoản";
            this.clTaikhoan.Name = "clTaikhoan";
            this.clTaikhoan.ReadOnly = true;
            // 
            // clMatkhau
            // 
            this.clMatkhau.HeaderText = "Mật khẩu";
            this.clMatkhau.Name = "clMatkhau";
            this.clMatkhau.ReadOnly = true;
            // 
            // clQuyen
            // 
            this.clQuyen.HeaderText = "Quyền sử dụng";
            this.clQuyen.Name = "clQuyen";
            this.clQuyen.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tài khoản";
            // 
            // frmTaotaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 387);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTaotaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaotaikhoan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaotaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.TextBox txtNhapMK2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhapMK1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTaotaikhoan;
        private System.Windows.Forms.ComboBox cbTaikhoan;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.ComboBox cbMatkhau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSoTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMatkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuyen;
    }
}