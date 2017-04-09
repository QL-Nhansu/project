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
    public partial class UCThemSuaNV : UserControl
    {
        public UCThemSuaNV()
        {
            InitializeComponent();
        }

        private void btnImage1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                UCThemSuaNV uc;
                foreach (Control ctrl in this.Parent.Controls)
                {
                    uc = ctrl as UCThemSuaNV;
                    if (uc == null) ctrl.Visible = true;
                }

                this.Dispose();
            }
        }
    }
}
