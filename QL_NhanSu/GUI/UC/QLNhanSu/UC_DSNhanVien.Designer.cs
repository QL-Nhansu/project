namespace GUI.UC.QLNhanSu
{
    partial class UC_DSNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DSNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btnXoa = new GUI.Class.btnImage();
            this.btnSua = new GUI.Class.btnImage();
            this.btnThem = new GUI.Class.btnImage();
            this.cbxView = new GUI.Class.cbxNoneChangeText();
            this.labView = new System.Windows.Forms.Label();
            this.ctmnMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemHồSơChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLine1 = new GUI.Class.pnlLine();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTool.SuspendLayout();
            this.ctmnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.WhiteSmoke;
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
            "Phòng ban",
            "Chức vụ"});
            this.cbxView.Location = new System.Drawing.Point(634, 5);
            this.cbxView.Name = "cbxView";
            this.cbxView.Size = new System.Drawing.Size(121, 21);
            this.cbxView.TabIndex = 1;
            this.cbxView.TabStop = false;
            // 
            // labView
            // 
            this.labView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labView.AutoSize = true;
            this.labView.Location = new System.Drawing.Point(587, 9);
            this.labView.Name = "labView";
            this.labView.Size = new System.Drawing.Size(47, 13);
            this.labView.TabIndex = 0;
            this.labView.Text = "ViewTile";
            // 
            // ctmnMenu
            // 
            this.ctmnMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemHồSơChiTiếtToolStripMenuItem,
            this.chuyểnPhòngBanToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaNhânViênToolStripMenuItem});
            this.ctmnMenu.Name = "contextMenuStrip1";
            this.ctmnMenu.Size = new System.Drawing.Size(177, 114);
            // 
            // xemHồSơChiTiếtToolStripMenuItem
            // 
            this.xemHồSơChiTiếtToolStripMenuItem.Name = "xemHồSơChiTiếtToolStripMenuItem";
            this.xemHồSơChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.xemHồSơChiTiếtToolStripMenuItem.Text = "Xem hồ sơ chi tiết";
            this.xemHồSơChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.xemHồSơChiTiếtToolStripMenuItem_Click);
            // 
            // chuyểnPhòngBanToolStripMenuItem
            // 
            this.chuyểnPhòngBanToolStripMenuItem.Name = "chuyểnPhòngBanToolStripMenuItem";
            this.chuyểnPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.chuyểnPhòngBanToolStripMenuItem.Text = "Chuyển phòng ban";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.sửaToolStripMenuItem.Text = "Sửa nhân viên";
            // 
            // xóaNhânViênToolStripMenuItem
            // 
            this.xóaNhânViênToolStripMenuItem.Name = "xóaNhânViênToolStripMenuItem";
            this.xóaNhânViênToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.xóaNhânViênToolStripMenuItem.Text = "Xóa nhân viên";
            // 
            // pnlLine1
            // 
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine1.Location = new System.Drawing.Point(0, 30);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(758, 6);
            this.pnlLine1.TabIndex = 1;
            // 
            // dgvDSNV
            // 
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
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDSNV.ContextMenuStrip = this.ctmnMenu;
            this.dgvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDSNV.Location = new System.Drawing.Point(0, 36);
            this.dgvDSNV.MultiSelect = false;
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersVisible = false;
            this.dgvDSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNV.Size = new System.Drawing.Size(758, 467);
            this.dgvDSNV.TabIndex = 2;
            this.dgvDSNV.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // UC_DSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.pnlLine1);
            this.Controls.Add(this.pnlTool);
            this.Name = "UC_DSNhanVien";
            this.Size = new System.Drawing.Size(758, 503);
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
        private System.Windows.Forms.ToolStripMenuItem xemHồSơChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaNhânViênToolStripMenuItem;
        private Class.pnlLine pnlLine1;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
