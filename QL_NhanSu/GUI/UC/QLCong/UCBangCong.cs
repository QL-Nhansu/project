using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.QLCong
{
    public partial class UCBangCong : UserControl
    {
        DataTable data;
        public UCBangCong()
        {
            InitializeComponent();
        }

        private void cbxView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNam_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                data = DTO.ChamCong.Get_BangChamCong(int.Parse(txtThang.Text), int.Parse(txtNam.Text));

            }
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyData != Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void FillData()
        {
            foreach(DataRow row in data.Rows)
            {
                
            }
        }
    }
}
