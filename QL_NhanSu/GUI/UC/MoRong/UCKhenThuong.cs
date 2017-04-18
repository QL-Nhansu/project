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
    public partial class UCKhenThuong : UserControl
    {
        private DTO.KhenThuong khenthuong = new DTO.KhenThuong();
        public UCKhenThuong()
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
                        if (dgvKT.RowCount > 0)
                        {
                            txtMa.Text = (string)((DataTable)dgvKT.DataSource).Select("Mã is not null", "Mã DESC")[0].ItemArray[0];
                            txtMa.Text = "kt" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("kt", "00")) + 1);
                        }
                        else txtMa.Text = "kt001";
                        break;
                    case "Sửa":
                        if (dgvKT.RowCount > 0)
                        {
                            txtMa.Text = dgvKT.CurrentRow.Cells[0].Value.ToString();
                            txtTen.Text = dgvKT.CurrentRow.Cells[1].Value.ToString();
                            txtST.Text = (dgvKT.CurrentRow.Cells[2].Value.ToString() != "") ? dgvKT.CurrentRow.Cells[2].Value.ToString().Split('.')[0] : "";
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

                if (dgvKT.RowCount > 0)
                {
                    MessageBox.Show("Đã xóa " + DTO.KhenThuong.Xoa((string)dgvKT.CurrentRow.Cells[0].Value).ToString());
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
                khenthuong.Ma = txtMa.Text;
                khenthuong.Ten = txtTen.Text;
                khenthuong.Sotien = (txtST.Text != "" && txtST.Text.Trim() != "") ? decimal.Parse(txtST.Text) : -1;
                switch (btnSave.Text)
                {
                    case "Thêm":
                        MessageBox.Show("Đã thêm " + khenthuong.Them().ToString());
                        txtMa.Text = "kt" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("kt", "00")) + 1);
                        txtTen.Text = "";
                        txtST.Text = "";
                        LoadData();
                        break;
                    case "Sửa":
                        khenthuong.Sua();
                        MessageBox.Show("Đã sửa " + khenthuong.Sua().ToString());
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

        private void UCKhenThuong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvKT.DataSource = DTO.KhenThuong.Get_KhenThuong();
        }
    }
}
