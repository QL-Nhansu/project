using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.QLNhanSu
{
    public partial class UCDSNhanVien : UserControl
    {
        public UCDSNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormMain.stackControl.Push(this);
                this.Visible = false;
                this.Parent.Controls.Add(new UCThemSuaNV()
                {
                    Location = new Point(8, 8),
                    Width = this.Width,
                    Height = this.Height,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                });
            }
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

            }
        }

        private void xemHoSoChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCXemNV uc;
            foreach (Control ctrl in this.Parent.Controls)
            {
                uc = ctrl as UCXemNV;
                if (uc == null) ctrl.Visible = false;
            }
            this.Parent.Controls.Add(new UCXemNV()
            {
                Location = new Point(8, 8),
                Width = this.Width,
                Height = this.Height,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }
    }
}
