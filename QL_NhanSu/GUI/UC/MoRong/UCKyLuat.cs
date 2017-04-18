using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.MoRong
{
    public partial class UCKyLuat : UserControl
    {
        private DTO.KyLuat kiluat = new DTO.KyLuat();
        public UCKyLuat()
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
                txtST.Text = "";
                switch (btnSave.Text)
                {
                    case "Thêm":
                        if (dgvKL.RowCount > 0)
                        {
                            txtMa.Text = (string)((DataTable)dgvKL.DataSource).Select("Mã is not null", "Mã DESC")[0].ItemArray[0];
                            txtMa.Text = "kl" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("kl", "00")) + 1);
                        }
                        else txtMa.Text = "kl001";
                        break;
                    case "Sửa":
                        if (dgvKL.RowCount > 0)
                        {
                            txtMa.Text = dgvKL.CurrentRow.Cells[0].Value.ToString();
                            txtTen.Text = dgvKL.CurrentRow.Cells[1].Value.ToString();
                            txtST.Text = (dgvKL.CurrentRow.Cells[2].Value.ToString() != "") ? dgvKL.CurrentRow.Cells[2].Value.ToString().Split('.')[0] : "";
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
                txtST.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pnlInput.Visible) pnlInput.Visible = false;

                if (dgvKL.RowCount > 0)
                {
                    MessageBox.Show("Đã xóa " + DTO.KyLuat.Xoa((string)dgvKL.CurrentRow.Cells[0].Value).ToString());
                    LoadData();
                }

                txtMa.Text = "";
                txtTen.Text = "";
                txtST.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void UCKyLuat_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvKL.DataSource = DTO.KyLuat.Get_KyLuat();
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                kiluat.Ma = txtMa.Text;
                kiluat.Ten = txtTen.Text;
                kiluat.Sotien = (txtST.Text != "" && txtST.Text.Trim() != "") ? decimal.Parse(txtST.Text) : -1;
                switch (btnSave.Text)
                {
                    case "Thêm":
                        MessageBox.Show("Đã thêm " + kiluat.Them().ToString());
                        txtMa.Text = "kl" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("kl", "00")) + 1);
                        txtTen.Text = "";
                        txtST.Text = "";
                        LoadData();
                        break;
                    case "Sửa":
                        kiluat.Sua();
                        MessageBox.Show("Đã sửa " + kiluat.Sua().ToString());
                        txtMa.Text = "";
                        txtTen.Text = "";
                        txtST.Text = "";
                        btnXoa.Actived = true;
                        pnlInput.Visible = false;
                        LoadData();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
