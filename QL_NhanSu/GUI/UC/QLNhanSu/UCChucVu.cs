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
    public partial class UCChucVu : UserControl
    {
        private DTO.ChucDanh chucdanh = new DTO.ChucDanh();
        public UCChucVu()
        {
            InitializeComponent();
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlInput.Visible = true;
                btnSave.Text = ((Class.btnImage)sender).Text;
                txtTen.Text = "";
                txtLuong.Text = "";
                txtCT.Text = "";
                switch (btnSave.Text)
                {
                    case "Thêm":
                        if (dgvCV.RowCount > 0)
                        {
                            txtMa.Text = (string)((DataTable)dgvCV.DataSource).Select("Mã is not null", "Mã DESC")[0].ItemArray[0];
                            txtMa.Text = "cd" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("cd", "00")) + 1);
                        }
                        else txtMa.Text = "cd001";
                        break;
                    case "Sửa":
                        if (dgvCV.RowCount > 0)
                        {
                            txtMa.Text = dgvCV.CurrentRow.Cells[0].Value.ToString();
                            txtTen.Text = dgvCV.CurrentRow.Cells[1].Value.ToString();
                            txtLuong.Text = (dgvCV.CurrentRow.Cells[2].Value.ToString() != "") ? dgvCV.CurrentRow.Cells[2].Value.ToString().Split('.')[0] : "";
                            txtCT.Text = dgvCV.CurrentRow.Cells[3].Value.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnKT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlInput.Visible = false;
                txtMa.Text = "";
                txtTen.Text = "";
                txtCT.Text = "";
                txtLuong.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pnlInput.Visible) pnlInput.Visible = false;

                if (dgvCV.RowCount > 0)
                {
                    MessageBox.Show("Đã xóa " + DTO.ChucDanh.Xoa((string)dgvCV.CurrentRow.Cells[0].Value).ToString());
                    LoadData();
                }

                txtMa.Text = "";
                txtTen.Text = "";
                txtCT.Text = "";
                txtLuong.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void txtLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyData != Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void LoadData()
        {
            dgvCV.DataSource = DTO.ChucDanh.Get_ChucDanh();
        }

        private void UCChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                chucdanh.Ma = txtMa.Text;
                chucdanh.Ten = txtTen.Text;
                chucdanh.Luongcoban = (txtLuong.Text != "" && txtLuong.Text.Trim() != "") ? decimal.Parse(txtLuong.Text) : -1;
                chucdanh.Chuthich = txtCT.Text;
                switch (btnSave.Text)
                {
                    case "Thêm":
                        MessageBox.Show("Đã thêm " + chucdanh.Them().ToString());
                        txtMa.Text = "cd" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("cd", "00")) + 1);
                        txtTen.Text = "";
                        txtCT.Text = "";
                        txtLuong.Text = "";
                        LoadData();
                        break;
                    case "Sửa":
                        chucdanh.Sua();
                        MessageBox.Show("Đã sửa " + chucdanh.Sua().ToString());
                        txtMa.Text = "";
                        txtTen.Text = "";
                        txtCT.Text = "";
                        txtLuong.Text = "";
                        btnXoa.Actived = true;
                        pnlInput.Visible = false;
                        LoadData();
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgvCV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pnlInput.Visible) pnlInput.Visible = false;
                txtMa.Text = "";
                txtTen.Text = "";
                txtCT.Text = "";
                txtLuong.Text = "";
                btnXoa.Actived = true;
            }
        }
    }
}
