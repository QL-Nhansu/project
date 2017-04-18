namespace GUI.UC.QLNhanSu
{
    partial class UCDSNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDSNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new GUI.Class.btnImage();
            this.btnSua = new GUI.Class.btnImage();
            this.btnThem = new GUI.Class.btnImage();
            this.cbxView = new GUI.Class.cbxNoneChangeText();
            this.labView = new System.Windows.Forms.Label();
            this.ctmnMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemHoSoChiTietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenPhongBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.pnlLine1 = new GUI.Class.pnlLine();
            this.pnlTool.SuspendLayout();
            this.ctmnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Controls.Add(this.btnXoa);
            this.pnlTool.Controls.Add(this.btnSua);
            this.pnlTool.Controls.Add(this.btnThem);
            this.pnlTool.Controls.Add(this.cbxView);
            this.pnlTool.Controls.Add(this.labView);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(758, 30);
            this.pnlTool.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhân viên";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BgrColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnXoa.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXoa.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnXoa.ImageMouseDown = null;
            this.btnXoa.ImageMouseEnter = null;
            this.btnXoa.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageMouseLeave")));
            this.btnXoa.ImgMargin = 5;
            this.btnXoa.ImgSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(134, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(67, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnXoa.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnXoa.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnXoa.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnXoa.UseActived = false;
            this.btnXoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnXoa_MouseClick);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BgrColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnSua.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSua.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnSua.ImageMouseDown = null;
            this.btnSua.ImageMouseEnter = null;
            this.btnSua.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageMouseLeave")));
            this.btnSua.ImgMargin = 5;
            this.btnSua.ImgSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(67, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(67, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnSua.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnSua.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnSua.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnSua.UseActived = false;
            this.btnSua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSua_MouseClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BgrColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnThem.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnThem.ImageMouseDown = null;
            this.btnThem.ImageMouseEnter = null;
            this.btnThem.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageMouseLeave")));
            this.btnThem.ImgMargin = 5;
            this.btnThem.ImgSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 30);
            this.btnThem.TabIndex = 2;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnThem.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnThem.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnThem.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnThem.UseActived = false;
            this.btnThem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThem_MouseClick);
            // 
            // cbxView
            // 
            this.cbxView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxView.FormattingEnabled = true;
            this.cbxView.Items.AddRange(new object[] {
            "Phòng ban, mã nv",
            "Chức vụ, mã nv"});
            this.cbxView.Location = new System.Drawing.Point(634, 5);
            this.cbxView.Name = "cbxView";
            this.cbxView.Size = new System.Drawing.Size(121, 21);
            this.cbxView.TabIndex = 1;
            this.cbxView.TabStop = false;
            this.cbxView.SelectedIndexChanged += new System.EventHandler(this.cbxView_SelectedIndexChanged);
            // 
            // labView
            // 
            this.labView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labView.AutoSize = true;
            this.labView.Location = new System.Drawing.Point(587, 9);
            this.labView.Name = "labView";
            this.labView.Size = new System.Drawing.Size(40, 13);
            this.labView.TabIndex = 0;
            this.labView.Text = "Sort by";
            // 
            // ctmnMenu
            // 
            this.ctmnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemHoSoChiTietToolStripMenuItem,
            this.chuyenPhongBanToolStripMenuItem,
            this.suaToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.ctmnMenu.Name = "contextMenuStrip1";
            this.ctmnMenu.Size = new System.Drawing.Size(177, 92);
            // 
            // xemHoSoChiTietToolStripMenuItem
            // 
            this.xemHoSoChiTietToolStripMenuItem.Name = "xemHoSoChiTietToolStripMenuItem";
            this.xemHoSoChiTietToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.xemHoSoChiTietToolStripMenuItem.Text = "Xem hồ sơ chi tiết";
            this.xemHoSoChiTietToolStripMenuItem.Click += new System.EventHandler(this.xemHoSoChiTietToolStripMenuItem_Click);
            // 
            // chuyenPhongBanToolStripMenuItem
            // 
            this.chuyenPhongBanToolStripMenuItem.Name = "chuyenPhongBanToolStripMenuItem";
            this.chuyenPhongBanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.chuyenPhongBanToolStripMenuItem.Text = "Chuyển phòng ban";
            this.chuyenPhongBanToolStripMenuItem.Click += new System.EventHandler(this.chuyenPhongBanToolStripMenuItem_Click);
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.suaToolStripMenuItem.Text = "Sửa nhân viên";
            this.suaToolStripMenuItem.Click += new System.EventHandler(this.suaToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.xoaToolStripMenuItem.Text = "Xóa nhân viên";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.AllowUserToAddRows = false;
            this.dgvDSNV.AllowUserToDeleteRows = false;
            this.dgvDSNV.AllowUserToResizeRows = false;
            this.dgvDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.ContextMenuStrip = this.ctmnMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDSNV.Location = new System.Drawing.Point(0, 36);
            this.dgvDSNV.MultiSelect = false;
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.ReadOnly = true;
            this.dgvDSNV.RowHeadersVisible = false;
            this.dgvDSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNV.Size = new System.Drawing.Size(758, 467);
            this.dgvDSNV.TabIndex = 2;
            this.dgvDSNV.TabStop = false;
            // 
            // pnlLine1
            // 
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine1.Location = new System.Drawing.Point(0, 30);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(758, 6);
            this.pnlLine1.TabIndex = 1;
            // 
            // UCDSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.pnlLine1);
            this.Controls.Add(this.pnlTool);
            this.Name = "UCDSNhanVien";
            this.Size = new System.Drawing.Size(758, 503);
            this.Load += new System.EventHandler(this.UCDSNhanVien_Load);
            this.VisibleChanged += new System.EventHandler(this.UCDSNhanVien_VisibleChanged);
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.ctmnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private Class.btnImage btnXoa;
        private Class.btnImage btnSua;
        private Class.btnImage btnThem;
        private Class.cbxNoneChangeText cbxView;
        private System.Windows.Forms.Label labView;
        private System.Windows.Forms.ContextMenuStrip ctmnMenu;
        private System.Windows.Forms.ToolStripMenuItem xemHoSoChiTietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenPhongBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private Class.pnlLine pnlLine1;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.Label label1;
    }
}
