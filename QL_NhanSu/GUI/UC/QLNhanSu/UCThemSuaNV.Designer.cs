namespace GUI.UC.QLNhanSu
{
    partial class UCThemSuaNV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCThemSuaNV));
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btnBack = new GUI.Class.btnImage();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.cbxChucVu = new GUI.Class.cbxNoneChangeText();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxHocVan = new GUI.Class.cbxNoneChangeText();
            this.cbxNgoaiNgu = new GUI.Class.cbxNoneChangeText();
            this.btnSave = new GUI.Class.btnImage();
            this.btnAnh = new GUI.Class.btnImage();
            this.ptrAnh = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCMT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKHD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHHHD = new System.Windows.Forms.DateTimePicker();
            this.txtDT = new GUI.Class.cbxNoneChangeText();
            this.txtTG = new GUI.Class.cbxNoneChangeText();
            this.pnlTool.SuspendLayout();
            this.layout.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.pnlTool.Controls.Add(this.btnBack);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(758, 30);
            this.pnlTool.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnBack.BgrColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnBack.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBack.BgrColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnBack.ImageMouseDown = null;
            this.btnBack.ImageMouseEnter = null;
            this.btnBack.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageMouseLeave")));
            this.btnBack.ImgMargin = 0;
            this.btnBack.ImgSize = new System.Drawing.Size(23, 23);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnBack.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnBack.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnBack.TextColorMouseLeave = System.Drawing.Color.White;
            this.btnBack.UseActived = false;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClick);
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.layout.ColumnCount = 3;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Controls.Add(this.pnlBody, 1, 0);
            this.layout.Location = new System.Drawing.Point(0, 30);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 473F));
            this.layout.Size = new System.Drawing.Size(758, 473);
            this.layout.TabIndex = 1;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Controls.Add(this.txtTG);
            this.pnlBody.Controls.Add(this.txtDT);
            this.pnlBody.Controls.Add(this.dtpNgayHHHD);
            this.pnlBody.Controls.Add(this.dtpNgayKHD);
            this.pnlBody.Controls.Add(this.dtpNgaySinh);
            this.pnlBody.Controls.Add(this.cbxChucVu);
            this.pnlBody.Controls.Add(this.label20);
            this.pnlBody.Controls.Add(this.cbxHocVan);
            this.pnlBody.Controls.Add(this.cbxNgoaiNgu);
            this.pnlBody.Controls.Add(this.btnSave);
            this.pnlBody.Controls.Add(this.btnAnh);
            this.pnlBody.Controls.Add(this.ptrAnh);
            this.pnlBody.Controls.Add(this.label12);
            this.pnlBody.Controls.Add(this.label11);
            this.pnlBody.Controls.Add(this.label10);
            this.pnlBody.Controls.Add(this.label9);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.label5);
            this.pnlBody.Controls.Add(this.txtSDT);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.txtMK);
            this.pnlBody.Controls.Add(this.label13);
            this.pnlBody.Controls.Add(this.label8);
            this.pnlBody.Controls.Add(this.label7);
            this.pnlBody.Controls.Add(this.label6);
            this.pnlBody.Controls.Add(this.txtCMT);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.rdbNu);
            this.pnlBody.Controls.Add(this.rdbNam);
            this.pnlBody.Controls.Add(this.txtHT);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.txtMa);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(32, 3);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(694, 467);
            this.pnlBody.TabIndex = 3;
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Location = new System.Drawing.Point(297, 137);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(220, 21);
            this.cbxChucVu.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(294, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 13);
            this.label20.TabIndex = 96;
            this.label20.Text = "Chức vụ";
            // 
            // cbxHocVan
            // 
            this.cbxHocVan.FormattingEnabled = true;
            this.cbxHocVan.Location = new System.Drawing.Point(297, 364);
            this.cbxHocVan.Name = "cbxHocVan";
            this.cbxHocVan.Size = new System.Drawing.Size(220, 21);
            this.cbxHocVan.TabIndex = 19;
            // 
            // cbxNgoaiNgu
            // 
            this.cbxNgoaiNgu.FormattingEnabled = true;
            this.cbxNgoaiNgu.Location = new System.Drawing.Point(297, 304);
            this.cbxNgoaiNgu.Name = "cbxNgoaiNgu";
            this.cbxNgoaiNgu.Size = new System.Drawing.Size(220, 21);
            this.cbxNgoaiNgu.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSave.BgrColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnSave.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.BgrColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSave.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnSave.ImageMouseDown = null;
            this.btnSave.ImageMouseEnter = null;
            this.btnSave.ImageMouseLeave = null;
            this.btnSave.ImgMargin = 3;
            this.btnSave.ImgSize = new System.Drawing.Size(18, 18);
            this.btnSave.Location = new System.Drawing.Point(297, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnSave.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnSave.TextColorMouseLeave = System.Drawing.Color.White;
            this.btnSave.UseActived = false;
            this.btnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseClick);
            // 
            // btnAnh
            // 
            this.btnAnh.BackColor = System.Drawing.Color.Transparent;
            this.btnAnh.BgrColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnAnh.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnh.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnAnh.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnAnh.ImageMouseDown = null;
            this.btnAnh.ImageMouseEnter = null;
            this.btnAnh.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnAnh.ImageMouseLeave")));
            this.btnAnh.ImgMargin = 0;
            this.btnAnh.ImgSize = new System.Drawing.Size(20, 20);
            this.btnAnh.Location = new System.Drawing.Point(579, 189);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(75, 23);
            this.btnAnh.TabIndex = 0;
            this.btnAnh.TabStop = false;
            this.btnAnh.Text = "Choice";
            this.btnAnh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAnh.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnAnh.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnAnh.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnAnh.UseActived = false;
            this.btnAnh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAnh_MouseClick);
            // 
            // ptrAnh
            // 
            this.ptrAnh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptrAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptrAnh.Location = new System.Drawing.Point(555, 23);
            this.ptrAnh.Name = "ptrAnh";
            this.ptrAnh.Size = new System.Drawing.Size(120, 160);
            this.ptrAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrAnh.TabIndex = 88;
            this.ptrAnh.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(294, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày hết hạn hợp đồng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(294, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày ký hợp đồng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(294, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trình độ học vấn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trinh độ ngoại ngữ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 89);
            this.txtEmail.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(297, 39);
            this.txtSDT.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(220, 20);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMT_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(30, 419);
            this.txtMK.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtMK.MaxLength = 30;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(220, 20);
            this.txtMK.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 403);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tôn giáo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dân tộc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số CMTND";
            // 
            // txtCMT
            // 
            this.txtCMT.Location = new System.Drawing.Point(30, 246);
            this.txtCMT.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtCMT.MaxLength = 10;
            this.txtCMT.Name = "txtCMT";
            this.txtCMT.Size = new System.Drawing.Size(220, 20);
            this.txtCMT.TabIndex = 5;
            this.txtCMT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMT_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(103, 132);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 0;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(31, 132);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(30, 85);
            this.txtHT.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtHT.MaxLength = 50;
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(220, 20);
            this.txtHT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(30, 39);
            this.txtMa.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtMa.MaxLength = 10;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(220, 20);
            this.txtMa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(30, 185);
            this.dtpNgaySinh.MinDate = new System.DateTime(1966, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(220, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // dtpNgayKHD
            // 
            this.dtpNgayKHD.Location = new System.Drawing.Point(297, 185);
            this.dtpNgayKHD.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKHD.Name = "dtpNgayKHD";
            this.dtpNgayKHD.Size = new System.Drawing.Size(220, 20);
            this.dtpNgayKHD.TabIndex = 12;
            // 
            // dtpNgayHHHD
            // 
            this.dtpNgayHHHD.Location = new System.Drawing.Point(297, 246);
            this.dtpNgayHHHD.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHHHD.Name = "dtpNgayHHHD";
            this.dtpNgayHHHD.Size = new System.Drawing.Size(220, 20);
            this.dtpNgayHHHD.TabIndex = 15;
            // 
            // txtDT
            // 
            this.txtDT.FormattingEnabled = true;
            this.txtDT.Items.AddRange(new object[] {
            "Kinh",
            "Tày",
            "Thái",
            "Mường",
            "Khơ Me",
            "H\'Mông",
            "Nùng",
            "Hoa",
            "Dao",
            "Gia Rai",
            "Ê Đê",
            "Ba Na",
            "Xơ Đăng",
            "Sán Chay",
            "Cơ Ho",
            "Chăm",
            "Sán Dìu",
            "Hrê",
            "Ra Glai",
            "M\'Nông",
            "X’Tiêng",
            "Bru - Vân Kiều",
            "Thổ",
            "Khơ Mú",
            "Cơ Tu",
            "Giáy",
            "Giẻ Triêng",
            "Tà Ôi",
            "Mạ",
            "Co",
            "Chơ Ro",
            "Xinh Mun",
            "Hà Nhì",
            "Chu Ru",
            "Lào",
            "Kháng",
            "La Chí",
            "Phú Lá",
            "La Hủ",
            "La Ha",
            "Pà Thẻn",
            "Chứt",
            "Lự",
            "Lô Lô",
            "Mảng",
            "Cờ Lao",
            "Bố Y",
            "Cống",
            "Ngái",
            "Si La",
            "Pu Péo",
            "Rơ măm",
            "Brâu",
            "Ơ Đu"});
            this.txtDT.Location = new System.Drawing.Point(30, 304);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(220, 21);
            this.txtDT.TabIndex = 97;
            // 
            // txtTG
            // 
            this.txtTG.FormattingEnabled = true;
            this.txtTG.Items.AddRange(new object[] {
            "Không",
            "Phật giáo",
            "Công giáo",
            "Cao Đài",
            "Hòa Hảo",
            "Tin Lành",
            "Hồi Giáo",
            "Bà La Môn",
            "Đạo Tứ ấn hiếu nghĩa",
            "Bửu sơn Kỳ hương",
            "Minh Sư Đạo",
            "Minh Lý Đạo"});
            this.txtTG.Location = new System.Drawing.Point(31, 364);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(220, 21);
            this.txtTG.TabIndex = 98;
            // 
            // UCThemSuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Controls.Add(this.pnlTool);
            this.Name = "UCThemSuaNV";
            this.Size = new System.Drawing.Size(758, 503);
            this.Load += new System.EventHandler(this.UCThemSuaNV_Load);
            this.pnlTool.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private Class.btnImage btnBack;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Panel pnlBody;
        private Class.cbxNoneChangeText cbxHocVan;
        private Class.cbxNoneChangeText cbxNgoaiNgu;
        private Class.btnImage btnSave;
        private Class.btnImage btnAnh;
        private System.Windows.Forms.PictureBox ptrAnh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private Class.cbxNoneChangeText cbxChucVu;
        private System.Windows.Forms.Label label20;
        private Class.cbxNoneChangeText txtTG;
        private Class.cbxNoneChangeText txtDT;
        private System.Windows.Forms.DateTimePicker dtpNgayHHHD;
        private System.Windows.Forms.DateTimePicker dtpNgayKHD;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}
