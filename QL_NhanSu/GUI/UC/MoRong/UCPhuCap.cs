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
    public partial class UCPhuCap : UserControl
    {
        DTO.PhuCap phucap = new DTO.PhuCap();
        public UCPhuCap()
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
                        if (dgvPC.RowCount > 0)
                        {
                            txtMa.Text = (string)((DataTable)dgvPC.DataSource).Select("Mã is not null", "Mã DESC")[0].ItemArray[0];
                            txtMa.Text = "pc" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("pc", "00")) + 1);
                        }
                        else txtMa.Text = "pc001";
                        break;
                    case "Sửa":
                        if (dgvPC.RowCount > 0)
                        {
                            txtMa.Text = dgvPC.CurrentRow.Cells[0].Value.ToString();
                            txtTen.Text = dgvPC.CurrentRow.Cells[1].Value.ToString();
                            txtST.Text = (dgvPC.CurrentRow.Cells[2].Value.ToString() != "") ? dgvPC.CurrentRow.Cells[2].Value.ToString().Split('.')[0] : "";
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

                if (dgvPC.RowCount > 0)
                {
                    MessageBox.Show("Đã xóa " + DTO.PhuCap.Xoa((string)dgvPC.CurrentRow.Cells[0].Value).ToString());
                    LoadData();
                }

                txtMa.Text = "";
                txtTen.Text = "";
                txtST.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                phucap.Ma = txtMa.Text;
                phucap.Ten = txtTen.Text;
                phucap.Sotien = (txtST.Text != "" && txtST.Text.Trim() != "") ? decimal.Parse(txtST.Text) : -1;
                switch (btnSave.Text)
                {
                    case "Thêm":
                        MessageBox.Show("Đã thêm " + phucap.Them().ToString());
                        txtMa.Text = "pc" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("pc", "00")) + 1);
                        txtTen.Text = "";
                        txtST.Text = "";
                        LoadData();
                        break;
                    case "Sửa":
                        phucap.Sua();
                        MessageBox.Show("Đã sửa " + phucap.Sua().ToString());
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

        private void UCPhuCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvPC.DataSource = DTO.PhuCap.Get_PhuCap();
        }
    }
}
