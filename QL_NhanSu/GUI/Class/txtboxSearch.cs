using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Class
{
    class txtboxSearch : TextBox
    {
        public event EventHandler EventKeyEnter;
        public txtboxSearch() : base()
        {
            this.BorderStyle = BorderStyle.None;
            this.Text = "Search...";
            this.TabStop = false;
            this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.Size, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.DimGray;

        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (this.Text == null || this.Text.Trim() == "")
            {
                this.Text = "Search...";
                this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.Size, System.Drawing.FontStyle.Italic);
                this.ForeColor = System.Drawing.Color.DimGray;

            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (this.Text == "Search...")
            {
                this.Text = "";
                this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.Size, System.Drawing.FontStyle.Regular);
                this.ForeColor = System.Drawing.Color.Black;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                EventKeyEnter?.Invoke(this, EventArgs.Empty);
                return;
            }
            base.OnKeyDown(e);
        }
    }
}
