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
    public partial class UCXemNV : UserControl
    {
        public static string manv;
        public UCXemNV()
        {
            InitializeComponent();
        }

        private void UCXemNV_Load(object sender, EventArgs e)
        {
            DataTable tb = DTO.NhanVien.Get_NhanVien(manv);
            if (tb.Rows.Count == 1)
            {
                if (tb.Rows[0].ItemArray[0] != DBNull.Value)
                    ptrAnh.Image = Image.FromStream(new System.IO.MemoryStream((byte[])tb.Rows[0].ItemArray[0]));
                txtHT.Text = (tb.Rows[0].ItemArray[2] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[2] : "";
                if (tb.Rows[0].ItemArray[3] != DBNull.Value)
                    txtNS.Text = ((DateTime)tb.Rows[0].ItemArray[3]).ToShortDateString();
                txtGT.Text = (string)tb.Rows[0].ItemArray[4];
                txtCMT.Text = (string)tb.Rows[0].ItemArray[5];
                txtCV.Text = (tb.Rows[0].ItemArray[6] != DBNull.Value && (string)tb.Rows[0].ItemArray[6] != "") ? (string)tb.Rows[0].ItemArray[6] : "";
                txtDT.Text = (tb.Rows[0].ItemArray[7] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[7] : "";
                txtTG.Text = (tb.Rows[0].ItemArray[8] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[8] : "";
                txtSDT.Text = (tb.Rows[0].ItemArray[9] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[9] : "";
                txtEmail.Text = (tb.Rows[0].ItemArray[10] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[10] : "";
                txtHV.Text = (tb.Rows[0].ItemArray[11] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[11] : "";
                txtNN.Text = (tb.Rows[0].ItemArray[12] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[12] : "";
                if (tb.Rows[0].ItemArray[13] != DBNull.Value)
                    txtNKHD.Text = ((DateTime)tb.Rows[0].ItemArray[13]).ToShortDateString();
                if (tb.Rows[0].ItemArray[14] != DBNull.Value)
                    txtNHHHD.Text = ((DateTime)tb.Rows[0].ItemArray[14]).ToShortDateString();
            }
            dgvKhenThuong.DataSource = DTO.NhanVien.Get_LichSuKT(manv);
            dgvKyLuat.DataSource = DTO.NhanVien.Get_LichSuKL(manv);
            dgvLSLV.DataSource = DTO.NhanVien.Get_LichSuLV(manv);
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control ctrl = FormMain.stackControl.Pop();
                ctrl.Dispose();
                FormMain.stackControl.Pop().Visible = true;
            }
        }
    }
}
