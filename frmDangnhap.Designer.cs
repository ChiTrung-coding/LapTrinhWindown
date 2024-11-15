namespace ChuongtrinhQLDiemTHPT
{
    partial class frmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btDangnhap = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.dgDangnhap = new System.Windows.Forms.DataGridView();
            this.cltaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(120, 70);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(116, 22);
            this.txtTaikhoan.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(120, 121);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(116, 22);
            this.txtMatkhau.TabIndex = 1;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 50);
            this.label4.TabIndex = 3;
            // 
            // btDangnhap
            // 
            this.btDangnhap.Location = new System.Drawing.Point(57, 165);
            this.btDangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDangnhap.Name = "btDangnhap";
            this.btDangnhap.Size = new System.Drawing.Size(87, 28);
            this.btDangnhap.TabIndex = 2;
            this.btDangnhap.Text = "&Đăng nhập";
            this.btDangnhap.UseVisualStyleBackColor = true;
            this.btDangnhap.Click += new System.EventHandler(this.btDangnhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(189, 165);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(87, 28);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "&Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dgDangnhap
            // 
            this.dgDangnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDangnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cltaikhoan,
            this.clMK,
            this.clQuyen});
            this.dgDangnhap.Location = new System.Drawing.Point(349, 53);
            this.dgDangnhap.Name = "dgDangnhap";
            this.dgDangnhap.RowHeadersVisible = false;
            this.dgDangnhap.Size = new System.Drawing.Size(240, 118);
            this.dgDangnhap.TabIndex = 4;
            // 
            // cltaikhoan
            // 
            this.cltaikhoan.HeaderText = "TK";
            this.cltaikhoan.Name = "cltaikhoan";
            this.cltaikhoan.ReadOnly = true;
            // 
            // clMK
            // 
            this.clMK.HeaderText = "MK";
            this.clMK.Name = "clMK";
            this.clMK.ReadOnly = true;
            // 
            // clQuyen
            // 
            this.clQuyen.HeaderText = "Quyen";
            this.clQuyen.Name = "clQuyen";
            this.clQuyen.ReadOnly = true;
            // 
            // frmDangnhap
            // 
            this.AcceptButton = this.btDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(332, 203);
            this.Controls.Add(this.dgDangnhap);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangnhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dgDangnhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDangnhap;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridView dgDangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuyen;
    }
}

