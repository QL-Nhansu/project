using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Class
{
    class cbxNoneChangeText : ComboBox
    {
        public cbxNoneChangeText() : base() { }
        protected override void OnKeyDown(KeyEventArgs e) { e.Handled = true; }
        protected override void OnKeyPress(KeyPressEventArgs e) { e.Handled = true; }
        protected override void OnKeyUp(KeyEventArgs e) { e.Handled = true; }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            this.Parent.Focus();
        }
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            Refresh();
        }
    }
}
