using System.Windows.Forms;
using GUI.Class;
using System.Collections.Generic;

namespace GUI
{
    public partial class FormMain : Form
    {
        Mouse_Position mouse_point = Mouse_Position.None;
        public static Stack<Control> stackControl = new Stack<Control>();

        public FormMain()
        {
            DTO.Connect.SetConnectString(Application.StartupPath.Replace(@"bin\Debug", @"data\NhanSu.mdf"));
            while (!DTO.Connect.Open() && MessageBox.Show("Can not connect DataBase", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) ;
            MessageBox.Show(DTO.Connect.GetSqlConnection().State.ToString());
            InitializeComponent();
        }

        #region FormFunction
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                //minimize box
                cp.Style |= 0x00020000;
                return cp;
            }
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Close();
        }

        private void btnMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Normal) { MaximizedBounds = Screen.PrimaryScreen.WorkingArea; this.WindowState = FormWindowState.Maximized; btnMaximize.Text = "2"; this.Padding = new Padding(0); }
                else { this.WindowState = FormWindowState.Normal; btnMaximize.Text = "1"; this.Padding = new Padding(1); }
            }
        }

        private void btnMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) this.WindowState = FormWindowState.Minimized;
        }

        private void toolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                User32.ReleaseCapture();
                User32.SendMessage(this.Handle, User32.WM_NCLBUTTONDOWN, User32.HT_CAPTION, 0);
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                if (e.X == this.Width - 1)
                {
                    if (e.Y < this.Height - 20) { Cursor.Current = Cursors.SizeWE; mouse_point = Mouse_Position.Right; }
                    else { Cursor.Current = Cursors.SizeNWSE; mouse_point = Mouse_Position.BotRight; }
                }
                else if (e.Y == this.Height - 1)
                {
                    if (e.X < this.Width - 20) { Cursor.Current = Cursors.SizeNS; mouse_point = Mouse_Position.Bottom; }
                    else { Cursor.Current = Cursors.SizeNWSE; mouse_point = Mouse_Position.BotRight; }
                }
                else mouse_point = Mouse_Position.None;
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (mouse_point == Mouse_Position.Right)
                {
                    Cursor.Current = Cursors.SizeWE;
                    this.Width = e.X;
                }
                else if (mouse_point == Mouse_Position.BotRight)
                {
                    Cursor.Current = Cursors.SizeNWSE;
                    this.Width = e.X;
                    this.Height = e.Y;
                }
                else if (mouse_point == Mouse_Position.Bottom)
                {
                    Cursor.Current = Cursors.SizeNS;
                    this.Height = e.Y;
                }
            }
        }

        #endregion

        #region EventFormMain
        private void RefreshBtn(Control ctrlNoneRefresh)
        {
            btnSimple btn;
            foreach (Control ctrl in pnlQLNhanSu.Controls)
            {
                btn = ctrl as btnSimple;
                if (btn != null && btn != ctrlNoneRefresh && btn.UseActived) btn.Actived = false;
            }
            foreach (Control ctrl in pnlQLCong.Controls)
            {
                btn = ctrl as btnSimple;
                if (btn != null && btn != ctrlNoneRefresh && btn.UseActived) btn.Actived = false;
            }
            foreach (Control ctrl in pnlMoRong.Controls)
            {
                btn = ctrl as btnSimple;
                if (btn != null && btn != ctrlNoneRefresh && btn.UseActived) btn.Actived = false;
            }
        }

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!pnlQLNhanSu.Visible)
                {
                    pnlQLNhanSu.Visible = true;
                    btnQLNhanSu.Text = "   ◢   Quản lý nhân sự";
                    pnlQLCong.Visible = true;
                    btnQLCong.Text = "   ◢   Quản lý công";
                    pnlMoRong.Visible = true;
                    btnMoRong.Text = "   ◢   Mở rộng";
                }
                else
                {
                    pnlQLNhanSu.Visible = false;
                    btnQLNhanSu.Text = "   ▶   Quản lý nhân sự";
                    pnlQLCong.Visible = false;
                    btnQLCong.Text = "   ▶   Quản lý công";
                    pnlMoRong.Visible = false;
                    btnMoRong.Text = "   ▶   Mở rộng";
                }
            }
        }

        private void btnQLNhanSu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!pnlQLNhanSu.Visible) { pnlQLNhanSu.Visible = true; btnQLNhanSu.Text = "   ◢   Quản lý nhân sự"; }
                else { pnlQLNhanSu.Visible = false; btnQLNhanSu.Text = "   ▶   Quản lý nhân sự"; }
            }
        }

        private void btnQLCong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!pnlQLCong.Visible) { pnlQLCong.Visible = true; btnQLCong.Text = "   ◢   Quản lý công"; }
                else { pnlQLCong.Visible = false; btnQLCong.Text = "   ▶   Quản lý công"; }
            }
        }

        private void btnMoRong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!pnlMoRong.Visible) { pnlMoRong.Visible = true; btnMoRong.Text = "   ◢   Mở rộng"; }
                else { pnlMoRong.Visible = false; btnMoRong.Text = "   ▶   Mở rộng"; }
            }
        }

        private void btnChucVu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnChucVu);
                btnChucVuClick();
            }
        }

        private void btnDSNV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnDSNV);
                btnDSNVClick();
            }
        }

        private void btnChamCong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnChamCong);
                btnChamCongClick();
            }
        }

        private void btnBangCong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnBangCong);
                btnBangCongClick();
            }
        }

        private void btnNgoaiNgu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnNgoaiNgu);
                btnNgoaiNguClick();
            }
        }

        private void btnHocVan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnHocVan);
                btnHocVanClick();
            }
        }

        private void btnKhenThuong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnKhenThuong);
                btnKhenThuongClick();
            }
        }

        private void btnKyLuat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnKyLuat);
                btnKyLuatClick();
            }
        }

        private void btnPhuCap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnPhuCap);
                btnPhuCapClick();
            }
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnLoginClick();
            }
        }

        private void RenderBody_ControlAdded(object sender, ControlEventArgs e)
        {
            stackControl.Push(e.Control);
        }
        #endregion

        #region Function Execute Event
        private void ClearChildrenControl()
        {
            Control ctrl;
            while(stackControl.Count!=0)
            {
                ctrl = stackControl.Pop();
                if (ctrl != null) ctrl.Dispose();
            }
            foreach(Control ctr in RenderBody.Controls)
            {
                ctr.Dispose();
            }
        }

        private void btnLoginClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.UCLogin()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnChucVuClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.QLNhanSu.UCChucVu()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnDSNVClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.QLNhanSu.UCDSNhanVien()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnChamCongClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.QLCong.UCChamCong()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnBangCongClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.QLCong.UCBangCong()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnNgoaiNguClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.MoRong.UCNgoaiNgu()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnHocVanClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.MoRong.UCHocVan()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnKhenThuongClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.MoRong.UCKhenThuong()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnKyLuatClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.MoRong.UCKyLuat()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void btnPhuCapClick()
        {
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.MoRong.UCPhuCap()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = RenderBody.Width - 16,
                Height = RenderBody.Height - 16,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        #endregion

        private void txtSearch_EventKeyEnter(object sender, System.EventArgs e)
        {
            UC.QLNhanSu.UCXemNV.manv = txtSearch.Text;
            ClearChildrenControl();
            RenderBody.Controls.Add(new UC.QLNhanSu.UCXemNV()
            {
                Location = new System.Drawing.Point(8, 8),
                Width = this.Width,
                Height = this.Height,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }
    }

}
