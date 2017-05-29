namespace GUI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ToolBar = new System.Windows.Forms.Panel();
            this.pnlSearch = new GUI.Class.pnlRoundRectangle();
            this.txtSearch = new GUI.Class.txtboxSearch();
            this.btnSearch = new GUI.Class.btnImage();
            this.labUser = new System.Windows.Forms.Label();
            this.btnLogin = new GUI.Class.btnImage();
            this.Logo = new System.Windows.Forms.Label();
            this.labLogo = new System.Windows.Forms.Label();
            this.btnMinimize = new GUI.Class.btnSimple();
            this.btnMaximize = new GUI.Class.btnSimple();
            this.btnClose = new GUI.Class.btnSimple();
            this.Body = new System.Windows.Forms.Panel();
            this.RenderBody = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTryAgain = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsername = new GUI.Class.txtboxSearch();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new GUI.Class.txtboxSearch();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new GUI.Class.btnSimple();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.Panel();
            this.pnlMoRong = new System.Windows.Forms.Panel();
            this.pnlLine14 = new GUI.Class.pnlLine();
            this.btnPhuCap = new GUI.Class.btnSimple();
            this.pnlLine13 = new GUI.Class.pnlLine();
            this.btnKyLuat = new GUI.Class.btnSimple();
            this.pnlLine12 = new GUI.Class.pnlLine();
            this.btnKhenThuong = new GUI.Class.btnSimple();
            this.pnlLine10 = new GUI.Class.pnlLine();
            this.btnHocVan = new GUI.Class.btnSimple();
            this.pnlLine9 = new GUI.Class.pnlLine();
            this.btnNgoaiNgu = new GUI.Class.btnSimple();
            this.pnlLine8 = new GUI.Class.pnlLine();
            this.btnMoRong = new GUI.Class.btnSimple();
            this.pnlQLCong = new System.Windows.Forms.Panel();
            this.pnlLine7 = new GUI.Class.pnlLine();
            this.btnBangCong = new GUI.Class.btnSimple();
            this.pnlLine6 = new GUI.Class.pnlLine();
            this.btnChamCong = new GUI.Class.btnSimple();
            this.pnlLine5 = new GUI.Class.pnlLine();
            this.btnQLCong = new GUI.Class.btnSimple();
            this.pnlQLNhanSu = new System.Windows.Forms.Panel();
            this.pnlLine4 = new GUI.Class.pnlLine();
            this.btnDSNV = new GUI.Class.btnSimple();
            this.pnlLine3 = new GUI.Class.pnlLine();
            this.btnChucVu = new GUI.Class.btnSimple();
            this.pnlLine2 = new GUI.Class.pnlLine();
            this.btnQLNhanSu = new GUI.Class.btnSimple();
            this.pnlLine1 = new GUI.Class.pnlLine();
            this.btnMenu = new GUI.Class.btnImage();
            this.erpSignIn = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolBar.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.Body.SuspendLayout();
            this.RenderBody.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.pnlMoRong.SuspendLayout();
            this.pnlQLCong.SuspendLayout();
            this.pnlQLNhanSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpSignIn)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.ToolBar.Controls.Add(this.pnlSearch);
            this.ToolBar.Controls.Add(this.labUser);
            this.ToolBar.Controls.Add(this.btnLogin);
            this.ToolBar.Controls.Add(this.Logo);
            this.ToolBar.Controls.Add(this.labLogo);
            this.ToolBar.Controls.Add(this.btnMinimize);
            this.ToolBar.Controls.Add(this.btnMaximize);
            this.ToolBar.Controls.Add(this.btnClose);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(1, 1);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(958, 35);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseDown);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BoderColor = System.Drawing.Color.Empty;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.InnerColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(352, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Radius = 5;
            this.pnlSearch.Size = new System.Drawing.Size(389, 30);
            this.pnlSearch.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.DefaultString = "Search...";
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(13, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(344, 13);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "Search...";
            this.txtSearch.EventKeyEnter += new System.EventHandler(this.txtSearch_EventKeyEnter);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BgrColorMouseDown = System.Drawing.Color.Transparent;
            this.btnSearch.BgrColorMouseEnter = System.Drawing.Color.Transparent;
            this.btnSearch.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnSearch.ImageMouseDown = null;
            this.btnSearch.ImageMouseEnter = null;
            this.btnSearch.ImageMouseLeave = null;
            this.btnSearch.ImgMargin = 0;
            this.btnSearch.ImgSize = new System.Drawing.Size(23, 23);
            this.btnSearch.Location = new System.Drawing.Point(363, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "";
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.TextColorMouseDown = System.Drawing.SystemColors.Highlight;
            this.btnSearch.TextColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnSearch.UseActived = false;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser.ForeColor = System.Drawing.Color.White;
            this.labUser.Location = new System.Drawing.Point(203, 9);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(55, 17);
            this.labUser.TabIndex = 6;
            this.labUser.Text = " User";
            this.labUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BgrColorMouseDown = System.Drawing.Color.Empty;
            this.btnLogin.BgrColorMouseEnter = System.Drawing.Color.Empty;
            this.btnLogin.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.Enabled = false;
            this.btnLogin.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnLogin.ImageMouseDown = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageMouseDown")));
            this.btnLogin.ImageMouseEnter = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageMouseEnter")));
            this.btnLogin.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageMouseLeave")));
            this.btnLogin.ImgMargin = 3;
            this.btnLogin.ImgSize = new System.Drawing.Size(23, 23);
            this.btnLogin.Location = new System.Drawing.Point(766, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.TextColorMouseDown = System.Drawing.Color.Black;
            this.btnLogin.TextColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.TextColorMouseLeave = System.Drawing.Color.White;
            this.btnLogin.UseActived = false;
            this.btnLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseClick);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Location = new System.Drawing.Point(-1, -4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(62, 44);
            this.Logo.TabIndex = 3;
            this.Logo.Text = "DT";
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseDown);
            // 
            // labLogo
            // 
            this.labLogo.AutoSize = true;
            this.labLogo.BackColor = System.Drawing.Color.Transparent;
            this.labLogo.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogo.ForeColor = System.Drawing.Color.White;
            this.labLogo.Location = new System.Drawing.Point(56, 2);
            this.labLogo.Name = "labLogo";
            this.labLogo.Size = new System.Drawing.Size(56, 35);
            this.labLogo.TabIndex = 4;
            this.labLogo.Text = "Project";
            this.labLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolbar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Alignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnMinimize.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(217)))));
            this.btnMinimize.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(853, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "0";
            this.btnMinimize.UseActived = false;
            this.btnMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseClick);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Alignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnMaximize.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(161)))), ((int)(((byte)(217)))));
            this.btnMaximize.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(888, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Text = "1";
            this.btnMaximize.UseActived = false;
            this.btnMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMaximize_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
            this.btnClose.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(923, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "r";
            this.btnClose.UseActived = false;
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseClick);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.SystemColors.Control;
            this.Body.Controls.Add(this.RenderBody);
            this.Body.Controls.Add(this.MainMenu);
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(1, 36);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(958, 503);
            this.Body.TabIndex = 1;
            // 
            // RenderBody
            // 
            this.RenderBody.BackColor = System.Drawing.Color.White;
            this.RenderBody.Controls.Add(this.pnlLogin);
            this.RenderBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderBody.Location = new System.Drawing.Point(200, 0);
            this.RenderBody.Name = "RenderBody";
            this.RenderBody.Size = new System.Drawing.Size(758, 503);
            this.RenderBody.TabIndex = 1;
            this.RenderBody.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.RenderBody_ControlAdded);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(758, 503);
            this.pnlLogin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Location = new System.Drawing.Point(259, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 506);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTryAgain);
            this.panel4.Location = new System.Drawing.Point(47, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 36);
            this.panel4.TabIndex = 5;
            // 
            // lblTryAgain
            // 
            this.lblTryAgain.AutoSize = true;
            this.lblTryAgain.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTryAgain.Location = new System.Drawing.Point(82, 12);
            this.lblTryAgain.Name = "lblTryAgain";
            this.lblTryAgain.Size = new System.Drawing.Size(223, 13);
            this.lblTryAgain.TabIndex = 0;
            this.lblTryAgain.Text = "Please try again your username and password";
            this.lblTryAgain.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(47, 185);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 45);
            this.panel3.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.DefaultString = "Username/ Email";
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(44, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(324, 13);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "Username/ Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(47, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 48);
            this.panel2.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.DefaultString = "Password";
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(44, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(324, 13);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connect to \r\nHUMAN RESOURCES MANAGEMENT\r\n";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Alignment = System.Drawing.StringAlignment.Center;
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSignIn.ColorMouseDown = System.Drawing.Color.Teal;
            this.btnSignIn.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSignIn.ColorMouseLeave = System.Drawing.Color.White;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Location = new System.Drawing.Point(186, 309);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(90, 23);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseActived = false;
            this.btnSignIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSignIn_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(18, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter your username and password to manager \r\nand browse your Human resources man" +
    "agement\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(18, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(21, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 227);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MainMenu.Controls.Add(this.pnlMoRong);
            this.MainMenu.Controls.Add(this.pnlLine8);
            this.MainMenu.Controls.Add(this.btnMoRong);
            this.MainMenu.Controls.Add(this.pnlQLCong);
            this.MainMenu.Controls.Add(this.pnlLine5);
            this.MainMenu.Controls.Add(this.btnQLCong);
            this.MainMenu.Controls.Add(this.pnlQLNhanSu);
            this.MainMenu.Controls.Add(this.pnlLine2);
            this.MainMenu.Controls.Add(this.btnQLNhanSu);
            this.MainMenu.Controls.Add(this.pnlLine1);
            this.MainMenu.Controls.Add(this.btnMenu);
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(200, 503);
            this.MainMenu.TabIndex = 0;
            // 
            // pnlMoRong
            // 
            this.pnlMoRong.Controls.Add(this.pnlLine14);
            this.pnlMoRong.Controls.Add(this.btnPhuCap);
            this.pnlMoRong.Controls.Add(this.pnlLine13);
            this.pnlMoRong.Controls.Add(this.btnKyLuat);
            this.pnlMoRong.Controls.Add(this.pnlLine12);
            this.pnlMoRong.Controls.Add(this.btnKhenThuong);
            this.pnlMoRong.Controls.Add(this.pnlLine10);
            this.pnlMoRong.Controls.Add(this.btnHocVan);
            this.pnlMoRong.Controls.Add(this.pnlLine9);
            this.pnlMoRong.Controls.Add(this.btnNgoaiNgu);
            this.pnlMoRong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMoRong.Location = new System.Drawing.Point(0, 248);
            this.pnlMoRong.Name = "pnlMoRong";
            this.pnlMoRong.Size = new System.Drawing.Size(200, 155);
            this.pnlMoRong.TabIndex = 10;
            this.pnlMoRong.Visible = false;
            // 
            // pnlLine14
            // 
            this.pnlLine14.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine14.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine14.Location = new System.Drawing.Point(0, 154);
            this.pnlLine14.Name = "pnlLine14";
            this.pnlLine14.Size = new System.Drawing.Size(200, 1);
            this.pnlLine14.TabIndex = 14;
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Alignment = System.Drawing.StringAlignment.Near;
            this.btnPhuCap.BackColor = System.Drawing.Color.Transparent;
            this.btnPhuCap.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnPhuCap.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnPhuCap.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnPhuCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhuCap.ForeColor = System.Drawing.Color.Black;
            this.btnPhuCap.Location = new System.Drawing.Point(0, 124);
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.Size = new System.Drawing.Size(200, 30);
            this.btnPhuCap.TabIndex = 13;
            this.btnPhuCap.TabStop = false;
            this.btnPhuCap.Text = "           Phụ cấp";
            this.btnPhuCap.UseActived = true;
            this.btnPhuCap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPhuCap_MouseClick);
            // 
            // pnlLine13
            // 
            this.pnlLine13.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine13.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine13.Location = new System.Drawing.Point(0, 123);
            this.pnlLine13.Name = "pnlLine13";
            this.pnlLine13.Size = new System.Drawing.Size(200, 1);
            this.pnlLine13.TabIndex = 12;
            // 
            // btnKyLuat
            // 
            this.btnKyLuat.Alignment = System.Drawing.StringAlignment.Near;
            this.btnKyLuat.BackColor = System.Drawing.Color.Transparent;
            this.btnKyLuat.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnKyLuat.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnKyLuat.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnKyLuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKyLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyLuat.ForeColor = System.Drawing.Color.Black;
            this.btnKyLuat.Location = new System.Drawing.Point(0, 93);
            this.btnKyLuat.Name = "btnKyLuat";
            this.btnKyLuat.Size = new System.Drawing.Size(200, 30);
            this.btnKyLuat.TabIndex = 11;
            this.btnKyLuat.TabStop = false;
            this.btnKyLuat.Text = "           Kỷ luật";
            this.btnKyLuat.UseActived = true;
            this.btnKyLuat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnKyLuat_MouseClick);
            // 
            // pnlLine12
            // 
            this.pnlLine12.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine12.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine12.Location = new System.Drawing.Point(0, 92);
            this.pnlLine12.Name = "pnlLine12";
            this.pnlLine12.Size = new System.Drawing.Size(200, 1);
            this.pnlLine12.TabIndex = 10;
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Alignment = System.Drawing.StringAlignment.Near;
            this.btnKhenThuong.BackColor = System.Drawing.Color.Transparent;
            this.btnKhenThuong.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnKhenThuong.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnKhenThuong.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnKhenThuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhenThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhenThuong.ForeColor = System.Drawing.Color.Black;
            this.btnKhenThuong.Location = new System.Drawing.Point(0, 62);
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.Size = new System.Drawing.Size(200, 30);
            this.btnKhenThuong.TabIndex = 9;
            this.btnKhenThuong.TabStop = false;
            this.btnKhenThuong.Text = "           Khen thưởng";
            this.btnKhenThuong.UseActived = true;
            this.btnKhenThuong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnKhenThuong_MouseClick);
            // 
            // pnlLine10
            // 
            this.pnlLine10.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine10.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine10.Location = new System.Drawing.Point(0, 61);
            this.pnlLine10.Name = "pnlLine10";
            this.pnlLine10.Size = new System.Drawing.Size(200, 1);
            this.pnlLine10.TabIndex = 6;
            // 
            // btnHocVan
            // 
            this.btnHocVan.Alignment = System.Drawing.StringAlignment.Near;
            this.btnHocVan.BackColor = System.Drawing.Color.Transparent;
            this.btnHocVan.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnHocVan.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnHocVan.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnHocVan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHocVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocVan.ForeColor = System.Drawing.Color.Black;
            this.btnHocVan.Location = new System.Drawing.Point(0, 31);
            this.btnHocVan.Name = "btnHocVan";
            this.btnHocVan.Size = new System.Drawing.Size(200, 30);
            this.btnHocVan.TabIndex = 5;
            this.btnHocVan.TabStop = false;
            this.btnHocVan.Text = "           Học vấn";
            this.btnHocVan.UseActived = true;
            this.btnHocVan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHocVan_MouseClick);
            // 
            // pnlLine9
            // 
            this.pnlLine9.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine9.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine9.Location = new System.Drawing.Point(0, 30);
            this.pnlLine9.Name = "pnlLine9";
            this.pnlLine9.Size = new System.Drawing.Size(200, 1);
            this.pnlLine9.TabIndex = 4;
            // 
            // btnNgoaiNgu
            // 
            this.btnNgoaiNgu.Alignment = System.Drawing.StringAlignment.Near;
            this.btnNgoaiNgu.BackColor = System.Drawing.Color.Transparent;
            this.btnNgoaiNgu.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnNgoaiNgu.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnNgoaiNgu.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnNgoaiNgu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgoaiNgu.ForeColor = System.Drawing.Color.Black;
            this.btnNgoaiNgu.Location = new System.Drawing.Point(0, 0);
            this.btnNgoaiNgu.Name = "btnNgoaiNgu";
            this.btnNgoaiNgu.Size = new System.Drawing.Size(200, 30);
            this.btnNgoaiNgu.TabIndex = 3;
            this.btnNgoaiNgu.TabStop = false;
            this.btnNgoaiNgu.Text = "           Ngoại ngữ";
            this.btnNgoaiNgu.UseActived = true;
            this.btnNgoaiNgu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNgoaiNgu_MouseClick);
            // 
            // pnlLine8
            // 
            this.pnlLine8.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine8.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine8.Location = new System.Drawing.Point(0, 247);
            this.pnlLine8.Name = "pnlLine8";
            this.pnlLine8.Size = new System.Drawing.Size(200, 1);
            this.pnlLine8.TabIndex = 9;
            // 
            // btnMoRong
            // 
            this.btnMoRong.Alignment = System.Drawing.StringAlignment.Near;
            this.btnMoRong.BackColor = System.Drawing.Color.Transparent;
            this.btnMoRong.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnMoRong.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnMoRong.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnMoRong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoRong.Enabled = false;
            this.btnMoRong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoRong.ForeColor = System.Drawing.Color.Black;
            this.btnMoRong.Location = new System.Drawing.Point(0, 217);
            this.btnMoRong.Name = "btnMoRong";
            this.btnMoRong.Size = new System.Drawing.Size(200, 30);
            this.btnMoRong.TabIndex = 8;
            this.btnMoRong.TabStop = false;
            this.btnMoRong.Text = "   ▶   Mở rộng";
            this.btnMoRong.UseActived = false;
            this.btnMoRong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMoRong_MouseClick);
            // 
            // pnlQLCong
            // 
            this.pnlQLCong.Controls.Add(this.pnlLine7);
            this.pnlQLCong.Controls.Add(this.btnBangCong);
            this.pnlQLCong.Controls.Add(this.pnlLine6);
            this.pnlQLCong.Controls.Add(this.btnChamCong);
            this.pnlQLCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQLCong.Location = new System.Drawing.Point(0, 155);
            this.pnlQLCong.Name = "pnlQLCong";
            this.pnlQLCong.Size = new System.Drawing.Size(200, 62);
            this.pnlQLCong.TabIndex = 7;
            this.pnlQLCong.Visible = false;
            // 
            // pnlLine7
            // 
            this.pnlLine7.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine7.Location = new System.Drawing.Point(0, 61);
            this.pnlLine7.Name = "pnlLine7";
            this.pnlLine7.Size = new System.Drawing.Size(200, 1);
            this.pnlLine7.TabIndex = 5;
            // 
            // btnBangCong
            // 
            this.btnBangCong.Alignment = System.Drawing.StringAlignment.Near;
            this.btnBangCong.BackColor = System.Drawing.Color.Transparent;
            this.btnBangCong.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnBangCong.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnBangCong.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnBangCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBangCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangCong.ForeColor = System.Drawing.Color.Black;
            this.btnBangCong.Location = new System.Drawing.Point(0, 31);
            this.btnBangCong.Name = "btnBangCong";
            this.btnBangCong.Size = new System.Drawing.Size(200, 30);
            this.btnBangCong.TabIndex = 4;
            this.btnBangCong.TabStop = false;
            this.btnBangCong.Text = "           Bảng công";
            this.btnBangCong.UseActived = true;
            this.btnBangCong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBangCong_MouseClick);
            // 
            // pnlLine6
            // 
            this.pnlLine6.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine6.Location = new System.Drawing.Point(0, 30);
            this.pnlLine6.Name = "pnlLine6";
            this.pnlLine6.Size = new System.Drawing.Size(200, 1);
            this.pnlLine6.TabIndex = 3;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Alignment = System.Drawing.StringAlignment.Near;
            this.btnChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnChamCong.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnChamCong.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.Black;
            this.btnChamCong.Location = new System.Drawing.Point(0, 0);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(200, 30);
            this.btnChamCong.TabIndex = 2;
            this.btnChamCong.TabStop = false;
            this.btnChamCong.Text = "           Chấm công";
            this.btnChamCong.UseActived = true;
            this.btnChamCong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChamCong_MouseClick);
            // 
            // pnlLine5
            // 
            this.pnlLine5.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine5.Location = new System.Drawing.Point(0, 154);
            this.pnlLine5.Name = "pnlLine5";
            this.pnlLine5.Size = new System.Drawing.Size(200, 1);
            this.pnlLine5.TabIndex = 6;
            // 
            // btnQLCong
            // 
            this.btnQLCong.Alignment = System.Drawing.StringAlignment.Near;
            this.btnQLCong.BackColor = System.Drawing.Color.Transparent;
            this.btnQLCong.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnQLCong.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnQLCong.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnQLCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLCong.Enabled = false;
            this.btnQLCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCong.ForeColor = System.Drawing.Color.Black;
            this.btnQLCong.Location = new System.Drawing.Point(0, 124);
            this.btnQLCong.Name = "btnQLCong";
            this.btnQLCong.Size = new System.Drawing.Size(200, 30);
            this.btnQLCong.TabIndex = 5;
            this.btnQLCong.TabStop = false;
            this.btnQLCong.Text = "   ▶   Quản lý công";
            this.btnQLCong.UseActived = false;
            this.btnQLCong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnQLCong_MouseClick);
            // 
            // pnlQLNhanSu
            // 
            this.pnlQLNhanSu.Controls.Add(this.pnlLine4);
            this.pnlQLNhanSu.Controls.Add(this.btnDSNV);
            this.pnlQLNhanSu.Controls.Add(this.pnlLine3);
            this.pnlQLNhanSu.Controls.Add(this.btnChucVu);
            this.pnlQLNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQLNhanSu.Location = new System.Drawing.Point(0, 62);
            this.pnlQLNhanSu.Name = "pnlQLNhanSu";
            this.pnlQLNhanSu.Size = new System.Drawing.Size(200, 62);
            this.pnlQLNhanSu.TabIndex = 4;
            // 
            // pnlLine4
            // 
            this.pnlLine4.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine4.Location = new System.Drawing.Point(0, 61);
            this.pnlLine4.Name = "pnlLine4";
            this.pnlLine4.Size = new System.Drawing.Size(200, 1);
            this.pnlLine4.TabIndex = 6;
            // 
            // btnDSNV
            // 
            this.btnDSNV.Alignment = System.Drawing.StringAlignment.Near;
            this.btnDSNV.BackColor = System.Drawing.Color.Transparent;
            this.btnDSNV.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnDSNV.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnDSNV.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSNV.Enabled = false;
            this.btnDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSNV.ForeColor = System.Drawing.Color.Black;
            this.btnDSNV.Location = new System.Drawing.Point(0, 31);
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(200, 30);
            this.btnDSNV.TabIndex = 2;
            this.btnDSNV.TabStop = false;
            this.btnDSNV.Text = "           Danh sách nhân viên";
            this.btnDSNV.UseActived = true;
            this.btnDSNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDSNV_MouseClick);
            // 
            // pnlLine3
            // 
            this.pnlLine3.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine3.Location = new System.Drawing.Point(0, 30);
            this.pnlLine3.Name = "pnlLine3";
            this.pnlLine3.Size = new System.Drawing.Size(200, 1);
            this.pnlLine3.TabIndex = 4;
            // 
            // btnChucVu
            // 
            this.btnChucVu.Alignment = System.Drawing.StringAlignment.Near;
            this.btnChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnChucVu.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnChucVu.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnChucVu.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnChucVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChucVu.Enabled = false;
            this.btnChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucVu.ForeColor = System.Drawing.Color.Black;
            this.btnChucVu.Location = new System.Drawing.Point(0, 0);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(200, 30);
            this.btnChucVu.TabIndex = 1;
            this.btnChucVu.TabStop = false;
            this.btnChucVu.Text = "           Chức vụ";
            this.btnChucVu.UseActived = true;
            this.btnChucVu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChucVu_MouseClick);
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine2.Location = new System.Drawing.Point(0, 61);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(200, 1);
            this.pnlLine2.TabIndex = 3;
            // 
            // btnQLNhanSu
            // 
            this.btnQLNhanSu.Alignment = System.Drawing.StringAlignment.Near;
            this.btnQLNhanSu.BackColor = System.Drawing.Color.Transparent;
            this.btnQLNhanSu.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnQLNhanSu.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnQLNhanSu.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnQLNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanSu.Enabled = false;
            this.btnQLNhanSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanSu.ForeColor = System.Drawing.Color.Black;
            this.btnQLNhanSu.Location = new System.Drawing.Point(0, 31);
            this.btnQLNhanSu.Name = "btnQLNhanSu";
            this.btnQLNhanSu.Size = new System.Drawing.Size(200, 30);
            this.btnQLNhanSu.TabIndex = 2;
            this.btnQLNhanSu.TabStop = false;
            this.btnQLNhanSu.Text = "   ◢   Quản lý nhân sự";
            this.btnQLNhanSu.UseActived = false;
            this.btnQLNhanSu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnQLNhanSu_MouseClick);
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine1.Location = new System.Drawing.Point(0, 30);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(200, 1);
            this.pnlLine1.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BgrColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMenu.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.btnMenu.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.Enabled = false;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnMenu.ImageMouseDown = null;
            this.btnMenu.ImageMouseEnter = null;
            this.btnMenu.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnMenu.ImageMouseLeave")));
            this.btnMenu.ImgMargin = 8;
            this.btnMenu.ImgSize = new System.Drawing.Size(23, 23);
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 30);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "   Menu";
            this.btnMenu.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnMenu.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnMenu.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnMenu.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnMenu.UseActived = false;
            this.btnMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseClick);
            // 
            // erpSignIn
            // 
            this.erpSignIn.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.ToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.Body.ResumeLayout(false);
            this.RenderBody.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.pnlMoRong.ResumeLayout(false);
            this.pnlQLCong.ResumeLayout(false);
            this.pnlQLNhanSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpSignIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnMinimize;
        private Class.btnSimple btnMaximize;
        private Class.btnSimple btnClose;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Panel MainMenu;
        private System.Windows.Forms.Panel RenderBody;
        private Class.btnImage btnMenu;
        private System.Windows.Forms.Panel pnlMoRong;
        private Class.pnlLine pnlLine14;
        private Class.btnSimple btnPhuCap;
        private Class.pnlLine pnlLine13;
        private Class.btnSimple btnKyLuat;
        private Class.pnlLine pnlLine12;
        private Class.btnSimple btnKhenThuong;
        private Class.pnlLine pnlLine10;
        private Class.btnSimple btnHocVan;
        private Class.pnlLine pnlLine9;
        private Class.btnSimple btnNgoaiNgu;
        private Class.pnlLine pnlLine8;
        private Class.btnSimple btnMoRong;
        private System.Windows.Forms.Panel pnlQLCong;
        private Class.pnlLine pnlLine7;
        private Class.btnSimple btnBangCong;
        private Class.pnlLine pnlLine6;
        private Class.btnSimple btnChamCong;
        private Class.pnlLine pnlLine5;
        private Class.btnSimple btnQLCong;
        private System.Windows.Forms.Panel pnlQLNhanSu;
        private Class.pnlLine pnlLine4;
        private Class.btnSimple btnDSNV;
        private Class.pnlLine pnlLine3;
        private Class.btnSimple btnChucVu;
        private Class.pnlLine pnlLine2;
        private Class.btnSimple btnQLNhanSu;
        private Class.pnlLine pnlLine1;
        private Class.btnImage btnLogin;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label labLogo;
        private System.Windows.Forms.Label labUser;
        private Class.pnlRoundRectangle pnlSearch;
        private Class.btnImage btnSearch;
        private Class.txtboxSearch txtSearch;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTryAgain;
        private System.Windows.Forms.Panel panel3;
        private Class.txtboxSearch txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Class.txtboxSearch txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Class.btnSimple btnSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider erpSignIn;
    }
}

