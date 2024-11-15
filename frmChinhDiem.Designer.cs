namespace ChuongtrinhQLDiemTHPT
{
    partial class frmChinhDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinhDiem));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt451 = new System.Windows.Forms.TextBox();
            this.txt452 = new System.Windows.Forms.TextBox();
            this.txt453 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt151 = new System.Windows.Forms.TextBox();
            this.txt152 = new System.Windows.Forms.TextBox();
            this.txt153 = new System.Windows.Forms.TextBox();
            this.cbTen = new System.Windows.Forms.ComboBox();
            this.txthocki = new System.Windows.Forms.TextBox();
            this.txtthuchanh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMieng = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHanhkiem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btNhap = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbHocki = new System.Windows.Forms.ComboBox();
            this.cbMonhoc = new System.Windows.Forms.ComboBox();
            this.cbNamhoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbNienkhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgBangdiem = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNienkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBangdiem)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btSua);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.btNhap);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgBangdiem);
            this.splitContainer1.Size = new System.Drawing.Size(874, 488);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(771, 145);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(771, 108);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(426, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 130);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi Chú";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhichu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(3, 18);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(297, 109);
            this.txtGhichu.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtMa);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cbTen);
            this.groupBox2.Controls.Add(this.txthocki);
            this.groupBox2.Controls.Add(this.txtthuchanh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMieng);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbHanhkiem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 154);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thành phần";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.ForeColor = System.Drawing.Color.Black;
            this.txtMa.Location = new System.Drawing.Point(101, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(90, 22);
            this.txtMa.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(217, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Họ và Tên";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt451);
            this.groupBox5.Controls.Add(this.txt452);
            this.groupBox5.Controls.Add(this.txt453);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(404, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 61);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "45 phút";
            // 
            // txt451
            // 
            this.txt451.Location = new System.Drawing.Point(28, 26);
            this.txt451.MaxLength = 4;
            this.txt451.Name = "txt451";
            this.txt451.Size = new System.Drawing.Size(39, 22);
            this.txt451.TabIndex = 0;
            this.txt451.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt451_KeyPress);
            this.txt451.Leave += new System.EventHandler(this.txt451_Leave);
            // 
            // txt452
            // 
            this.txt452.Location = new System.Drawing.Point(73, 26);
            this.txt452.MaxLength = 4;
            this.txt452.Name = "txt452";
            this.txt452.Size = new System.Drawing.Size(37, 22);
            this.txt452.TabIndex = 1;
            this.txt452.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt452_KeyPress);
            this.txt452.Leave += new System.EventHandler(this.txt452_Leave);
            // 
            // txt453
            // 
            this.txt453.Location = new System.Drawing.Point(116, 26);
            this.txt453.MaxLength = 4;
            this.txt453.Name = "txt453";
            this.txt453.Size = new System.Drawing.Size(38, 22);
            this.txt453.TabIndex = 2;
            this.txt453.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt453_KeyPress);
            this.txt453.Leave += new System.EventHandler(this.txt453_Leave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt151);
            this.groupBox4.Controls.Add(this.txt152);
            this.groupBox4.Controls.Add(this.txt153);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(180, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 61);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "15 phút";
            // 
            // txt151
            // 
            this.txt151.Location = new System.Drawing.Point(18, 26);
            this.txt151.MaxLength = 4;
            this.txt151.Name = "txt151";
            this.txt151.Size = new System.Drawing.Size(38, 22);
            this.txt151.TabIndex = 0;
            this.txt151.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt151_KeyPress);
            this.txt151.Leave += new System.EventHandler(this.txt151_Leave);
            // 
            // txt152
            // 
            this.txt152.Location = new System.Drawing.Point(62, 26);
            this.txt152.MaxLength = 4;
            this.txt152.Name = "txt152";
            this.txt152.Size = new System.Drawing.Size(42, 22);
            this.txt152.TabIndex = 1;
            this.txt152.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt152_KeyPress);
            this.txt152.Leave += new System.EventHandler(this.txt152_Leave);
            // 
            // txt153
            // 
            this.txt153.Location = new System.Drawing.Point(110, 26);
            this.txt153.MaxLength = 4;
            this.txt153.Name = "txt153";
            this.txt153.Size = new System.Drawing.Size(41, 22);
            this.txt153.TabIndex = 2;
            this.txt153.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt153_KeyPress);
            this.txt153.Leave += new System.EventHandler(this.txt153_Leave);
            // 
            // cbTen
            // 
            this.cbTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTen.ForeColor = System.Drawing.Color.Black;
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(320, 29);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(193, 24);
            this.cbTen.TabIndex = 0;
            // 
            // txthocki
            // 
            this.txthocki.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthocki.ForeColor = System.Drawing.Color.Black;
            this.txthocki.Location = new System.Drawing.Point(755, 92);
            this.txthocki.MaxLength = 4;
            this.txthocki.Name = "txthocki";
            this.txthocki.Size = new System.Drawing.Size(33, 22);
            this.txthocki.TabIndex = 4;
            this.txthocki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthocki_KeyPress);
            this.txthocki.Leave += new System.EventHandler(this.txthocki_Leave);
            // 
            // txtthuchanh
            // 
            this.txtthuchanh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthuchanh.ForeColor = System.Drawing.Color.Black;
            this.txtthuchanh.Location = new System.Drawing.Point(679, 92);
            this.txtthuchanh.MaxLength = 4;
            this.txtthuchanh.Name = "txtthuchanh";
            this.txtthuchanh.Size = new System.Drawing.Size(38, 22);
            this.txtthuchanh.TabIndex = 3;
            this.txtthuchanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtthuchanh_KeyPress);
            this.txtthuchanh.Leave += new System.EventHandler(this.txtthuchanh_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã Học Sinh";
            // 
            // txtMieng
            // 
            this.txtMieng.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMieng.ForeColor = System.Drawing.Color.Black;
            this.txtMieng.Location = new System.Drawing.Point(59, 92);
            this.txtMieng.MaxLength = 4;
            this.txtMieng.Name = "txtMieng";
            this.txtMieng.Size = new System.Drawing.Size(34, 22);
            this.txtMieng.TabIndex = 1;
            this.txtMieng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMieng_KeyPress);
            this.txtMieng.Leave += new System.EventHandler(this.txtMieng_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(559, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hạnh kiểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Miệng";
            // 
            // cbHanhkiem
            // 
            this.cbHanhkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHanhkiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHanhkiem.ForeColor = System.Drawing.Color.Black;
            this.cbHanhkiem.FormattingEnabled = true;
            this.cbHanhkiem.Items.AddRange(new object[] {
            "Tôt",
            "Khá",
            "Trung Bình",
            "Yếu",
            "Kém"});
            this.cbHanhkiem.Location = new System.Drawing.Point(635, 29);
            this.cbHanhkiem.Name = "cbHanhkiem";
            this.cbHanhkiem.Size = new System.Drawing.Size(121, 24);
            this.cbHanhkiem.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(660, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thực hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(742, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm Thi";
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(771, 68);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(75, 23);
            this.btNhap.TabIndex = 0;
            this.btNhap.Text = "&Nhập";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cbLop);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbHocki);
            this.groupBox3.Controls.Add(this.cbMonhoc);
            this.groupBox3.Controls.Add(this.cbNamhoc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbNienkhoa);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 130);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "Năm học";
            // 
            // cbLop
            // 
            this.cbLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.ForeColor = System.Drawing.Color.Black;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(283, 55);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(69, 24);
            this.cbLop.TabIndex = 2;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(233, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Lớp";
            // 
            // cbHocki
            // 
            this.cbHocki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocki.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocki.ForeColor = System.Drawing.Color.Black;
            this.cbHocki.FormattingEnabled = true;
            this.cbHocki.Items.AddRange(new object[] {
            "Kì I",
            "Kì II"});
            this.cbHocki.Location = new System.Drawing.Point(283, 92);
            this.cbHocki.Name = "cbHocki";
            this.cbHocki.Size = new System.Drawing.Size(69, 24);
            this.cbHocki.TabIndex = 4;
            this.cbHocki.SelectedIndexChanged += new System.EventHandler(this.cbHocki_SelectedIndexChanged);
            // 
            // cbMonhoc
            // 
            this.cbMonhoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMonhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMonhoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonhoc.ForeColor = System.Drawing.Color.Black;
            this.cbMonhoc.FormattingEnabled = true;
            this.cbMonhoc.Location = new System.Drawing.Point(88, 92);
            this.cbMonhoc.Name = "cbMonhoc";
            this.cbMonhoc.Size = new System.Drawing.Size(136, 24);
            this.cbMonhoc.TabIndex = 3;
            this.cbMonhoc.SelectedIndexChanged += new System.EventHandler(this.cbMonhoc_SelectedIndexChanged);
            // 
            // cbNamhoc
            // 
            this.cbNamhoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamhoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNamhoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamhoc.ForeColor = System.Drawing.Color.Black;
            this.cbNamhoc.FormattingEnabled = true;
            this.cbNamhoc.Location = new System.Drawing.Point(88, 55);
            this.cbNamhoc.Name = "cbNamhoc";
            this.cbNamhoc.Size = new System.Drawing.Size(136, 24);
            this.cbNamhoc.TabIndex = 1;
            this.cbNamhoc.SelectedIndexChanged += new System.EventHandler(this.cbNamhoc_SelectedIndexChanged);
            this.cbNamhoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNamhoc_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niên Khóa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(233, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Học Kì";
            // 
            // cbNienkhoa
            // 
            this.cbNienkhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNienkhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNienkhoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNienkhoa.ForeColor = System.Drawing.Color.Black;
            this.cbNienkhoa.FormattingEnabled = true;
            this.cbNienkhoa.Location = new System.Drawing.Point(88, 25);
            this.cbNienkhoa.Name = "cbNienkhoa";
            this.cbNienkhoa.Size = new System.Drawing.Size(264, 24);
            this.cbNienkhoa.TabIndex = 0;
            this.cbNienkhoa.SelectedIndexChanged += new System.EventHandler(this.cbNienkhoa_SelectedIndexChanged);
            this.cbNienkhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNienkhoa_KeyPress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP CHỈNH SỬA ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgBangdiem
            // 
            this.dgBangdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBangdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBangdiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clTen,
            this.clLop,
            this.clMonhoc,
            this.clMieng,
            this.cl15,
            this.cl45,
            this.clTH,
            this.clThi,
            this.clHanhkiem,
            this.clHocki,
            this.clNamhoc,
            this.clNienkhoa,
            this.clGhichu});
            this.dgBangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBangdiem.Location = new System.Drawing.Point(0, 0);
            this.dgBangdiem.Name = "dgBangdiem";
            this.dgBangdiem.RowHeadersVisible = false;
            this.dgBangdiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBangdiem.Size = new System.Drawing.Size(874, 144);
            this.dgBangdiem.TabIndex = 1;
            this.dgBangdiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBangdiem_CellClick);
            // 
            // clMa
            // 
            this.clMa.FillWeight = 50F;
            this.clMa.HeaderText = "Mã HS";
            this.clMa.Name = "clMa";
            // 
            // clTen
            // 
            this.clTen.FillWeight = 120F;
            this.clTen.HeaderText = "Họ và Tên";
            this.clTen.Name = "clTen";
            // 
            // clLop
            // 
            this.clLop.FillWeight = 50F;
            this.clLop.HeaderText = "Lớp";
            this.clLop.Name = "clLop";
            // 
            // clMonhoc
            // 
            this.clMonhoc.HeaderText = "Môn Học";
            this.clMonhoc.Name = "clMonhoc";
            this.clMonhoc.ReadOnly = true;
            // 
            // clMieng
            // 
            this.clMieng.FillWeight = 80F;
            this.clMieng.HeaderText = "Miệng";
            this.clMieng.Name = "clMieng";
            // 
            // cl15
            // 
            this.cl15.FillWeight = 80F;
            this.cl15.HeaderText = "15 phút";
            this.cl15.Name = "cl15";
            // 
            // cl45
            // 
            this.cl45.FillWeight = 80F;
            this.cl45.HeaderText = "45 phút";
            this.cl45.Name = "cl45";
            // 
            // clTH
            // 
            this.clTH.FillWeight = 80F;
            this.clTH.HeaderText = "Thực hành";
            this.clTH.Name = "clTH";
            // 
            // clThi
            // 
            this.clThi.FillWeight = 50F;
            this.clThi.HeaderText = "Điểm Thi";
            this.clThi.Name = "clThi";
            // 
            // clHanhkiem
            // 
            this.clHanhkiem.HeaderText = "Hạnh kiểm";
            this.clHanhkiem.Name = "clHanhkiem";
            this.clHanhkiem.ReadOnly = true;
            // 
            // clHocki
            // 
            this.clHocki.HeaderText = "Học kì";
            this.clHocki.Name = "clHocki";
            this.clHocki.ReadOnly = true;
            // 
            // clNamhoc
            // 
            this.clNamhoc.FillWeight = 80F;
            this.clNamhoc.HeaderText = "Năm học";
            this.clNamhoc.Name = "clNamhoc";
            this.clNamhoc.ReadOnly = true;
            // 
            // clNienkhoa
            // 
            this.clNienkhoa.FillWeight = 80F;
            this.clNienkhoa.HeaderText = "Niên Khóa";
            this.clNienkhoa.Name = "clNienkhoa";
            this.clNienkhoa.ReadOnly = true;
            // 
            // clGhichu
            // 
            this.clGhichu.FillWeight = 120F;
            this.clGhichu.HeaderText = "Ghi Chú";
            this.clGhichu.Name = "clGhichu";
            // 
            // frmChinhDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(874, 488);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChinhDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm";
            this.Load += new System.EventHandler(this.frmChinhDiem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBangdiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBangdiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNienkhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt451;
        private System.Windows.Forms.TextBox txt452;
        private System.Windows.Forms.TextBox txt453;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt151;
        private System.Windows.Forms.TextBox txt152;
        private System.Windows.Forms.TextBox txt153;
        private System.Windows.Forms.TextBox txthocki;
        private System.Windows.Forms.TextBox txtthuchanh;
        private System.Windows.Forms.TextBox txtMieng;
        private System.Windows.Forms.ComboBox cbHocki;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMonhoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHanhkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl15;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl45;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHanhkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocki;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNienkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhichu;

    }
}