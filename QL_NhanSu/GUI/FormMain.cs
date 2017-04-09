using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DAL;
using GUI.Class;

namespace GUI
{
    public partial class FormMain : Form
    {
        Mouse_Position mouse_point = Mouse_Position.None;

        public FormMain()
        {
            DataProvider.DirectoryConnect = Application.StartupPath.Replace(@"bin\Debug", @"data\NhanSu .mdf");
            MessageBox.Show(Application.StartupPath);
            if (DataProvider.GetData("select * from NhanVien") == null) MessageBox.Show("Test");
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
            foreach(Control ctrl in pnlQLNhanSu.Controls)
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
            if(e.Button == MouseButtons.Left)
            {
                if(!pnlQLNhanSu.Visible) { pnlQLNhanSu.Visible = true; btnQLNhanSu.Text = "   ◢   Quản lý nhân sự"; }
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

        private void btnBHYT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RefreshBtn(btnBHYT);
                btnBHYTClick();
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
        #endregion

        #region Function Execute Event
        private void btnLoginClick()
        {

        }

        private void btnChucVuClick()
        {

        }

        private void btnDSNVClick()
        {

        }

        private void btnChamCongClick()
        {

        }

        private void btnBangCongClick()
        {

        }

        private void btnNgoaiNguClick()
        {

        }

        private void btnHocVanClick()
        {

        }

        private void btnBHYTClick()
        {

        }

        private void btnKhenThuongClick()
        {

        }

        private void btnKyLuatClick()
        {

        }

        private void btnPhuCapClick()
        {

        }
        #endregion


    }

}
