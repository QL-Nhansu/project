namespace GUI.UC
{
    partial class UCLogin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlRoundRectangle1 = new GUI.Class.pnlRoundRectangle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSearch1 = new GUI.Class.txtboxSearch();
            this.pnlRoundRectangle2 = new GUI.Class.pnlRoundRectangle();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxSearch3 = new GUI.Class.txtboxSearch();
            this.btnSimple1 = new GUI.Class.btnSimple();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlRoundRectangle1.SuspendLayout();
            this.pnlRoundRectangle2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlLogin, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.panel1);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnSimple1);
            this.pnlLogin.Controls.Add(this.pnlRoundRectangle2);
            this.pnlLogin.Controls.Add(this.pnlRoundRectangle1);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(207, 53);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(344, 294);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.LocationChanged += new System.EventHandler(this.pnlLogin_LocationChanged);
            // 
            // pnlRoundRectangle1
            // 
            this.pnlRoundRectangle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoundRectangle1.BackColor = System.Drawing.Color.White;
            this.pnlRoundRectangle1.BoderColor = System.Drawing.Color.Empty;
            this.pnlRoundRectangle1.Controls.Add(this.label1);
            this.pnlRoundRectangle1.Controls.Add(this.txtboxSearch1);
            this.pnlRoundRectangle1.InnerColor = System.Drawing.Color.White;
            this.pnlRoundRectangle1.Location = new System.Drawing.Point(21, 95);
            this.pnlRoundRectangle1.Name = "pnlRoundRectangle1";
            this.pnlRoundRectangle1.Radius = 6;
            this.pnlRoundRectangle1.Size = new System.Drawing.Size(302, 40);
            this.pnlRoundRectangle1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "";
            // 
            // txtboxSearch1
            // 
            this.txtboxSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearch1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearch1.DefaultString = "Tài khoản";
            this.txtboxSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtboxSearch1.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxSearch1.Location = new System.Drawing.Point(38, 13);
            this.txtboxSearch1.Name = "txtboxSearch1";
            this.txtboxSearch1.Size = new System.Drawing.Size(247, 13);
            this.txtboxSearch1.TabIndex = 2;
            this.txtboxSearch1.TabStop = false;
            this.txtboxSearch1.Text = "Tài khoản";
            // 
            // pnlRoundRectangle2
            // 
            this.pnlRoundRectangle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoundRectangle2.BackColor = System.Drawing.Color.White;
            this.pnlRoundRectangle2.BoderColor = System.Drawing.Color.Empty;
            this.pnlRoundRectangle2.Controls.Add(this.label3);
            this.pnlRoundRectangle2.Controls.Add(this.txtboxSearch3);
            this.pnlRoundRectangle2.InnerColor = System.Drawing.Color.White;
            this.pnlRoundRectangle2.Location = new System.Drawing.Point(21, 156);
            this.pnlRoundRectangle2.Name = "pnlRoundRectangle2";
            this.pnlRoundRectangle2.Radius = 6;
            this.pnlRoundRectangle2.Size = new System.Drawing.Size(302, 40);
            this.pnlRoundRectangle2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "";
            // 
            // txtboxSearch3
            // 
            this.txtboxSearch3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxSearch3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearch3.DefaultString = "Mật khẩu";
            this.txtboxSearch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtboxSearch3.ForeColor = System.Drawing.Color.DimGray;
            this.txtboxSearch3.Location = new System.Drawing.Point(38, 13);
            this.txtboxSearch3.Name = "txtboxSearch3";
            this.txtboxSearch3.Size = new System.Drawing.Size(247, 13);
            this.txtboxSearch3.TabIndex = 2;
            this.txtboxSearch3.TabStop = false;
            this.txtboxSearch3.Text = "Mật khẩu";
            // 
            // btnSimple1
            // 
            this.btnSimple1.Alignment = System.Drawing.StringAlignment.Center;
            this.btnSimple1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSimple1.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.btnSimple1.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSimple1.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(107)))), ((int)(((byte)(191)))));
            this.btnSimple1.ForeColor = System.Drawing.Color.White;
            this.btnSimple1.Location = new System.Drawing.Point(21, 236);
            this.btnSimple1.Name = "btnSimple1";
            this.btnSimple1.Size = new System.Drawing.Size(300, 34);
            this.btnSimple1.TabIndex = 4;
            this.btnSimple1.Text = "Đăng nhập";
            this.btnSimple1.UseActived = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(21, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 1);
            this.panel1.TabIndex = 6;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(758, 503);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRoundRectangle1.ResumeLayout(false);
            this.pnlRoundRectangle1.PerformLayout();
            this.pnlRoundRectangle2.ResumeLayout(false);
            this.pnlRoundRectangle2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label2;
        private Class.btnSimple btnSimple1;
        private Class.pnlRoundRectangle pnlRoundRectangle2;
        private System.Windows.Forms.Label label3;
        private Class.txtboxSearch txtboxSearch3;
        private Class.pnlRoundRectangle pnlRoundRectangle1;
        private System.Windows.Forms.Label label1;
        private Class.txtboxSearch txtboxSearch1;
        private System.Windows.Forms.Panel panel1;
    }
}
