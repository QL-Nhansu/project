namespace GUI.UC.QLNhanSu
{
    partial class UCChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCChucVu));
            this.dgvCV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnKT = new GUI.Class.btnSimple();
            this.btnSave = new GUI.Class.btnSimple();
            this.txtCT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Panel();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new GUI.Class.btnImage();
            this.btnSua = new GUI.Class.btnImage();
            this.btnThem = new GUI.Class.btnImage();
            this.line1 = new GUI.Class.pnlLine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).BeginInit();
            this.pnlInput.SuspendLayout();
            this.pnlTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCV
            // 
            this.dgvCV.AllowUserToDeleteRows = false;
            this.dgvCV.AllowUserToResizeRows = false;
            this.dgvCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCV.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCV.Location = new System.Drawing.Point(0, 182);
            this.dgvCV.MultiSelect = false;
            this.dgvCV.Name = "dgvCV";
            this.dgvCV.RowHeadersVisible = false;
            this.dgvCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCV.Size = new System.Drawing.Size(758, 321);
            this.dgvCV.TabIndex = 7;
            this.dgvCV.TabStop = false;
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
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInput.Controls.Add(this.btnKT);
            this.pnlInput.Controls.Add(this.btnSave);
            this.pnlInput.Controls.Add(this.txtCT);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.txtTen);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.txtMa);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.line2);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 36);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(758, 146);
            this.pnlInput.TabIndex = 6;
            this.pnlInput.Visible = false;
            // 
            // btnKT
            // 
            this.btnKT.Alignment = System.Drawing.StringAlignment.Center;
            this.btnKT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnKT.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnKT.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnKT.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnKT.ForeColor = System.Drawing.Color.White;
            this.btnKT.Location = new System.Drawing.Point(518, 98);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(75, 23);
            this.btnKT.TabIndex = 0;
            this.btnKT.TabStop = false;
            this.btnKT.Text = "Kết thúc";
            this.btnKT.UseActived = false;
            this.btnKT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnKT_MouseClick);
            // 
            // btnSave
            // 
            this.btnSave.Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSave.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnSave.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(360, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Thêm";
            this.btnSave.UseActived = false;
            // 
            // txtCT
            // 
            this.txtCT.Location = new System.Drawing.Point(360, 40);
            this.txtCT.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(233, 20);
            this.txtCT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chú thích";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(24, 101);
            this.txtTen.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(233, 20);
            this.txtTen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên chức vụ";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(24, 40);
            this.txtMa.MaximumSize = new System.Drawing.Size(250, 20);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(233, 20);
            this.txtMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã chức vụ";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line2.Location = new System.Drawing.Point(0, 140);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(758, 6);
            this.line2.TabIndex = 0;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTool.Controls.Add(this.label3);
            this.pnlTool.Controls.Add(this.btnXoa);
            this.pnlTool.Controls.Add(this.btnSua);
            this.pnlTool.Controls.Add(this.btnThem);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(758, 30);
            this.pnlTool.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chức vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BgrColorMouseDown = System.Drawing.Color.Green;
            this.btnXoa.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btnXoa.TabIndex = 0;
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
            this.btnSua.BgrColorMouseDown = System.Drawing.Color.Green;
            this.btnSua.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btnSua.TabIndex = 0;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnSua.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnSua.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnSua.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnSua.UseActived = true;
            this.btnSua.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThem_MouseClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BgrColorMouseDown = System.Drawing.Color.Green;
            this.btnThem.BgrColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.btnThem.TabIndex = 0;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnThem.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnThem.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnThem.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnThem.UseActived = true;
            this.btnThem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnThem_MouseClick);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Dock = System.Windows.Forms.DockStyle.Top;
            this.line1.Location = new System.Drawing.Point(0, 30);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(758, 6);
            this.line1.TabIndex = 5;
            // 
            // UCChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCV);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.pnlTool);
            this.Name = "UCChucVu";
            this.Size = new System.Drawing.Size(758, 503);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCV)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel pnlInput;
        private Class.btnSimple btnKT;
        private Class.btnSimple btnSave;
        private System.Windows.Forms.TextBox txtCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel line2;
        private Class.pnlLine line1;
        private System.Windows.Forms.Panel pnlTool;
        private Class.btnImage btnXoa;
        private Class.btnImage btnSua;
        private Class.btnImage btnThem;
        private System.Windows.Forms.Label label3;
    }
}
